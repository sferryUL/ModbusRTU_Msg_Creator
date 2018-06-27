using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusRTU
{
    public class ModbusRTUMsg
    {
        public byte SlaveAddr = 0;
        public byte FuncCode = 0;
        public ushort SubFunction = 0;
        public ushort StartReg = 0;
        public ushort RegCount = 0;
        public byte RegByteCount = 2;
        public List<ushort> Data = new List<ushort>();
        public ushort CRC16 = 0xFFFF;

        public void Clear()
        {
            FuncCode = 0;
            StartReg = 0;
            RegCount = 0;
            RegByteCount = 2;
            Data.Clear();
            CRC16 = 0xFFFF;
        }

        public void ClearAll()
        {
            SlaveAddr = 0;
            FuncCode = 0;
            StartReg = 0;
            RegCount = 0;
            RegByteCount = 2;
            Data.Clear();
            CRC16 = 0xFFFF;
        }
    }

    public class ModbusRTUMaster
    {
        // Fields
        public List<byte> RawMsg = new List<byte>();
        ModbusRTUMsg Message = new ModbusRTUMsg();
        
        // Class Constructors
        public ModbusRTUMaster() { }

        public ModbusRTUMaster(byte p_SlaveAddr, byte p_FuncCode, ushort p_StartReg)
        {
            Message.SlaveAddr = p_SlaveAddr;
            Message.FuncCode = p_FuncCode;
            Message.StartReg = p_StartReg;
        }

        public ModbusRTUMaster(byte p_SlaveAddr, byte p_FuncCode, ushort p_StartReg, ushort p_RegCount, List<ushort> p_Payload)
        {
            Message.SlaveAddr = p_SlaveAddr;
            Message.FuncCode = p_FuncCode;
            Message.StartReg = p_StartReg;
            Message.RegCount = p_RegCount;
            Message.Data = p_Payload.ToList();
        }

        // Property Initializers
        public byte SlaveAddr { get => Message.SlaveAddr; set => Message.SlaveAddr = value; }
        public byte FuncCode    { get => Message.FuncCode; set => Message.FuncCode = value; }
        public ushort StartReg  { get => Message.StartReg; set => Message.StartReg = value; }
        public ushort RegCount  { get => Message.RegCount; set => Message.RegCount = value; }
        public ushort RegByteCount => Message.RegByteCount;
        public ushort CRC16     => Message.CRC16;
        public ushort MsgSize   => (ushort)Message.Data.Count();

        // Public Class Methods
        public void ClearData() { Message.Clear(); }

        public void ClearAll() { Message.ClearAll(); }

        public ModbusRTUMsg CreateMessage(byte p_SlaveAddr, byte p_FuncCode, ushort p_StartReg, ushort p_RegCount, List<byte> p_Payload)
        {
            ModbusRTUMsg TmpMsg = new ModbusRTUMsg();

            TmpMsg.SlaveAddr = p_SlaveAddr;
            TmpMsg.FuncCode = p_FuncCode;
            TmpMsg.StartReg = p_StartReg;
            TmpMsg.RegCount = p_RegCount;

            for (int i = 0; i < p_Payload.Count(); i += 2)
                TmpMsg.Data.Add((ushort)((p_Payload[i] << 8) | p_Payload[i]));

            return TmpMsg;
        }

        public List<byte> CreateRawMessageBuffer(List<byte> p_Payload)
        {
            RawMsg.Add(Message.SlaveAddr);                         // Add slave address to overall message
            RawMsg.Add(Message.FuncCode);                          // Add function code to overall message
            RawMsg.Add((byte)(Message.StartReg >> 8));             // Add starting register upper byte
            RawMsg.Add((byte)(Message.StartReg & 0x00FF));         // Add starting register lower byte

            if (Message.FuncCode != 0x08)
            {
                RawMsg.Add((byte)(Message.RegCount >> 8));             // Add register count upper byte
                RawMsg.Add((byte)(Message.RegCount & 0x00FF));         // Add register count lower byte
            }

            if(Message.FuncCode == 0x10)
                RawMsg.Add(GetNumDataBytes(p_Payload));    // Add number of data bytes in the data payload

            // Add data payload to overall message - skip for read register requests
            if ((Message.FuncCode == 0x08) || (Message.FuncCode == 0x10))
                for (int i = 0; i < p_Payload.Count; i++)
                    RawMsg.Add(p_Payload[i]);

            Message.CRC16 = CalcModbusRTUCRC16(RawMsg);            // Calculate the Modbus RTU CRC-16 value

            // Modbus RTU CRC16 is Big-Endian format So lower byte is added first
            RawMsg.Add((byte)(Message.CRC16 & 0x00FF));
            RawMsg.Add((byte)(Message.CRC16 >> 8));

            return RawMsg;
        }

        public byte ExtractMessage(List<byte> p_FullMsg)
        {
            ushort InCRC = 0, CalcCRC16 = 0;
            ModbusRTUMsg TmpMsg = new ModbusRTUMsg();

            /* First verify message has a valid CRC in relation to its data */
            // Extract CRC-16 value
            InCRC = (ushort)((p_FullMsg[p_FullMsg.Count - 1] << 8) | (p_FullMsg[p_FullMsg.Count - 2])); 

            // Strip CRC-16 off the full message
            p_FullMsg.RemoveRange(p_FullMsg.Count - 1, 2); 

            // Calculate the CRC-16 based on the received data minus the last two bytes (received CRC-16)
            CalcCRC16 = CalcModbusRTUCRC16(p_FullMsg);
            if (InCRC != CalcCRC16)
                return 0xFF;

            /* Extract the received message and put each data byte into it's correct ModbusRTUMsg fields */
            TmpMsg.CRC16 = InCRC;               // Store CRC-16 value that was previously extracted from the full message
            TmpMsg.SlaveAddr = p_FullMsg[0];    // Store the slave address
            TmpMsg.FuncCode = p_FullMsg[1];     // Store the function code

            // Store the different byte locations of the overall message based on the type of message it is
            switch (TmpMsg.FuncCode)
            {
                case 0x03: // Read register response from slave
                    TmpMsg.RegByteCount = p_FullMsg[2];
                    for (int i = 3; i < (i + TmpMsg.RegByteCount); i+=2)
                        TmpMsg.Data.Add((ushort)((p_FullMsg[i] << 8) | p_FullMsg[i + 1]));
                    break;
                case 0x08: // Loopback response from slave
                    TmpMsg.SubFunction = (ushort)((p_FullMsg[2] << 8) | p_FullMsg[3]);
                    TmpMsg.RegCount = (ushort)((p_FullMsg[4] << 8) | p_FullMsg[5]);
                    break;

                case 0x10: // Write register response from slave
                    TmpMsg.StartReg = (ushort)((p_FullMsg[2] << 8) | p_FullMsg[3]);
                    TmpMsg.RegCount = (ushort)((p_FullMsg[4] << 8) | p_FullMsg[5]);
                    break;
                default:
                    return 0xF0; // Unknown function code
            }

            return 1;
        }

        // Private Helper Functions
        private byte GetNumDataBytes(List<byte> p_Payload)
        {
            return (byte)p_Payload.Count();
        }

        private ushort CalcModbusRTUCRC16(List<byte> p_DataBuffer)
        {
            ushort CRCResult = 0xFFFF, XORVal = 0xA001, XOR = 0x0000;

            for (int i = 0; i < p_DataBuffer.Count; i++)
            {
                CRCResult ^= p_DataBuffer[i];
                for (int j = 0; j < 8; j++)
                {
                    XOR = (ushort)(CRCResult & 0x0001);
                    CRCResult >>= 1;

                    if (XOR > 0)
                        CRCResult ^= XORVal;
                }
            }

            return CRCResult;
        }
    }
}

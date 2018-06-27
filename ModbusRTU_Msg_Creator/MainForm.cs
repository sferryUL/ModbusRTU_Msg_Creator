using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusRTU;

namespace Modbus_CRC16_Calc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalcModCRC16_Click(object sender, EventArgs e)
        {

            byte RegSize;
            List<byte> Payload = new List<byte>();
            ModbusRTUMaster Msg = new ModbusRTUMaster();


            Msg.SlaveAddr = Convert.ToByte(txtSlaveAddr.Text, 16); // Get Slave Address

            switch (cmbFuncCode.SelectedIndex) // Get Function Code
            {
                case 0:
                    Msg.FuncCode = 0x03;
                    break;
                case 1:
                    Msg.FuncCode = 0x08;
                    break;
                case 2:
                    Msg.FuncCode = 0x10;
                    break;
            }

            Msg.StartReg = Convert.ToUInt16(txtStartReg.Text, 16);  // Get Starting Register
            Msg.RegCount = Convert.ToUInt16(txtRegCnt.Text);             // Get number of registers to be read or written
            RegSize = Convert.ToByte(txtRegSize.Text);           // Get size of each register to be read or written

            if(txtDataBuffer.Text != "")
                Payload = CreateDataPayload(txtDataBuffer.Text);


            Msg.CreateMessage(Payload);


            txtDataBuffComplete.Text = CreateModbusRTUDataString(Msg);

            txtBuffSize.Text = Msg.DataBytes.ToString();
            txtModCRC16Result.Text = "0x" + Msg.CRC16.ToString("X4");
            txtModCRC16Upper.Text = "0x" + ((byte)(Msg.CRC16 & 0x00FF)).ToString("X2");
            txtModCRC16Lower.Text = "0x" + ((byte)(Msg.CRC16 >> 8)).ToString("X2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDataBuffer.Clear();
            txtBuffSize.Clear();
            txtModCRC16Result.Clear();
            txtModCRC16Upper.Clear();
            txtModCRC16Lower.Clear();
            txtDataBuffComplete.Clear();

            txtSlaveAddr.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtSlaveAddr.Focus();
            cmbFuncCode.SelectedIndex = 0;
        }

        private ushort GetNumBytes(string p_Buffer)
        {
            ushort BuffSize = 0;
            Char c;

            p_Buffer = p_Buffer.Trim();
            p_Buffer = p_Buffer.PadRight(p_Buffer.Length + 1);
            for (int ctr = 0; ctr < p_Buffer.Length; ctr++)
            {
                c = p_Buffer[ctr];
                if (Char.IsWhiteSpace(p_Buffer[ctr]))
                    BuffSize++;
            }

            return BuffSize;
        }
        
        private List<byte> CreateDataPayload(string p_Buffer)
        {
            string[] HexBuffer;
            List<byte> RetVal = new List<byte>();

            p_Buffer = p_Buffer.Trim();
            HexBuffer = p_Buffer.Split(' ');
            foreach (String HexStr in HexBuffer)
            {
                byte HexVal = Convert.ToByte(HexStr, 16);
                RetVal.Add(HexVal);
            }

            return RetVal;
        }

        private string CreateDataBufferString(List<byte> p_DataBuffer)
        {
            string RetVal = "";

            for (ushort i = 0; i < p_DataBuffer.Count; i++)
            {
                RetVal += ("0x" + p_DataBuffer[i].ToString("X2") + " ");
            }

            return RetVal;
        }

        public string CreateModbusRTUDataString(ModbusRTUMaster p_Msg)
        {
            string RetVal = "";

            for (int i = 0; i < p_Msg.MsgSize; i++)
                RetVal += ("0x" + p_Msg.Msg[i].ToString("X2") + " ");

            return RetVal;
        }

    }
}

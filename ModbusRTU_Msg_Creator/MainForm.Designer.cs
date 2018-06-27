namespace Modbus_CRC16_Calc
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDataBuffer = new System.Windows.Forms.Label();
            this.txtDataBuffer = new System.Windows.Forms.TextBox();
            this.txtModCRC16Result = new System.Windows.Forms.TextBox();
            this.lblModCRC16Result = new System.Windows.Forms.Label();
            this.txtModCRC16Upper = new System.Windows.Forms.TextBox();
            this.lblModCRC16Upper = new System.Windows.Forms.Label();
            this.txtModCRC16Lower = new System.Windows.Forms.TextBox();
            this.lblModCRC16Lower = new System.Windows.Forms.Label();
            this.btnCalcModCRC16 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBuffSize = new System.Windows.Forms.TextBox();
            this.lblBuffSize = new System.Windows.Forms.Label();
            this.txtDataBuffComplete = new System.Windows.Forms.TextBox();
            this.lblDataBuffComplete = new System.Windows.Forms.Label();
            this.txtSlaveAddr = new System.Windows.Forms.TextBox();
            this.lblSlaveAddr = new System.Windows.Forms.Label();
            this.lblFuncCode = new System.Windows.Forms.Label();
            this.cmbFuncCode = new System.Windows.Forms.ComboBox();
            this.txtRegCnt = new System.Windows.Forms.TextBox();
            this.lblRegCnt = new System.Windows.Forms.Label();
            this.txtRegSize = new System.Windows.Forms.TextBox();
            this.lblRegSize = new System.Windows.Forms.Label();
            this.txtStartReg = new System.Windows.Forms.TextBox();
            this.lblStartReg = new System.Windows.Forms.Label();
            this.btnTransmit = new System.Windows.Forms.Button();
            this.spVFD = new System.IO.Ports.SerialPort(this.components);
            this.tmrResponse = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDataBuffer
            // 
            this.lblDataBuffer.AutoSize = true;
            this.lblDataBuffer.Location = new System.Drawing.Point(26, 152);
            this.lblDataBuffer.Name = "lblDataBuffer";
            this.lblDataBuffer.Size = new System.Drawing.Size(90, 13);
            this.lblDataBuffer.TabIndex = 0;
            this.lblDataBuffer.Text = "Data Buffer (hex):";
            this.lblDataBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDataBuffer
            // 
            this.txtDataBuffer.Location = new System.Drawing.Point(122, 149);
            this.txtDataBuffer.Name = "txtDataBuffer";
            this.txtDataBuffer.Size = new System.Drawing.Size(233, 20);
            this.txtDataBuffer.TabIndex = 5;
            // 
            // txtModCRC16Result
            // 
            this.txtModCRC16Result.Location = new System.Drawing.Point(191, 186);
            this.txtModCRC16Result.Name = "txtModCRC16Result";
            this.txtModCRC16Result.ReadOnly = true;
            this.txtModCRC16Result.Size = new System.Drawing.Size(142, 20);
            this.txtModCRC16Result.TabIndex = 3;
            this.txtModCRC16Result.TabStop = false;
            // 
            // lblModCRC16Result
            // 
            this.lblModCRC16Result.AutoSize = true;
            this.lblModCRC16Result.Location = new System.Drawing.Point(64, 189);
            this.lblModCRC16Result.Name = "lblModCRC16Result";
            this.lblModCRC16Result.Size = new System.Drawing.Size(121, 13);
            this.lblModCRC16Result.TabIndex = 2;
            this.lblModCRC16Result.Text = "Modbus CRC-16 Result:";
            this.lblModCRC16Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModCRC16Upper
            // 
            this.txtModCRC16Upper.Location = new System.Drawing.Point(191, 212);
            this.txtModCRC16Upper.Name = "txtModCRC16Upper";
            this.txtModCRC16Upper.ReadOnly = true;
            this.txtModCRC16Upper.Size = new System.Drawing.Size(142, 20);
            this.txtModCRC16Upper.TabIndex = 5;
            this.txtModCRC16Upper.TabStop = false;
            // 
            // lblModCRC16Upper
            // 
            this.lblModCRC16Upper.AutoSize = true;
            this.lblModCRC16Upper.Location = new System.Drawing.Point(41, 215);
            this.lblModCRC16Upper.Name = "lblModCRC16Upper";
            this.lblModCRC16Upper.Size = new System.Drawing.Size(144, 13);
            this.lblModCRC16Upper.TabIndex = 4;
            this.lblModCRC16Upper.Text = "Modbus CRC-16 Upper Byte:";
            this.lblModCRC16Upper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModCRC16Lower
            // 
            this.txtModCRC16Lower.Location = new System.Drawing.Point(191, 238);
            this.txtModCRC16Lower.Name = "txtModCRC16Lower";
            this.txtModCRC16Lower.ReadOnly = true;
            this.txtModCRC16Lower.Size = new System.Drawing.Size(142, 20);
            this.txtModCRC16Lower.TabIndex = 7;
            this.txtModCRC16Lower.TabStop = false;
            // 
            // lblModCRC16Lower
            // 
            this.lblModCRC16Lower.AutoSize = true;
            this.lblModCRC16Lower.Location = new System.Drawing.Point(41, 241);
            this.lblModCRC16Lower.Name = "lblModCRC16Lower";
            this.lblModCRC16Lower.Size = new System.Drawing.Size(144, 13);
            this.lblModCRC16Lower.TabIndex = 6;
            this.lblModCRC16Lower.Text = "Modbus CRC-16 Lower Byte:";
            this.lblModCRC16Lower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalcModCRC16
            // 
            this.btnCalcModCRC16.Location = new System.Drawing.Point(9, 301);
            this.btnCalcModCRC16.Name = "btnCalcModCRC16";
            this.btnCalcModCRC16.Size = new System.Drawing.Size(176, 23);
            this.btnCalcModCRC16.TabIndex = 6;
            this.btnCalcModCRC16.Text = "Create Modbus RTU Message";
            this.btnCalcModCRC16.UseVisualStyleBackColor = true;
            this.btnCalcModCRC16.Click += new System.EventHandler(this.btnCalcModCRC16_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(471, 301);
            this.btnClear.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnClear.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBuffSize
            // 
            this.txtBuffSize.Location = new System.Drawing.Point(508, 149);
            this.txtBuffSize.Name = "txtBuffSize";
            this.txtBuffSize.ReadOnly = true;
            this.txtBuffSize.Size = new System.Drawing.Size(38, 20);
            this.txtBuffSize.TabIndex = 11;
            this.txtBuffSize.TabStop = false;
            // 
            // lblBuffSize
            // 
            this.lblBuffSize.AutoSize = true;
            this.lblBuffSize.Location = new System.Drawing.Point(381, 152);
            this.lblBuffSize.Name = "lblBuffSize";
            this.lblBuffSize.Size = new System.Drawing.Size(121, 13);
            this.lblBuffSize.TabIndex = 10;
            this.lblBuffSize.Text = "Data Buffer Size (bytes):";
            this.lblBuffSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDataBuffComplete
            // 
            this.txtDataBuffComplete.Location = new System.Drawing.Point(191, 264);
            this.txtDataBuffComplete.Name = "txtDataBuffComplete";
            this.txtDataBuffComplete.ReadOnly = true;
            this.txtDataBuffComplete.Size = new System.Drawing.Size(355, 20);
            this.txtDataBuffComplete.TabIndex = 13;
            this.txtDataBuffComplete.TabStop = false;
            // 
            // lblDataBuffComplete
            // 
            this.lblDataBuffComplete.AutoSize = true;
            this.lblDataBuffComplete.Location = new System.Drawing.Point(20, 267);
            this.lblDataBuffComplete.Name = "lblDataBuffComplete";
            this.lblDataBuffComplete.Size = new System.Drawing.Size(165, 13);
            this.lblDataBuffComplete.TabIndex = 12;
            this.lblDataBuffComplete.Text = "Full Modbus RTU Message (hex):";
            this.lblDataBuffComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSlaveAddr
            // 
            this.txtSlaveAddr.Location = new System.Drawing.Point(122, 6);
            this.txtSlaveAddr.Name = "txtSlaveAddr";
            this.txtSlaveAddr.Size = new System.Drawing.Size(46, 20);
            this.txtSlaveAddr.TabIndex = 0;
            // 
            // lblSlaveAddr
            // 
            this.lblSlaveAddr.AutoSize = true;
            this.lblSlaveAddr.Location = new System.Drawing.Point(12, 9);
            this.lblSlaveAddr.Name = "lblSlaveAddr";
            this.lblSlaveAddr.Size = new System.Drawing.Size(104, 13);
            this.lblSlaveAddr.TabIndex = 14;
            this.lblSlaveAddr.Text = "Slave Address (hex):";
            this.lblSlaveAddr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuncCode
            // 
            this.lblFuncCode.AutoSize = true;
            this.lblFuncCode.Location = new System.Drawing.Point(37, 35);
            this.lblFuncCode.Name = "lblFuncCode";
            this.lblFuncCode.Size = new System.Drawing.Size(79, 13);
            this.lblFuncCode.TabIndex = 16;
            this.lblFuncCode.Text = "Function Code:";
            this.lblFuncCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFuncCode
            // 
            this.cmbFuncCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncCode.FormattingEnabled = true;
            this.cmbFuncCode.Items.AddRange(new object[] {
            "0x03 - Read Registers",
            "0x08 - Loopback Test",
            "0x10 - Write Registers"});
            this.cmbFuncCode.Location = new System.Drawing.Point(122, 35);
            this.cmbFuncCode.Name = "cmbFuncCode";
            this.cmbFuncCode.Size = new System.Drawing.Size(155, 21);
            this.cmbFuncCode.TabIndex = 1;
            // 
            // txtRegCnt
            // 
            this.txtRegCnt.Location = new System.Drawing.Point(122, 92);
            this.txtRegCnt.Name = "txtRegCnt";
            this.txtRegCnt.Size = new System.Drawing.Size(46, 20);
            this.txtRegCnt.TabIndex = 3;
            // 
            // lblRegCnt
            // 
            this.lblRegCnt.AutoSize = true;
            this.lblRegCnt.Location = new System.Drawing.Point(36, 95);
            this.lblRegCnt.Name = "lblRegCnt";
            this.lblRegCnt.Size = new System.Drawing.Size(80, 13);
            this.lblRegCnt.TabIndex = 18;
            this.lblRegCnt.Text = "Register Count:";
            this.lblRegCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRegSize
            // 
            this.txtRegSize.Location = new System.Drawing.Point(122, 118);
            this.txtRegSize.Name = "txtRegSize";
            this.txtRegSize.ReadOnly = true;
            this.txtRegSize.Size = new System.Drawing.Size(46, 20);
            this.txtRegSize.TabIndex = 4;
            this.txtRegSize.Text = "2";
            // 
            // lblRegSize
            // 
            this.lblRegSize.AutoSize = true;
            this.lblRegSize.Location = new System.Drawing.Point(10, 121);
            this.lblRegSize.Name = "lblRegSize";
            this.lblRegSize.Size = new System.Drawing.Size(106, 13);
            this.lblRegSize.TabIndex = 20;
            this.lblRegSize.Text = "Register Size (bytes):";
            this.lblRegSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartReg
            // 
            this.txtStartReg.Location = new System.Drawing.Point(122, 66);
            this.txtStartReg.Name = "txtStartReg";
            this.txtStartReg.Size = new System.Drawing.Size(46, 20);
            this.txtStartReg.TabIndex = 2;
            // 
            // lblStartReg
            // 
            this.lblStartReg.AutoSize = true;
            this.lblStartReg.Location = new System.Drawing.Point(2, 69);
            this.lblStartReg.Name = "lblStartReg";
            this.lblStartReg.Size = new System.Drawing.Size(114, 13);
            this.lblStartReg.TabIndex = 22;
            this.lblStartReg.Text = "Starting Register (hex):";
            this.lblStartReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTransmit
            // 
            this.btnTransmit.Location = new System.Drawing.Point(192, 300);
            this.btnTransmit.Name = "btnTransmit";
            this.btnTransmit.Size = new System.Drawing.Size(141, 23);
            this.btnTransmit.TabIndex = 23;
            this.btnTransmit.Text = "Transmit Message";
            this.btnTransmit.UseVisualStyleBackColor = true;
            this.btnTransmit.Click += new System.EventHandler(this.btnTransmit_Click);
            // 
            // spVFD
            // 
            this.spVFD.PortName = "COM6";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalcModCRC16;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(561, 336);
            this.Controls.Add(this.btnTransmit);
            this.Controls.Add(this.txtStartReg);
            this.Controls.Add(this.lblStartReg);
            this.Controls.Add(this.txtRegSize);
            this.Controls.Add(this.lblRegSize);
            this.Controls.Add(this.txtRegCnt);
            this.Controls.Add(this.lblRegCnt);
            this.Controls.Add(this.cmbFuncCode);
            this.Controls.Add(this.lblFuncCode);
            this.Controls.Add(this.txtSlaveAddr);
            this.Controls.Add(this.lblSlaveAddr);
            this.Controls.Add(this.txtDataBuffComplete);
            this.Controls.Add(this.lblDataBuffComplete);
            this.Controls.Add(this.txtBuffSize);
            this.Controls.Add(this.lblBuffSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcModCRC16);
            this.Controls.Add(this.txtModCRC16Lower);
            this.Controls.Add(this.lblModCRC16Lower);
            this.Controls.Add(this.txtModCRC16Upper);
            this.Controls.Add(this.lblModCRC16Upper);
            this.Controls.Add(this.txtModCRC16Result);
            this.Controls.Add(this.lblModCRC16Result);
            this.Controls.Add(this.txtDataBuffer);
            this.Controls.Add(this.lblDataBuffer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Modbus RTU Message Creator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataBuffer;
        private System.Windows.Forms.TextBox txtDataBuffer;
        private System.Windows.Forms.TextBox txtModCRC16Result;
        private System.Windows.Forms.Label lblModCRC16Result;
        private System.Windows.Forms.TextBox txtModCRC16Upper;
        private System.Windows.Forms.Label lblModCRC16Upper;
        private System.Windows.Forms.TextBox txtModCRC16Lower;
        private System.Windows.Forms.Label lblModCRC16Lower;
        private System.Windows.Forms.Button btnCalcModCRC16;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBuffSize;
        private System.Windows.Forms.Label lblBuffSize;
        private System.Windows.Forms.TextBox txtDataBuffComplete;
        private System.Windows.Forms.Label lblDataBuffComplete;
        private System.Windows.Forms.TextBox txtSlaveAddr;
        private System.Windows.Forms.Label lblSlaveAddr;
        private System.Windows.Forms.Label lblFuncCode;
        private System.Windows.Forms.ComboBox cmbFuncCode;
        private System.Windows.Forms.TextBox txtRegCnt;
        private System.Windows.Forms.Label lblRegCnt;
        private System.Windows.Forms.TextBox txtRegSize;
        private System.Windows.Forms.Label lblRegSize;
        private System.Windows.Forms.TextBox txtStartReg;
        private System.Windows.Forms.Label lblStartReg;
        private System.Windows.Forms.Button btnTransmit;
        private System.IO.Ports.SerialPort spVFD;
        private System.Windows.Forms.Timer tmrResponse;
    }
}


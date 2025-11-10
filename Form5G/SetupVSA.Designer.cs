namespace Form5G
{
    partial class SetupVSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupVSA));
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblCmdText = new System.Windows.Forms.Label();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblVSAName = new System.Windows.Forms.Label();
            this.cboVSAList = new System.Windows.Forms.ComboBox();
            this.cboIP = new System.Windows.Forms.ComboBox();
            this.cboInterface = new System.Windows.Forms.ComboBox();
            this.lblConnPort = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.cboCmd = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtRespond = new System.Windows.Forms.TextBox();
            this.btnDisconnectVSA = new System.Windows.Forms.Button();
            this.btnCloseVSA = new System.Windows.Forms.Button();
            this.btnConnectVSA = new System.Windows.Forms.Button();
            this.grpVSA = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.lbSearialNumber = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblModelText = new System.Windows.Forms.Label();
            this.lblMfrName = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.picVSA = new System.Windows.Forms.PictureBox();
            this.grpVSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVSA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResponse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResponse.Location = new System.Drawing.Point(28, 240);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(92, 24);
            this.lblResponse.TabIndex = 30;
            this.lblResponse.Text = "Respond:";
            // 
            // lblCmdText
            // 
            this.lblCmdText.AutoSize = true;
            this.lblCmdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCmdText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCmdText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCmdText.Location = new System.Drawing.Point(28, 195);
            this.lblCmdText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmdText.Name = "lblCmdText";
            this.lblCmdText.Size = new System.Drawing.Size(164, 24);
            this.lblCmdText.TabIndex = 32;
            this.lblCmdText.Text = "Verify Connection:";
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblInterface.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInterface.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInterface.Location = new System.Drawing.Point(28, 135);
            this.lblInterface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(86, 24);
            this.lblInterface.TabIndex = 31;
            this.lblInterface.Text = "Interface:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(28, 85);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 24);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "IP address:";
            // 
            // lblVSAName
            // 
            this.lblVSAName.AutoSize = true;
            this.lblVSAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblVSAName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVSAName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVSAName.Location = new System.Drawing.Point(28, 30);
            this.lblVSAName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVSAName.Name = "lblVSAName";
            this.lblVSAName.Size = new System.Drawing.Size(110, 24);
            this.lblVSAName.TabIndex = 34;
            this.lblVSAName.Text = "VSA Select:";
            // 
            // cboVSAList
            // 
            this.cboVSAList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboVSAList.FormattingEnabled = true;
            this.cboVSAList.Items.AddRange(new object[] {
            "N9020A",
            "FSW26",
            "FSV3030"});
            this.cboVSAList.Location = new System.Drawing.Point(209, 30);
            this.cboVSAList.Margin = new System.Windows.Forms.Padding(4);
            this.cboVSAList.Name = "cboVSAList";
            this.cboVSAList.Size = new System.Drawing.Size(307, 24);
            this.cboVSAList.TabIndex = 35;
            this.cboVSAList.Text = "FSW26";
            // 
            // cboIP
            // 
            this.cboIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboIP.FormattingEnabled = true;
            this.cboIP.ItemHeight = 16;
            this.cboIP.Items.AddRange(new object[] {
            "10.61.61.201",
            "192.168.185.212",
            "192.168.185.212",
            "10.0.0.110"});
            this.cboIP.Location = new System.Drawing.Point(209, 87);
            this.cboIP.Name = "cboIP";
            this.cboIP.Size = new System.Drawing.Size(307, 24);
            this.cboIP.TabIndex = 36;
            this.cboIP.Text = "10.0.0.110";
            // 
            // cboInterface
            // 
            this.cboInterface.FormattingEnabled = true;
            this.cboInterface.Items.AddRange(new object[] {
            "TCPIP",
            "GPIB"});
            this.cboInterface.Location = new System.Drawing.Point(209, 135);
            this.cboInterface.Name = "cboInterface";
            this.cboInterface.Size = new System.Drawing.Size(81, 21);
            this.cboInterface.TabIndex = 40;
            // 
            // lblConnPort
            // 
            this.lblConnPort.AutoSize = true;
            this.lblConnPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConnPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConnPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConnPort.Location = new System.Drawing.Point(353, 135);
            this.lblConnPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnPort.Name = "lblConnPort";
            this.lblConnPort.Size = new System.Drawing.Size(43, 24);
            this.lblConnPort.TabIndex = 41;
            this.lblConnPort.Text = "Port";
            // 
            // cboPort
            // 
            this.cboPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Items.AddRange(new object[] {
            "23",
            "22"});
            this.cboPort.Location = new System.Drawing.Point(436, 133);
            this.cboPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(80, 24);
            this.cboPort.TabIndex = 42;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // cboCmd
            // 
            this.cboCmd.FormattingEnabled = true;
            this.cboCmd.Items.AddRange(new object[] {
            "*IDN?",
            "*OPC?"});
            this.cboCmd.Location = new System.Drawing.Point(209, 198);
            this.cboCmd.Name = "cboCmd";
            this.cboCmd.Size = new System.Drawing.Size(173, 21);
            this.cboCmd.TabIndex = 45;
            this.cboCmd.Text = "*IDN?";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(436, 195);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 24);
            this.btnSend.TabIndex = 46;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtRespond
            // 
            this.txtRespond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRespond.Location = new System.Drawing.Point(209, 243);
            this.txtRespond.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespond.Name = "txtRespond";
            this.txtRespond.Size = new System.Drawing.Size(307, 22);
            this.txtRespond.TabIndex = 47;
            // 
            // btnDisconnectVSA
            // 
            this.btnDisconnectVSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectVSA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDisconnectVSA.Location = new System.Drawing.Point(315, 289);
            this.btnDisconnectVSA.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnectVSA.Name = "btnDisconnectVSA";
            this.btnDisconnectVSA.Size = new System.Drawing.Size(97, 38);
            this.btnDisconnectVSA.TabIndex = 50;
            this.btnDisconnectVSA.Text = "DISCONNECT";
            this.btnDisconnectVSA.UseVisualStyleBackColor = true;
            // 
            // btnCloseVSA
            // 
            this.btnCloseVSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseVSA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseVSA.Location = new System.Drawing.Point(436, 289);
            this.btnCloseVSA.Name = "btnCloseVSA";
            this.btnCloseVSA.Size = new System.Drawing.Size(80, 38);
            this.btnCloseVSA.TabIndex = 49;
            this.btnCloseVSA.Text = "CLOSE";
            this.btnCloseVSA.UseVisualStyleBackColor = true;
            // 
            // btnConnectVSA
            // 
            this.btnConnectVSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectVSA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnectVSA.Location = new System.Drawing.Point(209, 289);
            this.btnConnectVSA.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnectVSA.Name = "btnConnectVSA";
            this.btnConnectVSA.Size = new System.Drawing.Size(81, 38);
            this.btnConnectVSA.TabIndex = 48;
            this.btnConnectVSA.Text = "CONNECT";
            this.btnConnectVSA.UseVisualStyleBackColor = true;
            this.btnConnectVSA.Click += new System.EventHandler(this.btnConnectVSA_Click);
            // 
            // grpVSA
            // 
            this.grpVSA.Controls.Add(this.lblStatus);
            this.grpVSA.Controls.Add(this.lblConnStatus);
            this.grpVSA.Controls.Add(this.lbSearialNumber);
            this.grpVSA.Controls.Add(this.lblSerial);
            this.grpVSA.Controls.Add(this.lblModel);
            this.grpVSA.Controls.Add(this.lblModelText);
            this.grpVSA.Controls.Add(this.lblMfrName);
            this.grpVSA.Controls.Add(this.lblManufacturer);
            this.grpVSA.Controls.Add(this.picVSA);
            this.grpVSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpVSA.Location = new System.Drawing.Point(532, 23);
            this.grpVSA.Name = "grpVSA";
            this.grpVSA.Size = new System.Drawing.Size(386, 304);
            this.grpVSA.TabIndex = 51;
            this.grpVSA.TabStop = false;
            this.grpVSA.Text = "Instruments";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(192, 266);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Not Connect";
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConnStatus.Location = new System.Drawing.Point(66, 266);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(60, 20);
            this.lblConnStatus.TabIndex = 7;
            this.lblConnStatus.Text = "Status:";
            // 
            // lbSearialNumber
            // 
            this.lbSearialNumber.AutoSize = true;
            this.lbSearialNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSearialNumber.Location = new System.Drawing.Point(192, 235);
            this.lbSearialNumber.Name = "lbSearialNumber";
            this.lbSearialNumber.Size = new System.Drawing.Size(39, 20);
            this.lbSearialNumber.TabIndex = 7;
            this.lbSearialNumber.Text = "*****";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSerial.Location = new System.Drawing.Point(66, 235);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(113, 20);
            this.lblSerial.TabIndex = 7;
            this.lblSerial.Text = "Serial Number:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModel.Location = new System.Drawing.Point(192, 204);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 20);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "*****";
            // 
            // lblModelText
            // 
            this.lblModelText.AutoSize = true;
            this.lblModelText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModelText.Location = new System.Drawing.Point(66, 204);
            this.lblModelText.Name = "lblModelText";
            this.lblModelText.Size = new System.Drawing.Size(56, 20);
            this.lblModelText.TabIndex = 7;
            this.lblModelText.Text = "Model:";
            // 
            // lblMfrName
            // 
            this.lblMfrName.AutoSize = true;
            this.lblMfrName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMfrName.Location = new System.Drawing.Point(192, 174);
            this.lblMfrName.Name = "lblMfrName";
            this.lblMfrName.Size = new System.Drawing.Size(39, 20);
            this.lblMfrName.TabIndex = 7;
            this.lblMfrName.Text = "*****";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblManufacturer.Location = new System.Drawing.Point(66, 174);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(108, 20);
            this.lblManufacturer.TabIndex = 7;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // picVSA
            // 
            this.picVSA.Image = ((System.Drawing.Image)(resources.GetObject("picVSA.Image")));
            this.picVSA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picVSA.InitialImage = ((System.Drawing.Image)(resources.GetObject("picVSA.InitialImage")));
            this.picVSA.Location = new System.Drawing.Point(70, 56);
            this.picVSA.Name = "picVSA";
            this.picVSA.Size = new System.Drawing.Size(220, 105);
            this.picVSA.TabIndex = 6;
            this.picVSA.TabStop = false;
            // 
            // SetupVSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 348);
            this.Controls.Add(this.grpVSA);
            this.Controls.Add(this.btnDisconnectVSA);
            this.Controls.Add(this.btnCloseVSA);
            this.Controls.Add(this.btnConnectVSA);
            this.Controls.Add(this.txtRespond);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cboCmd);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.lblConnPort);
            this.Controls.Add(this.cboInterface);
            this.Controls.Add(this.cboIP);
            this.Controls.Add(this.cboVSAList);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblCmdText);
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblVSAName);
            this.Name = "SetupVSA";
            this.Text = "SetupVSA";
            this.grpVSA.ResumeLayout(false);
            this.grpVSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblCmdText;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblVSAName;
        private System.Windows.Forms.ComboBox cboVSAList;
        private System.Windows.Forms.ComboBox cboIP;
        private System.Windows.Forms.ComboBox cboInterface;
        private System.Windows.Forms.Label lblConnPort;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.ComboBox cboCmd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtRespond;
        private System.Windows.Forms.Button btnDisconnectVSA;
        private System.Windows.Forms.Button btnCloseVSA;
        private System.Windows.Forms.Button btnConnectVSA;
        private System.Windows.Forms.GroupBox grpVSA;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Label lbSearialNumber;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblModelText;
        private System.Windows.Forms.Label lblMfrName;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.PictureBox picVSA;
    }
}
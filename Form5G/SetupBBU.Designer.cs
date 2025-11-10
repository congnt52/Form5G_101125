namespace Form5G
{
    partial class SetupBBU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupBBU));
            this.cboBBUList = new System.Windows.Forms.ComboBox();
            this.cboIP = new System.Windows.Forms.ComboBox();
            this.lblBBUName = new System.Windows.Forms.Label();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBBURespond = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cboInterface = new System.Windows.Forms.ComboBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConnPort = new System.Windows.Forms.Label();
            this.grpDU = new System.Windows.Forms.GroupBox();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblModelText = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.picBBU = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbSearialNumber = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMfrName = new System.Windows.Forms.Label();
            this.grpDU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBU)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBBUList
            // 
            this.cboBBUList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboBBUList.FormattingEnabled = true;
            this.cboBBUList.Items.AddRange(new object[] {
            "XEON Gold",
            "DL380",
            "XEON D"});
            this.cboBBUList.Location = new System.Drawing.Point(182, 23);
            this.cboBBUList.Margin = new System.Windows.Forms.Padding(4);
            this.cboBBUList.Name = "cboBBUList";
            this.cboBBUList.Size = new System.Drawing.Size(290, 24);
            this.cboBBUList.TabIndex = 66;
            this.cboBBUList.Text = "XEON D";
            this.cboBBUList.SelectedIndexChanged += new System.EventHandler(this.cboBBUList_SelectedIndexChanged);
            // 
            // cboIP
            // 
            this.cboIP.FormattingEnabled = true;
            this.cboIP.Items.AddRange(new object[] {
            "192.168.120.186",
            "192.168.120.187",
            "192.168.120.3"});
            this.cboIP.Location = new System.Drawing.Point(182, 73);
            this.cboIP.Name = "cboIP";
            this.cboIP.Size = new System.Drawing.Size(290, 21);
            this.cboIP.TabIndex = 74;
            this.cboIP.Text = "192.168.120.195";
            // 
            // lblBBUName
            // 
            this.lblBBUName.AutoSize = true;
            this.lblBBUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblBBUName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBBUName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBBUName.Location = new System.Drawing.Point(28, 23);
            this.lblBBUName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBBUName.Name = "lblBBUName";
            this.lblBBUName.Size = new System.Drawing.Size(109, 24);
            this.lblBBUName.TabIndex = 75;
            this.lblBBUName.Text = "BBU Select:";
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblInterface.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInterface.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInterface.Location = new System.Drawing.Point(28, 115);
            this.lblInterface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(86, 24);
            this.lblInterface.TabIndex = 76;
            this.lblInterface.Text = "Interface:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(28, 70);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 24);
            this.lblAddress.TabIndex = 77;
            this.lblAddress.Text = "IP address:";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblResponse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResponse.Location = new System.Drawing.Point(28, 212);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(92, 24);
            this.lblResponse.TabIndex = 78;
            this.lblResponse.Text = "Respond:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(28, 164);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 24);
            this.lblUser.TabIndex = 79;
            this.lblUser.Text = "User:";
            // 
            // txtBBURespond
            // 
            this.txtBBURespond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBBURespond.Location = new System.Drawing.Point(182, 214);
            this.txtBBURespond.Margin = new System.Windows.Forms.Padding(4);
            this.txtBBURespond.Name = "txtBBURespond";
            this.txtBBURespond.Size = new System.Drawing.Size(290, 22);
            this.txtBBURespond.TabIndex = 81;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPass.Location = new System.Drawing.Point(394, 168);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(78, 22);
            this.txtPass.TabIndex = 82;
            this.txtPass.Text = "root";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUser.Location = new System.Drawing.Point(182, 169);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(81, 22);
            this.txtUser.TabIndex = 83;
            this.txtUser.Text = "root";
            // 
            // cboInterface
            // 
            this.cboInterface.FormattingEnabled = true;
            this.cboInterface.Items.AddRange(new object[] {
            "OAM",
            "SSH",
            "Telnet"});
            this.cboInterface.Location = new System.Drawing.Point(182, 118);
            this.cboInterface.Name = "cboInterface";
            this.cboInterface.Size = new System.Drawing.Size(81, 21);
            this.cboInterface.TabIndex = 84;
            this.cboInterface.Text = "SSH";
            // 
            // cboPort
            // 
            this.cboPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Items.AddRange(new object[] {
            "23",
            "22"});
            this.cboPort.Location = new System.Drawing.Point(394, 118);
            this.cboPort.Margin = new System.Windows.Forms.Padding(4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(78, 24);
            this.cboPort.TabIndex = 80;
            this.cboPort.Text = "1970";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDisconnect.Location = new System.Drawing.Point(282, 255);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(91, 38);
            this.btnDisconnect.TabIndex = 89;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(394, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 39);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConnect.Location = new System.Drawing.Point(182, 255);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 38);
            this.btnConnect.TabIndex = 87;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(316, 169);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 24);
            this.lblPassword.TabIndex = 85;
            this.lblPassword.Text = "Pass:";
            // 
            // lblConnPort
            // 
            this.lblConnPort.AutoSize = true;
            this.lblConnPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConnPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConnPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConnPort.Location = new System.Drawing.Point(316, 118);
            this.lblConnPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnPort.Name = "lblConnPort";
            this.lblConnPort.Size = new System.Drawing.Size(43, 24);
            this.lblConnPort.TabIndex = 86;
            this.lblConnPort.Text = "Port";
            // 
            // grpDU
            // 
            this.grpDU.Controls.Add(this.lblStatus);
            this.grpDU.Controls.Add(this.lbSearialNumber);
            this.grpDU.Controls.Add(this.lblModel);
            this.grpDU.Controls.Add(this.lblMfrName);
            this.grpDU.Controls.Add(this.lblConnStatus);
            this.grpDU.Controls.Add(this.lblSerial);
            this.grpDU.Controls.Add(this.lblModelText);
            this.grpDU.Controls.Add(this.lblManufacturer);
            this.grpDU.Controls.Add(this.picBBU);
            this.grpDU.Location = new System.Drawing.Point(499, 23);
            this.grpDU.Name = "grpDU";
            this.grpDU.Size = new System.Drawing.Size(342, 255);
            this.grpDU.TabIndex = 90;
            this.grpDU.TabStop = false;
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConnStatus.Location = new System.Drawing.Point(42, 201);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(40, 13);
            this.lblConnStatus.TabIndex = 9;
            this.lblConnStatus.Text = "Status:";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSerial.Location = new System.Drawing.Point(42, 170);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(76, 13);
            this.lblSerial.TabIndex = 10;
            this.lblSerial.Text = "Serial Number:";
            // 
            // lblModelText
            // 
            this.lblModelText.AutoSize = true;
            this.lblModelText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModelText.Location = new System.Drawing.Point(42, 139);
            this.lblModelText.Name = "lblModelText";
            this.lblModelText.Size = new System.Drawing.Size(39, 13);
            this.lblModelText.TabIndex = 11;
            this.lblModelText.Text = "Model:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblManufacturer.Location = new System.Drawing.Point(42, 109);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 12;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // picBBU
            // 
            this.picBBU.Image = ((System.Drawing.Image)(resources.GetObject("picBBU.Image")));
            this.picBBU.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBBU.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBBU.InitialImage")));
            this.picBBU.Location = new System.Drawing.Point(46, 44);
            this.picBBU.Name = "picBBU";
            this.picBBU.Size = new System.Drawing.Size(255, 48);
            this.picBBU.TabIndex = 8;
            this.picBBU.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(131, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Not Connect";
            // 
            // lbSearialNumber
            // 
            this.lbSearialNumber.AutoSize = true;
            this.lbSearialNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSearialNumber.Location = new System.Drawing.Point(131, 172);
            this.lbSearialNumber.Name = "lbSearialNumber";
            this.lbSearialNumber.Size = new System.Drawing.Size(27, 13);
            this.lbSearialNumber.TabIndex = 14;
            this.lbSearialNumber.Text = "*****";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModel.Location = new System.Drawing.Point(131, 141);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(27, 13);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "*****";
            // 
            // lblMfrName
            // 
            this.lblMfrName.AutoSize = true;
            this.lblMfrName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMfrName.Location = new System.Drawing.Point(131, 111);
            this.lblMfrName.Name = "lblMfrName";
            this.lblMfrName.Size = new System.Drawing.Size(27, 13);
            this.lblMfrName.TabIndex = 16;
            this.lblMfrName.Text = "*****";
            // 
            // SetupBBU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 313);
            this.Controls.Add(this.grpDU);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblConnPort);
            this.Controls.Add(this.txtBBURespond);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cboInterface);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBBUName);
            this.Controls.Add(this.cboIP);
            this.Controls.Add(this.cboBBUList);
            this.Name = "SetupBBU";
            this.Text = "SetupBBU";
            this.grpDU.ResumeLayout(false);
            this.grpDU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBBU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBBUList;
        private System.Windows.Forms.ComboBox cboIP;
        private System.Windows.Forms.Label lblBBUName;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtBBURespond;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cboInterface;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConnPort;
        private System.Windows.Forms.GroupBox grpDU;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbSearialNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMfrName;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblModelText;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.PictureBox picBBU;
    }
}
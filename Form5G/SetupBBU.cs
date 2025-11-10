using Form5G.Instruments.BBU;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form5G
{
    public partial class SetupBBU : Form
    {
        public SetupBBU()
        {
            InitializeComponent();
        }

        private Form5GAT mainForm;
        public SetupBBU(Form callingForm)
        {
            mainForm = callingForm as Form5GAT;
            InitializeComponent();
        }

        //Khai bao 

        string manufacturer = "";
        string serial = "";
        string IP = "";
        string instrument = "";
        string user = "";
        string pass = "";
        bool connStatus = false;
        string connectionSTT = "ERROR";


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (connectionSTT != "DU_Connected")
            {
                try
                {
                    IP = cboIP.Text;
                    instrument = cboBBUList.Text;
                    user = txtUser.Text;
                    pass = txtPass.Text;
                    this.mainForm.BBUConnection(instrument, IP, user, pass, out connStatus);
                }
                catch {
                    lblStatus.Text = "ERROR";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    txtBBURespond.Text = "ERROR";
                }
                if (connStatus == true)
                {
                    if (instrument == "XEON D")
                    {
                        connectionSTT = "DU_Connected";
                        lblMfrName.Text = "DELL";
                        lbSearialNumber.Text = "";
                        lblModel.Text = "XEON D";
                        txtBBURespond.Text = "Connected";
                        lblStatus.Text = "Connected";
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                    }
                }
                else
                {
                    connectionSTT = "Disconected";
                    txtBBURespond.Text = "No Connection !";
                    lblStatus.Text = "Not Connected";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                Console.WriteLine("XEON Connected");
            }
        }

        
        public void infor(out string instrument, out string IP, out int port, out string user, out string pass)
        { 
            IP = cboIP.Text;
            instrument = cboBBUList.Text;
            user = txtUser.Text; pass = txtPass.Text;
            port = int.Parse(cboPort.Text);
        }
        public void statusConnection(out string IP, out string sttConnect)
        {
            sttConnect = connectionSTT;
            IP = cboIP.Text;
        }

        public void statusConnection()
        {
            connectionSTT = "DU_Connected";
            lblMfrName.Text = "DELL";
            lbSearialNumber.Text = "XEON Gold";
            lblModel.Text = "R740";
            txtBBURespond.Text = "Connected";
            lblStatus.Text = "Connected";
            lblStatus.ForeColor = System.Drawing.Color.Green;
        }
        private void cboBBUList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBBUList.Text == "XEON Gold")
            {
                cboIP.Text = "192.168.120.3";
                txtUser.Text = "root";
                txtPass.Text = "1";
            }
            else if (cboBBUList.Text == "DL380")
            {
                cboIP.Text = "192.168.120.186";
                txtUser.Text = "root";
                txtPass.Text = "root";
            }
            else if (cboBBUList.Text == "XEON D")
            {
                cboIP.Text = "192.168.120.187";
                txtUser.Text = "root";
                txtPass.Text = "root";
            }
            else
            {

            }
        }

        public void flagConn(string flagConn)
        {
            connectionSTT = flagConn;
            if (connectionSTT == "DU_Disconnected")
            {
                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (connectionSTT == "DU_Connected")
            {
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Text = "Disconnected";
            connectionSTT = "DU_Disconnected";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using Form5G.Instruments.VSA;
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
    public partial class SetupVSA : Form
    {
        public SetupVSA()
        {
            InitializeComponent();
        }
        VSA VSA;
        private Form5GAT mainForm;
        public SetupVSA(Form callingForm)
        {
            mainForm = callingForm as Form5GAT;    
            InitializeComponent();
            
        }
        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string manufacturer = "";
        string model = "";
        string serial = "";
       
        
        string connectionSTT = "ERROR";
        private void btnConnectVSA_Click(object sender, EventArgs e)
        {
            if (connectionSTT != "VSA_Connected")
            {
                string IP = cboIP.Text;
                string instrument = cboVSAList.Text;
                string cmd = "*IDN?";
                this.mainForm.VSAConnection(IP, cmd, instrument, out manufacturer, out model, out serial);
                if (manufacturer == "Rodeh&Schwars" && instrument == "FSV3030")
                {
                    connectionSTT = "VSA_Connected";
                    lblMfrName.Text = manufacturer;
                    lbSearialNumber.Text = serial;
                    lblModel.Text = model;
                    txtRespond.Text = manufacturer + "/" + model + "/" + serial;
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.Green;

                }
                else if (manufacturer == "Agilent Technologies" && instrument == "N9020A")
                {

                }
                else
                {
                    connectionSTT = "VSA_Disconnected";
                    txtRespond.Text = "No connection";
                    lblStatus.Text = "No connection";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            else
            { 
            
            }
        }

        public void flagConn(string flagConn)
        {
            connectionSTT = flagConn;
            if (connectionSTT == "VSA_Disconnected")
            {
                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (connectionSTT == "VSA_Connected")
            {
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        public void StatusConnection(out string IP, out string sttConnect)
        {
            sttConnect = connectionSTT;
            IP = cboIP.Text;
        }
    }
}

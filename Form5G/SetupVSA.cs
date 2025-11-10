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
        string cmd = "*IDN?";
        
        string connectionSTT = "ERROR";
        private void btnConnectVSA_Click(object sender, EventArgs e)
        {
            if (connectionSTT != "VSA_Connected")
            { 
            
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSH = Renci.SshNet;

namespace Form5G.Instruments.BBU.BBU_Version
{
    public class XeonD
    {
        public Form5GAT mainForm;
        public XeonD(Form5GAT mMainForm)
        {
            mainForm = mMainForm;
        }

        SSH.SshClient xeonD;
        BackgroundWorker backgroundWorker_NRTM, backgroundWorker_RX;
        string ThroughputValue = "0";
        public void Connection(string IP, string Username, string Password, out bool statusConnection)
        {
            statusConnection = false;
            try
            {
                xeonD = new SSH.SshClient(IP, Username, Password);
                xeonD.Connect();
                xeonD.ConnectionInfo.Timeout = TimeSpan.FromSeconds(1);
                statusConnection = xeonD.IsConnected;
                if (statusConnection == true)
                {
                    mainForm.LogText("XEON D: Connected: " + IP);
                }
                else
                {
                    mainForm.LogText("ERROR: XEON connection fail");
                }

            }
            catch
            {
                mainForm.LogText("ERROR: XEON Dconnection fail");
             }
        }
        public void Disconnect()
        {
            try
            {
                if (xeonD.IsConnected)
                {
                    xeonD.Disconnect();
                    mainForm.LogText("XEON D Disconnected");
                }
            }
            catch
            {

            }
        }

    }
}

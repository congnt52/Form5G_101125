using Form5G.Instruments.BBU.BBU_Version;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form5G.Instruments.BBU
{
   
    public class BBU
     {
        XeonD xeonD;
        string bbuVersion = "0";
        public Form5GAT mainForm;
        public BBU(Form5GAT mMainForm)
        {
            mainForm = mMainForm;
            xeonD = new XeonD(mainForm);
            
        }
        public void BBUVersion(string Version_BBU)
        {
            bbuVersion = Version_BBU;
        }

        public void Connection(string IP, string Username, string Password, out bool statusConnection)
        {
            statusConnection = false;
            if (bbuVersion == "XEON D")
            {
                xeonD.Connection(IP, Username, Password, out statusConnection);
            }
            else
            {
                mainForm.LogText("Kiem tra phien ban BBU");
            }

        }
    }
}

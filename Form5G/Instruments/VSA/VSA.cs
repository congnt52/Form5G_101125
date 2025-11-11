using DevExpress.XtraReports.Native;
using Form5G.Instruments.VSA.VSA_Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form5G.Instruments.VSA
{
    public class VSA
    {
        public Form5GAT mainForm;
        public FSV3030 fsv3030;
        string instrumentVSA;
        public VSA(Form5GAT mMainForm) 
        {
            mainForm = mMainForm;
            fsv3030 = new FSV3030(mainForm);

        }
        public void Instrument(String VSA_instrument)
        { 
            instrumentVSA = VSA_instrument;
        }

        public void Connection(string IP, string cmd, out string manufacturer, out string model, out string serial)
        {
            manufacturer = "ERROR";
            model = "ERROR";
            serial = "ERROR";
            if (instrumentVSA == "FSV3030")
            {
                fsv3030.Connection(IP, cmd, out manufacturer, out model, out serial);
            }
            else if (instrumentVSA == "N9020A")
            {
                
            }
            else if (instrumentVSA == "FSW26")
            {
            }
            else
            {
                mainForm.LogText("VSA Instrument not supported");
            }
        }
    }
}

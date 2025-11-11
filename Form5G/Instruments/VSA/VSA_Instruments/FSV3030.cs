using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form5G.Instruments.VSA.VSA_Instruments
{
    public class FSV3030
    {
        public Form5GAT mainForm;
        public FSV3030(Form5GAT mMainForm)
        {
            mainForm = mMainForm;
        }
        Ivi.Visa.Interop.ResourceManager rm = new Ivi.Visa.Interop.ResourceManager();
        Ivi.Visa.Interop.FormattedIO488 fsv = new Ivi.Visa.Interop.FormattedIO488();

        public void Connection(string IP, string cmd, out string manufacturer, out string model, out string serial)
        {
            manufacturer = "ERROR";
            model = "ERROR";
            serial = "ERROR";
            try
            {
                fsv.IO = (Ivi.Visa.Interop.IMessage)rm.Open("TCPIP::" + IP + "::INSTR", Ivi.Visa.Interop.AccessMode.NO_LOCK, 2000, "");
                fsv.WriteString(cmd);
                string idn = fsv.ReadString();
                mainForm.LogText("VSA FSV3030 Connected: " + idn);
            }
            catch (Exception ex)
            {
                mainForm.LogText("VSA FSV3030 Connection Error: " + ex.Message);
            }
        }

    }
}

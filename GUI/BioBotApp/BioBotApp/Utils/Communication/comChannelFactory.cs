using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication
{
    class ComChannelFactory
    {

        public static CustomSerial getGCodeSerial()
        {
            if (gCodeSerialChannel == null)
            {
                gCodeSerialChannel = new CustomSerial();

                try
                {
                    gCodeSerialChannel.configure("COM3", "115200", "8", "One", "None");
                    gCodeSerialChannel.Open();
                }
                catch(Exception e)
                {

                }
            }
            return gCodeSerialChannel;
        }

        private static CustomSerial gCodeSerialChannel;
    }
}

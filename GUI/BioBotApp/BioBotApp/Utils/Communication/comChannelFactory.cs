﻿using System;
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
                    gCodeSerialChannel.configure("COM4", "57600", "8", "One", "None");

                    //PCAN.ctrCanConnector temp = new PCAN.ctrCanConnector();
                    //temp.connect("51");

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

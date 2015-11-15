using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace BioBotApp.Utils.Communication.pcan.TAC
{
    class TacComm
    {
        public static void sendInstruction(byte[] trame)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = trame; //new byte[8];
            CANMsg.ID = CANDevice.HARDWARE_FILTER_TAC;  //  physical filtering address
            PCANCom.Instance.send(CANMsg);
        }
        public static void printPacket(byte[] packet)
        {
            for (int n = 0; n < 8; n++)
            {
                Console.Write("[{0:X}] ", packet[n]);
            }
        }
    }
}

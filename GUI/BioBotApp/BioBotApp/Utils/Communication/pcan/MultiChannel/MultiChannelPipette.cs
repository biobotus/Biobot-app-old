using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication.pcan.MultiChannelPipette
{
    class MultiChannelPipette
    {
        public static void sendInstruction(byte direction, String volume)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];
            Int16 aaa;
            Int16.TryParse(volume, out aaa);
            CANMsg.DATA[4] = (byte)(aaa >> 8);
            CANMsg.DATA[5] = (byte)(aaa);
            CANMsg.DATA[6] = direction;
            CANMsg.ID = CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE;

            PCANCom.Instance.send(CANMsg);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------");
            Console.Write("T: ");
            printPacket(CANMsg.DATA);
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

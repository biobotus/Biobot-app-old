using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication.pcan.SingleChannelPipette
{
    class SingleChannelPipette
    {
        public static void sendInstruction(byte direction, Int16 volume)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[4] = (byte)(volume >> 8);
            CANMsg.DATA[5] = (byte)(volume);
            CANMsg.DATA[6] = direction;
            CANMsg.ID = CANDevice.HARDWARE_FILTER_SINGLE_CHANNEL_PIPETTE;
            
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

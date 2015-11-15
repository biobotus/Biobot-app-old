using Peak.Can.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication.pcan.Dynamixel
{
    class DynamixelCom
    {

        public static void sendInstruction(byte instruction, byte id, UInt16 data)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];
            CANMsg.DATA[0] = instruction;
            CANMsg.DATA[1] = id;
            CANMsg.DATA[2] = (byte)(data);
            CANMsg.DATA[3] = (byte)(data >> 8);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;
            PCANCom.Instance.send(CANMsg);
        }

        public static void sendInstruction(byte instruction, UInt16 data)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];
            CANMsg.DATA[0] = instruction;
            CANMsg.DATA[1] = (byte)(data);
            CANMsg.DATA[2] = (byte)(data>>8);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;
            PCANCom.Instance.send(CANMsg);
        }

        public static void sendInstruction(byte instruction)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];
            CANMsg.DATA[0] = instruction;
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;
            PCANCom.Instance.send(CANMsg);
            
            /*Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------");
            Console.Write("T: ");
            printPacket(CANMsg.DATA);//*/
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

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
        private enum InstructionSet { Home = 0x00, GoTo = 0x01  };
        static int INSTRUCTION_BYTE = 0;

        public static void sendInstruction(byte instruction, byte id, UInt16 data)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];
            CANMsg.DATA[INSTRUCTION_BYTE] = instruction;
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
            CANMsg.DATA[INSTRUCTION_BYTE] = instruction;
            CANMsg.DATA[1] = (byte)(data);
            CANMsg.DATA[2] = (byte)(data >> 8);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;
            PCANCom.Instance.send(CANMsg);
        }

        public static void sendInstruction(byte instruction)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];
            CANMsg.DATA[INSTRUCTION_BYTE] = instruction;
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;
            PCANCom.Instance.send(CANMsg);

            /*Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------");
            Console.Write("T: ");
            printPacket(CANMsg.DATA);//*/
        }

        public static void sendPositionToMoveTo(Int16 position)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[INSTRUCTION_BYTE] = (byte)InstructionSet.GoTo;
            CANMsg.DATA[6] = (byte)(position >> 8);
            CANMsg.DATA[7] = (byte)(position);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;

            PCANCom.Instance.send(CANMsg);
        }

        public static void homeTool()
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[INSTRUCTION_BYTE] = (byte)InstructionSet.Home;
            CANMsg.ID = CANDevice.HARDWARE_FILTER_GRIPPER;

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

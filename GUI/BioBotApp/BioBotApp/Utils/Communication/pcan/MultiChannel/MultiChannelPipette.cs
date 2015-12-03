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
        private enum InstructionSet { Home = 0x00, GoTo = 0x01, Pipette = 0x02, Dispense = 0x03 };
        static int INSTRUCTION_BYTE = 0;

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
                Console.Write("Single channel pipette : [{0:X}] ", packet[n]);
            }
        }

        public static void sendPositionToMoveTo(Int16 position)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[INSTRUCTION_BYTE] = (byte)InstructionSet.GoTo;
            CANMsg.DATA[6] = (byte)(position >> 8);
            CANMsg.DATA[7] = (byte)(position);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE;
            printPacket(CANMsg.DATA);
            PCANCom.Instance.send(CANMsg);
        }

        public static void homeTool()
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[INSTRUCTION_BYTE] = (byte)InstructionSet.Home;
            CANMsg.ID = CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE;

            PCANCom.Instance.send(CANMsg);
        }

        public static void pipette(Int16 volume)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[INSTRUCTION_BYTE] = (byte)InstructionSet.Pipette;
            CANMsg.DATA[6] = (byte)(volume >> 8);
            CANMsg.DATA[7] = (byte)(volume);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE;

            PCANCom.Instance.send(CANMsg);
        }

        public static void dispense(Int16 volume)
        {
            TPCANMsg CANMsg = new TPCANMsg();
            CANMsg.DATA = new byte[8];

            CANMsg.DATA[INSTRUCTION_BYTE] = (byte)InstructionSet.Dispense;
            CANMsg.DATA[6] = (byte)(volume >> 8);
            CANMsg.DATA[7] = (byte)(volume);
            CANMsg.ID = CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE;

            PCANCom.Instance.send(CANMsg);
        }
    }
}

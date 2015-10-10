using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioBotApp.Utils.Communication.pcan;
using BioBotApp.Utils.Communication.pcan.TAC;
using System.Threading;

namespace BioBotApp.Utils.FSM
{
    class fsmTAC
    {
        private const int SET_TARGET_TEMPERATURE = 1;  // Linked to ID in DB
        private const int SET_AGITATOR_SPEED = 33;
        private const int SET_FAN_SPEED = 34;
        private const int START_CALIBRATION = 35;
        private const int STOP_CALIBRATION = 36;
        private const int START_TEMPERATURE_MAINTAIN = 37;
        private const int STOP_TEMPERATURE_MAINTAIN = 38;
        private const int ENABLE_FAN = 39;
        private const int DISABLE_FAN = 40;
        private const int ENABLE_AGITATOR = 41;
        private const int DISABLE_AGITATOR = 42;

        // Pinging functions awaiting an answer
        private const int GET_FAN_SPEED = 43;
        private const int GET_TEMPERATURE = 44;
        private const int GET_AGITATOR_SPEED = 45;
        private const int GET_TURBIDITY = 46;

        AutoResetEvent acknowledgeEvent = new AutoResetEvent(false);

        public fsmTAC()
        {
            PCANCom.Instance.OnMessageReceived += messageReceivedHandler;
        }

        private void messageReceivedHandler(object sender, PCANComEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.CanMsg.ToString());
            String response = e.CanMsg.ToString();

            // You can add treatment here
            // Tell the module that ack has been received
            acknowledgeEvent.Set();
        }

        public void move(DataSets.dsModuleStructure3.dtActionValueRow actionValue)
        {
            if (actionValue.fk_action_type == SET_TARGET_TEMPERATURE)
            {
                byte[] toSend = new byte[8];

                String[] values = actionValue.description.Split(',');

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x00;   // Instruction number: 0 --> Set target temperature
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = byte.Parse(values[0]);
                toSend[5] = byte.Parse(values[1]);
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == SET_AGITATOR_SPEED)
            {
                byte[] toSend = new byte[8];

                String[] values = actionValue.description.Split(',');

                byte speed = byte.Parse(values[0]);
                if (speed > 100)
                {
                    speed = 100;
                }
                else if (speed < 0) // Not sure if required....
                {
                    speed = 0;
                }

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x01;   // Instruction number: 1 --> Set agitator speed
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = speed;  // Agitator speed in %
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == SET_FAN_SPEED)
            {
                byte[] toSend = new byte[8];

                String[] values = actionValue.description.Split(',');

                byte speed = byte.Parse(values[0]);
                if(speed > 100)
                {
                    speed = 100;
                }
                else if (speed < 0)
                {
                    speed = 0;
                }

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x02;   // Instruction number: 2 --> Set fan speed
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = speed;  // Desired speed in %
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == START_CALIBRATION)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x03;   // Instruction number: 3 --> Start calibration
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == STOP_CALIBRATION)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x04;   // Instruction number: 4 --> Stop calibration
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == START_TEMPERATURE_MAINTAIN)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x05;   // Instruction number: 5 --> Start temperature maintain
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == STOP_TEMPERATURE_MAINTAIN)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x06;   // Instruction number: 6 --> Stop temperature maintain
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == ENABLE_FAN)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x07;   // Instruction number: 7 --> Start fan
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == DISABLE_FAN)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x08;   // Instruction number: 8 --> Stop fan
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == ENABLE_AGITATOR)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x09;   // Instruction number: 9 --> Start fan
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == DISABLE_AGITATOR)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x0A;   // Instruction number: 10 --> Stop fan
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == GET_FAN_SPEED)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x0D;   // Instruction number: 13 --> Get fan speed
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == GET_TEMPERATURE)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x0E;   // Instruction number: 14 --> Get temperature
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }
            else if (actionValue.fk_action_type == GET_TURBIDITY)
            {
                byte[] toSend = new byte[8];

                toSend[0] = 0x00;   // Will be replaced by something like byte.Parse(values[0]);    // Device ID
                toSend[1] = 0x01;   // Submodule ID
                toSend[2] = 0x0F;   // Instruction number: 15 --> Get fan speed
                toSend[3] = 0x00;   // Spare byte
                toSend[4] = 0x00;   // Unused
                toSend[5] = 0x00;   // Unused
                toSend[6] = 0x00;   // Unused
                toSend[7] = 0x00;   // Unused

                TacComm.sendInstruction(toSend);
            }

            acknowledgeEvent.Reset();
            acknowledgeEvent.WaitOne();
        }
    }
}

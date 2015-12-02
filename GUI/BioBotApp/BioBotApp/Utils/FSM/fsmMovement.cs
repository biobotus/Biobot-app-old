using BioBotApp.Utils.Communication;
using BioBotApp.Utils.Communication.pcan;
using BioBotApp.Utils.Communication.pcan.Dynamixel;
using BioBotApp.Utils.Communication.pcan.MultiChannelPipette;
using BioBotApp.Utils.Communication.pcan.SingleChannelPipette;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BioBotApp.Utils.FSM
{
    class fsmMovement
    {
        private const int MOVE_X = 14;  // Linked to ID in DB
        private const int MOVE_Y = 15;
        private const int MOVE_Z1 = 16;
        private const int MOVE_Z2 = 17;
        private const int MOVE_Z3 = 18;
        private const int HOME = 19;

        int desiredXSpeed = 25000;
        int desiredYSpeed = 10000;
        
        CustomSerial serial = ComChannelFactory.getGCodeSerial();
        SingleChannelPipette SCP = new SingleChannelPipette();
        AutoResetEvent acknowledgeEvent = new AutoResetEvent(false);

        AutoResetEvent wait = new AutoResetEvent(false);
        
        public fsmMovement()
        {
            PCANCom.Instance.OnMessageReceived += Instance_OnMessageReceived;
        }

        private void Instance_OnMessageReceived(object sender, PCANComEventArgs e)
        {
            wait.Set();
        }

        public void move(DataSets.dsModuleStructure3.dtActionValueRow actionValue)
        {
            if (actionValue.fk_action_type == MOVE_X)
            {
                //String value = "X" + Int32.Parse(actionValue.description) + '\n';
                //String value = "G1 X" + Int32.Parse(actionValue.description) / 10 + " F" + desiredXSpeed + "\n";
                String value = "G1 X" + Int32.Parse(actionValue.description) / 10 + "\n";
                write(value);
            }
            else if (actionValue.fk_action_type == MOVE_Y)
            {
                //String value = "Y" + Int32.Parse(actionValue.description) + '\n'; 
                //String value = "G1 Y" + Int32.Parse(actionValue.description) / 10 + " F" + desiredYSpeed + "\n";
                String value = "G1 Y" + Int32.Parse(actionValue.description) / 10 + "\n";
                write(value);
            }
            else if (actionValue.fk_action_type == MOVE_Z1)
            {
                Int16 tempValue = 0;
                if (Int16.TryParse(actionValue.description, out tempValue))
                {
                    SingleChannelPipette.sendPositionToMoveTo(tempValue);
                    wait.WaitOne();
                }
                //serial.Write("Z1" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == MOVE_Z2)
            {
                Int16 tempValue = 0;
                if (Int16.TryParse(actionValue.description, out tempValue))
                {
                    MultiChannelPipette.sendPositionToMoveTo(tempValue);
                    wait.WaitOne();
                }
                //serial.Write("Z2" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == MOVE_Z3)
            {
                Int16 tempValue = 0;
                if (Int16.TryParse(actionValue.description, out tempValue))
                {
                    DynamixelCom.sendPositionToMoveTo(tempValue);
                    wait.WaitOne();
                }
                //serial.Write("Z3" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == HOME)
            {
                switch (actionValue.description)
                {
                    case "X":
                        //write("HX",1);
                        write("G28 X");
                        break;
                    case "Y":
                        //write("HY",1);
                        write("G28 Y");
                        break;
                    case "Z1":
                        SingleChannelPipette.homeTool();
                        wait.WaitOne();
                        break;
                    case "Z2":
                        MultiChannelPipette.homeTool();
                        wait.WaitOne();
                        break;
                    case "Z3":
                        DynamixelCom.homeTool();
                        wait.WaitOne();
                        break;
                    default:
                        break;
                }
                //if (actionValue.description == 
                //serial.Write("H" + actionValue.description + '\n');
            }    
        }

        public void write(string value)
        {
            serial.Write(value + '\n');
            String test;
            bool stayInThere = true;
            
            test = serial.ReadLine();                    

            while (stayInThere == true)
            {
                if (test != String.Empty)
                {
                    if (test.Contains("Completed"))
                    {
                        //System.Windows.Forms.MessageBox.Show(test);
                        stayInThere = false;
                        serial.ReadExisting();
                        serial.DiscardInBuffer();
                        serial.DiscardOutBuffer();
                    }
                }
                else
                {
                    test = serial.ReadLine();
                    //System.Threading.Thread.Sleep(100);
                }
            }   
        }
    }
}

﻿using BioBotApp.Utils.Communication;
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

        public bool isBusy = false;

        int desiredXSpeed = 25000;
        int desiredYSpeed = 10000;

                
        CustomSerial serial = ComChannelFactory.getGCodeSerial();        
        SingleChannelPipette SCP = new SingleChannelPipette();
        AutoResetEvent acknowledgeEvent = new AutoResetEvent(false);

        AutoResetEvent wait = new AutoResetEvent(false);
        
        public fsmMovement()
        {
            PCANCom.Instance.OnMessageReceived += Instance_OnMessageReceived;
            serial.isBusy = false;
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
                String value = "G1 X" + Int32.Parse(actionValue.description) / 10;
                write(value);
                wait.WaitOne();
            }
            else if (actionValue.fk_action_type == MOVE_Y)
            {
                //String value = "Y" + Int32.Parse(actionValue.description) + '\n'; 
                //String value = "G1 Y" + Int32.Parse(actionValue.description) / 10 + " F" + desiredYSpeed + "\n";
                String value = "G1 Y" + Int32.Parse(actionValue.description) / 10;
                
                write(value);
                wait.WaitOne();
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
                        wait.WaitOne();
                        break;
                    case "Y":
                        //write("HY",1);
                        write("G28 Y");
                        wait.WaitOne();
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

        public void write(string dataToSend)
        {
            //while (InterOperationFlag.isCanBusy != false)
            //{
            //    System.Threading.Thread.Sleep(100);
            //}
            //InterOperationFlag.isSerialBusy = true;

            serial.isBusy = true;           

            Logger.Instance.writeToLog(">>>>>>>>>>>>>>>>>>>>>", true, true);
            Logger.Instance.writeToLog("SERIAL - Sending at : "+System.DateTime.Now, true, true);
            Logger.Instance.writeToLog(dataToSend, true, true);
            Logger.Instance.writeToLog(">>>>>>>>>>>>>>>>>>>>>", true, true);

            serial.Open();

            serial.DiscardInBuffer();
            serial.DiscardOutBuffer();

            serial.Write(dataToSend + '\n');
            String receivedData;
            bool stayInThere = true;
            
            receivedData = serial.ReadLine();

            while (stayInThere == true)
            {
                Logger.Instance.writeToLog("<<<<<<<<<<<<<<<<<<<<<", true, true);
                Logger.Instance.writeToLog("SERIAL - Receiving at : " + System.DateTime.Now, true, true);
                Logger.Instance.writeToLog(receivedData, false, true);
                Logger.Instance.writeToLog("<<<<<<<<<<<<<<<<<<<<<", true, true);

                if (receivedData.Contains(dataToSend))
                {
                    serial.DiscardInBuffer();
                    serial.DiscardOutBuffer();
                    System.Threading.Thread.Sleep(200);

                    //System.Windows.Forms.MessageBox.Show(test);
                    stayInThere = false;
                    wait.Set();
                    serial.isBusy = false;
                }
                else
                {
                    receivedData = serial.ReadLine();
                    System.Threading.Thread.Sleep(200);
                }
            }            
            //InterOperationFlag.isSerialBusy = false;
            serial.Close();
        }
    }
}

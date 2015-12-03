using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using PCAN;
using Peak.Can.Basic;
using BioBotApp.Utils.Communication.pcan;
using System.Runtime.InteropServices;
using BioBotApp.Controls.TCPConsole;

namespace BioBotApp.Utils
{
    public class Logger
    {

        List<string> commandsSent = new List<string>();

        private StreamWriter file;
        private string filename;

        #region CONSTRUCTOR
        public Logger()
        {
        }
        #endregion


        #region INSTANCE
        private static Logger instance;
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
        #endregion


        public void openLog(String _fileName)
        {
            //writeToLog("Starting log :", true, false);
            file = new StreamWriter(_fileName);
            filename = _fileName;
        }

        public void close()
        {
            file.Close();

            StreamWriter file2 = new StreamWriter("OutputFileDataLog.txt");
            
            foreach (string s in commandsSent)
            {
                file2.Write(s);
            }

            file2.Close();
        }

        public void logPacket(byte[] packet, bool transmit, int physicalFilterId)
        {
            int N = 8;

            switch (packet[1])
            {
                case CANDevice.HARDWARE_FILTER_GRIPPER:
                    writeToLog("Gripper (" + physicalFilterId + ") - (" + DateTime.Now + "): ", true, true);
                    //file.WriteLine("Gripper (" + DateTime.Now +"): ");
                    break;
                case CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE:
                    writeToLog("Pippet Multiple (" + physicalFilterId + ") - (" + DateTime.Now + "): ", true, true);
                    //file.WriteLine("Pippet Multiple (" + DateTime.Now + "): ");
                    break;
                case CANDevice.HARDWARE_FILTER_SINGLE_CHANNEL_PIPETTE:
                    writeToLog("Pippet Simple (" + physicalFilterId + ") - (" + DateTime.Now + "): ", true, true);
                    break;
                //file.WriteLine("Pippet Simple (" + DateTime.Now + "): ");
                default:
                    writeToLog("Unknown byte 1 (" + physicalFilterId + ") - (" + DateTime.Now + ") ", true, true);
                    break;
            }

            if (transmit == true)
            {
                writeToLog("Transmit - ", true, true);
                //file.Write("Transmit - ");
            }
            else
            {
                writeToLog("Receive - ", true, true);
                //file.Write("Receive - ");
            }          

            for (int n = 0; n < N; n++)
            {
                if (n == (N - 1))
                {
                    writeToLog(String.Format("[{0}] ", packet[n]), true, true);
                }
                else
                {
                    writeToLog(String.Format("[{0}] ", packet[n]), false, true);
                }
            }            
        } 

        private void writeToLog(string toWrite, bool newLine, bool appendText)
        {
            string newLineInString = newLine ? Environment.NewLine : "";
            commandsSent.Add(toWrite + newLineInString);
            //file.Write(toWrite + newLineInString);
            ctrlConsole.Instance.AppendTextBox(toWrite + newLineInString);

            /*
            using (StreamWriter writer = new StreamWriter("OutputTest.txt"))
            {
                writer.Write(toWrite + newLineInString);
                System.Threading.Thread.Sleep(10);
            }     */       
            //ctrlConsole.Instance.Log(toWrite);
        }
    }
}

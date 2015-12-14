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

        public void logPacket(byte[] packet, bool transmit, int canIdMsg)
        {
            int N = 8;
            int outil = packet[1];
            if (transmit == true)
                outil = canIdMsg;
            
            switch (outil)
            {
                case CANDevice.HARDWARE_FILTER_GRIPPER:
                    writeToLog("Gripper - (" + DateTime.Now + "): ", true, true);
                    //file.WriteLine("Gripper (" + DateTime.Now +"): ");
                    break;
                case CANDevice.HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE:
                    writeToLog("Pippet Multiple - (" + DateTime.Now + "): ", true, true);
                    //file.WriteLine("Pippet Multiple (" + DateTime.Now + "): ");
                    break;
                case CANDevice.HARDWARE_FILTER_SINGLE_CHANNEL_PIPETTE:
                    writeToLog("Pippet Simple - (" + DateTime.Now + "): ", true, true);
                    break;
                //file.WriteLine("Pippet Simple (" + DateTime.Now + "): ");
                default:
                    writeToLog("Unknown byte 1 (" + outil + ") - (" + DateTime.Now + ") ", true, true);
                    break;
            }

            writeToLog("CAN Message ID: " + canIdMsg, true, true);

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
            Console.WriteLine("########################");
        } 

        public void writeToLog(string toWrite, bool newLine, bool appendText)
        {
            string lineToPrint = newLine ? Environment.NewLine : "";
            commandsSent.Add(toWrite + lineToPrint);
            //file.Write(toWrite + newLineInString);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(toWrite + lineToPrint);
            
            Console.ResetColor();

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace BioBotApp.Utils.Communication
{
    class CustomSerial : SerialPort
    {
        public CustomSerial()
        {

        }

        public bool configure(string portName, string baudRate, string dataBits, string stopBits, string parityBits)
        {
            isConfigured = false;
            if (this.IsOpen == true)
            {
                this.Close();
            }
            try
            {
                this.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
                this.BaudRate = int.Parse(baudRate);
                this.DataBits = int.Parse(dataBits);
                this.PortName = portName;
                this.Parity = (Parity)Enum.Parse(typeof(Parity), parityBits);   
            }
            catch (Exception ex)
            {
                //TODO gestion des exceptions?
                Console.WriteLine(ex.ToString());
                return false;
            }

            isConfigured = true;
            return true;
        }

        public new bool Open()
        {
            if (this.IsOpen)
            {
                this.Close();
            }
            if (isConfigured)
            {
                try
                {
                    // Genere parfois des exceptions que je ne comprend pas sur de mauvais arguments 
                    base.Open();
                    return this.IsOpen;
                }
                catch (Exception ex)
                {
                    //TODO gestion des exceptions?
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }          
        }

        private bool isConfigured = false;
        
    }
}

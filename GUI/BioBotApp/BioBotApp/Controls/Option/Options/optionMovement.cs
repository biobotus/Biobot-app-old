using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Utils.Communication;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionMovement : UserControl
    {
        //public event SerialDataReceivedEventHandler DataReceived;
        public optionMovement()
        {
            InitializeComponent();
        }

        public optionMovement( DataSets.dsModuleStructure3 dsModuleStructure) : this()
        {
            this.dsModuleStructure = dsModuleStructure;
            bsStepComposite.DataSource = dsModuleStructure;

        }

        public DataSets.dsModuleStructure3.dtLabwareTypeRow getSelectedRow()
        {
            DataSets.dsModuleStructure3.dtLabwareTypeRow row;
            DataRowView rowView = bsStepComposite.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure3.dtLabwareTypeRow;
            return row;
        }
        public void sendGCode(string text)
        {
           
            Console.Out.WriteLine(text);
            CustomSerial movementSerial = ComChannelFactory.getGCodeSerial();
            movementSerial.configure("COM3", "115200", "8", "One", "None");
            movementSerial.Open();
            //movementSerial.WriteLine(text);
            movementSerial.Write("M105\n");
            //movementSerial.WriteLine("T1\n");
            
            System.Threading.Thread.Sleep(1000);
            movementSerial.Write("G91\n"); 
            movementSerial.Write("G1 X-300 F6000\n");
            System.Threading.Thread.Sleep(1000);
            movementSerial.ReadExisting();
            //movementSerial.ReadLine();
            movementSerial.Close();
            
        }
        /*
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
        }
        */
        private void btnSend_Click(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure3.dtLabwareTypeRow row;
            row = getSelectedRow();
            //sendGCode();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sendGCode("G28");
                
        }

        private void dtStepLeafDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

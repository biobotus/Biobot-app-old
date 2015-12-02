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
using BioBotApp.DataSets;
using BioBotApp.Utils.FSM;
using System.Threading;
using BioBotApp.Utils.Communication.pcan;
using BioBotApp.Utils.Communication.pcan.SingleChannelPipette;
using BioBotApp.Utils.Communication.pcan.MultiChannelPipette;
using BioBotApp.Utils.Communication.pcan.Dynamixel;

namespace BioBotApp.Controls.Option.Options
{
    //public class RoundButton : Button
    //{
    //    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    //    {
    //        GraphicsPath grPath = new GraphicsPath();
    //        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
    //        this.Region = new System.Drawing.Region(grPath);
    //        base.OnPaint(e);
    //    }
    //}

    //private void InitializeComponent()
    //{
    //    this.SuspendLayout();
    //    this.ResumeLayout(false);

    //}
    ////}
    public partial class optionJoypad : UserControl
    {
        fsmMovement fsmMove = new fsmMovement(); 
        
        private enum SerialCommandType { MoveTo, Home };  
        private enum Axis { X, Y };     

        AutoResetEvent wait = new AutoResetEvent(false);
        public optionJoypad()
        {
            InitializeComponent();
            //ComChannelFactory.getGCodeSerial().DataReceived += OptionJoypad_DataReceived;
            PCANCom.Instance.OnMessageReceived += Instance_OnMessageReceived;
        }

        private void Instance_OnMessageReceived(object sender, PCANComEventArgs e)
        {
            wait.Set();            
        }

        public optionJoypad(dsModuleStructure3 dsModuleStructure,BindingSource bsModule) : this()
        {
            this.dsModuleStructure1 = dsModuleStructure;
            this.bs1 = bsModule;
            bs1.DataSource = dsModuleStructure;

            if (labelX.Text== "X :   ")
            {
                taModule1.Fill(this.dsModuleStructure1.dtModule);
            }
        }

        public void updateRow(DataSets.dsModuleStructure3.dtModuleRow updateRow)
        {
            try
            {
                taModule1.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action type, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsModuleStructure1.RejectChanges();
            }
        }
        public optionJoypad(string tag, string lblTestTxt)
        {
            InitializeComponent();
            this.Tag = tag;
            this.lblTestTxt = lblTestTxt;
        }

        double xcoor=0;
        double ycoor=0;
        double z1coor=0;
        double z2coor=0;
        double z3coor=0;
        Double varCoor = 0;
        string GCode;
        private dsModuleStructure3 dsModuleStructure;
        private string v;
        private string lblTestTxt;

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void optionJoypad_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ycoor += 1;
            writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
            //move("Y", ycoor);
            updatePositions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ycoor += 10;
            writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
            //move("Y", ycoor);
            updatePositions();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            xcoor += 1;
            //move("X", xcoor);
            writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
            updatePositions();
        }      

        private void button9_Click(object sender, EventArgs e)
        {
            xcoor += 10;
            //move("X", xcoor);
            writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
            updatePositions();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                xcoor += value;
                //move("X", xcoor);
                writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
                updatePositions();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            xcoor -= 1;
            writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
            //move("X", xcoor);
            updatePositions();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            xcoor -= 10;
            //move("X", xcoor);
            writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
            updatePositions();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ycoor -= 1;
            writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
            //move("Y", ycoor);
            updatePositions();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                ycoor += value;
                writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
                //move("Y", ycoor);
                updatePositions();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                xcoor -= value;
                writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
                //move("X", xcoor);
                updatePositions();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ycoor -= 10;
            writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
            //move("Y", ycoor);
            updatePositions();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                ycoor -= value;
                writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
                //move("Y", ycoor);
                updatePositions();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                z3coor += value;
                DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
                wait.Reset();
                wait.WaitOne();
                updatePositions();
                //move("Z3", z3coor);
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {                
            z3coor += 10;
            DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
            /*
            z3coor += 10;
            move("Z3", z3coor);*/
        }

        private void button46_Click(object sender, EventArgs e)
        {
            z3coor += 1;
            DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                z2coor += value;
                MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
                wait.Reset();
                wait.WaitOne();
                updatePositions();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            z2coor += 10;
            MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            z2coor += 1;
            MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                z1coor += value;
                SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);                
                wait.Reset();
                wait.WaitOne();
                updatePositions();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            z1coor += 10;
            SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            z1coor += 1;
            SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button41_Click(object sender, EventArgs e)
        {            
            z3coor -= 1;
            DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            z3coor -= 10;
            DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                z3coor -= value;
                DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
                wait.Reset();
                wait.WaitOne();
                updatePositions();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            z2coor -= 1;
            MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            z2coor -= 10;
            MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);                
                z2coor -= value;
                MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
                wait.Reset();
                wait.WaitOne();
                updatePositions();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            z1coor -= 1;
            SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            z1coor -= 10;
            SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);
            wait.Reset();
            wait.WaitOne();
            updatePositions();
        }

        private void button34_Click(object sender, EventArgs e)
        {            
            if (tbIncrement.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(tbIncrement.Text);
                z1coor -= value;
                SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);
                wait.Reset();
                wait.WaitOne();
                updatePositions();
            }
        }

        private void ycoord_Click(object sender, EventArgs e)
        {

        }

        private void z1coord_Click(object sender, EventArgs e)
        {

        }

        private void z2coord_Click(object sender, EventArgs e)
        {

        }
        private Double getNumber(string coord)
        {
            String myInt = coord.Remove(0, 4);
            Double N = Int32.Parse(myInt);
            return N;
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

        private void move(String axe, double position)
        {
            //ComChannelFactory.getGCodeSerial().WriteLine(axe + position);
        }

        public void setupGCode(double x, double y, double z1, double z2, double z3)
        {
            GCode = "X" + x + "Y" + y + "Z1" + z1 + "Z2" + z2 + "Z3" + z3;
            sendGCode(GCode);
        }

        private void xcoord_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                varCoor = double.Parse(edtMoveValue.Text);
                edtMoveValue.Select(0, 0);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OptionJoypad_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String comPortDataReceived = ComChannelFactory.getGCodeSerial().ReadExisting();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            updatePositions();
        }
        public void updatePositions()
        {
            labelX.Text = "X :   " + xcoor;
            labelY.Text = "Y :   " + ycoor;
            labelZ1.Text = "Z1 :   " + z1coor;
            labelZ2.Text = "Z2 :   " + z2coor;
            labelZ3.Text = "Z3 :   " + z3coor;
        }

        private void btnHomeZ3_Click(object sender, EventArgs e)
        {
            z3coor = 0;
            DynamixelCom.homeTool();
            wait.Reset();
            wait.WaitOne();
            updatePositions();
            /*
            ComChannelFactory.getGCodeSerial().WriteLine("HZ3");
            z3coor = 0;
            updatePositions();*/
        }

        private void btnHomeZ2_Click(object sender, EventArgs e)
        {
            z2coor = 0;
            MultiChannelPipette.homeTool();
            wait.Reset();
            wait.WaitOne();
            updatePositions();
            /*
            ComChannelFactory.getGCodeSerial().WriteLine("HZ2");
            z2coor = 0;
            updatePositions();*/
        }

        private void btnHomeZ1_Click(object sender, EventArgs e)
        {
            z1coor = 0;
            SingleChannelPipette.homeTool();
            wait.Reset();
            wait.WaitOne();
            updatePositions();
            /*
            ComChannelFactory.getGCodeSerial().WriteLine("HZ1");
            z1coor = 0;
            updatePositions();*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ComChannelFactory.getGCodeSerial().WriteLine("HY");
            writeSerial(SerialCommandType.Home, Axis.Y, 0);
            ycoor = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ComChannelFactory.getGCodeSerial().WriteLine("HX");
            writeSerial(SerialCommandType.Home, Axis.X, 0);
            xcoor = 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (edtMoveValue.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(edtMoveValue.Text);
                xcoor = value;
                writeSerial(SerialCommandType.MoveTo, Axis.X, (int)xcoor);
                //move("X", xcoor);
                updatePositions();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (edtMoveValue.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(edtMoveValue.Text);
                ycoor = value;
                writeSerial(SerialCommandType.MoveTo, Axis.Y, (int)ycoor);
                //move("Y", ycoor);
                updatePositions();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (edtMoveValue.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(edtMoveValue.Text);
                z1coor = value;
                SingleChannelPipette.sendPositionToMoveTo((Int16)z1coor);
                updatePositions();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (edtMoveValue.Text.Length != 0)
            {
                Int16 value = Convert.ToInt16(edtMoveValue.Text);
                z2coor = value;
                MultiChannelPipette.sendPositionToMoveTo((Int16)z2coor);
                updatePositions();
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (edtMoveValue.Text.Length != 0)
            {                
                Int16 value = Convert.ToInt16(edtMoveValue.Text);
                z3coor = value;
                DynamixelCom.sendPositionToMoveTo((Int16)z3coor);
                updatePositions();
            }
        }

        private void writeSerial(SerialCommandType command, Axis axis, Int32 positionToMoveTo)
        {
            if (command == SerialCommandType.Home)
            {
                if (axis == Axis.X)
                {
                    fsmMove.write("G28 X");
                }
                else if (axis == Axis.Y)
                {
                    fsmMove.write("G28 Y");
                }

            }
            else if (command == SerialCommandType.MoveTo)
            {
                if (axis == Axis.X)
                {
                    String value = "G1 X" + positionToMoveTo / 10 + "\n";
                    fsmMove.write(value);
                }
                else if (axis == Axis.Y)
                {
                    String value = "G1 Y" + positionToMoveTo / 10 + "\n";
                    fsmMove.write(value);
                }
            }           
        }

        private void homeAll()
        {
            SingleChannelPipette.homeTool();
            MultiChannelPipette.homeTool();
            DynamixelCom.homeTool();
            writeSerial(SerialCommandType.Home, Axis.X, 0);
            writeSerial(SerialCommandType.Home, Axis.Y, 0);
        }
    }
}

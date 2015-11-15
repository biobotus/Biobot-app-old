using BioBotApp.Utils.Communication;
using System;
using System.Collections.Generic;
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

        CustomSerial serial =  ComChannelFactory.getGCodeSerial();
        AutoResetEvent acknowledgeEvent = new AutoResetEvent(false);

        public fsmMovement()
        {
        }

        public void move(DataSets.dsModuleStructure3.dtActionValueRow actionValue)
        {
            if(actionValue.fk_action_type == MOVE_X)
            {
                serial.Write("X" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == MOVE_Y)
            {
                String value = "Y" + Int32.Parse(actionValue.description) + '\n';
                serial.Write(value);
            }
            else if (actionValue.fk_action_type == MOVE_Z1)
            {
                serial.Write("Z1" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == MOVE_Z2)
            {
                serial.Write("Z2" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == MOVE_Z3)
            {
                serial.Write("Z3" + Int32.Parse(actionValue.description) + '\n');
            }
            else if (actionValue.fk_action_type == HOME)
            {
                serial.Write("H" + actionValue.description + '\n');
            }

            String test = serial.ReadLine();
            while (!test.Contains("Ok"))
            {
                //do nothing
                System.Threading.Thread.Sleep(10);
                try
                {
                    test = serial.ReadLine();
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.StackTrace);
                }
                
            }
        }
    }
}

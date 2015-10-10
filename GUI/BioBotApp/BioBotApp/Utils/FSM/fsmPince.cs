using BioBotApp.Utils.Communication.pcan.Dynamixel;
using BioBotApp.Utils.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.FSM
{
    public class fsmPince
    {

        private const byte INST_CLOSE_GRIPPER = 1;
        private const byte INST_OPEN_GRIPPER = 2;
        private const byte INST_SET_MOVING_SPEED = 3;
        private const byte INST_SET_TORQUE = 4;
        private const byte INST_SET_TORQUE_ENABLE = 5;
        private const byte INST_TILT = 6;
        private const byte INST_ROTATE = 7;


        public fsmPince()
        {

        }

        public void executeAction(DataSets.dsModuleStructure3.dtActionValueRow row)
        {
            if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.OPEN)
            {
                DynamixelCom.sendInstruction(INST_OPEN_GRIPPER);
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.CLOSE)
            {
                DynamixelCom.sendInstruction(INST_CLOSE_GRIPPER);
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.TILT)
            {
                DynamixelCom.sendInstruction(INST_TILT, UInt16.Parse(row.description));
            }
            else if(row.dtActionTypeRow.pk_id == DBManager.ActionTypes.ROTATE)
            {
                DynamixelCom.sendInstruction(INST_ROTATE, UInt16.Parse(row.description));
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.SPEED)
            {
                String[] values = row.description.Split(',');
                byte id = byte.Parse(values[0]);
                UInt16 speed = UInt16.Parse(values[1]);

                DynamixelCom.sendInstruction(INST_SET_MOVING_SPEED, id, speed);
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.TORQUE)
            {
                String[] values = row.description.Split(',');
                byte id = byte.Parse(values[0]);
                UInt16 torque = UInt16.Parse(values[1]);

                DynamixelCom.sendInstruction(INST_SET_MOVING_SPEED, id, torque);
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.TORQUE_ENABLE)
            {
                DynamixelCom.sendInstruction(INST_SET_TORQUE_ENABLE, UInt16.Parse(row.description));
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.DELAY_MS)
            {
                System.Threading.Thread.Sleep(Int32.Parse(row.description));
            }
        }

    }
}

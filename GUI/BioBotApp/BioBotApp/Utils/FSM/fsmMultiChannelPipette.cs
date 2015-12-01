using BioBotApp.Utils.Communication.pcan;
using BioBotApp.Utils.Communication.pcan.MultiChannelPipette;
using System;
using System.Threading;

namespace BioBotApp.Utils.FSM
{
    class fsmMultiChannelPipette
    {
        private const int PIPETTE = 24;
        private const int DISPENSE = 25;
        private const int MOVE_Z2 = 17;
        private const int HOME = 19;

        AutoResetEvent wait = new AutoResetEvent(false);
        public fsmMultiChannelPipette()
        {
            PCANCom.Instance.OnMessageReceived += Instance_OnMessageReceived;
        }

        private void Instance_OnMessageReceived(object sender, PCANComEventArgs e)
        {
            wait.Set();
        }

        public void executeAction(DataSets.dsModuleStructure3.dtActionValueRow row)
        {
            if (row.dtActionTypeRow.pk_id == PIPETTE)
            {
                MultiChannelPipette.sendInstruction(0x01, row.description);
                wait.Reset();
                wait.WaitOne();
                Int16 delay = Convert.ToInt16(row.description);
                System.Threading.Thread.Sleep(delay / 2);
            }
            else if (row.dtActionTypeRow.pk_id == DISPENSE)
            {
                MultiChannelPipette.sendInstruction(0x00, row.description);
                wait.Reset();
                wait.WaitOne();
                Int16 delay = Convert.ToInt16(row.description);
                System.Threading.Thread.Sleep(delay / 2);
            }
            else if (row.dtActionTypeRow.pk_id == MOVE_Z2)
            {
                Int16 tempValue = 0;
                if (Int16.TryParse(row.description, out tempValue))
                {
                    MultiChannelPipette.sendPositionToMoveTo(tempValue);
                    wait.Reset();
                    wait.WaitOne();
                }
            }
            else if (row.dtActionTypeRow.pk_id == HOME)
            {
                MultiChannelPipette.homeTool();
                wait.Reset();
                wait.WaitOne();
            }            
        }
    }
}

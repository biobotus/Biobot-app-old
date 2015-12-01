using BioBotApp.Utils.Communication.pcan;
using BioBotApp.Utils.Communication.pcan.SingleChannelPipette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BioBotApp.Utils.FSM
{
    class fsmSingleChannelPipette
    {
        private const int PIPETTE = 24;
        private const int DISPENSE = 25;
        private const int MOVE_Z1 = 16;
        private const int HOME = 19;

        AutoResetEvent wait = new AutoResetEvent(false);

        public fsmSingleChannelPipette()
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
                SingleChannelPipette.pipette(Convert.ToInt16(row.description));
                wait.Reset();
                wait.WaitOne();
                Int16 delay = Convert.ToInt16(row.description);
                System.Threading.Thread.Sleep(delay / 2);
            }
            else if (row.dtActionTypeRow.pk_id == DISPENSE)
            {
                SingleChannelPipette.dispense(Convert.ToInt16(row.description));
                wait.Reset();
                wait.WaitOne();
                Int16 delay = Convert.ToInt16(row.description);
                System.Threading.Thread.Sleep(delay / 2);
            }
            else if (row.dtActionTypeRow.pk_id == MOVE_Z1)
            {
                Int16 tempValue = 0;
                if (Int16.TryParse(row.description, out tempValue))
                {
                    SingleChannelPipette.sendPositionToMoveTo(tempValue);
                    wait.Reset();
                    wait.WaitOne();
                }
            }
            else if (row.dtActionTypeRow.pk_id == HOME)
            {
                SingleChannelPipette.homeTool();
                wait.Reset();
                wait.WaitOne();
            }     
        }
    }
}

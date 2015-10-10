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
            if(row.dtActionTypeRow.pk_id == PIPETTE)
            {
                SingleChannelPipette.sendInstruction(0x01, Convert.ToInt16(row.description));
            }
            else if (row.dtActionTypeRow.pk_id == DISPENSE)
            {
                SingleChannelPipette.sendInstruction(0x00, Convert.ToInt16(row.description));
            }

            wait.Reset();
            wait.WaitOne();
           
        }
    }
}

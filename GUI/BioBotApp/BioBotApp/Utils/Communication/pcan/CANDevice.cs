using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication.pcan
{
    class CANDevice
    {
        public const int HARDWARE_FILTER_GRIPPER = 0x30;
        public const int HARDWARE_FILTER_TAC = 0x70;
        public const int HARDWARE_FILTER_SINGLE_CHANNEL_PIPETTE = 0x71;
        public const int HARDWARE_FILTER_MUTLI_CHANNEL_PIPETTE = 0x72;
    }
}

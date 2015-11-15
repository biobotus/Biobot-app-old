using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.DataBase
{
    public class DBManager
    {
        public class ActionTypes
        {
            public const int OPEN = 11;
            public const int CLOSE = 13;
            public const int DELAY_MS = 7;

            public const int SPEED = 26;
            public const int TILT = 27;
            public const int ROTATE = 28;
            public const int TORQUE = 29;
            public const int TORQUE_ENABLE = 30;
        }
        
    }
}

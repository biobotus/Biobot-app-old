using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    [Serializable]
    class ProtocolNode : System.Windows.Forms.TreeNode, ISerializable
    {
        public ProtocolNode(SerializationInfo info, StreamingContext context) : base(info,context)
        {
        }
        public ProtocolNode(String title)
        {
            this.Text = title;
            this.BackColor = Color.LightGreen;
        }
    }
}

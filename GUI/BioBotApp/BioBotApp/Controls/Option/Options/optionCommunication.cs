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
    public partial class optionCommunication : UserControl
    {
        public optionCommunication()
        {
            CustomSerial gcodeChan = ComChannelFactory.getGCodeSerial();
            InitializeComponent();
            

            if(gcodeChan.IsOpen)
            {
                this.imgSerialMotorStatus.Image = BioBotApp.Properties.Resources.link;
            }
        }

        private void btnConnectMotor_Click(object sender, EventArgs e)
        {
            CustomSerial gcodeChan = ComChannelFactory.getGCodeSerial();
            if(gcodeChan.IsOpen)
            {
                // on devrait jamais venir ici
            }

            gcodeChan.Open();
            
            if (gcodeChan.IsOpen)
            {
                // si c'est pas ouvert on a un probleme
                this.imgSerialMotorStatus.Image = BioBotApp.Properties.Resources.link;
                this.btnConnectMotor.Enabled = false;
            }
            else
            {
                this.imgSerialMotorStatus.Image = BioBotApp.Properties.Resources.link_break;
            }
        }
    }
}

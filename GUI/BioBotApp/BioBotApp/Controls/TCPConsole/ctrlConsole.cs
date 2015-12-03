using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.TCPConsole
{
    public partial class ctrlConsole : UserControl
    {
        public ctrlConsole()
        {
            InitializeComponent();
        }

        #region INSTANCE
        private static ctrlConsole instance;
        public static ctrlConsole Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ctrlConsole();
                }
                return instance;
            }
        }
        #endregion

        private void btnSendCmbToRemote_Click(object sender, EventArgs e)
        {
            if (edtCmdWindow.Text.Length > 0)
            {
                edtCmdWindow.Text += "\r\n";
            }
            edtCmdWindow.Text += edtSendCmd.Text;
            edtCmdWindow.SelectionStart = edtCmdWindow.Text.Length;
            edtCmdWindow.ScrollToCaret();
        }

        public void Log(String logLine)
        {
            if (edtCmdWindow.Text.Length > 0)
            {
                edtCmdWindow.Text += "\r\n";
            }
            edtCmdWindow.Text += logLine;
            edtCmdWindow.SelectionStart = edtCmdWindow.Text.Length;
            edtCmdWindow.Refresh();
            edtCmdWindow.ScrollToCaret();
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            edtCmdWindow.Text += value + "\r\n";
        }

        private void edtCmdWindow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

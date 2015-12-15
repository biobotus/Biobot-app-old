using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Tools_controls
{
    public class ModuleTypeSelectionEventArgs : EventArgs
    {
        public TreeNode SelectedTreeNode { get; set; }

        public ModuleTypeSelectionEventArgs()
        {

        }
    }
}

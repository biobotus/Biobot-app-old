using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    class ProtocolTreeView : System.Windows.Forms.TreeView
    {
        ProtocolTreeView()
        {
        }
        
        public void addStepCompositeNode(DataSets.dsModuleStructure3.dtStepCompositeRow stepCompositeRow)
        {
            SelectedNode.Nodes.Add(new StepCompositeNode(stepCompositeRow));
        }
    }
}

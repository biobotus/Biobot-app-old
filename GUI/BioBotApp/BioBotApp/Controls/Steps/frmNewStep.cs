using BioBotApp.Controls.Steps.Parameter_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Steps
{
    public partial class frmNewStep : Form
    {
        public frmNewStep()
        {
            InitializeComponent();
            this.AcceptButton = moduleParameters.getAcceptButton();
            this.CancelButton = moduleParameters.getCancelButton();
        }

        public frmNewStep(DataSets.dsModuleStructure3 dsModuleStructure, DataSets.dsModuleStructure3.dtModuleRow moduleRow)
            : this()
        {
            moduleParameters.setParameterActions(dsModuleStructure, moduleRow);
        }

        public Dictionary<DataSets.dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand> getActionValues()
        {
            return moduleParameters.getParameterActions();
        }

        public String getStepDescription()
        {
            return moduleParameters.getStepName();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Parameter_control;
using BioBotApp.Controls.Steps.Parameter_controls;
using BioBotApp.DataSets;

namespace BioBotApp.Controls.Parameter_controls
{
    public partial class ctrlModuleParameters : UserControl
    {
        dsModuleStructure3 _dsModuleStructure;
        dsModuleStructure3.dtModuleRow _moduleRow;
        Dictionary<dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand> actionTypeDict;

        public ctrlModuleParameters()
        {
            InitializeComponent();
        }

        public ctrlModuleParameters(dsModuleStructure3.dtModuleRow moduleRow,
            dsModuleStructure3 dsModuleStructure)
            : this()
        {
            _moduleRow = moduleRow;
            _dsModuleStructure = dsModuleStructure;

            setParameterActions(_dsModuleStructure, _moduleRow);
        }

        public void setParameterActions(dsModuleStructure3 dsModuleStructure, dsModuleStructure3.dtModuleRow module)
        {
            actionTypeDict = new Dictionary<dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand>();

            _dsModuleStructure = dsModuleStructure;

            dsModuleStructure3.dtModuleTypeActionTypeRow[] moduleTypeActionTypeRows = module.dtModuleTypeRow.GetdtModuleTypeActionTypeRows();
            foreach (dsModuleStructure3.dtModuleTypeActionTypeRow moduleTypeActionTypeRow in moduleTypeActionTypeRows)
            {
                ctrlCommand command = new ctrlCommand();

                foreach (KeyValuePair<dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand> kvp in actionTypeDict)
                {
                    if (moduleTypeActionTypeRow.fk_action_value_type_id == kvp.Key.fk_action_value_type_id)
                    {
                        command = kvp.Value;
                    }
                }

                if (!command.isInitialized())
                {
                    command.init(moduleTypeActionTypeRow.dtActionValueTypeRow.description);
                    actionTypeDict.Add(moduleTypeActionTypeRow, command);
                }
                command.addCommand(moduleTypeActionTypeRow.dtActionTypeRow);
            }

            foreach (ctrlCommand commands in actionTypeDict.Values)
            {
                commands.Dock = DockStyle.Top;
                layoutMainPanel.Controls.Add(commands);
            }
        }

        public Button getAcceptButton()
        {
            return btnApply;
        }

        public Button getCancelButton()
        {
            return btnCancel;
        }

        public Dictionary<dsModuleStructure3.dtModuleTypeActionTypeRow, ctrlCommand> getParameterActions()
        {
            return this.actionTypeDict;
        }

        public String getStepName()
        {
            return edtStepName.Text;
        }
    }
}

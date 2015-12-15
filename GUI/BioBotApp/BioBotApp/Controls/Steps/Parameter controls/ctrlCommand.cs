using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BioBotApp.DataSets;
using BioBotApp.Controls.Option.Options;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    public partial class ctrlCommand : UserControl
    {
        private Dictionary<dsModuleStructure3.dtActionTypeRow, namedInputTextBox> actionTypeInputBoxDict;
        private namedInputTextBox inputBox;
        private Boolean _isInitialized = false;

        public ctrlCommand()
        {
            InitializeComponent();
            actionTypeInputBoxDict = new Dictionary<dsModuleStructure3.dtActionTypeRow,namedInputTextBox>();
        }

        public void init(String title)
        {
            txtCommandTypeName.Text = title;
            _isInitialized = true;
        }

        public void addCommand(dsModuleStructure3.dtActionTypeRow actionType)
        {
            inputBox = new namedInputTextBox(actionType.description);
            layoutModuleParametersStop.Controls.Add(inputBox);
            actionTypeInputBoxDict.Add(actionType, inputBox);
        }

        public String getValue()
        {
            return inputBox.getInputTextValue();
        }

        public Dictionary<dsModuleStructure3.dtActionTypeRow, namedInputTextBox> getActionTypesValues()
        {
            return this.actionTypeInputBoxDict;
        }

        public Boolean isInitialized()
        {
            return _isInitialized;
        }
    }
}

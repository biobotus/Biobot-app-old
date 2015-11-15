using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Parameter_control
{
    public partial class ParameterActions : UserControl
    {
        private DataSets.dsModuleStructure3.dtActionTypeRow _parameterActionType;
        
        public ParameterActions()
        {
            InitializeComponent();
        }

        public ParameterActions(DataSets.dsModuleStructure3.dtActionTypeRow parameterActionType) : this()
        {
            this._parameterActionType = parameterActionType;
            txtParameterKey.Text = _parameterActionType.description;
        }

        public String getTempratureValue()
        {
            return edtParameterValue.Text;
        }

        public DataSets.dsModuleStructure3.dtActionTypeRow getParameterActionType()
        {
            return _parameterActionType;
        }
    }
}

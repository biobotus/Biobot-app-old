using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    [Serializable()]
    class StepLeafNode : System.Windows.Forms.TreeNode , ISerializable
    {
        private DataSets.dsModuleStructure3.dtStepLeafRow _stepLeaf;
        private DataSets.dsModuleStructure3TableAdapters.taStepLeaf taStepLeaf ;
        private DataSets.dsModuleStructure3.dtStepLeafDataTable stepLeafDataTable;
        private DataSets.dsModuleStructure3TableAdapters.taActionValue taActionValue;
        private DataSets.dsModuleStructure3.dtActionValueDataTable actionValueDataValueTable;

        public StepLeafNode(DataSets.dsModuleStructure3.dtStepLeafRow stepLeaf, DataSets.dsModuleStructure3.dtActionValueDataTable actionValueDataTable)
        {
            if(stepLeaf == null)
            {
                return;
            }

            if(stepLeaf.pk_id < 0)
            {
                //return;
            }

            _stepLeaf = stepLeaf;
            this.Text = stepLeaf.description;
            this.BackColor = Color.LightBlue;
            this.Tag = stepLeaf.pk_id;
            this.actionValueDataValueTable = actionValueDataTable.Clone() as DataSets.dsModuleStructure3.dtActionValueDataTable;
        }

        protected StepLeafNode(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            stepLeafDataTable = new DataSets.dsModuleStructure3.dtStepLeafDataTable();
            taActionValue = new DataSets.dsModuleStructure3TableAdapters.taActionValue();
            actionValueDataValueTable = new DataSets.dsModuleStructure3.dtActionValueDataTable();

            taStepLeaf = new DataSets.dsModuleStructure3TableAdapters.taStepLeaf();
            int id = 0;
            if(Tag is int)
            {
                id = (int)Tag;
            }
            //taStepLeaf.Select(stepLeafDataTable, id);
            if (stepLeafDataTable.Rows.Count != 1)
            {
                System.Windows.Forms.MessageBox.Show("An error occured while loading Steps !");
            }
            _stepLeaf = stepLeafDataTable.FindBypk_id(id);

            //taActionValue.SelectById(actionValueDataValueTable, id);
        }

        public DataSets.dsModuleStructure3.dtStepLeafRow getStepLeaf()
        {
            return _stepLeaf;
        }

        public DataSets.dsModuleStructure3.dtActionValueDataTable getActionValueDataTable()
        {
            return actionValueDataValueTable;
        }
    }
}

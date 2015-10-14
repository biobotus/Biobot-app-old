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
    class StepCompositeNode : System.Windows.Forms.TreeNode, ISerializable
    {
        private DataSets.dsModuleStructure3.dtStepCompositeRow _stepCompositeRow;
        private DataSets.dsModuleStructure3TableAdapters.taStepComposite taStepComposite;
        private DataSets.dsModuleStructure3.dtStepCompositeDataTable stepCompositeDataTable;
        public int id { get; set; }

        public StepCompositeNode(DataSets.dsModuleStructure3.dtStepCompositeRow stepCompositeRow)
        {
            if (stepCompositeRow == null)
            {
                return;
            }

            if (stepCompositeRow.pk_id < 0)
            {
                //return;
            }

            _stepCompositeRow = stepCompositeRow;
            this.Text = stepCompositeRow.description;
            this.BackColor = Color.Yellow;
            this.Tag = stepCompositeRow.pk_id;
        }

        protected StepCompositeNode(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            stepCompositeDataTable = new DataSets.dsModuleStructure3.dtStepCompositeDataTable();

            taStepComposite = new DataSets.dsModuleStructure3TableAdapters.taStepComposite();

            if(Tag is int)
            {
                id = (int) Tag;
            }

            //taStepComposite.Select(stepCompositeDataTable, id);
            if (stepCompositeDataTable.Rows.Count != 1)
            {
                System.Windows.Forms.MessageBox.Show("An error occured while loading protols !");
            }

            _stepCompositeRow = stepCompositeDataTable.FindBypk_id(id);
        }


        public DataSets.dsModuleStructure3.dtStepCompositeRow getStepCompositeRow()
        {
            return _stepCompositeRow;
        }
    }
}

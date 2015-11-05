using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionSavedProtocol : UserControl
    {
        public optionSavedProtocol()
        {
            InitializeComponent();
        }
        public optionSavedProtocol(DataSets.dsModuleStructure3 dsModuleStructure) : this()
        {
            this.dsModuleStructureGUI = dsModuleStructure;

            this.dtSavedProtocolBindingSource.DataSource = dsModuleStructureGUI;
            this.dataGridView1.DataSource = taSavedProtocol1.GetDataByDesc();
            this.dataGridView2.DataSource = taSavedProtocol1.GetData();
            bindingSource1.DataSource = dataGridView2.DataSource;
            this.bindingSource1.Filter = "description = null";
        }
        private void dtSavedProtocolBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (this.dataGridView1.CurrentCell == null)
            {
                this.bindingSource1.Filter = "description = null";
            }
            else
            {
                bindingSource1.Filter = "description  = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                dataGridView2.DataSource = bindingSource1;
            }

        }

    }
}

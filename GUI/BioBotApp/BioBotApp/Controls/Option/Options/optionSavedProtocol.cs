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
            //this.bindingSource1.DataMember = "dtSavedProtocol_dtSavedProtocol";
            //this.bindingSource1.DataSource = dtSavedProtocolBindingSource;

            this.dataGridView1.DataSource = taSavedProtocol1.GetDataByDesc();

            if (this.dataGridView1.CurrentCell == null)
            {
                this.dataGridView2.DataSource = taSavedProtocol1.GetDataByDesc2(null);
            }
            else
            {
                this.dataGridView2.DataSource = taSavedProtocol1.GetDataByDesc2(this.dataGridView1.CurrentCell.Value.ToString());
            }

            //if (this.dsModuleStructureGUI.dtSavedProtocol.Count == 0)
            //{
            //    taSavedProtocol1.Fill(this.dsModuleStructureGUI.dtSavedProtocol);
            //}


        }
        private void dtModuleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell == null)
            {
                this.dataGridView2.DataSource = taSavedProtocol1.GetDataByDesc2(null);
            }
            else
            {
                this.dataGridView2.DataSource = taSavedProtocol1.GetDataByDesc2(this.dataGridView1.CurrentCell.Value.ToString());
            }
        }



    }
}

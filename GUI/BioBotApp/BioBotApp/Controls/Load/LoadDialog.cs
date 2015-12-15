using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Load
{
    public partial class LoadDialog : Form
    {
        public LoadDialog()
        {
            InitializeComponent();
            AcceptButton = LoadBtn;
            CancelButton = CancelBtn;
            this.dataGridView2.DataSource = taSavedProtocol1.GetDataByDesc();
            this.dataGridView1.DataSource = taSavedProtocol1.GetData();
            bindingSource1.DataSource = dataGridView1.DataSource;
            this.bindingSource1.Filter = "description = null";
        }
        private void dtSavedProtocolBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (this.dataGridView2.CurrentCell == null)
            {
                this.bindingSource1.Filter = "description = null";
            }
            else
            {
                bindingSource1.Filter = "description  = '" + dataGridView2.CurrentCell.Value.ToString() + "'";
                dataGridView1.DataSource = bindingSource1;
            }

        }
        private void LoadDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsModuleStructure3.dtSavedProtocol' table. You can move, or remove it, as needed.
            this.taSavedProtocol.Fill(this.dsModuleStructure3.dtSavedProtocol);

        }
       public string getProtocolName()
        {

            return dataGridView2.CurrentCell.Value.ToString();

        }
        public DataGridView getDGV()
        {

            return dataGridView1;

        }
    }
}

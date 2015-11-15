using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Tools_controls
{
    public partial class ctrlTools : UserControl
    {
        /// <summary>
        /// Occurs after a tool has been selected
        /// </summary>
        public event EventHandler<ModuleTypeSelectionEventArgs> ToolSelectionChanged;

        //Currently selected node
        TreeNode selectedNode;

        public ctrlTools()
        {
            InitializeComponent();
        }

        public void initControl(DataSets.dsModuleStructure3 dsModuleStructure, BindingSource bsModule)
        {
            this.dsModuleStructure = dsModuleStructure;
            this.bsModule = bsModule;
            bsModule.DataSource = this.dsModuleStructure;
            bsModuleType.DataSource = this.dsModuleStructure;

            this.dataGridView1.DataSource = this.bsModule;

            this.bsModule.DataMember = "dtModule";
            this.bsModule.DataSource = this.dsModuleStructure;

            initData();
            //_dsModuleStructure.dtModule.dtModuleRowChanged += dtModule_dtModuleRowChanged;
        }



        public void initData()
        {
            //taModuleType.Fill(_dsModuleStructure.dtModuleType);
        }

        private void tlvTools_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                selectedNode.BackColor = Color.Transparent;
                selectedNode.ForeColor = Color.Black;
                e.SuppressKeyPress = true;
                selectedNode = null;
            }
        }

        private void dataGridView1_DragLeave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.DoDragDrop(dataGridView1.Name, DragDropEffects.Move);
        }
    }
}

//Rows[e.RowIndex]
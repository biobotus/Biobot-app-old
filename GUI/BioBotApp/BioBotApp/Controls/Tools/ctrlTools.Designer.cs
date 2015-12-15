namespace BioBotApp.Controls.Tools_controls
{
    partial class ctrlTools
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.taModuleType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModuleType();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkmoduletypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsModuleType = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure3();
            this.bsModule = new System.Windows.Forms.BindingSource(this.components);
            this.taModule = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModule();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 32);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tools";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 371);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(313, 45);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // taModuleType
            // 
            this.taModuleType.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn,
            this.fkmoduletypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsModule;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(313, 334);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.DragLeave += new System.EventHandler(this.dataGridView1_DragLeave);
            // 
            // pkidDataGridViewTextBoxColumn
            // 
            this.pkidDataGridViewTextBoxColumn.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn.HeaderText = "Module";
            this.pkidDataGridViewTextBoxColumn.Name = "pkidDataGridViewTextBoxColumn";
            this.pkidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkmoduletypeDataGridViewTextBoxColumn
            // 
            this.fkmoduletypeDataGridViewTextBoxColumn.DataPropertyName = "fk_module_type";
            this.fkmoduletypeDataGridViewTextBoxColumn.DataSource = this.bsModuleType;
            this.fkmoduletypeDataGridViewTextBoxColumn.DisplayMember = "description";
            this.fkmoduletypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fkmoduletypeDataGridViewTextBoxColumn.HeaderText = "Module type";
            this.fkmoduletypeDataGridViewTextBoxColumn.Name = "fkmoduletypeDataGridViewTextBoxColumn";
            this.fkmoduletypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkmoduletypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkmoduletypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkmoduletypeDataGridViewTextBoxColumn.ValueMember = "pk_id";
            // 
            // bsModuleType
            // 
            this.bsModuleType.DataMember = "dtModuleType";
            this.bsModuleType.DataSource = this.dsModuleStructure;
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure3";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsModule
            // 
            this.bsModule.DataMember = "dtModule";
            this.bsModule.DataSource = this.dsModuleStructure;
            // 
            // taModule
            // 
            this.taModule.ClearBeforeFill = true;
            // 
            // ctrlTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlTools";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Size = new System.Drawing.Size(321, 421);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private DataSets.dsModuleStructure3TableAdapters.taModuleType taModuleType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsModule;
        private DataSets.dsModuleStructure3 dsModuleStructure;
        private DataSets.dsModuleStructure3TableAdapters.taModule taModule;
        private System.Windows.Forms.BindingSource bsModuleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkmoduletypeDataGridViewTextBoxColumn;



    }
}

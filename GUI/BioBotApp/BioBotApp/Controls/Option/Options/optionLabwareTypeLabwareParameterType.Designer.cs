namespace BioBotApp.Controls.Option.Options
{
    partial class optionLabwareTypeLabwareParameterType
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
            this.dsModuleStructureGUI = new BioBotApp.DataSets.dsModuleStructure3();
            this.bsLabwareType = new System.Windows.Forms.BindingSource(this.components);
            this.dtLabwareTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fklabwaretypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fklabwareparametertypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsLabwareParameterType = new System.Windows.Forms.BindingSource(this.components);
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLabwareTypedtLabwareTypeLabwareParameterType = new System.Windows.Forms.BindingSource(this.components);
            this.crudOptions = new BioBotApp.Controls.Utils.crudOptions();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.taLabwareTypeLabwareParameterType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taLabwareTypeLabwareParameterType();
            this.dsModuleStructureGUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taLabwareParameterType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taLabwareParameterType();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabwareType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLabwareTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabwareParameterType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabwareTypedtLabwareTypeLabwareParameterType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsModuleStructureGUI
            // 
            this.dsModuleStructureGUI.DataSetName = "dsModuleStructure3";
            this.dsModuleStructureGUI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsLabwareType
            // 
            this.bsLabwareType.DataMember = "dtLabwareType";
            this.bsLabwareType.DataSource = this.dsModuleStructureGUI;
            this.bsLabwareType.CurrentChanged += new System.EventHandler(this.bsLabwareType_CurrentChanged);
            // 
            // dtLabwareTypeDataGridView
            // 
            this.dtLabwareTypeDataGridView.AllowUserToAddRows = false;
            this.dtLabwareTypeDataGridView.AllowUserToDeleteRows = false;
            this.dtLabwareTypeDataGridView.AllowUserToOrderColumns = true;
            this.dtLabwareTypeDataGridView.AllowUserToResizeColumns = false;
            this.dtLabwareTypeDataGridView.AllowUserToResizeRows = false;
            this.dtLabwareTypeDataGridView.AutoGenerateColumns = false;
            this.dtLabwareTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLabwareTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLabwareTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dtLabwareTypeDataGridView.DataSource = this.bsLabwareType;
            this.dtLabwareTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtLabwareTypeDataGridView.Location = new System.Drawing.Point(2, 15);
            this.dtLabwareTypeDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dtLabwareTypeDataGridView.Name = "dtLabwareTypeDataGridView";
            this.dtLabwareTypeDataGridView.RowHeadersVisible = false;
            this.dtLabwareTypeDataGridView.RowTemplate.Height = 24;
            this.dtLabwareTypeDataGridView.Size = new System.Drawing.Size(305, 288);
            this.dtLabwareTypeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pk_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "pk_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fklabwaretypeidDataGridViewTextBoxColumn,
            this.fklabwareparametertypeidDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsLabwareTypedtLabwareTypeLabwareParameterType;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(261, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // fklabwaretypeidDataGridViewTextBoxColumn
            // 
            this.fklabwaretypeidDataGridViewTextBoxColumn.DataPropertyName = "fk_labware_type_id";
            this.fklabwaretypeidDataGridViewTextBoxColumn.HeaderText = "fk_labware_type_id";
            this.fklabwaretypeidDataGridViewTextBoxColumn.Name = "fklabwaretypeidDataGridViewTextBoxColumn";
            this.fklabwaretypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // fklabwareparametertypeidDataGridViewTextBoxColumn
            // 
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.DataPropertyName = "fk_labware_parameter_type_id";
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.DataSource = this.bsLabwareParameterType;
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.DisplayMember = "description";
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.HeaderText = "Parameter type";
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.Name = "fklabwareparametertypeidDataGridViewTextBoxColumn";
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fklabwareparametertypeidDataGridViewTextBoxColumn.ValueMember = "pk_id";
            // 
            // bsLabwareParameterType
            // 
            this.bsLabwareParameterType.DataMember = "dtLabwareParameterType";
            this.bsLabwareParameterType.DataSource = this.dsModuleStructureGUI;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // bsLabwareTypedtLabwareTypeLabwareParameterType
            // 
            this.bsLabwareTypedtLabwareTypeLabwareParameterType.DataMember = "dtLabwareType_dtLabwareTypeLabwareParameterType";
            this.bsLabwareTypedtLabwareTypeLabwareParameterType.DataSource = this.bsLabwareType;
            // 
            // crudOptions
            // 
            this.crudOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudOptions.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions.Location = new System.Drawing.Point(3, 18);
            this.crudOptions.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptions.Name = "crudOptions";
            this.crudOptions.Size = new System.Drawing.Size(347, 37);
            this.crudOptions.TabIndex = 3;
            this.crudOptions.AddClickHandler += new System.EventHandler(this.crudOptions_AddClickHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.crudOptions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(309, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(265, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtLabwareTypeDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(309, 305);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Labware type";
            // 
            // taLabwareTypeLabwareParameterType
            // 
            this.taLabwareTypeLabwareParameterType.ClearBeforeFill = true;
            // 
            // dsModuleStructureGUIBindingSource
            // 
            this.dsModuleStructureGUIBindingSource.DataSource = this.dsModuleStructureGUI;
            this.dsModuleStructureGUIBindingSource.Position = 0;
            // 
            // taLabwareParameterType
            // 
            this.taLabwareParameterType.ClearBeforeFill = true;
            // 
            // optionLabwareTypeLabwareParameterType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "optionLabwareTypeLabwareParameterType";
            this.Size = new System.Drawing.Size(574, 305);
            this.Tag = "Labware type labware parameters";
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabwareType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLabwareTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabwareParameterType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabwareTypedtLabwareTypeLabwareParameterType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.dsModuleStructure3 dsModuleStructureGUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bsLabwareType;
        private System.Windows.Forms.DataGridView dtLabwareTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsLabwareParameterType;
        private Utils.crudOptions crudOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bsLabwareTypedtLabwareTypeLabwareParameterType;
        private DataSets.dsModuleStructure3TableAdapters.taLabwareTypeLabwareParameterType taLabwareTypeLabwareParameterType;
        private System.Windows.Forms.BindingSource dsModuleStructureGUIBindingSource;
        private DataSets.dsModuleStructure3TableAdapters.taLabwareParameterType taLabwareParameterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn fklabwaretypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fklabwareparametertypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}

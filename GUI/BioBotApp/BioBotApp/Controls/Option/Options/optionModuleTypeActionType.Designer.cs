namespace BioBotApp.Controls.Option.Options
{
    partial class optionModuleTypeActionType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtModuleTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.bsModuleType = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructureGUI = new BioBotApp.DataSets.dsModuleStructure3();
            this.crudOptions2 = new BioBotApp.Controls.Utils.crudOptions();
            this.bsActionType = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvActionType = new System.Windows.Forms.DataGridView();
            this.fkmoduletypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkactiontypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fk_action_value_type_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsActionValueType = new System.Windows.Forms.BindingSource(this.components);
            this.bsModuleTypeActionType = new System.Windows.Forms.BindingSource(this.components);
            this.crudOptionsActionType = new BioBotApp.Controls.Utils.crudOptions();
            this.taActionType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionType();
            this.taModuleType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModuleType();
            this.taModuleTypeActionType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModuleTypeActionType();
            this.taActionValueType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValueType();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtModuleTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionType)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionValueType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleTypeActionType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtModuleTypeDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 566);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modules";
            // 
            // dtModuleTypeDataGridView
            // 
            this.dtModuleTypeDataGridView.AllowUserToAddRows = false;
            this.dtModuleTypeDataGridView.AllowUserToDeleteRows = false;
            this.dtModuleTypeDataGridView.AutoGenerateColumns = false;
            this.dtModuleTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtModuleTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtModuleTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtModuleTypeDataGridView.DataSource = this.bsModuleType;
            this.dtModuleTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtModuleTypeDataGridView.Location = new System.Drawing.Point(3, 18);
            this.dtModuleTypeDataGridView.Name = "dtModuleTypeDataGridView";
            this.dtModuleTypeDataGridView.ReadOnly = true;
            this.dtModuleTypeDataGridView.RowHeadersVisible = false;
            this.dtModuleTypeDataGridView.RowTemplate.Height = 24;
            this.dtModuleTypeDataGridView.Size = new System.Drawing.Size(232, 545);
            this.dtModuleTypeDataGridView.TabIndex = 2;
            // 
            // bsModuleType
            // 
            this.bsModuleType.DataMember = "dtModuleType";
            this.bsModuleType.DataSource = this.dsModuleStructureGUI;
            // 
            // dsModuleStructureGUI
            // 
            this.dsModuleStructureGUI.DataSetName = "dsModuleStructure3";
            this.dsModuleStructureGUI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crudOptions2
            // 
            this.crudOptions2.ButtonAddVisible = false;
            this.crudOptions2.ButtonDeleteVisible = false;
            this.crudOptions2.ButtonModifyVisible = false;
            this.crudOptions2.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudOptions2.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions2.Location = new System.Drawing.Point(3, 18);
            this.crudOptions2.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptions2.Name = "crudOptions2";
            this.crudOptions2.Size = new System.Drawing.Size(232, 37);
            this.crudOptions2.TabIndex = 2;
            // 
            // bsActionType
            // 
            this.bsActionType.DataMember = "dtActionType";
            this.bsActionType.DataSource = this.dsModuleStructureGUI;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvActionType);
            this.groupBox2.Controls.Add(this.crudOptionsActionType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(238, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 566);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action types";
            // 
            // gvActionType
            // 
            this.gvActionType.AllowUserToAddRows = false;
            this.gvActionType.AllowUserToDeleteRows = false;
            this.gvActionType.AllowUserToOrderColumns = true;
            this.gvActionType.AutoGenerateColumns = false;
            this.gvActionType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvActionType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActionType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fkmoduletypeidDataGridViewTextBoxColumn,
            this.fkactiontypeidDataGridViewTextBoxColumn,
            this.fk_action_value_type_id});
            this.gvActionType.DataSource = this.bsModuleTypeActionType;
            this.gvActionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvActionType.Location = new System.Drawing.Point(3, 55);
            this.gvActionType.Name = "gvActionType";
            this.gvActionType.ReadOnly = true;
            this.gvActionType.RowHeadersVisible = false;
            this.gvActionType.RowTemplate.Height = 24;
            this.gvActionType.Size = new System.Drawing.Size(280, 508);
            this.gvActionType.TabIndex = 1;
            // 
            // fkmoduletypeidDataGridViewTextBoxColumn
            // 
            this.fkmoduletypeidDataGridViewTextBoxColumn.DataPropertyName = "fk_module_type_id";
            this.fkmoduletypeidDataGridViewTextBoxColumn.HeaderText = "fk_module_type_id";
            this.fkmoduletypeidDataGridViewTextBoxColumn.Name = "fkmoduletypeidDataGridViewTextBoxColumn";
            this.fkmoduletypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkmoduletypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // fkactiontypeidDataGridViewTextBoxColumn
            // 
            this.fkactiontypeidDataGridViewTextBoxColumn.DataPropertyName = "fk_action_type_id";
            this.fkactiontypeidDataGridViewTextBoxColumn.DataSource = this.bsActionType;
            this.fkactiontypeidDataGridViewTextBoxColumn.DisplayMember = "description";
            this.fkactiontypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fkactiontypeidDataGridViewTextBoxColumn.HeaderText = "Action type";
            this.fkactiontypeidDataGridViewTextBoxColumn.Name = "fkactiontypeidDataGridViewTextBoxColumn";
            this.fkactiontypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkactiontypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkactiontypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkactiontypeidDataGridViewTextBoxColumn.ValueMember = "pk_id";
            // 
            // fk_action_value_type_id
            // 
            this.fk_action_value_type_id.DataPropertyName = "fk_action_value_type_id";
            this.fk_action_value_type_id.DataSource = this.bsActionValueType;
            this.fk_action_value_type_id.DisplayMember = "description";
            this.fk_action_value_type_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fk_action_value_type_id.HeaderText = "Action value type";
            this.fk_action_value_type_id.Name = "fk_action_value_type_id";
            this.fk_action_value_type_id.ReadOnly = true;
            this.fk_action_value_type_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fk_action_value_type_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fk_action_value_type_id.ValueMember = "pk_id";
            // 
            // bsActionValueType
            // 
            this.bsActionValueType.DataMember = "dtActionValueType";
            this.bsActionValueType.DataSource = this.dsModuleStructureGUI;
            // 
            // bsModuleTypeActionType
            // 
            this.bsModuleTypeActionType.DataMember = "dtModuleTypeActionType";
            this.bsModuleTypeActionType.DataSource = this.dsModuleStructureGUI;
            // 
            // crudOptionsActionType
            // 
            this.crudOptionsActionType.ButtonModifyVisible = false;
            this.crudOptionsActionType.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudOptionsActionType.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptionsActionType.Location = new System.Drawing.Point(3, 18);
            this.crudOptionsActionType.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptionsActionType.Name = "crudOptionsActionType";
            this.crudOptionsActionType.Size = new System.Drawing.Size(280, 37);
            this.crudOptionsActionType.TabIndex = 1;
            this.crudOptionsActionType.AddClickHandler += new System.EventHandler(this.crudOptionsActionType_AddClickHandler);
            this.crudOptionsActionType.DeleteClickHandler += new System.EventHandler(this.crudOptionsActionType_DeleteClickHandler);
            // 
            // taActionType
            // 
            this.taActionType.ClearBeforeFill = true;
            // 
            // taModuleType
            // 
            this.taModuleType.ClearBeforeFill = true;
            // 
            // taModuleTypeActionType
            // 
            this.taModuleTypeActionType.ClearBeforeFill = true;
            // 
            // taActionValueType
            // 
            this.taActionValueType.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pk_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "pk_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // optionModuleTypeActionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "optionModuleTypeActionType";
            this.Size = new System.Drawing.Size(524, 566);
            this.Tag = "Module type action type";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtModuleTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvActionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionValueType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleTypeActionType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.dsModuleStructure3 dsModuleStructureGUI;
        private System.Windows.Forms.GroupBox groupBox1;
        private Utils.crudOptions crudOptions2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Utils.crudOptions crudOptionsActionType;
        private System.Windows.Forms.BindingSource bsActionType;
        private DataSets.dsModuleStructure3TableAdapters.taActionType taActionType;
        private System.Windows.Forms.DataGridView dtModuleTypeDataGridView;
        private System.Windows.Forms.BindingSource bsModuleType;
        private System.Windows.Forms.DataGridView gvActionType;
        private DataSets.dsModuleStructure3TableAdapters.taModuleType taModuleType;
        private System.Windows.Forms.BindingSource bsModuleTypeActionType;
        private DataSets.dsModuleStructure3TableAdapters.taModuleTypeActionType taModuleTypeActionType;
        private DataSets.dsModuleStructure3TableAdapters.taActionValueType taActionValueType;
        private System.Windows.Forms.BindingSource bsActionValueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkmoduletypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkactiontypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fk_action_value_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

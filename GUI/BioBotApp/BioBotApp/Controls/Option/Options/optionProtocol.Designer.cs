namespace BioBotApp.Controls.Option.Options
{
    partial class optionProtocol
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
            this.crudOptionsProtocol = new BioBotApp.Controls.Utils.crudOptions();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pkidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkmoduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleStepComposite = new System.Windows.Forms.BindingSource(this.components);
            this.dtModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructureGUI = new BioBotApp.DataSets.dsModuleStructure3();
            this.dtStepCompositeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_step_composite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepLeafStepComposite = new System.Windows.Forms.BindingSource(this.components);
            this.bs_dtStepLeafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ta_StepLeaf = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepLeaf();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crudOptionsStep = new BioBotApp.Controls.Utils.crudOptions();
            this.taStepComposite = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepComposite();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pkidDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkmoduletypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.crudOptionsActionType = new BioBotApp.Controls.Utils.crudOptions();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkstepleafidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fkactiontypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtActionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkactionvaluetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtActionValueTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepLeafActionValue = new System.Windows.Forms.BindingSource(this.components);
            this.dtActionValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taModule1 = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModule();
            this.taActionValue1 = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValue();
            this.button1 = new System.Windows.Forms.Button();
            this.taActionType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionType();
            this.taActionValueType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValueType();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleStepComposite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStepCompositeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepLeafStepComposite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dtStepLeafBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionValueTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepLeafActionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionValueBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crudOptionsProtocol);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(229, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocol";
            // 
            // crudOptionsProtocol
            // 
            this.crudOptionsProtocol.ButtonRefreshVisible = false;
            this.crudOptionsProtocol.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptionsProtocol.Location = new System.Drawing.Point(84, 16);
            this.crudOptionsProtocol.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptionsProtocol.Name = "crudOptionsProtocol";
            this.crudOptionsProtocol.Size = new System.Drawing.Size(121, 37);
            this.crudOptionsProtocol.TabIndex = 1;
            this.crudOptionsProtocol.AddClickHandler += new System.EventHandler(this.crudOptionsProto_AddClickHandler);
            this.crudOptionsProtocol.DeleteClickHandler += new System.EventHandler(this.crudOptionsProto_DeleteClickHandler);
            this.crudOptionsProtocol.ModifyClickHandler += new System.EventHandler(this.crudOptionsProto_ModifyClickHandler);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn1,
            this.fkmoduleidDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.ModuleStepComposite;
            this.dataGridView2.Location = new System.Drawing.Point(6, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(199, 297);
            this.dataGridView2.TabIndex = 0;
            // 
            // pkidDataGridViewTextBoxColumn1
            // 
            this.pkidDataGridViewTextBoxColumn1.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.pkidDataGridViewTextBoxColumn1.Name = "pkidDataGridViewTextBoxColumn1";
            this.pkidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pkidDataGridViewTextBoxColumn1.Width = 25;
            // 
            // fkmoduleidDataGridViewTextBoxColumn
            // 
            this.fkmoduleidDataGridViewTextBoxColumn.DataPropertyName = "fk_module_id";
            this.fkmoduleidDataGridViewTextBoxColumn.HeaderText = "Module ID";
            this.fkmoduleidDataGridViewTextBoxColumn.Name = "fkmoduleidDataGridViewTextBoxColumn";
            this.fkmoduleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkmoduleidDataGridViewTextBoxColumn.Width = 80;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Protocol Name";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ModuleStepComposite
            // 
            this.ModuleStepComposite.DataMember = "dtModule_dtStepComposite";
            this.ModuleStepComposite.DataSource = this.dtModuleBindingSource;
            // 
            // dtModuleBindingSource
            // 
            this.dtModuleBindingSource.DataMember = "dtModule";
            this.dtModuleBindingSource.DataSource = this.dsModuleStructureGUI;
            this.dtModuleBindingSource.CurrentItemChanged += new System.EventHandler(this.dtModuleBindingSource_CurrentChanged);
            // 
            // dsModuleStructureGUI
            // 
            this.dsModuleStructureGUI.DataSetName = "dsModuleStructure3";
            this.dsModuleStructureGUI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtStepCompositeBindingSource
            // 
            this.dtStepCompositeBindingSource.DataMember = "dtStepComposite";
            this.dtStepCompositeBindingSource.DataSource = this.dsModuleStructureGUI;
            this.dtStepCompositeBindingSource.CurrentItemChanged += new System.EventHandler(this.dtStepCompositeBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn,
            this.fk_step_composite,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.StepLeafStepComposite;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(225, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "Protocol";
            // 
            // pkidDataGridViewTextBoxColumn
            // 
            this.pkidDataGridViewTextBoxColumn.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pkidDataGridViewTextBoxColumn.Name = "pkidDataGridViewTextBoxColumn";
            this.pkidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkidDataGridViewTextBoxColumn.Width = 50;
            // 
            // fk_step_composite
            // 
            this.fk_step_composite.DataPropertyName = "fk_step_composite";
            this.fk_step_composite.HeaderText = "fk_step_composite";
            this.fk_step_composite.Name = "fk_step_composite";
            this.fk_step_composite.ReadOnly = true;
            this.fk_step_composite.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Step Name";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StepLeafStepComposite
            // 
            this.StepLeafStepComposite.DataMember = "dtStepComposite_dtStepLeaf";
            this.StepLeafStepComposite.DataSource = this.ModuleStepComposite;
            // 
            // bs_dtStepLeafBindingSource
            // 
            this.bs_dtStepLeafBindingSource.DataMember = "dtStepLeaf";
            this.bs_dtStepLeafBindingSource.DataSource = this.dsModuleStructureGUI;
            this.bs_dtStepLeafBindingSource.CurrentItemChanged += new System.EventHandler(this.bs_dtStepLeafBindingSource_CurrentChanged);
            // 
            // ta_StepLeaf
            // 
            this.ta_StepLeaf.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crudOptionsStep);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(446, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Steps";
            // 
            // crudOptionsStep
            // 
            this.crudOptionsStep.ButtonRefreshVisible = false;
            this.crudOptionsStep.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptionsStep.Location = new System.Drawing.Point(111, 12);
            this.crudOptionsStep.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptionsStep.Name = "crudOptionsStep";
            this.crudOptionsStep.Size = new System.Drawing.Size(118, 41);
            this.crudOptionsStep.TabIndex = 0;
            this.crudOptionsStep.AddClickHandler += new System.EventHandler(this.crudOptionsStep_AddClickHandler);
            this.crudOptionsStep.DeleteClickHandler += new System.EventHandler(this.crudOptionsStep_DeleteClickHandler);
            this.crudOptionsStep.ModifyClickHandler += new System.EventHandler(this.crudOptionsStep_ModifyClickHandler);
            // 
            // taStepComposite
            // 
            this.taStepComposite.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(12, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 366);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Module";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn3,
            this.fkmoduletypeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.dtModuleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(199, 341);
            this.dataGridView3.TabIndex = 0;
            // 
            // pkidDataGridViewTextBoxColumn3
            // 
            this.pkidDataGridViewTextBoxColumn3.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.pkidDataGridViewTextBoxColumn3.Name = "pkidDataGridViewTextBoxColumn3";
            this.pkidDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fkmoduletypeDataGridViewTextBoxColumn
            // 
            this.fkmoduletypeDataGridViewTextBoxColumn.DataPropertyName = "fk_module_type";
            this.fkmoduletypeDataGridViewTextBoxColumn.HeaderText = "Module Type";
            this.fkmoduletypeDataGridViewTextBoxColumn.Name = "fkmoduletypeDataGridViewTextBoxColumn";
            this.fkmoduletypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.crudOptionsActionType);
            this.groupBox4.Controls.Add(this.dataGridView4);
            this.groupBox4.Location = new System.Drawing.Point(687, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 366);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action Value";
            // 
            // crudOptionsActionType
            // 
            this.crudOptionsActionType.ButtonRefreshVisible = false;
            this.crudOptionsActionType.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptionsActionType.Location = new System.Drawing.Point(111, 12);
            this.crudOptionsActionType.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptionsActionType.Name = "crudOptionsActionType";
            this.crudOptionsActionType.Size = new System.Drawing.Size(118, 41);
            this.crudOptionsActionType.TabIndex = 0;
            this.crudOptionsActionType.AddClickHandler += new System.EventHandler(this.crudOptionsAction_AddClickHandler);
            this.crudOptionsActionType.DeleteClickHandler += new System.EventHandler(this.crudOptionsAction_DeleteClickHandler);
            this.crudOptionsActionType.ModifyClickHandler += new System.EventHandler(this.crudOptionsAction_ModifyClickHandler);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.pkidDataGridViewTextBoxColumn2,
            this.fkstepleafidDataGridViewTextBoxColumn,
            this.fkactiontypeDataGridViewTextBoxColumn,
            this.fkactionvaluetypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView4.DataSource = this.StepLeafActionValue;
            this.dataGridView4.Location = new System.Drawing.Point(6, 63);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(485, 297);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.Tag = "Protocol";
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.FillWeight = 25F;
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 40;
            // 
            // pkidDataGridViewTextBoxColumn2
            // 
            this.pkidDataGridViewTextBoxColumn2.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn2.FillWeight = 25F;
            this.pkidDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.pkidDataGridViewTextBoxColumn2.Name = "pkidDataGridViewTextBoxColumn2";
            this.pkidDataGridViewTextBoxColumn2.ReadOnly = true;
            this.pkidDataGridViewTextBoxColumn2.Width = 40;
            // 
            // fkstepleafidDataGridViewTextBoxColumn
            // 
            this.fkstepleafidDataGridViewTextBoxColumn.DataPropertyName = "fk_step_leaf_id";
            this.fkstepleafidDataGridViewTextBoxColumn.DataSource = this.bs_dtStepLeafBindingSource;
            this.fkstepleafidDataGridViewTextBoxColumn.DisplayMember = "description";
            this.fkstepleafidDataGridViewTextBoxColumn.HeaderText = "Step Name";
            this.fkstepleafidDataGridViewTextBoxColumn.Name = "fkstepleafidDataGridViewTextBoxColumn";
            this.fkstepleafidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkstepleafidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkstepleafidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkstepleafidDataGridViewTextBoxColumn.ValueMember = "pk_id";
            // 
            // fkactiontypeDataGridViewTextBoxColumn
            // 
            this.fkactiontypeDataGridViewTextBoxColumn.DataPropertyName = "fk_action_type";
            this.fkactiontypeDataGridViewTextBoxColumn.DataSource = this.dtActionTypeBindingSource;
            this.fkactiontypeDataGridViewTextBoxColumn.DisplayMember = "description";
            this.fkactiontypeDataGridViewTextBoxColumn.HeaderText = "Action Type";
            this.fkactiontypeDataGridViewTextBoxColumn.Name = "fkactiontypeDataGridViewTextBoxColumn";
            this.fkactiontypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkactiontypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkactiontypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkactiontypeDataGridViewTextBoxColumn.ValueMember = "pk_id";
            // 
            // dtActionTypeBindingSource
            // 
            this.dtActionTypeBindingSource.DataMember = "dtActionType";
            this.dtActionTypeBindingSource.DataSource = this.dsModuleStructureGUI;
            // 
            // fkactionvaluetypeDataGridViewTextBoxColumn
            // 
            this.fkactionvaluetypeDataGridViewTextBoxColumn.DataPropertyName = "fk_action_value_type";
            this.fkactionvaluetypeDataGridViewTextBoxColumn.DataSource = this.dtActionValueTypeBindingSource;
            this.fkactionvaluetypeDataGridViewTextBoxColumn.DisplayMember = "description";
            this.fkactionvaluetypeDataGridViewTextBoxColumn.HeaderText = "Action Value";
            this.fkactionvaluetypeDataGridViewTextBoxColumn.Name = "fkactionvaluetypeDataGridViewTextBoxColumn";
            this.fkactionvaluetypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkactionvaluetypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fkactionvaluetypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fkactionvaluetypeDataGridViewTextBoxColumn.ValueMember = "pk_id";
            // 
            // dtActionValueTypeBindingSource
            // 
            this.dtActionValueTypeBindingSource.DataMember = "dtActionValueType";
            this.dtActionValueTypeBindingSource.DataSource = this.dsModuleStructureGUI;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Value";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fk_step_composite";
            this.dataGridViewTextBoxColumn2.HeaderText = "fk_step_composite";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // StepLeafActionValue
            // 
            this.StepLeafActionValue.DataMember = "dtStepLeaf_dtActionValue";
            this.StepLeafActionValue.DataSource = this.StepLeafStepComposite;
            // 
            // dtActionValueBindingSource
            // 
            this.dtActionValueBindingSource.DataMember = "dtActionValue";
            this.dtActionValueBindingSource.DataSource = this.dsModuleStructureGUI;
            // 
            // taModule1
            // 
            this.taModule1.ClearBeforeFill = true;
            // 
            // taActionValue1
            // 
            this.taActionValue1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1030, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // taActionType
            // 
            this.taActionType.ClearBeforeFill = true;
            // 
            // taActionValueType
            // 
            this.taActionValueType.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1200, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Visible = false;
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // optionProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "optionProtocol";
            this.Size = new System.Drawing.Size(1200, 461);
            this.Tag = "Protocol";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleStepComposite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStepCompositeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepLeafStepComposite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dtStepLeafBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionValueTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepLeafActionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionValueBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Bs_dtStepLeafBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Utils.crudOptions crudOptionsStep;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs_dtStepLeafBindingSource;
        private DataSets.dsModuleStructure3 dsModuleStructureGUI;
        private DataSets.dsModuleStructure3TableAdapters.taStepLeaf ta_StepLeaf;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dtStepCompositeBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private DataSets.dsModuleStructure3TableAdapters.taStepComposite taStepComposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkmoduleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource StepLeafStepComposite;
        private Utils.crudOptions crudOptionsProtocol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Utils.crudOptions crudOptionsActionType;
        private System.Windows.Forms.DataGridView dataGridView4;
        private DataSets.dsModuleStructure3TableAdapters.taModule taModule1;
        private DataSets.dsModuleStructure3TableAdapters.taActionValue taActionValue1;
        private System.Windows.Forms.BindingSource dtModuleBindingSource;
        private System.Windows.Forms.BindingSource dtActionValueBindingSource;
        private System.Windows.Forms.BindingSource StepLeafActionValue;
        private System.Windows.Forms.BindingSource ModuleStepComposite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dtActionTypeBindingSource;
        private System.Windows.Forms.BindingSource dtActionValueTypeBindingSource;
        private DataSets.dsModuleStructure3TableAdapters.taActionType taActionType;
        private DataSets.dsModuleStructure3TableAdapters.taActionValueType taActionValueType;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_step_composite;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkstepleafidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkactiontypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkactionvaluetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkmoduletypeDataGridViewTextBoxColumn;
    }
}

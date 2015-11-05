namespace BioBotApp.Controls.Option.Options
{
    partial class optionSavedProtocol
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
            this.crudOptions1 = new BioBotApp.Controls.Utils.crudOptions();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtSavedProtocolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructure3 = new BioBotApp.DataSets.dsModuleStructure3();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crudOptions2 = new BioBotApp.Controls.Utils.crudOptions();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.taSavedProtocol1 = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taSavedProtocol();
            this.pkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkstepcompositeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fksavedprotocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSavedProtocolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crudOptions1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saved Protocol";
            // 
            // crudOptions1
            // 
            this.crudOptions1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crudOptions1.ButtonRefreshVisible = false;
            this.crudOptions1.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions1.Location = new System.Drawing.Point(230, 21);
            this.crudOptions1.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptions1.Name = "crudOptions1";
            this.crudOptions1.Size = new System.Drawing.Size(127, 37);
            this.crudOptions1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dtSavedProtocolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(351, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "SavedProtocol";
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dtSavedProtocolBindingSource_CurrentChanged);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // dtSavedProtocolBindingSource
            // 
            this.dtSavedProtocolBindingSource.DataMember = "dtSavedProtocol";
            this.dtSavedProtocolBindingSource.DataSource = this.dsModuleStructure3;
            // 
            // dsModuleStructure3
            // 
            this.dsModuleStructure3.DataSetName = "dsModuleStructure3";
            this.dsModuleStructure3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.crudOptions2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 515);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Steps Saved";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.fkstepcompositeDataGridViewTextBoxColumn,
            this.fksavedprotocolDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(351, 418);
            this.dataGridView2.TabIndex = 2;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtSavedProtocol";
            this.bindingSource1.DataSource = this.dsModuleStructure3;
            this.bindingSource1.Filter = "description = null";
            // 
            // crudOptions2
            // 
            this.crudOptions2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crudOptions2.ButtonRefreshVisible = false;
            this.crudOptions2.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions2.Location = new System.Drawing.Point(230, 21);
            this.crudOptions2.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptions2.Name = "crudOptions2";
            this.crudOptions2.Size = new System.Drawing.Size(127, 37);
            this.crudOptions2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(739, 515);
            this.splitContainer2.SplitterDistance = 369;
            this.splitContainer2.TabIndex = 3;
            // 
            // taSavedProtocol1
            // 
            this.taSavedProtocol1.ClearBeforeFill = true;
            // 
            // pkidDataGridViewTextBoxColumn
            // 
            this.pkidDataGridViewTextBoxColumn.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn.HeaderText = "pk_id";
            this.pkidDataGridViewTextBoxColumn.Name = "pkidDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // fkstepcompositeDataGridViewTextBoxColumn
            // 
            this.fkstepcompositeDataGridViewTextBoxColumn.DataPropertyName = "fk_step_composite";
            this.fkstepcompositeDataGridViewTextBoxColumn.HeaderText = "fk_step_composite";
            this.fkstepcompositeDataGridViewTextBoxColumn.Name = "fkstepcompositeDataGridViewTextBoxColumn";
            // 
            // fksavedprotocolDataGridViewTextBoxColumn
            // 
            this.fksavedprotocolDataGridViewTextBoxColumn.DataPropertyName = "fk_saved_protocol";
            this.fksavedprotocolDataGridViewTextBoxColumn.HeaderText = "fk_saved_protocol";
            this.fksavedprotocolDataGridViewTextBoxColumn.Name = "fksavedprotocolDataGridViewTextBoxColumn";
            // 
            // optionSavedProtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "optionSavedProtocol";
            this.Size = new System.Drawing.Size(742, 518);
            this.Tag = "SavedProtocol";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSavedProtocolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Utils.crudOptions crudOptions1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Utils.crudOptions crudOptions2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DataSets.dsModuleStructure3 dsModuleStructureGUI;
        private System.Windows.Forms.BindingSource dtSavedProtocolBindingSource;
        private DataSets.dsModuleStructure3 dsModuleStructure3;
        private DataSets.dsModuleStructure3TableAdapters.taSavedProtocol taSavedProtocol1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkstepcompositeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fksavedprotocolDataGridViewTextBoxColumn;
    }
}

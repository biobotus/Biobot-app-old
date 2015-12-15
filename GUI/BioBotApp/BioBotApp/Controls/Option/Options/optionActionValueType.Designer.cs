namespace BioBotApp.Controls.Option.Options
{
    partial class optionActionValueType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvActionType = new System.Windows.Forms.DataGridView();
            this.bsActionValueType = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructureGUI = new BioBotApp.DataSets.dsModuleStructure3();
            this.crudOptions = new BioBotApp.Controls.Utils.crudOptions();
            this.ta_bbt_action_value_type = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValueType();
            this.pkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionValueType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 351);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvActionType);
            this.panel3.Controls.Add(this.crudOptions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 351);
            this.panel3.TabIndex = 2;
            // 
            // gvActionType
            // 
            this.gvActionType.AllowUserToAddRows = false;
            this.gvActionType.AllowUserToDeleteRows = false;
            this.gvActionType.AllowUserToOrderColumns = true;
            this.gvActionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gvActionType.AutoGenerateColumns = false;
            this.gvActionType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvActionType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.gvActionType.DataSource = this.bsActionValueType;
            this.gvActionType.Location = new System.Drawing.Point(3, 54);
            this.gvActionType.MultiSelect = false;
            this.gvActionType.Name = "gvActionType";
            this.gvActionType.ReadOnly = true;
            this.gvActionType.RowHeadersVisible = false;
            this.gvActionType.RowTemplate.Height = 24;
            this.gvActionType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvActionType.Size = new System.Drawing.Size(415, 290);
            this.gvActionType.TabIndex = 0;
            // 
            // bsActionValueType
            // 
            this.bsActionValueType.DataMember = "dtActionValueType";
            this.bsActionValueType.DataSource = this.dsModuleStructureGUI;
            // 
            // dsModuleStructureGUI
            // 
            this.dsModuleStructureGUI.DataSetName = "dsModuleStructure3";
            this.dsModuleStructureGUI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crudOptions
            // 
            this.crudOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.crudOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crudOptions.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions.Location = new System.Drawing.Point(3, 8);
            this.crudOptions.MinimumSize = new System.Drawing.Size(108, 33);
            this.crudOptions.Name = "crudOptions";
            this.crudOptions.Size = new System.Drawing.Size(415, 40);
            this.crudOptions.TabIndex = 1;
            this.crudOptions.AddClickHandler += new System.EventHandler(this.crudOptions_AddClickHandler);
            this.crudOptions.DeleteClickHandler += new System.EventHandler(this.crudOptions_DeleteClickHandler);
            this.crudOptions.ModifyClickHandler += new System.EventHandler(this.crudOptions_ModifyClickHandler);
            // 
            // ta_bbt_action_value_type
            // 
            this.ta_bbt_action_value_type.ClearBeforeFill = true;
            // 
            // pkidDataGridViewTextBoxColumn
            // 
            this.pkidDataGridViewTextBoxColumn.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn.HeaderText = "pk_id";
            this.pkidDataGridViewTextBoxColumn.Name = "pkidDataGridViewTextBoxColumn";
            this.pkidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkidDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionActionValueType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(421, 351);
            this.Name = "optionActionValueType";
            this.Size = new System.Drawing.Size(421, 351);
            this.Tag = "Action types";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvActionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActionValueType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DataSets.dsModuleStructure3 dsModuleStructureGUI;
        private System.Windows.Forms.DataGridView gvActionType;
        private Utils.crudOptions crudOptions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bsActionValueType;
        private DataSets.dsModuleStructure3TableAdapters.taActionValueType ta_bbt_action_value_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}

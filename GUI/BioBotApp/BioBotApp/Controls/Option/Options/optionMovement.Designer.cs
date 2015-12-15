namespace BioBotApp.Controls.Option.Options
{
    partial class optionMovement
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.bsStepComposite = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure3();
            this.taStepComposite = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepComposite();
            this.dtStepLeafDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsStepComposite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStepLeafDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(114, 72);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(14, 72);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bsStepComposite
            // 
            this.bsStepComposite.DataMember = "dtStepComposite";
            this.bsStepComposite.DataSource = this.dsModuleStructure;
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure3";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taStepComposite
            // 
            this.taStepComposite.ClearBeforeFill = true;
            // 
            // dtStepLeafDataGridView
            // 
            this.dtStepLeafDataGridView.AutoGenerateColumns = false;
            this.dtStepLeafDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStepLeafDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtStepLeafDataGridView.DataSource = this.bsStepComposite;
            this.dtStepLeafDataGridView.Location = new System.Drawing.Point(14, 0);
            this.dtStepLeafDataGridView.Name = "dtStepLeafDataGridView";
            this.dtStepLeafDataGridView.Size = new System.Drawing.Size(550, 66);
            this.dtStepLeafDataGridView.TabIndex = 2;
            this.dtStepLeafDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtStepLeafDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pk_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "pk_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fk_step_parent_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "fk_step_parent_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fk_module_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "fk_module_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fk_step_leaf_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "fk_step_leaf_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn5.HeaderText = "description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // optionMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtStepLeafDataGridView);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnHome);
            this.Name = "optionMovement";
            this.Size = new System.Drawing.Size(632, 270);
            this.Tag = "Movement";
            ((System.ComponentModel.ISupportInitialize)(this.bsStepComposite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStepLeafDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.BindingSource bsStepComposite;
        private DataSets.dsModuleStructure3 dsModuleStructure;
        private DataSets.dsModuleStructure3TableAdapters.taStepComposite taStepComposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dtStepLeafDataGridView;

    }
}

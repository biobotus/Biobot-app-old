namespace BioBotApp.Controls.Steps
{
    partial class ctrlStepsView
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
            this.tlvSteps = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.taStepComposite = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepComposite();
            this.taStepLeaf = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepLeaf();
            this.taActionValue = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValue();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlvSteps
            // 
            this.tlvSteps.AllowDrop = true;
            this.tlvSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlvSteps.Location = new System.Drawing.Point(4, 37);
            this.tlvSteps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlvSteps.Name = "tlvSteps";
            this.tlvSteps.Size = new System.Drawing.Size(493, 318);
            this.tlvSteps.TabIndex = 3;
            this.tlvSteps.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tlvSteps_ItemDrag);
            this.tlvSteps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tlvSteps_AfterSelect);
            this.tlvSteps.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlvSteps_DragDrop);
            this.tlvSteps.DragEnter += new System.Windows.Forms.DragEventHandler(this.tlvSteps_DragEnter);
            this.tlvSteps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlvSteps_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 32);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steps";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 355);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(493, 45);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(377, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(257, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // taStepComposite
            // 
            this.taStepComposite.ClearBeforeFill = true;
            // 
            // taStepLeaf
            // 
            this.taStepLeaf.ClearBeforeFill = true;
            // 
            // taActionValue
            // 
            this.taActionValue.ClearBeforeFill = true;
            // 
            // ctrlStepsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlvSteps);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlStepsView";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Size = new System.Drawing.Size(501, 405);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tlvSteps;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private DataSets.dsModuleStructure3TableAdapters.taStepComposite taStepComposite;
        private DataSets.dsModuleStructure3TableAdapters.taStepLeaf taStepLeaf;
        private DataSets.dsModuleStructure3TableAdapters.taActionValue taActionValue;

    }
}

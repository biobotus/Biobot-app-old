namespace BioBotApp.Controls.Protocol
{
    partial class ctrlProtocolsView
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
            this.tlvProtocol = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure3();
            this.ta_Saved_Protocol = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taSavedProtocol();
            this.taStepComposite1 = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepComposite();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            this.SuspendLayout();
            // 
            // tlvProtocol
            // 
            this.tlvProtocol.AllowDrop = true;
            this.tlvProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlvProtocol.Location = new System.Drawing.Point(3, 24);
            this.tlvProtocol.Name = "tlvProtocol";
            this.tlvProtocol.Size = new System.Drawing.Size(243, 193);
            this.tlvProtocol.TabIndex = 6;
            this.tlvProtocol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tlvProtocol_AfterSelect);
            this.tlvProtocol.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlvProtocol_DragDrop);
            this.tlvProtocol.DragEnter += new System.Windows.Forms.DragEventHandler(this.tlvProtocol_DragEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 21);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Protocols";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStart);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.SaveButton);
            this.flowLayoutPanel1.Controls.Add(this.btnStop);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.LoadButton);
            this.flowLayoutPanel1.Controls.Add(this.btnReset);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 217);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 99);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 61);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(84, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(84, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(84, 61);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(165, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure3";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ta_Saved_Protocol
            // 
            this.ta_Saved_Protocol.ClearBeforeFill = true;
            // 
            // taStepComposite1
            // 
            this.taStepComposite1.ClearBeforeFill = true;
            // 
            // ctrlProtocolsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlvProtocol);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ctrlProtocolsView";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Size = new System.Drawing.Size(249, 319);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tlvProtocol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAdd;
        private DataSets.dsModuleStructure3 dsModuleStructure;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        //private DataSets.dsModuleStructure3 dsModuleStructureGUI;
        //private DataSets.dsModuleStructure3TableAdapters.taSavedProtocol ta_Saved_Protocol;
        private DataSets.dsModuleStructure3TableAdapters.taSavedProtocol ta_Saved_Protocol;
        private DataSets.dsModuleStructure3TableAdapters.taStepComposite taStepComposite1;
    }
}

namespace BioBotApp.Controls.Option
{
    partial class frmOptions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Action types");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Action value types");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Module types");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Module types action types");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Labware types labware parameters");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Labware types");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Labware parameter types");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Module type labware parameter type");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Gcode Serial");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("serial -> can");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Communication", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Movement");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Protocol");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Joypad");
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlvOptions = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure3();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlvOptions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 257);
            this.panel1.TabIndex = 0;
            // 
            // tlvOptions
            // 
            this.tlvOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlvOptions.Location = new System.Drawing.Point(0, 0);
            this.tlvOptions.Margin = new System.Windows.Forms.Padding(1);
            this.tlvOptions.Name = "tlvOptions";
            treeNode1.Name = "nodeActionTypes";
            treeNode1.Tag = "actionTypes";
            treeNode1.Text = "Action types";
            treeNode2.Name = "nodeActionValueTypes";
            treeNode2.Tag = "actionValueTypes";
            treeNode2.Text = "Action value types";
            treeNode3.Name = "nodeModuleTypes";
            treeNode3.Tag = "moduleType";
            treeNode3.Text = "Module types";
            treeNode4.Name = "nodeModuleTypesActionTypes";
            treeNode4.Tag = "moduleTypeActionType";
            treeNode4.Text = "Module types action types";
            treeNode5.Name = "nodeLabwareTypesLabwareParameterTypes";
            treeNode5.Text = "Labware types labware parameters";
            treeNode6.Name = "nodeLabwareTypes";
            treeNode6.Text = "Labware types";
            treeNode7.Name = "nodeLabwareParameterTypes";
            treeNode7.Text = "Labware parameter types";
            treeNode8.Name = "nodeModuleTypeLabwareParameterType";
            treeNode8.Tag = "";
            treeNode8.Text = "Module type labware parameter type";
            treeNode9.Name = "nodeDB";
            treeNode9.Text = "Database";
            treeNode10.Name = "nodeGCode";
            treeNode10.Text = "Gcode Serial";
            treeNode11.Name = "nodeCan";
            treeNode11.Text = "serial -> can";
            treeNode12.Name = "nodeCom";
            treeNode12.Text = "Communication";
            treeNode13.Name = "nodeMovement";
            treeNode13.Text = "Movement";
            treeNode14.Name = "nodeProtocol";
            treeNode14.Text = "Protocol";
            treeNode15.Name = "nodeJoypad";
            treeNode15.Tag = "Joypad";
            treeNode15.Text = "Joypad";
            this.tlvOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.tlvOptions.Size = new System.Drawing.Size(150, 257);
            this.tlvOptions.TabIndex = 0;
            this.tlvOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tlvOptions_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 38);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(356, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(152, 38);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(356, 185);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure3";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(150, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 257);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(152, 223);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 34);
            this.panel3.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(291, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(508, 257);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tlvOptions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private DataSets.dsModuleStructure3 dsModuleStructure;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
    }
}
namespace BioBotApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.bsModuleStructure = new System.Windows.Forms.BindingSource(this.components);
            this.dtActionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canCommunicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ctrlDeck = new BioBotApp.Controls.Deck.ctrlDeck();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ctrlConsole = new BioBotApp.Controls.TCPConsole.ctrlConsole();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ctrlTools = new BioBotApp.Controls.Tools_controls.ctrlTools();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ctrlLabware = new BioBotApp.Controls.Labware.ctrlLabware();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlSteps = new BioBotApp.Controls.Steps.ctrlStepsView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ctrlProtocolsView = new BioBotApp.Controls.Protocol.ctrlProtocolsView();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttsDBConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.bsModule = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure3();
            this.bbt_action_typeTableAdapter = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionType();
            this.bsModuleType = new System.Windows.Forms.BindingSource(this.components);
            this.taModuleType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModuleType();
            this.taModule = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModule();
            this.taModuleTypeActionType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taModuleTypeActionType();
            this.taActionType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionType();
            this.taActionValueType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValueType();
            this.taLabwareType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taLabwareType();
            this.taLabwareParameterType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taLabwareParameterType();
            this.taLabwareTypeLabwareParameterType = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taLabwareTypeLabwareParameterType();
            this.taStepComposite = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepComposite();
            this.taStepLeaf = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taStepLeaf();
            this.taActionValue = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taActionValue();
            this.taSavedProtocol = new BioBotApp.DataSets.dsModuleStructure3TableAdapters.taSavedProtocol();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionTypeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleType)).BeginInit();
            this.SuspendLayout();
            // 
            // dtActionTypeBindingSource
            // 
            this.dtActionTypeBindingSource.DataSource = this.bsModuleStructure;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1412, 26);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canCommunicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // canCommunicationToolStripMenuItem
            // 
            this.canCommunicationToolStripMenuItem.Name = "canCommunicationToolStripMenuItem";
            this.canCommunicationToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.canCommunicationToolStripMenuItem.Text = "Can Communication";
            this.canCommunicationToolStripMenuItem.Click += new System.EventHandler(this.canCommunicationToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametersToolStripMenuItem,
            this.playToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.optionsToolStripMenuItem.Text = "&Tools";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.parametersToolStripMenuItem.Text = "&Options";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 648);
            this.panel1.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.splitter4);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(821, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(589, 646);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ctrlDeck);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(589, 371);
            this.panel6.TabIndex = 2;
            // 
            // ctrlDeck
            // 
            this.ctrlDeck.AllowDrop = true;
            this.ctrlDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDeck.Location = new System.Drawing.Point(0, 0);
            this.ctrlDeck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlDeck.Name = "ctrlDeck";
            this.ctrlDeck.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlDeck.Size = new System.Drawing.Size(589, 371);
            this.ctrlDeck.TabIndex = 0;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.Silver;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(0, 371);
            this.splitter4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(589, 4);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ctrlConsole);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 375);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(589, 271);
            this.panel10.TabIndex = 0;
            // 
            // ctrlConsole
            // 
            this.ctrlConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlConsole.Location = new System.Drawing.Point(0, 0);
            this.ctrlConsole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlConsole.Name = "ctrlConsole";
            this.ctrlConsole.Size = new System.Drawing.Size(589, 271);
            this.ctrlConsole.TabIndex = 0;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Silver;
            this.splitter3.Location = new System.Drawing.Point(817, 0);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(4, 646);
            this.splitter3.TabIndex = 22;
            this.splitter3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(550, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 646);
            this.panel3.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.splitter5);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 646);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ctrlTools);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(267, 398);
            this.panel8.TabIndex = 2;
            // 
            // ctrlTools
            // 
            this.ctrlTools.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTools.Location = new System.Drawing.Point(0, 0);
            this.ctrlTools.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlTools.Name = "ctrlTools";
            this.ctrlTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlTools.Size = new System.Drawing.Size(267, 398);
            this.ctrlTools.TabIndex = 0;
            this.ctrlTools.ToolSelectionChanged += new System.EventHandler<BioBotApp.Controls.Tools_controls.ModuleTypeSelectionEventArgs>(this.ctrlTools_ToolSelectionChanged);
            // 
            // splitter5
            // 
            this.splitter5.BackColor = System.Drawing.Color.Silver;
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter5.Location = new System.Drawing.Point(0, 398);
            this.splitter5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(267, 4);
            this.splitter5.TabIndex = 1;
            this.splitter5.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ctrlLabware);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 402);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(267, 244);
            this.panel9.TabIndex = 0;
            // 
            // ctrlLabware
            // 
            this.ctrlLabware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLabware.Location = new System.Drawing.Point(0, 0);
            this.ctrlLabware.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlLabware.Name = "ctrlLabware";
            this.ctrlLabware.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlLabware.Size = new System.Drawing.Size(267, 244);
            this.ctrlLabware.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Silver;
            this.splitter2.Location = new System.Drawing.Point(546, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 646);
            this.splitter2.TabIndex = 20;
            this.splitter2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlSteps);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 646);
            this.panel2.TabIndex = 18;
            // 
            // ctrlSteps
            // 
            this.ctrlSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlSteps.Location = new System.Drawing.Point(0, 0);
            this.ctrlSteps.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlSteps.Name = "ctrlSteps";
            this.ctrlSteps.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlSteps.Size = new System.Drawing.Size(267, 646);
            this.ctrlSteps.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Silver;
            this.splitter1.Location = new System.Drawing.Point(275, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 646);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ctrlProtocolsView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 646);
            this.panel4.TabIndex = 17;
            // 
            // ctrlProtocolsView
            // 
            this.ctrlProtocolsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlProtocolsView.Location = new System.Drawing.Point(0, 0);
            this.ctrlProtocolsView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlProtocolsView.Name = "ctrlProtocolsView";
            this.ctrlProtocolsView.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlProtocolsView.Size = new System.Drawing.Size(275, 646);
            this.ctrlProtocolsView.TabIndex = 8;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.ttsDBConnection});
            this.statusStrip2.Location = new System.Drawing.Point(4, 678);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1412, 37);
            this.statusStrip2.TabIndex = 19;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 32);
            // 
            // ttsDBConnection
            // 
            this.ttsDBConnection.Image = global::BioBotApp.Properties.Resources.link_break;
            this.ttsDBConnection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ttsDBConnection.Name = "ttsDBConnection";
            this.ttsDBConnection.Size = new System.Drawing.Size(32, 32);
            // 
            // bsModule
            // 
            this.bsModule.DataMember = "dtModule";
            this.bsModule.DataSource = this.dsModuleStructure;
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure3";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bbt_action_typeTableAdapter
            // 
            this.bbt_action_typeTableAdapter.ClearBeforeFill = true;
            // 
            // bsModuleType
            // 
            this.bsModuleType.DataMember = "dtModuleType";
            this.bsModuleType.DataSource = this.dsModuleStructure;
            // 
            // taModuleType
            // 
            this.taModuleType.ClearBeforeFill = true;
            // 
            // taModule
            // 
            this.taModule.ClearBeforeFill = true;
            // 
            // taModuleTypeActionType
            // 
            this.taModuleTypeActionType.ClearBeforeFill = true;
            // 
            // taActionType
            // 
            this.taActionType.ClearBeforeFill = true;
            // 
            // taActionValueType
            // 
            this.taActionValueType.ClearBeforeFill = true;
            // 
            // taLabwareType
            // 
            this.taLabwareType.ClearBeforeFill = true;
            // 
            // taLabwareParameterType
            // 
            this.taLabwareParameterType.ClearBeforeFill = true;
            // 
            // taLabwareTypeLabwareParameterType
            // 
            this.taLabwareTypeLabwareParameterType.ClearBeforeFill = true;
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
            // taSavedProtocol1
            // 
            this.taSavedProtocol.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtActionTypeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModuleType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsModuleStructure;
        private System.Windows.Forms.BindingSource bsModule;
        private System.Windows.Forms.BindingSource dtActionTypeBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private Controls.Tools_controls.ctrlTools ctrlTools;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Panel panel9;
        private Controls.Labware.ctrlLabware ctrlLabware;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel2;
        private Controls.Steps.ctrlStepsView ctrlSteps;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private Controls.Protocol.ctrlProtocolsView ctrlProtocolsView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Controls.Deck.ctrlDeck ctrlDeck;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panel10;
        private Controls.TCPConsole.ctrlConsole ctrlConsole;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ttsDBConnection;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private DataSets.dsModuleStructure3TableAdapters.taActionType bbt_action_typeTableAdapter;
        private DataSets.dsModuleStructure3 dsModuleStructure;
        private System.Windows.Forms.BindingSource bsModuleType;
        private DataSets.dsModuleStructure3TableAdapters.taModuleType taModuleType;
        private DataSets.dsModuleStructure3TableAdapters.taModule taModule;
        private DataSets.dsModuleStructure3TableAdapters.taModuleTypeActionType taModuleTypeActionType;
        private DataSets.dsModuleStructure3TableAdapters.taActionType taActionType;
        private DataSets.dsModuleStructure3TableAdapters.taActionValueType taActionValueType;
        private DataSets.dsModuleStructure3TableAdapters.taLabwareType taLabwareType;
        private DataSets.dsModuleStructure3TableAdapters.taLabwareParameterType taLabwareParameterType;
        private DataSets.dsModuleStructure3TableAdapters.taLabwareTypeLabwareParameterType taLabwareTypeLabwareParameterType;
        private DataSets.dsModuleStructure3TableAdapters.taStepComposite taStepComposite;
        private DataSets.dsModuleStructure3TableAdapters.taStepLeaf taStepLeaf;
        private DataSets.dsModuleStructure3TableAdapters.taActionValue taActionValue;
        //private DataSets.dsModuleStructure3TableAdapters.taSavedProtocol taSavedProtocol;
        private System.Windows.Forms.ToolStripMenuItem canCommunicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private DataSets.dsModuleStructure3TableAdapters.taSavedProtocol taSavedProtocol;
    }
}


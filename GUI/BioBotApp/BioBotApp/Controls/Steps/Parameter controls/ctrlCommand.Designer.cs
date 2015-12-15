namespace BioBotApp.Controls.Steps.Parameter_controls
{
    partial class ctrlCommand
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.layoutModuleParametersStop = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCommandTypeName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.layoutModuleParametersStop);
            this.panel2.Controls.Add(this.txtCommandTypeName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 150);
            this.panel2.TabIndex = 5;
            // 
            // layoutModuleParametersStop
            // 
            this.layoutModuleParametersStop.AutoScroll = true;
            this.layoutModuleParametersStop.AutoSize = true;
            this.layoutModuleParametersStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutModuleParametersStop.Location = new System.Drawing.Point(0, 31);
            this.layoutModuleParametersStop.Margin = new System.Windows.Forms.Padding(4);
            this.layoutModuleParametersStop.Name = "layoutModuleParametersStop";
            this.layoutModuleParametersStop.Size = new System.Drawing.Size(542, 115);
            this.layoutModuleParametersStop.TabIndex = 0;
            // 
            // txtCommandTypeName
            // 
            this.txtCommandTypeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCommandTypeName.Location = new System.Drawing.Point(0, 0);
            this.txtCommandTypeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCommandTypeName.Name = "txtCommandTypeName";
            this.txtCommandTypeName.Size = new System.Drawing.Size(542, 31);
            this.txtCommandTypeName.TabIndex = 0;
            this.txtCommandTypeName.Text = "Command type name";
            this.txtCommandTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ctrlCommand";
            this.Size = new System.Drawing.Size(546, 150);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel layoutModuleParametersStop;
        private System.Windows.Forms.Label txtCommandTypeName;
    }
}

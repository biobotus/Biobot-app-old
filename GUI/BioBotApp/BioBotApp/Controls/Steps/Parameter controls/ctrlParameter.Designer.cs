namespace BioBotApp.Controls.Parameter_control
{
    partial class ParameterActions
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
            this.txtParameterKey = new System.Windows.Forms.Label();
            this.edtParameterValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtParameterKey
            // 
            this.txtParameterKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtParameterKey.Location = new System.Drawing.Point(5, 5);
            this.txtParameterKey.Name = "txtParameterKey";
            this.txtParameterKey.Size = new System.Drawing.Size(119, 20);
            this.txtParameterKey.TabIndex = 0;
            this.txtParameterKey.Text = "ParameterKeyValue";
            this.txtParameterKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtParameterValue
            // 
            this.edtParameterValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtParameterValue.Location = new System.Drawing.Point(124, 5);
            this.edtParameterValue.Multiline = true;
            this.edtParameterValue.Name = "edtParameterValue";
            this.edtParameterValue.Size = new System.Drawing.Size(97, 20);
            this.edtParameterValue.TabIndex = 1;
            // 
            // ParameterActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtParameterValue);
            this.Controls.Add(this.txtParameterKey);
            this.MinimumSize = new System.Drawing.Size(100, 30);
            this.Name = "ParameterActions";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(226, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtParameterKey;
        private System.Windows.Forms.TextBox edtParameterValue;
    }
}

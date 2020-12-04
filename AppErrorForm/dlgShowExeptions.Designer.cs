namespace AppErrorForm
{
    partial class dlgShowExeptions
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
            this.textBoxExSource = new System.Windows.Forms.TextBox();
            this.textBoxExMessage = new System.Windows.Forms.TextBox();
            this.textBoxExSteck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxExSource
            // 
            this.textBoxExSource.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxExSource.Enabled = false;
            this.textBoxExSource.Location = new System.Drawing.Point(0, 0);
            this.textBoxExSource.Multiline = true;
            this.textBoxExSource.Name = "textBoxExSource";
            this.textBoxExSource.ReadOnly = true;
            this.textBoxExSource.Size = new System.Drawing.Size(100, 20);
            this.textBoxExSource.TabIndex = 1;
            // 
            // textBoxExMessage
            // 
            this.textBoxExMessage.Enabled = false;
            this.textBoxExMessage.Location = new System.Drawing.Point(0, 38);
            this.textBoxExMessage.Multiline = true;
            this.textBoxExMessage.Name = "textBoxExMessage";
            this.textBoxExMessage.ReadOnly = true;
            this.textBoxExMessage.Size = new System.Drawing.Size(100, 20);
            this.textBoxExMessage.TabIndex = 4;
            // 
            // textBoxExSteck
            // 
            this.textBoxExSteck.Location = new System.Drawing.Point(0, 64);
            this.textBoxExSteck.Multiline = true;
            this.textBoxExSteck.Name = "textBoxExSteck";
            this.textBoxExSteck.ReadOnly = true;
            this.textBoxExSteck.Size = new System.Drawing.Size(100, 20);
            this.textBoxExSteck.TabIndex = 5;
            // 
            // dlgShowExeptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 255);
            this.Controls.Add(this.textBoxExSteck);
            this.Controls.Add(this.textBoxExMessage);
            this.Controls.Add(this.textBoxExSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgShowExeptions";
            this.Load += new System.EventHandler(this.dlgShowExeptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxExSource;
        public System.Windows.Forms.TextBox textBoxExMessage;
        public System.Windows.Forms.TextBox textBoxExSteck;
    }
}
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxExSource = new System.Windows.Forms.TextBox();
            this.textBoxExMessage = new System.Windows.Forms.TextBox();
            this.textBoxExSteck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxExSource
            // 
            this.textBoxExSource.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxExSource.Enabled = false;
            this.textBoxExSource.Location = new System.Drawing.Point(0, 0);
            this.textBoxExSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExSource.Multiline = true;
            this.textBoxExSource.Name = "textBoxExSource";
            this.textBoxExSource.ReadOnly = true;
            this.textBoxExSource.Size = new System.Drawing.Size(148, 29);
            this.textBoxExSource.TabIndex = 1;
            // 
            // textBoxExMessage
            // 
            this.textBoxExMessage.Enabled = false;
            this.textBoxExMessage.Location = new System.Drawing.Point(0, 59);
            this.textBoxExMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExMessage.Multiline = true;
            this.textBoxExMessage.Name = "textBoxExMessage";
            this.textBoxExMessage.ReadOnly = true;
            this.textBoxExMessage.Size = new System.Drawing.Size(148, 29);
            this.textBoxExMessage.TabIndex = 4;
            // 
            // textBoxExSteck
            // 
            this.textBoxExSteck.Location = new System.Drawing.Point(0, 293);
            this.textBoxExSteck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExSteck.Multiline = true;
            this.textBoxExSteck.Name = "textBoxExSteck";
            this.textBoxExSteck.ReadOnly = true;
            this.textBoxExSteck.Size = new System.Drawing.Size(148, 29);
            this.textBoxExSteck.TabIndex = 5;
            // 
            // dlgShowExeptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.textBoxExSteck);
            this.Controls.Add(this.textBoxExMessage);
            this.Controls.Add(this.textBoxExSource);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgShowExeptions";
            this.Load += new System.EventHandler(this.dlgShowExeptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxExSource;
        public System.Windows.Forms.TextBox textBoxExMessage;
        public System.Windows.Forms.TextBox textBoxExSteck;
    }
}
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
            this.labelExSource = new System.Windows.Forms.Label();
            this.labelExSteck = new System.Windows.Forms.Label();
            this.labelExMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelExSource
            // 
            this.labelExSource.AutoSize = true;
            this.labelExSource.Location = new System.Drawing.Point(13, 13);
            this.labelExSource.Name = "labelExSource";
            this.labelExSource.Size = new System.Drawing.Size(0, 20);
            this.labelExSource.TabIndex = 1;
            // 
            // labelExSteck
            // 
            this.labelExSteck.AutoSize = true;
            this.labelExSteck.Location = new System.Drawing.Point(12, 87);
            this.labelExSteck.Name = "labelExSteck";
            this.labelExSteck.Size = new System.Drawing.Size(0, 20);
            this.labelExSteck.TabIndex = 2;
            // 
            // labelExMessage
            // 
            this.labelExMessage.AutoSize = true;
            this.labelExMessage.Location = new System.Drawing.Point(12, 226);
            this.labelExMessage.Name = "labelExMessage";
            this.labelExMessage.Size = new System.Drawing.Size(0, 20);
            this.labelExMessage.TabIndex = 3;
            // 
            // dlgShowExeptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.labelExMessage);
            this.Controls.Add(this.labelExSteck);
            this.Controls.Add(this.labelExSource);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgShowExeptions";
            this.Load += new System.EventHandler(this.dlgShowExeptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelExSource;
        public System.Windows.Forms.Label labelExSteck;
        public System.Windows.Forms.Label labelExMessage;
    }
}
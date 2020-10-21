namespace AppErrorForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerateExeptions = new System.Windows.Forms.Button();
            this.buttonShowAbaut = new System.Windows.Forms.Button();
            this.buttonAppClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerateExeptions
            // 
            this.buttonGenerateExeptions.Location = new System.Drawing.Point(22, 32);
            this.buttonGenerateExeptions.Name = "buttonGenerateExeptions";
            this.buttonGenerateExeptions.Size = new System.Drawing.Size(242, 42);
            this.buttonGenerateExeptions.TabIndex = 5;
            this.buttonGenerateExeptions.Text = "Сгенерировать  Исключение";
            this.buttonGenerateExeptions.UseVisualStyleBackColor = true;
            this.buttonGenerateExeptions.Click += new System.EventHandler(this.buttonGenerateExeptions_Click);
            // 
            // buttonShowAbaut
            // 
            this.buttonShowAbaut.Location = new System.Drawing.Point(292, 32);
            this.buttonShowAbaut.Name = "buttonShowAbaut";
            this.buttonShowAbaut.Size = new System.Drawing.Size(160, 42);
            this.buttonShowAbaut.TabIndex = 6;
            this.buttonShowAbaut.Text = "О Программе";
            this.buttonShowAbaut.UseVisualStyleBackColor = true;
            this.buttonShowAbaut.Click += new System.EventHandler(this.buttonShowAbaut_Click);
            // 
            // buttonAppClose
            // 
            this.buttonAppClose.Location = new System.Drawing.Point(482, 32);
            this.buttonAppClose.Name = "buttonAppClose";
            this.buttonAppClose.Size = new System.Drawing.Size(107, 42);
            this.buttonAppClose.TabIndex = 7;
            this.buttonAppClose.Text = "Выйти";
            this.buttonAppClose.UseVisualStyleBackColor = true;
            this.buttonAppClose.Click += new System.EventHandler(this.buttonAppClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 86);
            this.Controls.Add(this.buttonAppClose);
            this.Controls.Add(this.buttonShowAbaut);
            this.Controls.Add(this.buttonGenerateExeptions);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateExeptions;
        private System.Windows.Forms.Button buttonShowAbaut;
        private System.Windows.Forms.Button buttonAppClose;
    }
}


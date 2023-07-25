namespace clock
{
    partial class autor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autor));
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_about_autor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_back.Location = new System.Drawing.Point(16, 193);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(449, 29);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Вернуться в предыдущую форму";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_about_autor
            // 
            this.textBox_about_autor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_about_autor.HideSelection = false;
            this.textBox_about_autor.Location = new System.Drawing.Point(97, 12);
            this.textBox_about_autor.Multiline = true;
            this.textBox_about_autor.Name = "textBox_about_autor";
            this.textBox_about_autor.ReadOnly = true;
            this.textBox_about_autor.ShortcutsEnabled = false;
            this.textBox_about_autor.Size = new System.Drawing.Size(297, 151);
            this.textBox_about_autor.TabIndex = 3;
            this.textBox_about_autor.TabStop = false;
            this.textBox_about_autor.Text = "Алексей Чёрный       Выполнил лабораторную работу №6                          Жив" +
    ", здоров";
            // 
            // autor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 240);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_about_autor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "autor";
            this.Text = "autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_about_autor;
    }
}
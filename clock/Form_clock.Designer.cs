namespace clock
{
    partial class Form_clock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_clock));
            this.button_autor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_setting = new System.Windows.Forms.Button();
            this.button_save_settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_autor
            // 
            this.button_autor.Location = new System.Drawing.Point(12, 477);
            this.button_autor.Name = "button_autor";
            this.button_autor.Size = new System.Drawing.Size(103, 40);
            this.button_autor.TabIndex = 0;
            this.button_autor.Text = "Об авторе";
            this.button_autor.UseVisualStyleBackColor = true;
            this.button_autor.Click += new System.EventHandler(this.button_autor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_setting
            // 
            this.button_setting.Location = new System.Drawing.Point(130, 477);
            this.button_setting.Name = "button_setting";
            this.button_setting.Size = new System.Drawing.Size(103, 40);
            this.button_setting.TabIndex = 1;
            this.button_setting.Text = "Настройки";
            this.button_setting.UseVisualStyleBackColor = true;
            this.button_setting.Click += new System.EventHandler(this.button_setting_Click);
            // 
            // button_save_settings
            // 
            this.button_save_settings.Location = new System.Drawing.Point(245, 477);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(232, 40);
            this.button_save_settings.TabIndex = 3;
            this.button_save_settings.Text = "Сохранить текущие настройки";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // Form_clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 531);
            this.Controls.Add(this.button_save_settings);
            this.Controls.Add(this.button_setting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_autor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_clock";
            this.Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_autor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_setting;
        private System.Windows.Forms.Button button_save_settings;
    }
}


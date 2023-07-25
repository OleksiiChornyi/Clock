namespace clock
{
    partial class Digital_clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Digital_clock));
            this.label1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.button_save_settings = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_autor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // t
            // 
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // button_save_settings
            // 
            this.button_save_settings.Location = new System.Drawing.Point(113, 107);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(239, 35);
            this.button_save_settings.TabIndex = 1;
            this.button_save_settings.Text = "Сохранить текущие настройки";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_settings_Click);
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(2, 107);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(105, 35);
            this.button_settings.TabIndex = 2;
            this.button_settings.Text = "Настойки";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_autor
            // 
            this.button_autor.Location = new System.Drawing.Point(358, 107);
            this.button_autor.Name = "button_autor";
            this.button_autor.Size = new System.Drawing.Size(135, 35);
            this.button_autor.TabIndex = 4;
            this.button_autor.Text = "Об авторе";
            this.button_autor.UseVisualStyleBackColor = true;
            this.button_autor.Click += new System.EventHandler(this.button_autor_Click);
            // 
            // Digital_clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(497, 143);
            this.Controls.Add(this.button_autor);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_save_settings);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Digital_clock";
            this.Text = "Digital_clock";
            this.Load += new System.EventHandler(this.Digital_clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_autor;
    }
}
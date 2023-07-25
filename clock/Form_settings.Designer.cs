namespace clock
{
    partial class Form_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_settings));
            this.button_show_clock = new System.Windows.Forms.Button();
            this.radioButton_analog = new System.Windows.Forms.RadioButton();
            this.radioButton_digital = new System.Windows.Forms.RadioButton();
            this.groupBox_radiobutton = new System.Windows.Forms.GroupBox();
            this.groupBox_color = new System.Windows.Forms.GroupBox();
            this.button_color_clock = new System.Windows.Forms.Button();
            this.button_color_arrow_s = new System.Windows.Forms.Button();
            this.button_color_arrow_m = new System.Windows.Forms.Button();
            this.button_color_arrow_h = new System.Windows.Forms.Button();
            this.comboBox_clock = new System.Windows.Forms.ComboBox();
            this.groupBox_all_data = new System.Windows.Forms.GroupBox();
            this.radioButton_no_data = new System.Windows.Forms.RadioButton();
            this.radioButton_data = new System.Windows.Forms.RadioButton();
            this.button_autor = new System.Windows.Forms.Button();
            this.groupBox_size = new System.Windows.Forms.GroupBox();
            this.label_height = new System.Windows.Forms.Label();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.label_width = new System.Windows.Forms.Label();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.button_save_settings = new System.Windows.Forms.Button();
            this.button_save_standart_settings = new System.Windows.Forms.Button();
            this.groupBox_radiobutton.SuspendLayout();
            this.groupBox_color.SuspendLayout();
            this.groupBox_all_data.SuspendLayout();
            this.groupBox_size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            this.SuspendLayout();
            // 
            // button_show_clock
            // 
            this.button_show_clock.Location = new System.Drawing.Point(635, 230);
            this.button_show_clock.Name = "button_show_clock";
            this.button_show_clock.Size = new System.Drawing.Size(135, 40);
            this.button_show_clock.TabIndex = 0;
            this.button_show_clock.Text = "Показать часы";
            this.button_show_clock.UseVisualStyleBackColor = true;
            this.button_show_clock.Click += new System.EventHandler(this.button_show_clock_Click);
            // 
            // radioButton_analog
            // 
            this.radioButton_analog.AutoSize = true;
            this.radioButton_analog.Location = new System.Drawing.Point(6, 30);
            this.radioButton_analog.Name = "radioButton_analog";
            this.radioButton_analog.Size = new System.Drawing.Size(145, 21);
            this.radioButton_analog.TabIndex = 1;
            this.radioButton_analog.TabStop = true;
            this.radioButton_analog.Text = "Аналоговые часы";
            this.radioButton_analog.UseVisualStyleBackColor = true;
            this.radioButton_analog.CheckedChanged += new System.EventHandler(this.radioButton_analog_CheckedChanged);
            // 
            // radioButton_digital
            // 
            this.radioButton_digital.AutoSize = true;
            this.radioButton_digital.Location = new System.Drawing.Point(6, 69);
            this.radioButton_digital.Name = "radioButton_digital";
            this.radioButton_digital.Size = new System.Drawing.Size(137, 21);
            this.radioButton_digital.TabIndex = 2;
            this.radioButton_digital.TabStop = true;
            this.radioButton_digital.Text = "Цифровые часы";
            this.radioButton_digital.UseVisualStyleBackColor = true;
            this.radioButton_digital.CheckedChanged += new System.EventHandler(this.radioButton_digital_CheckedChanged);
            // 
            // groupBox_radiobutton
            // 
            this.groupBox_radiobutton.Controls.Add(this.radioButton_analog);
            this.groupBox_radiobutton.Controls.Add(this.radioButton_digital);
            this.groupBox_radiobutton.Location = new System.Drawing.Point(12, 12);
            this.groupBox_radiobutton.Name = "groupBox_radiobutton";
            this.groupBox_radiobutton.Size = new System.Drawing.Size(200, 111);
            this.groupBox_radiobutton.TabIndex = 3;
            this.groupBox_radiobutton.TabStop = false;
            this.groupBox_radiobutton.Text = "Выбрать вид часов";
            // 
            // groupBox_color
            // 
            this.groupBox_color.Controls.Add(this.button_color_clock);
            this.groupBox_color.Controls.Add(this.button_color_arrow_s);
            this.groupBox_color.Controls.Add(this.button_color_arrow_m);
            this.groupBox_color.Controls.Add(this.button_color_arrow_h);
            this.groupBox_color.Location = new System.Drawing.Point(264, 12);
            this.groupBox_color.Name = "groupBox_color";
            this.groupBox_color.Size = new System.Drawing.Size(162, 300);
            this.groupBox_color.TabIndex = 4;
            this.groupBox_color.TabStop = false;
            this.groupBox_color.Text = "Выбрать цвет часов";
            // 
            // button_color_clock
            // 
            this.button_color_clock.Location = new System.Drawing.Point(6, 228);
            this.button_color_clock.Name = "button_color_clock";
            this.button_color_clock.Size = new System.Drawing.Size(137, 60);
            this.button_color_clock.TabIndex = 7;
            this.button_color_clock.Text = "Выбрать цвет циферблата";
            this.button_color_clock.UseVisualStyleBackColor = true;
            this.button_color_clock.Click += new System.EventHandler(this.button_color_clock_Click);
            // 
            // button_color_arrow_s
            // 
            this.button_color_arrow_s.Location = new System.Drawing.Point(6, 162);
            this.button_color_arrow_s.Name = "button_color_arrow_s";
            this.button_color_arrow_s.Size = new System.Drawing.Size(137, 60);
            this.button_color_arrow_s.TabIndex = 2;
            this.button_color_arrow_s.Text = "Выбрать цвет секундной стрелки";
            this.button_color_arrow_s.UseVisualStyleBackColor = true;
            this.button_color_arrow_s.Click += new System.EventHandler(this.button_color_arrow_s_Click);
            // 
            // button_color_arrow_m
            // 
            this.button_color_arrow_m.Location = new System.Drawing.Point(6, 96);
            this.button_color_arrow_m.Name = "button_color_arrow_m";
            this.button_color_arrow_m.Size = new System.Drawing.Size(137, 60);
            this.button_color_arrow_m.TabIndex = 1;
            this.button_color_arrow_m.Text = "Выбрать цвет минутной стрелки";
            this.button_color_arrow_m.UseVisualStyleBackColor = true;
            this.button_color_arrow_m.Click += new System.EventHandler(this.button_color_arrow_m_Click);
            // 
            // button_color_arrow_h
            // 
            this.button_color_arrow_h.Location = new System.Drawing.Point(6, 30);
            this.button_color_arrow_h.Name = "button_color_arrow_h";
            this.button_color_arrow_h.Size = new System.Drawing.Size(137, 60);
            this.button_color_arrow_h.TabIndex = 0;
            this.button_color_arrow_h.Text = "Выбрать цвет часовой стрелки";
            this.button_color_arrow_h.UseVisualStyleBackColor = true;
            this.button_color_arrow_h.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_clock
            // 
            this.comboBox_clock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clock.FormattingEnabled = true;
            this.comboBox_clock.Items.AddRange(new object[] {
            "Показывать штрихи и цифры (3, 6, 9, 12)",
            "Показывать все цифры",
            "Показывать только цифры 3, 6, 9, 12"});
            this.comboBox_clock.Location = new System.Drawing.Point(6, 57);
            this.comboBox_clock.Name = "comboBox_clock";
            this.comboBox_clock.Size = new System.Drawing.Size(306, 24);
            this.comboBox_clock.TabIndex = 0;
            // 
            // groupBox_all_data
            // 
            this.groupBox_all_data.Controls.Add(this.comboBox_clock);
            this.groupBox_all_data.Controls.Add(this.radioButton_no_data);
            this.groupBox_all_data.Controls.Add(this.radioButton_data);
            this.groupBox_all_data.Location = new System.Drawing.Point(442, 12);
            this.groupBox_all_data.Name = "groupBox_all_data";
            this.groupBox_all_data.Size = new System.Drawing.Size(328, 111);
            this.groupBox_all_data.TabIndex = 6;
            this.groupBox_all_data.TabStop = false;
            this.groupBox_all_data.Text = "Вид циферблата";
            // 
            // radioButton_no_data
            // 
            this.radioButton_no_data.AutoSize = true;
            this.radioButton_no_data.Location = new System.Drawing.Point(144, 30);
            this.radioButton_no_data.Name = "radioButton_no_data";
            this.radioButton_no_data.Size = new System.Drawing.Size(128, 21);
            this.radioButton_no_data.TabIndex = 1;
            this.radioButton_no_data.TabStop = true;
            this.radioButton_no_data.Text = "Не показывать";
            this.radioButton_no_data.UseVisualStyleBackColor = true;
            this.radioButton_no_data.CheckedChanged += new System.EventHandler(this.radioButton_no_data_CheckedChanged);
            // 
            // radioButton_data
            // 
            this.radioButton_data.AutoSize = true;
            this.radioButton_data.Location = new System.Drawing.Point(15, 30);
            this.radioButton_data.Name = "radioButton_data";
            this.radioButton_data.Size = new System.Drawing.Size(108, 21);
            this.radioButton_data.TabIndex = 0;
            this.radioButton_data.TabStop = true;
            this.radioButton_data.Text = "Показывать";
            this.radioButton_data.UseVisualStyleBackColor = true;
            this.radioButton_data.CheckedChanged += new System.EventHandler(this.radioButton_data_CheckedChanged);
            // 
            // button_autor
            // 
            this.button_autor.Location = new System.Drawing.Point(457, 230);
            this.button_autor.Name = "button_autor";
            this.button_autor.Size = new System.Drawing.Size(135, 40);
            this.button_autor.TabIndex = 3;
            this.button_autor.Text = "Об авторе";
            this.button_autor.UseVisualStyleBackColor = true;
            this.button_autor.Click += new System.EventHandler(this.button_autor_Click);
            // 
            // groupBox_size
            // 
            this.groupBox_size.Controls.Add(this.label_height);
            this.groupBox_size.Controls.Add(this.numericUpDown_height);
            this.groupBox_size.Controls.Add(this.label_width);
            this.groupBox_size.Controls.Add(this.numericUpDown_width);
            this.groupBox_size.Location = new System.Drawing.Point(18, 129);
            this.groupBox_size.Name = "groupBox_size";
            this.groupBox_size.Size = new System.Drawing.Size(240, 105);
            this.groupBox_size.TabIndex = 8;
            this.groupBox_size.TabStop = false;
            this.groupBox_size.Text = "Выберете размер циферблата";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(9, 54);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(57, 17);
            this.label_height.TabIndex = 3;
            this.label_height.Text = "Высота";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Location = new System.Drawing.Point(80, 54);
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Size = new System.Drawing.Size(105, 22);
            this.numericUpDown_height.TabIndex = 2;
            this.numericUpDown_height.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(6, 28);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(59, 17);
            this.label_width.TabIndex = 1;
            this.label_width.Text = "Ширина";
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Location = new System.Drawing.Point(80, 26);
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Size = new System.Drawing.Size(105, 22);
            this.numericUpDown_width.TabIndex = 0;
            this.numericUpDown_width.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // button_save_settings
            // 
            this.button_save_settings.Location = new System.Drawing.Point(457, 137);
            this.button_save_settings.Name = "button_save_settings";
            this.button_save_settings.Size = new System.Drawing.Size(313, 40);
            this.button_save_settings.TabIndex = 9;
            this.button_save_settings.Text = "Сохранить текущие настройки часов";
            this.button_save_settings.UseVisualStyleBackColor = true;
            this.button_save_settings.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_save_standart_settings
            // 
            this.button_save_standart_settings.Location = new System.Drawing.Point(457, 184);
            this.button_save_standart_settings.Name = "button_save_standart_settings";
            this.button_save_standart_settings.Size = new System.Drawing.Size(313, 40);
            this.button_save_standart_settings.TabIndex = 10;
            this.button_save_standart_settings.Text = "Сохранить стандартные настройки часов";
            this.button_save_standart_settings.UseVisualStyleBackColor = true;
            this.button_save_standart_settings.Click += new System.EventHandler(this.button_save_standart_settings_Click);
            // 
            // Form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(809, 323);
            this.Controls.Add(this.button_save_standart_settings);
            this.Controls.Add(this.button_save_settings);
            this.Controls.Add(this.groupBox_size);
            this.Controls.Add(this.button_autor);
            this.Controls.Add(this.groupBox_all_data);
            this.Controls.Add(this.groupBox_color);
            this.Controls.Add(this.groupBox_radiobutton);
            this.Controls.Add(this.button_show_clock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_settings";
            this.Text = "Настройка часов";
            this.groupBox_radiobutton.ResumeLayout(false);
            this.groupBox_radiobutton.PerformLayout();
            this.groupBox_color.ResumeLayout(false);
            this.groupBox_all_data.ResumeLayout(false);
            this.groupBox_all_data.PerformLayout();
            this.groupBox_size.ResumeLayout(false);
            this.groupBox_size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_show_clock;
        private System.Windows.Forms.RadioButton radioButton_analog;
        private System.Windows.Forms.RadioButton radioButton_digital;
        private System.Windows.Forms.GroupBox groupBox_radiobutton;
        private System.Windows.Forms.GroupBox groupBox_color;
        private System.Windows.Forms.Button button_color_arrow_h;
        private System.Windows.Forms.ComboBox comboBox_clock;
        private System.Windows.Forms.GroupBox groupBox_all_data;
        private System.Windows.Forms.RadioButton radioButton_no_data;
        private System.Windows.Forms.RadioButton radioButton_data;
        private System.Windows.Forms.Button button_autor;
        private System.Windows.Forms.Button button_color_arrow_s;
        private System.Windows.Forms.Button button_color_arrow_m;
        private System.Windows.Forms.Button button_color_clock;
        private System.Windows.Forms.GroupBox groupBox_size;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Button button_save_settings;
        private System.Windows.Forms.Button button_save_standart_settings;
    }
}
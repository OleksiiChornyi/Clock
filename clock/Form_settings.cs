using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clock
{
    public partial class Form_settings : Form
    {
        /// <summary>
        /// Цвета для выбора
        /// </summary>
        Color color_arrow_h = Color.Black, color_clock = Color.Black, color_arrow_m = Color.Black, color_arrow_s = Color.Coral;
        /// <summary>
        /// Выводить ли дату
        /// </summary>
        bool data = true;
        /// <summary>
        /// какой вид часов использовть
        /// </summary>
        int clock;
        /// <summary>
        /// Загрузка формы
        /// </summary>
        public Form_settings()
        {
            InitializeComponent();
            comboBox_clock.SelectedIndex = 0;
            radioButton_analog.Select();
            radioButton_data.Select();
            radioButton_data.Visible = false;
            radioButton_no_data.Visible = false;
            groupBox_color.Height = 250;
        }
        /// <summary>
        /// Выбор цвета для часовой стрелки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.ShowDialog();
            color_arrow_h = colorDialog.Color;
        }
        /// <summary>
        /// Выбор цвета для минутной стрелки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_color_arrow_m_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.ShowDialog();
            color_arrow_m = colorDialog.Color;
        }
        /// <summary>
        /// Выбор цвета для секундной стрелки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_color_arrow_s_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.ShowDialog();
            color_arrow_s = colorDialog.Color;
        }
        /// <summary>
        /// Выбор цвета для циферблата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_color_clock_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.ShowDialog();
            color_clock = colorDialog.Color;
        }
        /// <summary>
        /// Выбор выводить дату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_data_CheckedChanged(object sender, EventArgs e)
        {
            data = true;
        }
        /// <summary>
        /// Выбор не выводить дату
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_no_data_CheckedChanged(object sender, EventArgs e)
        {
            data = false;
        }
        /// <summary>
        /// Информация об авторе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_autor_Click(object sender, EventArgs e)
        {
            autor autor = new autor();
            autor.ShowDialog();
        }
        /// <summary>
        /// Сохранить текущие настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_Click(object sender, EventArgs e)
        {
            string Fname;
            string s;
            s = "Время сохранения: " + DateTime.Now.ToString() + "\n";
            s += "Вид часов: ";
            if (clock == 0)
            {
                s += "Круглые" + "\n";
                s += "Цвет циферблата: " ;
                s += color_clock.ToString() + "\n";
                s += "Цвет часовой стреки: ";
                s += color_arrow_h.ToString() + "\n";
                s += "Цвет минутной стрелки: ";
                s += color_arrow_m.ToString() + "\n";
                s += "Цвет секундной стрелки: ";
                s += color_arrow_s.ToString() + "\n";
                s += "Вид циферблата: ";
                s += comboBox_clock.Text + "\n";
            }
            else
            {
                s += "Цифровые" + "\n";
                s += "Цвет фона: ";
                s += color_clock.ToString() + "\n";
                s += "Цвет цифр: ";
                s += color_arrow_h.ToString() + "\n";
                if(data)
                    s += "Показывать дату" + "\n";
                else
                    s += "Не показывать дату" + "\n";
            }
            s += "Ширина часов: ";
            s += numericUpDown_width.Value + "\n";
            s += "Высота часов: ";
            s += numericUpDown_height.Value + "\n";
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"С:\";
            save.Filter = "txt files (*.txt)|*.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранить файл как";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Fname = save.FileName;
                StreamWriter SW = new StreamWriter(new FileStream(Fname, FileMode.Create, FileAccess.Write));
                SW.Write(s);
                SW.Close();
                MessageBox.Show("Файл сохранен с именем " + Fname);
            }
        }
        /// <summary>
        /// Сохранить стандартные настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_standart_settings_Click(object sender, EventArgs e)
        {
            string Fname;
            string s;
            s = "Время сохранения: " + DateTime.Now.ToString() + "\n\n";
            s += "Вид часов: ";
            s += "Круглые" + "\n";
            s += "Цвет циферблата: ";
            s += Color.Black.ToString() + "\n";
            s += "Цвет часовой стреки: ";
            s += Color.Black.ToString() + "\n";
            s += "Цвет минутной стрелки: ";
            s += Color.Black.ToString() + "\n";
            s += "Цвет секундной стрелки: ";
            s += Color.Coral.ToString() + "\n";
            s += "Вид циферблата: ";
            s += "Показывать штрихи и цифры (3, 6, 9, 12)" + "\n";
            s += "Ширина часов: ";
            s += "300" + "\n";
            s += "Высота часов: ";
            s += "300" + "\n";
            s += "\n" + "Вид часов: ";
            s += "Цифровые" + "\n";
            s += "Цвет фона: ";
            s += Color.White.ToString() + "\n";
            s += "Цвет цифр: ";
            s += Color.Black.ToString() + "\n";
            s += "Показывать дату" + "\n";
            s += "Ширина часов: ";
            s += "300" + "\n";
            s += "Высота часов: ";
            s += "300" + "\n";
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"С:\";
            save.Filter = "txt files (*.txt)|*.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранить файл как";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Fname = save.FileName;
                StreamWriter SW = new StreamWriter(new FileStream(Fname, FileMode.Create, FileAccess.Write));
                SW.Write(s);
                SW.Close();
                MessageBox.Show("Файл сохранен с именем " + Fname);
            }
        }
        /// <summary>
        /// Показать часы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_show_clock_Click(object sender, EventArgs e)
        {
            Form_clock f1;
            switch (clock)
            {
                case 0:
                    f1 = new Form_clock((int)numericUpDown_width.Value, (int)numericUpDown_height.Value, color_clock, color_arrow_h, color_arrow_m, color_arrow_s, comboBox_clock.SelectedIndex);
                    ActiveForm.Close();
                    f1.Show();
                    break;
                case 1:
                    if (color_arrow_h == color_arrow_m)
                    {
                        MessageBox.Show("Цвет фона и цифр одинаков!\nЧасы не будет видно!");
                    }
                    else
                    {
                        Digital_clock f2 = new Digital_clock((int)numericUpDown_width.Value, (int)numericUpDown_height.Value, color_arrow_h, color_arrow_m, data);
                        ActiveForm.Close();
                        f2.Show();
                    }
                    break;
                default:
                    f1 = new Form_clock((int)numericUpDown_width.Value, (int)numericUpDown_height.Value, color_clock, color_arrow_h, color_arrow_m, color_arrow_s, comboBox_clock.SelectedIndex);
                    ActiveForm.Close();
                    f1.Show();
                    break;
            }
        }
        /// <summary>
        /// Выбор круглых часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_analog_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_all_data.Text = "Вид циферблата";
            clock = 0;
            comboBox_clock.Visible = true;
            radioButton_data.Visible = false;
            radioButton_no_data.Visible = false;
            button_color_arrow_s.Visible = true;
            button_color_clock.Visible = true;
            button_color_arrow_h.Text = "Выбрать цвет часовой стрелки";
            button_color_arrow_m.Text = "Выбрать цвет минутной стрелки";
            color_arrow_h = Color.Black;
            color_arrow_m = Color.Black;
            groupBox_color.Height = 250;
        }
        /// <summary>
        /// Выбор цифровых часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_digital_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_all_data.Text = "Показывать дату?";
            clock = 1;
            comboBox_clock.Visible = false;
            radioButton_data.Visible = true;
            radioButton_no_data.Visible = true;
            button_color_arrow_s.Visible = false;
            button_color_clock.Visible = false;
            button_color_arrow_h.Text = "Выбрать цвет фона";
            button_color_arrow_m.Text = "Выбрать цвет цифр";
            color_arrow_h = Color.White;
            color_arrow_m = Color.Black;
            groupBox_color.Height = 150;
        }
    }
}

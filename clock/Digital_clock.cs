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
    public partial class Digital_clock : Form
    {
        /// <summary>
        /// wight - ширина часов
        /// height - высота часов
        /// </summary>
        int wight, height;
        /// <summary>
        /// Цвета для часов
        /// </summary>
        Color color_form, color_time;
        /// <summary>
        /// Выводить ли дату
        /// </summary>
        bool data;
        /// <summary>
        /// Кнопка сохранения настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void button_save_settings_Click(object sender, EventArgs e)
        {
            string Fname;
            string s;
            s = "Время сохранения: " + DateTime.Now.ToString() + "\n";
            s += "Вид часов: ";
            s += "Цифровые" + "\n";
            s += "Цвет фона: ";
            s += color_form.ToString() + "\n";
            s += "Цвет цифр: ";
            s += color_time.ToString() + "\n";
            if (data)
                s += "Показывать дату" + "\n";
            else
                s += "Не показывать дату" + "\n";
            s += "Ширина часов: ";
            s += wight + "\n";
            s += "Высота часов: ";
            s += height + "\n";
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
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Digital_clock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        /// <summary>
        /// Настройки часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_settings_Click(object sender, EventArgs e)
        {
            Form_settings dc = new Form_settings();
            ActiveForm.Hide();
            dc.Show();
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
        /// Загрузка формы
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="color_f"></param>
        /// <param name="color_t"></param>
        /// <param name="d"></param>
        public Digital_clock(int w, int h, Color color_f, Color color_t, bool d)
        {
            InitializeComponent();
            wight = w;
            height = h;
            color_form = color_f;
            color_time = color_t;
            data = d;
            this.BackColor = Color.White;
        }
        /// <summary>
        /// Тик таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_Tick(object sender, EventArgs e)
        {
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            label1.Text = "";
            label1.Size = new Size(wight, height);
            label1.BackColor = color_form;
            label1.Font = new Font("Times New Roman", wight / 20 + 10, FontStyle.Regular);
            if (data)
            {
                if (DateTime.Now.Day < 10)
                    label1.Text = "0" + DateTime.Now.Day;
                else
                    label1.Text = DateTime.Now.Day.ToString();
                if (DateTime.Now.Month < 10)
                    label1.Text += ":0" + DateTime.Now.Month.ToString();
                else
                    label1.Text += ":" + DateTime.Now.Month.ToString();
                label1.Text += ":" + DateTime.Now.Year.ToString() + "\n";
            }
            label1.ForeColor = color_time;
            if (hh < 10)
                label1.Text += "0" + hh + ":";
            else
                label1.Text += hh + ":";
            if (mm < 10)
                label1.Text += "0" + mm + ":";
            else
                label1.Text += mm + ":";
            if (ss < 10)
                label1.Text += "0" + ss;
            else
                label1.Text += ss;
            button_settings.Location = new Point(2, label1.Location.Y + label1.Size.Height + 5);
            button_save_settings.Location = new Point(113, label1.Location.Y + label1.Size.Height + 5);
            button_autor.Location = new Point(358, label1.Location.Y + label1.Size.Height + 5);
        }
    }
}

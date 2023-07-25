using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form_clock : Form
    {
        /// <summary>
        /// widht - ширина часов
        /// height - высота часов
        /// </summary>
        int width = 300, height = 300;
        /// <summary>
        /// c_x - центр по оси х
        /// x_y - центр по оси y
        /// is_shtrich - вариант циферблата
        /// </summary>
        int c_x = 150, c_y = 150, is_shtrich = 0;
        /// <summary>
        /// цвета стрелок и циферблата
        /// </summary>
        Color color_arrow_h = Color.Black, color_clock = Color.Black, color_arrow_m = Color.Black, color_arrow_s = Color.Coral;

        /// <summary>
        /// отрисовка часов
        /// </summary>
        Bitmap bmp;
        /// <summary>
        /// Отрисовка часов
        /// </summary>
        Graphics g;
        /// <summary>
        /// Шрифт для цифр на часах
        /// </summary>
        Font font = new Font("Times New Roman", 14, FontStyle.Regular);
        /// <summary>
        /// Загрузка формы
        /// </summary>
        public Form_clock()
        {
            InitializeComponent();
            bmp = new Bitmap(width + 1, height + 1);
            this.BackColor = Color.White;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(this.t_Tick);
            timer1.Start();
        }
        /// <summary>
        /// Загрузка формы с изменениями
        /// </summary>
        /// <param name="width_c"></param>
        /// <param name="height_c"></param>
        /// <param name="color_c"></param>
        /// <param name="color_h"></param>
        /// <param name="color_m"></param>
        /// <param name="color_s"></param>
        /// <param name="shtrich"></param>
        public Form_clock(int width_c, int height_c, Color color_c, Color color_h, Color color_m, Color color_s, int shtrich)
        {
            InitializeComponent();
            width = width_c;
            height = height_c;
            c_x = width_c / 2;
            c_y = height_c / 2;
            pictureBox1.Size = new Size(width, height);
            is_shtrich = shtrich;
            color_clock = color_c;
            color_arrow_h = color_h;
            color_arrow_m = color_m;
            color_arrow_s = color_s;
            bmp = new Bitmap(width + 1, height + 1);
            button_autor.Location = new Point(12, height + 28);
            button_setting.Location = new Point(130,height + 28);
            button_save_settings.Location = new Point(245, height + 28);
            this.BackColor = Color.White;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(this.t_Tick);
            timer1.Start();
        }
        /// <summary>
        /// Сохранение настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_settings_Click(object sender, EventArgs e)
        {
            string Fname;
            string s;
            s = "Время сохранения: " + DateTime.Now.ToString() + "\n";
            s += "Вид часов: ";
                s += "Круглые" + "\n";
                s += "Цвет циферблата: ";
                s += color_clock.ToString() + "\n";
                s += "Цвет часовой стреки: ";
                s += color_arrow_h.ToString() + "\n";
                s += "Цвет минутной стрелки: ";
                s += color_arrow_m.ToString() + "\n";
                s += "Цвет секундной стрелки: ";
                s += color_arrow_s.ToString() + "\n";
                s += "Вид циферблата: ";
            switch(is_shtrich)
            {
                case 0:
                    s += "Показывать штрихи и цифры (3, 6, 9, 12)" + "\n";
                    break;
                case 1:
                    s += "Показывать все цифры" + "\n";
                    break;
                case 2:
                    s += "Показывать только цифры 3, 6, 9, 12" + "\n";
                    break;
            }            
            s += "Ширина часов: ";
            s += width + "\n";
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
        /// Тик таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            int[] coordinate;
            int[] strih;
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(color_clock, 2), 0, 0, width, height);
            switch (is_shtrich)
            {
                case 0:
                    strih = Shtrich(60);
                    g.DrawString("12", font, Brushes.Black, strih[0] - 10, strih[1] + 2);
                    strih = Shtrich(15);
                    g.DrawString("3", font, Brushes.Black, strih[0] - 14, strih[1] - 10);
                    strih = Shtrich(30);
                    g.DrawString("6", font, Brushes.Black, strih[0] - 8, strih[1] - 18);
                    strih = Shtrich(45);
                    g.DrawString("9", font, Brushes.Black, strih[0], strih[1] - 10);
                    coordinate = Sec_Min(5);
                    strih = Shtrich(5);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//1
                    coordinate = Sec_Min(10);
                    strih = Shtrich(10);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//2
                    coordinate = Sec_Min(20);
                    strih = Shtrich(20);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//4
                    coordinate = Sec_Min(25);
                    strih = Shtrich(25);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//5
                    coordinate = Sec_Min(35);
                    strih = Shtrich(35);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//7
                    coordinate = Sec_Min(40);
                    strih = Shtrich(40);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//8
                    coordinate = Sec_Min(50);
                    strih = Shtrich(50);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//10
                    coordinate = Sec_Min(55);
                    strih = Shtrich(55);
                    g.DrawLine(new Pen(color_clock, 3), coordinate[0], coordinate[1], strih[0], strih[1]);//11
                    break;
                case 1:
                    strih = Shtrich(60);
                    g.DrawString("12", font, Brushes.Black, strih[0] - 10, strih[1] + 2);
                    strih = Shtrich(15);
                    g.DrawString("3", font, Brushes.Black, strih[0] - 14, strih[1] - 10);
                    strih = Shtrich(30);
                    g.DrawString("6", font, Brushes.Black, strih[0] - 8, strih[1] - 18);
                    strih = Shtrich(45);
                    g.DrawString("9", font, Brushes.Black, strih[0], strih[1] - 10);
                    strih = Shtrich(5);
                    g.DrawString("1", font, Brushes.Black, strih[0] - 8, strih[1]-3);//1
                    strih = Shtrich(10);
                    g.DrawString("2", font, Brushes.Black, strih[0] - 10, strih[1]-4);//2
                    strih = Shtrich(20);
                    g.DrawString("4", font, Brushes.Black, strih[0] - 16, strih[1]-12);//4
                    strih = Shtrich(25);
                    g.DrawString("5", font, Brushes.Black, strih[0]-8, strih[1]-17);//5
                    strih = Shtrich(35);
                    g.DrawString("7", font, Brushes.Black, strih[0], strih[1]-16);//7
                    strih = Shtrich(40);
                    g.DrawString("8", font, Brushes.Black, strih[0], strih[1]-12);//8
                    strih = Shtrich(50);
                    g.DrawString("10", font, Brushes.Black, strih[0]-2, strih[1]-2);//10
                    strih = Shtrich(55);
                    g.DrawString("11", font, Brushes.Black, strih[0]-3, strih[1]);//11
                    break;
                case 2:
                    strih = Shtrich(60);
                    g.DrawString("12", font, Brushes.Black, strih[0] - 10, strih[1] + 2);                    
                    strih = Shtrich(15);
                    g.DrawString("3", font, Brushes.Black, strih[0] - 14, strih[1] - 10);
                    strih = Shtrich(30);
                    g.DrawString("6", font, Brushes.Black, strih[0] - 8, strih[1] - 18);
                    strih = Shtrich(45);
                    g.DrawString("9", font, Brushes.Black, strih[0], strih[1] - 10);
                    break;
                default:
                    break;
            }
            coordinate = Sec_Min(ss);
            g.DrawLine(new Pen(color_arrow_s, 1), c_x, c_y, coordinate[0], coordinate[1]);

            coordinate = Sec_Min(mm);
            g.DrawLine(new Pen(color_arrow_m, 3), c_x, c_y, coordinate[0], coordinate[1]);

            coordinate = Hour(hh, mm);
            g.DrawLine(new Pen(color_arrow_h, 4), c_x, c_y, coordinate[0], coordinate[1]);
            pictureBox1.Image = bmp;
            g.Dispose();
        }
        /// <summary>
        /// Расчёт координат часовой стрелки
        /// </summary>
        /// <param name="hh"></param>
        /// <param name="mm"></param>
        /// <returns></returns>
        public int[] Hour(int hh, int mm)
        {
            int[] coordinate = new int[2];
            int hour = (int)(((hh % 12) * 30) + (mm * 0.5));
            if (hour >= 0 && hour <= 180)
            {
                coordinate[0] = c_x + (int)((width / 2 - width / 5) * Math.Sin(Math.PI * hour / 180));
                coordinate[1] = c_y - (int)((height / 2 - height / 5) * Math.Cos(Math.PI * hour / 180));
            }
            else
            {
                coordinate[0] = c_x - (int)((width / 2 - width / 5) * -Math.Sin(Math.PI * hour / 180));
                coordinate[1] = c_y - (int)((height / 2 - height / 5) * Math.Cos(Math.PI * hour / 180));
            }
            return coordinate;
        }
        /// <summary>
        /// Расчёт координат минутной и секундной стрелок
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int[] Sec_Min(int time)
        {
            int[] coordinate = new int[2];
            int sec = time * 6;
            if (sec >= 0 && sec <= 180)
            {
                coordinate[0] = c_x + (int)((width / 2 - 10) * Math.Sin(Math.PI * sec / 180));
                coordinate[1] = c_y - (int)((height / 2 - 10) * Math.Cos(Math.PI * sec / 180));
            }
            else
            {
                coordinate[0] = c_x - (int)((width /2 - 10) * -Math.Sin(Math.PI * sec / 180));
                coordinate[1] = c_y - (int)((height / 2 - 10) * Math.Cos(Math.PI * sec / 180));
            }
            return coordinate;
        }
        /// <summary>
        /// Открытие настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_setting_Click(object sender, EventArgs e)
        {
            Form_settings dc = new Form_settings();
            ActiveForm.Hide();
            dc.Show();
        }
        /// <summary>
        /// Расчет координат штрихов и цифр на циферблате
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int[] Shtrich(int time)
        {
            int[] coordinate = new int[2];
            int sec = time * 6;
            if (sec >= 0 && sec <= 180)
            {
                coordinate[0] = c_x + (int)((width /2) * Math.Sin(Math.PI * sec / 180));
                coordinate[1] = c_y - (int)((height /2) * Math.Cos(Math.PI * sec / 180));
            }
            else
            {
                coordinate[0] = c_x - (int)((width /2) * -Math.Sin(Math.PI * sec / 180));
                coordinate[1] = c_y - (int)((height /2) * Math.Cos(Math.PI * sec / 180));
            }
            return coordinate;
        }
    }
}

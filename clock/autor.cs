using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class autor : Form
    {
        /// <summary>
        /// Загрузка формы
        /// </summary>
        public autor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Возврат на предыдущую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_back_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}

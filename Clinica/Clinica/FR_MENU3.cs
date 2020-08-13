using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FR_MENU3 : Form
    {
        public FR_MENU3()
        {
            InitializeComponent();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            FR_PERSONAL usu = new FR_PERSONAL();
            usu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_PERSONAL2 usu = new FR_PERSONAL2();
            usu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_PERSONAL3 usu = new FR_PERSONAL3();
            usu.Show();
        }
    }
}

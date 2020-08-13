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
    public partial class FR_MENU2 : Form
    {
        public FR_MENU2()
        {
            InitializeComponent();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            FR_DOCTOR usu = new FR_DOCTOR();
            usu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_DOCTOR2 usu = new FR_DOCTOR2();
            usu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_DOCTOR3 usu = new FR_DOCTOR3();
            usu.Show();
        }
    }
}

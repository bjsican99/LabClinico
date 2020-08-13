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
    public partial class FR_MENU1 : Form
    {
        public FR_MENU1()
        {
            InitializeComponent();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            FR_PACIENTE1 usu = new FR_PACIENTE1();
            usu.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_PACIENTE2 usu = new FR_PACIENTE2();
            usu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_PACIENTE3 usu = new FR_PACIENTE3();
            usu.Show();
            this.Hide();
        }
    }
}

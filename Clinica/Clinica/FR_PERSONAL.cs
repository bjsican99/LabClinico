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
    public partial class FR_PERSONAL : Form
    {
        public FR_PERSONAL()
        {
            InitializeComponent();
        }

        private void btn_celmail_Click(object sender, EventArgs e)
        {
            FR_TELCORREO usu = new FR_TELCORREO();
            usu.Show();

        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            FR_TELCORREO usu = new FR_TELCORREO();
            usu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_TOTAL usu = new FR_TOTAL();
            usu.Show();
            this.Hide();
        }
    }
}

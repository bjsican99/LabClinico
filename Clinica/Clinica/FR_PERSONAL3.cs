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
    public partial class FR_PERSONAL3 : Form
    {
        public FR_PERSONAL3()
        {
            InitializeComponent();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_TOTAL usu = new FR_TOTAL();
            usu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_BELIMINARPERSONAL usu = new FR_BELIMINARPERSONAL();
            usu.Show();
        }
    }
}

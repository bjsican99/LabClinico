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
    public partial class FR_DOCTOR2 : Form
    {
        public FR_DOCTOR2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_TOTAL usu = new FR_TOTAL();
            usu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FR_BELIMINARDOCTOR usu = new FR_BELIMINARDOCTOR();
            usu.Show();
        }
    }
}

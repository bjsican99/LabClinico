//BRIAN SANTIZO FORM
//0901-17-1483

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
    public partial class FR_NUEVOUSU : Form
    {
        public FR_NUEVOUSU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_LOGIN usu = new FR_LOGIN();
            usu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FR_NUEVOUSU_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FR_LOGIN : Form
    {
        

        public FR_LOGIN()
        {
            InitializeComponent();
            TX_INGRESOPASSWORD.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tBIngresoUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(25, 0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FR_TOTAL usu = new FR_TOTAL();
            usu.Show();
            this.Hide();
            

        }

        private void TX_INGRESOPASSWORD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

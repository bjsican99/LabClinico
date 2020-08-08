//BRIAN SANTIZO FORM
//0901-17-1483
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
            //CODIFICACION PARA EL TEXTFIELD DE CONTRASEÑA
            txt_password.PasswordChar = '*';
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
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnl_blanco.BackColor = Color.FromArgb(25, 0, 0, 0);
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

        private void B_AGREGARUSU_Click(object sender, EventArgs e)
        {
            FR_NUEVOUSU usu = new FR_NUEVOUSU();
            usu.Show();
            this.Hide();
        }
    }
}

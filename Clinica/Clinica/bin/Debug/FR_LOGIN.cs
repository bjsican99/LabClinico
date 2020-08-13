//BRIAN SANTIZO FORM
//0901-17-1483
using System;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FR_LOGIN : Form
    {
        string strUsuarioDB, strContrasenaDB;
        

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
            if (txt_usuario.Text == "" || txt_password.Text == "")
                MessageBox.Show("Campos invalidos");
            else
            {
                if (logins() == 1)
                {
                    FR_TOTAL usu = new FR_TOTAL();
                    usu.Show();
                    this.Hide();
                }
                else
                {
                    txt_usuario.Text = "";
                    txt_password.Text = "";
                }
            }




        }

        Conexion cn = new Conexion();
        public int logins()
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT usuario_login, contraseña_login FROM tbl_login WHERE usuario_login='" + txt_usuario.Text + "' AND contraseña_login='" + txt_password.Text + "';", cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                strUsuarioDB = reader.GetString(0);
                strContrasenaDB = reader.GetString(1);
                reader.Close();
                if (String.IsNullOrEmpty(strUsuarioDB) || String.IsNullOrEmpty(strContrasenaDB))
                {
                    Console.WriteLine("No se encontro usuario");
                    return 0;
                }
                else
                    return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Usuario o Password no validos");
                return 0;
            }

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

        private void btn_salir_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }

        private void B_AGREGARUSU_Click(object sender, EventArgs e)
        {
            FR_NUEVOUSU usu = new FR_NUEVOUSU();
            usu.Show();
            this.Hide();
        }
    }
}

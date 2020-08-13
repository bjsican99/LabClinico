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
using System.Data.Odbc;

namespace Clinica
{
    public partial class FR_PACIENTE1 : Form
    {
        public FR_PACIENTE1()
        {
            InitializeComponent();
        }

        private void DatosUsuarioClini_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Regresar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            panel1.BackColor = Color.FromArgb(25, 0, 0, 0);
        }

        private void B_VALIDARUSUARIO_Click(object sender, EventArgs e)
        {
            //INSERTARUSUARIO();
            //LUSUARIO();
            FR_CELMAIL usu = new FR_CELMAIL();
            usu.Show();
            this.Hide();

        }



        Conexion cn = new Conexion();
        void INSERTARUSUARIO()
            
        {

            //CODIGO PARA PODER INSERTAR EN LA BASE DE DATOS

            //string cadena = "INSERT INTO usuario (pk_id_persona, nombre_persona, apellido_persona, telefono_persona, dpi_persona,direccion_persona, fecha_nacimiento_persona, genero_persona, estado_persona, tipo_persona ) VALUES ('"+"' , '" + txt_nombre.Text + "', '" + txt_apellido.Text + "', '" + txt_estado.Text + "' ,'" + txt_genero.Text + "','" + cbo_estado.Text + "','" + txt_alergias.Text + "' );";
            //OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            //consulta.ExecuteNonQuery();
          


        }

        void LUSUARIO()
        {
            //LIMPIAR
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_estado.Text = "";
            txt_genero.Text = "";
            cbo_estado.Text = ("");
            
           



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void btn_celmail_Click(object sender, EventArgs e)
        {
            FR_CELMAIL usu = new FR_CELMAIL();
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

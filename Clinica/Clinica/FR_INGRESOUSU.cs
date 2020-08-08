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
    public partial class FR_INGRESOUSU : Form
    {
        public FR_INGRESOUSU()
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
            INSERTARUSUARIO();
            LUSUARIO();

        }



        Conexion cn = new Conexion();
        void INSERTARUSUARIO()
            
        {

            //CODIGO PARA PODER INSERTAR EN LA BASE DE DATOS

            string cadena = "INSERT INTO usuario (pk_id_persona, nombre_persona, apellido_persona, telefono_persona, dpi_persona,direccion_persona, fecha_nacimiento_persona, genero_persona, estado_persona, tipo_persona ) VALUES ('"+"' , '" + TX_NOMBRE.Text + "', '" + TX_APELLIDO.Text + "', '" + TX_TELEFONO.Text + "' ,'" + TX_CORREO.Text + "','" + CB_ESTADOCIVIL.Text + "','" + TX_ALERGIAS.Text + "' );";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
          


        }

        void LUSUARIO()
        {
            //LIMPIAR
            TX_NOMBRE.Text = "";
            TX_APELLIDO.Text = "";
            TX_TELEFONO.Text = "";
            TX_CORREO.Text = "";
            CB_ESTADOCIVIL.Text = ("");
            TX_ALERGIAS.Text = "";
           



        }

    }
}

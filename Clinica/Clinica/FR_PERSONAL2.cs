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
    public partial class FR_PERSONAL2 : Form
    {
        public FR_PERSONAL2()
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
            FR_BELIMINARPERSONAL usu = new FR_BELIMINARPERSONAL();
            usu.Show();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {

        }

        private void txt_ingreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ingreso_Click(object sender, EventArgs e)
        {

        }

        private void txt_nacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nacimiento_Click(object sender, EventArgs e)
        {

        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_direccion_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_dpi_Click(object sender, EventArgs e)
        {

        }

        private void txt_dpi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_genero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void lbl_apellido_Click(object sender, EventArgs e)
        {

        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_estado_Click(object sender, EventArgs e)
        {

        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_telefono_Click(object sender, EventArgs e)
        {

        }

        private void lbl_correo_Click(object sender, EventArgs e)
        {

        }
    }
}

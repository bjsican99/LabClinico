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
    public partial class FR_EXAMEN : Form
    {
        public FR_EXAMEN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ENVIA AL FORM DE CORREO 
            FR_CORREO usu = new FR_CORREO();
            usu.Show();
        }

        private void B_INGRESAR_Click(object sender, EventArgs e)
        {

        }

        private void FR_EXAMEN_Load(object sender, EventArgs e)
        {

        }

        private void btn_muestra_Click(object sender, EventArgs e)
        {
            FR_MUESTRA usu = new FR_MUESTRA();
            usu.Show();


        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

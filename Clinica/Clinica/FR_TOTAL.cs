/*
 * Diseño de form por BRIAN SANTIZO 0901-17-1483
 * 
 */

using Clinica;
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
    public partial class FR_TOTAL : Form
    {
        public FR_TOTAL()
        {
            InitializeComponent();
            if (Clase_Global.TipoGlobal != "1")
            {
                btn_personal.Enabled = false;
                btn_doctor.Enabled = false;
            }
            else
            {
                btn_personal.Enabled = true;
                btn_doctor.Enabled = true;
            }


        }


        private void AbrirFormulario<Abrir>() where Abrir : Form, new()
        {

            //METODO PARA ABRIR FORMULARIOS DENTRO DE UN PANEL 
            //BRIAN SANTIZO 

            Form formulario;
            formulario = pnl_contenedor.Controls.OfType<Abrir>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new Abrir();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_contenedor.Controls.Add(formulario);
                pnl_contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("2");
            AbrirFormulario<FR_PACIENTE>();     
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {

            Bitacora bit = new Bitacora();
            bit.grabar("3");
            AbrirFormulario<FR_REPORTES>();
        }

        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("4");
            AbrirFormulario<FR_FACTURACION>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_examen_Click_(object sender, EventArgs e)
        {
            AbrirFormulario<FR_EXAMEN>();
            Bitacora bit = new Bitacora();
            bit.grabar("6");
        }

        private void btn_etiqueta_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("7");
            AbrirFormulario<FR_ETIQUETA>();
        
        }


        private void btn_personal_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("5");
            AbrirFormulario<FR_EMPLEADO>();
            
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("8");
            AbrirFormulario<FR_DOCTOR>();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("9");
            System.Windows.Forms.Application.Exit();
        }

        private void BTN_AYUDA_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaClinica/AyudaClinica.chm", "Login.htm");
        }
    }




}

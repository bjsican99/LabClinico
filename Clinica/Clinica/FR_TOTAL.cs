﻿//BRIAN SANTIZO FORM
//0901-17-1483

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
          if(Clase_Global.TipoGlobal != "1")
            {
                btn_personal.Enabled = false;
                button1.Enabled = false;
            }
          else
            {
                btn_personal.Enabled = true;
                button1.Enabled = true;
            }
           
           
        }

        private void P_CONTENEDOR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_PACIENTE>();
            Bitacora bit = new Bitacora();
            bit.grabar("2");
        }

        
        private void AbrirFormulario<Abrir>() where Abrir : Form, new() {

            //METODO PARA ABRIR FORMULARIOS DENTRO DE UN PANEL 
            //BRIAN SANTIZO 

            Form formulario;
            formulario = pnl_contenedor.Controls.OfType<Abrir>().FirstOrDefault();
             if(formulario == null)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("9");
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_EXAMEN>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_REPORTES>();
            Bitacora bit = new Bitacora();
            bit.grabar("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("4");
            AbrirFormulario<FR_FACTURACION>();
        }

        private void CK_PICTURE(object sender, EventArgs e)
        {
         


        }

        private void lbl_hora_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FR_ETIQUETA usu = new FR_ETIQUETA();
            usu.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FR_EXAMEN>();
            Bitacora bit = new Bitacora();
            bit.grabar("6");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("7");
            FR_ETIQUETA usu = new FR_ETIQUETA();
            usu.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_EMPLEADO>();
            Bitacora bit = new Bitacora();
            bit.grabar("5");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("8");
            AbrirFormulario <FR_DOCTOR>();
        }
    }


  

}
      
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
        }

        private void P_CONTENEDOR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_INGRESOUSU>();
        }

        
        private void AbrirFormulario<Abrir>() where Abrir : Form, new() {

            //METODO PARA ABRIR FORMULARIOS DENTRO DE UN PANEL 
            //BRIAN SANTIZO 

            Form formulario;
            formulario = P_CONTENEDOR.Controls.OfType<Abrir>().FirstOrDefault();
             if(formulario == null)
            {
                formulario = new Abrir();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                P_CONTENEDOR.Controls.Add(formulario);
                P_CONTENEDOR.Tag = formulario;
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
           
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_EXAMEN>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FR_REPORTES>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            AbrirFormulario<FR_FACTURACION>();
        }

        private void CK_PICTURE(object sender, EventArgs e)
        {
            FR_ETIQUETA usu = new FR_ETIQUETA();
            usu.Show();
            this.Hide();


        }
    }


  

}
      
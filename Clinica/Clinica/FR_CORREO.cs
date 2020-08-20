//BRIAN SANTIZO FORM
//0901-17-1483
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Odbc;
using Clinica.CLS_CLASES;

namespace Clinica
{
    public partial class FR_CORREO : Form
    {
        CLS_VALIDACION validacion = new CLS_VALIDACION();
        Conexion con = new Conexion();
        string strCorreo;
        public FR_CORREO()
        {
            InitializeComponent();
            txt_para.Enabled = false;
            btn_enviar.Enabled = false;
        }
        
        public void limpiar()
        {
            txt_para.Text = "";
            txt_asunto.Text = "";
            txt_mensaje.Text = "";
        }
        bool bolBanderacorreo;
        string strPatch;
        private void button2_Click(object sender, EventArgs e)
        {
            //BRIAN SANTIZO
            if (bolBanderacorreo == true && txt_para.Text != "")
            {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                try
                {
                    mmsg.To.Add(txt_para.Text);
                    mmsg.Subject = txt_asunto.Text;
                    mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                    mmsg.Body = txt_mensaje.Text;
                    mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                    mmsg.IsBodyHtml = true;
                    mmsg.Attachments.Add(new Attachment(strPatch));
                    mmsg.From = new System.Net.Mail.MailAddress("lclinico12@gmail.com");

                    //CONEXION CON EL SERVIDOR DE GMAIL
                    //INGRESO DE CREDENCIALES DEL CORREO 
                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                    cliente.Credentials = new System.Net.NetworkCredential("lclinico12@gmail.com", "Laboratorio123");
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";

                    //ENVIO DE MENSAJE
                    cliente.Send(mmsg);
                    MessageBox.Show("Correo enviado");
                    txt_codigo.Text = "";
                    limpiar();
                }
                catch (Exception)
                {
                    limpiar();
                    //SI NO LO ENVIA, MUESTRA MENSAJE DE ERROR
                    MessageBox.Show("Error al enviar");
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_adjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Examinar = new OpenFileDialog();
            if(Examinar.ShowDialog() == DialogResult.OK)
            {
                strPatch = Examinar.FileName;
            }
        }

        bool boBandera;
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CampoNumerico(e);
            if (Char.IsNumber(e.KeyChar))
            {
                limpiar();
                boBandera = true;
            }
            else
            {
                limpiar();
                boBandera = false;
            }
        }
        //Bryan Mazariegos 
        //codigo para obtener correo
        private void txt_codigo_TextChanged_1(object sender, EventArgs e)
        {
            if (boBandera == true && txt_codigo.Text != "")
            {
                try
                {
                    string strSql = "SELECT correo_paciente FROM tbl_paciente WHERE pk_id_paciente = " + txt_codigo.Text + ";";
                    OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txt_para.Text = reader[0].ToString();
                        bolBanderacorreo = true;
                    }
                }
                catch (Exception err)
                {
                    bolBanderacorreo = false;
                    btn_enviar.Enabled = false;
                    limpiar();
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txt_para_TextChanged(object sender, EventArgs e)
        {
            if(txt_para.Text=="")
            {
                btn_enviar.Enabled = false;
            }
            else
            {

                btn_enviar.Enabled = true;
            }

        }
    }
}

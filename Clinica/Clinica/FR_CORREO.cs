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


namespace Clinica
{
    public partial class FR_CORREO : Form
    {
        public FR_CORREO()
        {
            InitializeComponent();
        }

        private void FR_CORREO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(TX_PARA.Text);
            mmsg.Subject =TX_ASUNTO.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(TX_CC.Text);

            mmsg.Body = TX_MENSAJE.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("lclinico12@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("lclinico12@gmail.com", "Laboratorio123");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";




            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Correo enviado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}

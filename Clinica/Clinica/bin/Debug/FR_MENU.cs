using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FR_MENU : Form
    {
        public FR_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FR_INGRESOUSU usu = new FR_INGRESOUSU();
            usu.Show();
            this.Hide();

        }

        private void MenuClinica_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes Vi_Reporte = new Reportes();
            Vi_Reporte.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultas Vi_Consulta = new Consultas();
            Vi_Consulta.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void B_INGRESOFACTURACIÓN_Click(object sender, EventArgs e)
        {
            Consultas Vi_Consulta = new Consultas();
            Vi_Consulta.Show();
            this.Hide();
        }
    }
}

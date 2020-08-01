using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class MenuClinica : Form
    {
        public MenuClinica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosUsuarioClini usu = new DatosUsuarioClini();
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
    }
}

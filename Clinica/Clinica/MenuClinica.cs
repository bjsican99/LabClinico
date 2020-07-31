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
    }
}

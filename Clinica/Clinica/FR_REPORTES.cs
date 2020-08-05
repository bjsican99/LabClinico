using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Clinica
{
    public partial class FR_REPORTES : Form
    {
        public FR_REPORTES()
        {
            InitializeComponent();
        }

        Conexion cn = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            string cadena = "SELECT * FROM usuario";

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            DG_Pacientes.DataSource = dt;

        }

        private void DG_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

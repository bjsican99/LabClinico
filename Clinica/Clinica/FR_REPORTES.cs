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
using System.Drawing.Printing;

namespace Clinica
{
    public partial class FR_REPORTES : Form
    {
        public FR_REPORTES()
        {
            InitializeComponent();
            //cargar();


        }

        Conexion cn = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
           printDocument1.Print();


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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.DG_Pacientes.Width, this.DG_Pacientes.Height);
            DG_Pacientes.DrawToBitmap(bm, new Rectangle(0, 0, this.DG_Pacientes.Width, this.DG_Pacientes.Height));
            e.Graphics.DrawImage(bm, 10, 10);








        }
    }
}

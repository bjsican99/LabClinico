/*
 * Bryan Mazariegos 0901-17-1001
 */
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
using System.Security.Policy;

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
            string cadena = "SELECT * FROM empleados";

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            DG_Pacientes.DataSource = dt;

        }

        void buscar()
        {

            string cadena = "SELECT * FROM  empleados WHERE codigo_empleado = "+ txt_codigopaciente.Text;

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            DG_Pacientes.DataSource = dt;

        }
        void modificar()
        {
            DataGridViewRow fila = DG_Pacientes.CurrentRow; 
            string cadena = "UPDATE empleados SET nombre_completo= '"+ Convert.ToString(DG_Pacientes.CurrentRow.Cells[1].Value)+ "', puesto='"+ Convert.ToString(DG_Pacientes.CurrentRow.Cells[2].Value) + "', departamento='" + Convert.ToString(DG_Pacientes.CurrentRow.Cells[3].Value) + "', estado=" + Convert.ToString(DG_Pacientes.CurrentRow.Cells[4].Value) + " WHERE codigo_empleado = "+txt_codigopaciente.Text;
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            if (consulta.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
            }
            else
                MessageBox.Show("No existe un artículo con el código ingresado");
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
            txt_codigopaciente.Text = "";
        }
    }
}

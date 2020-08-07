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
            txt_codigopaciente.Text = "";
            //cargar();


        }

        Conexion cn = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
           

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
            try { 
            string cadena = "SELECT * FROM  empleados WHERE codigo_empleado = "+ txt_codigopaciente.Text;

            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
            DataTable dt = new DataTable();
            datos.Fill(dt);
            DG_Pacientes.DataSource = dt;
            }
            catch (Exception e)
            {

            }

}
        void modificar()
        {
            try
            {
                DataGridViewRow fila = DG_Pacientes.CurrentRow;
                string str_cadena = "UPDATE empleados SET nombre_completo= '" + Convert.ToString(DG_Pacientes.CurrentRow.Cells[1].Value) + "', puesto='" + Convert.ToString(DG_Pacientes.CurrentRow.Cells[2].Value) + "', departamento='" + Convert.ToString(DG_Pacientes.CurrentRow.Cells[3].Value) + "', estado=" + Convert.ToString(DG_Pacientes.CurrentRow.Cells[4].Value) + " WHERE codigo_empleado = " + txt_codigopaciente.Text;
                OdbcCommand consulta = new OdbcCommand(str_cadena, cn.conexion());
                if (consulta.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se modificaron los datos");
                }
                else
                    MessageBox.Show("No existe una persona con el código ingresado");
            }
            catch (Exception e)
            {
               
            }
        }
        void Eliminar()
        {
            DataGridViewRow fila = DG_Pacientes.CurrentRow;
            try
            {
                string str_cadena = "DELETE FROM empleados WHERE codigo_empleado = " + txt_codigopaciente.Text;
                OdbcCommand consulta = new OdbcCommand(str_cadena, cn.conexion());
                if (consulta.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Se han eliminado los datos");
                }
                else
                    MessageBox.Show("No exixte el codigo a eliminar");
            }
            catch (Exception e)
            {

            }
        }
        private void DG_Pacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           



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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            txt_codigopaciente.Text = "";
        }
    }
}

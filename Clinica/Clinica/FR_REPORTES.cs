﻿/*
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
        int intValido = 0;
        Conexion cn = new Conexion();
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
           

        }

        void cargar()
        {
            //CODIGO PARA EXTRAER DE LA BASE DE DATOS LA TABLA PARA MOSTRAR EN EL DATAGRID
            //BRIAN SANTIZO
            try
            {
                string strCadena = "SELECT * FROM empleados";

                OdbcDataAdapter datos = new OdbcDataAdapter(strCadena, cn.conexion());
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgv_vista.DataSource = dt;
            }
            catch (Exception exError)
            {
                Console.WriteLine("Error en cargar", exError);
            }
        }
        //FUNCION PARA BUSCAR SIRVE PARA BUSCAR A LA PERSONA A MODIFICAR Y A ELIMINAR
        //Bryan Mazariegos
        void buscar()
        {
            if (txt_codigopaciente.Text == "")
            {
                MessageBox.Show("Debe ingresar el códogo");
            }
            else
            {
                txt_codigopaciente.Enabled = false;
                try
                {
                    intValido = 1;
                    string cadena = "SELECT pk_id_persona FROM tbl_persona WHERE pk_id_persona=" + txt_codigopaciente.Text;
                    OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                    if (consulta.ExecuteNonQuery() == 1)
                    {
                        try
                        {
                            string strCadena = "SELECT * FROM  tbl_persona WHERE pk_id_persona = " + txt_codigopaciente.Text;

                            OdbcDataAdapter datos = new OdbcDataAdapter(strCadena, cn.conexion());
                            DataTable dt = new DataTable();
                            datos.Fill(dt);
                            dgv_vista.DataSource = dt;
                        }
                        catch (Exception exError)
                        {
                            Console.WriteLine("Error en llenado de busqueda", exError);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo de persona no exixte");
                        txt_codigopaciente.Enabled = true;
                    }
                }
                catch (Exception exError)
                {
                    Console.WriteLine("Error en la buscqueda de la persona", exError);
                }
            }
        }
        //FUNCION PARA MODIFICAR A UNA PERSONA
        //Bryan Mazariegos
        void modificar()
        {
            if (txt_codigopaciente.Text == ""|| intValido!=1)
            {
                MessageBox.Show("No se a buscado una persona");
                txt_codigopaciente.Enabled = true;
            }
            else
            {
                try
                {
                    DataGridViewRow fila = dgv_vista.CurrentRow;
                    string strCadena = "UPDATE tbl_persona SET nombre_persona= '" + Convert.ToString(dgv_vista.CurrentRow.Cells[1].Value) + "', apellido_persona='" + Convert.ToString(dgv_vista.CurrentRow.Cells[2].Value) + "', telefono_persona=" + Convert.ToString(dgv_vista.CurrentRow.Cells[3].Value) + ", dpi_persona=" + Convert.ToString(dgv_vista.CurrentRow.Cells[4].Value) + ", direccion_persona='" + Convert.ToString(dgv_vista.CurrentRow.Cells[5].Value) + "', email_persona='" + Convert.ToString(dgv_vista.CurrentRow.Cells[6].Value) + "', genero_persona=" + Convert.ToString(dgv_vista.CurrentRow.Cells[9].Value) + ", estado_persona=" + Convert.ToString(dgv_vista.CurrentRow.Cells[10].Value) + ", estadocivil_persona=" + Convert.ToString(dgv_vista.CurrentRow.Cells[11].Value) + ", alergias='" + Convert.ToString(dgv_vista.CurrentRow.Cells[12].Value) + "', tipo_persona=" + Convert.ToString(dgv_vista.CurrentRow.Cells[13].Value) + " WHERE pk_id_persona = " + txt_codigopaciente.Text;
                    OdbcCommand consulta = new OdbcCommand(strCadena, cn.conexion());
                    if (consulta.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Se modificaron los datos");
                        txt_codigopaciente.Enabled = true;
                        intValido = 0;
                    }
                    else
                    {
                        MessageBox.Show("No existe una persona con el código ingresado");
                        txt_codigopaciente.Enabled = true;
                        intValido = 0;
                    }
                }
                catch (Exception exError)
                {
                    Console.WriteLine("Error en modificar ", exError);
                    txt_codigopaciente.Enabled = true;
                    intValido = 0;
                }
            }
        }
        //FUNCION PARA ELIMINAR A UNA PRSONA DETERMINADA
        //Bryan Mazariegos
        void Eliminar()
        {
            if (txt_codigopaciente.Text == "" || intValido != 1)
            {
                MessageBox.Show("No se a buscado una persona");
            }
            else
            {
                try
                {
                    DataGridViewRow fila = dgv_vista.CurrentRow;
                    string strCadena = "DELETE FROM tbl_persona WHERE pk_id_persona = " + txt_codigopaciente.Text;
                    OdbcCommand consulta = new OdbcCommand(strCadena, cn.conexion());
                    if (consulta.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Se han eliminado los datos");
                        txt_codigopaciente.Enabled = true;
                        intValido = 0;
                    }
                    else
                    {
                        MessageBox.Show("No exixte el codigo a eliminar");
                        txt_codigopaciente.Enabled = true;
                        intValido = 0;
                    }
                }
                catch (Exception exError)
                {
                    Console.WriteLine("Error en eliminacion", exError);
                    txt_codigopaciente.Enabled = true;
                    intValido = 0;
                }
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

        private void FR_REPORTES_Load(object sender, EventArgs e)
        {

        }
    }
}

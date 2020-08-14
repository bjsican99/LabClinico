using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.CLS_CLASES
{
    public class CLS_CONSULTAS
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string str_sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(str_sql, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                //Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }
        public OdbcDataReader Insertar_empleado(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            try
            {
                cn.conexion();
                string str_consulta = "insert into tbl_empleado values("+str_codigo+",'" + str_nombre + "', '" + str_apellido + "' ," + str_dpi + ",'" + str_direccion + "'," + str_nit + ",'" + str_fechanacimiento + "','" + str_fechaingreso +"',"+str_telefono+",'"+str_correo +"',"+ str_genero+","+str_estadocivil+","+str_estado+");";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Datos registrados.");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error al registrar.");
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificar_empleado(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            try
            {
                cn.conexion();
                string str_consulta = "UPDATE tbl_empleado set nombre_empleado='" + str_nombre + "',apellido_empleado='" + str_apellido + "',dpi_empleado=" + str_dpi + ",direccion_empleado='" + str_direccion + "',nit_empleado=" + str_nit + ",fechanacimiento_empleado='" +str_fechanacimiento+ "',fechaingreso_empleado='"+str_fechaingreso+ "',telefono_empleado="+str_telefono+ ",correo_empleado='"+str_correo+ "',genero_empleado="+str_genero+ ",fk_idestadocivil_empleado="+str_estadocivil+ ",estado_empleado="+str_estado+" where pk_id_empleado='" + str_codigo + "';";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Datos modificados correctamente.");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la modificación de los datos");
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminar_empleado(string str_codigoo)
        {
            try
            {
                cn.conexion();
                string str_consulta = "UPDATE tbl_empleado set estado_empleado='0' where pk_id_empleado='" + str_codigoo + "';";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Eliminado Correctamente.");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la eliminación");
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------//

        public OdbcDataReader consulta_empleados( )
        {
            try
            {
                string str_consulta = "SELECT * FROM tbl_empleado;";
                OdbcCommand command = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
    }
}

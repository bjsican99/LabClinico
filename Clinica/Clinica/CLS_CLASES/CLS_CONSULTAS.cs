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
        public OdbcDataReader Insertar(String strTabla, string strCodigo, string strNombre, string strApellido, string strDpi, string strDireccion, string strNit, string strFechanacimiento, string strFechaingreso, string strTelefono, string strCorreo, string strGenero, string strEstadocivil, string strEstado)
        {
            try
            {

                string str_consulta = "insert into " + strTabla + " values(" + strCodigo + ",'" + strNombre + "', '" + strApellido + "' ," + strDpi + ",'" + strDireccion + "'," + strNit + ",'" + strFechanacimiento + "','" + strFechaingreso + "'," + strTelefono + ",'" + strCorreo + "'," + strGenero + "," + strEstadocivil + "," + strEstado + ");";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Datos registrados.");
                Bitacora bit = new Bitacora();
                bit.grabar("15");
                Clase_Global.EventoGlobal = (strTabla + " " + strCodigo);
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error al registrar.");
                Console.WriteLine(err.Message);
                Bitacora bit = new Bitacora();
                bit.grabar("16");
                Clase_Global.EventoGlobal = (strTabla + " " + strCodigo);
                return null;
            }
        }
        public OdbcDataReader modificar(int intConsulta, string strCodigo, string strNombre, string strApellido, string strDpi, string strDireccion, string strNit, string strFechanacimiento, string strFechaingreso, string strTelefono, string strCorreo, string strGenero, string strEstadocivil, string strEstado)
        {
            try
            {
                string strConsulta = "";
                if (intConsulta == 0)
                {
                    strConsulta = "UPDATE tbl_empleado set nombre_empleado='" + strNombre + "',apellido_empleado='" + strApellido + "',dpi_empleado=" + strDpi + ",direccion_empleado='" + strDireccion + "',nit_empleado=" + strNit + ",fechanacimiento_empleado='" + strFechanacimiento + "',fechaingreso_empleado='" + strFechaingreso + "',telefono_empleado=" + strTelefono + ",correo_empleado='" + strCorreo + "',genero_empleado=" + strGenero + ",fk_idestadocivil_empleado=" + strEstadocivil + ",estado_empleado=" + strEstado + " where pk_id_empleado='" + strCodigo + "';";
                }
                else if (intConsulta == 1)
                {
                    strConsulta = "UPDATE tbl_paciente set nombre_paciente='" + strNombre + "',apellido_paciente='" + strApellido + "',dpi_paciente=" + strDpi + ",direccion_paciente='" + strDireccion + "',nit_paciente=" + strNit + ",fechanacimiento_paciente='" + strFechanacimiento + "',fechaingreso_paciente='" + strFechaingreso + "',telefono_paciente=" + strTelefono + ",correo_paciente='" + strCorreo + "',genero_paciente=" + strGenero + ",fk_idestadocivil_paciente=" + strEstadocivil + ",estado_paciente=" + strEstado + " where pk_id_paciente='" + strCodigo + "';";
                }
                else
                {
                    strConsulta = "UPDATE tbl_doctor set nombre_doctor='" + strNombre + "',apellido_doctor='" + strApellido + "',dpi_doctor=" + strDpi + ",direccion_doctor='" + strDireccion + "',nit_doctor=" + strNit + ",fechanacimiento_doctor='" + strFechanacimiento + "',fechaingreso_doctor='" + strFechaingreso + "',telefono_doctor=" + strTelefono + ",correo_doctor='" + strCorreo + "',genero_doctor=" + strGenero + ",fk_idestadocivil_doctor=" + strEstadocivil + ",estado_doctor=" + strEstado + " where pk_id_doctor='" + strCodigo + "';";
                }

                comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Datos modificados correctamente.");
                Bitacora bit = new Bitacora();
                bit.grabar("17");
                Clase_Global.EventoGlobal = (strNombre + " " + strCodigo);
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la modificación de los datos");
                Console.WriteLine(err.Message);
                Bitacora bit = new Bitacora();
                bit.grabar("18");
                Clase_Global.EventoGlobal = (strNombre + " " + strCodigo);
                return null;
            }
        }
        public OdbcDataReader eliminar(int intConsulta, string strCodigoo)
        {
            try
            {
                string strConsulta = "";
                if (intConsulta == 0)
                {
                    strConsulta = "UPDATE tbl_empleado set estado_empleado='0' where pk_id_empleado='" + strCodigoo + "';";
                }
                else if (intConsulta == 1)
                {
                    strConsulta = "UPDATE tbl_paciente set estado_paciente='0' where pk_id_paciente='" + strCodigoo + "';";
                }
                else
                {
                    strConsulta = "UPDATE tbl_doctor set estado_doctor='0' where pk_id_doctor='" + strCodigoo + "';";
                }

                comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Eliminado Correctamente.");
                Bitacora bit = new Bitacora();
                bit.grabar("19");
                Clase_Global.EventoGlobal = (strConsulta + " " + strCodigoo);
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la eliminación");
                Console.WriteLine(err.Message);
                Bitacora bit = new Bitacora();
                bit.grabar("20");
                return null;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------//

        public OdbcDataReader consulta(string strTabla)
        {
            try
            {
                string strConsulta = "SELECT * FROM " + strTabla + ";";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                Bitacora bit = new Bitacora();
                bit.grabar("21");
                Clase_Global.EventoGlobal = (strTabla);
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                Bitacora bit = new Bitacora();
                bit.grabar("22");
                Clase_Global.EventoGlobal = (strTabla);
                return null;
            }

        }
    }
}

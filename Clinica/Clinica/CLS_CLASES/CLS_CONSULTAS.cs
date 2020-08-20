/*
 * Estructura de clase Estraida del  usuario de github imogollonh del repositorio Bienestar_SCM 
 * del link https://github.com/imogollonh/Bienestar_SCM 
 * 
 * adaptado a proyecto por Bryan Mazariegos 0901-17-1001 al proyecto LabClinico 
 */
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

        public string obtenerfinal(string strTabla, string strCampo)
        {
            String camporesultante = "";
            try
            {
                string str_sql = "SELECT MAX(" + strCampo + "+1) FROM " + strTabla + ";";      
                OdbcCommand command = new OdbcCommand(str_sql, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
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
                Clase_Global.EventoGlobal = ("Insercion en " + strTabla + " al codigo" + strCodigo);
                Bitacora bit = new Bitacora();
                bit.grabar("15");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error al registrar.");
                Console.WriteLine(err.Message);
                Clase_Global.EventoGlobal = ("Error al insertar en " + strTabla + " al codigo" + strCodigo);
                Bitacora bit = new Bitacora();
                bit.grabar("16");
                return null;
            }
        }
        public OdbcDataReader modificar(int intConsulta, string strCodigo, string strNombre, string strApellido, string strDpi, string strDireccion, string strNit, string strFechanacimiento, string strFechaingreso, string strTelefono, string strCorreo, string strGenero, string strEstadocivil, string strEstado)
        {
            string strTabla;
            
                string strConsulta = "";
                if (intConsulta == 0)
                {
                    strTabla = "tbl_empleado";
                    strConsulta = "UPDATE tbl_empleado set nombre_empleado='" + strNombre + "',apellido_empleado='" + strApellido + "',dpi_empleado=" + strDpi + ",direccion_empleado='" + strDireccion + "',nit_empleado=" + strNit + ",fechanacimiento_empleado='" + strFechanacimiento + "',fechaingreso_empleado='" + strFechaingreso + "',telefono_empleado=" + strTelefono + ",correo_empleado='" + strCorreo + "',genero_empleado=" + strGenero + ",fk_idestadocivil_empleado=" + strEstadocivil + ",estado_empleado=" + strEstado + " where pk_id_empleado= " + strCodigo + ";";
                }
                else if (intConsulta == 1)
                {
                    strTabla = "tbl_paciente";
                    strConsulta = "UPDATE tbl_paciente set nombre_paciente='" + strNombre + "',apellido_paciente='" + strApellido + "',dpi_paciente=" + strDpi + ",direccion_paciente='" + strDireccion + "',nit_paciente=" + strNit + ",fechanacimiento_paciente='" + strFechanacimiento + "',fechaingreso_paciente='" + strFechaingreso + "',telefono_paciente=" + strTelefono + ",correo_paciente='" + strCorreo + "',genero_paciente=" + strGenero + ",fk_idestadocivil_paciente=" + strEstadocivil + ",estado_paciente=" + strEstado + " where pk_id_paciente= " + strCodigo + ";";
                }
                else
                {
                    strTabla = "tbl_doctor";
                    strConsulta = "UPDATE tbl_doctor set nombre_doctor='" + strNombre + "',apellido_doctor='" + strApellido + "',dpi_doctor=" + strDpi + ",direccion_doctor='" + strDireccion + "',nit_doctor=" + strNit + ",fechanacimiento_doctor='" + strFechanacimiento + "',fechaingreso_doctor='" + strFechaingreso + "',telefono_doctor=" + strTelefono + ",correo_doctor='" + strCorreo + "',genero_doctor=" + strGenero + ",fk_idestadocivil_doctor=" + strEstadocivil + ",estado_doctor=" + strEstado + " where pk_id_doctor=  " + strCodigo + ";";
                }
            try
            {
                comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Datos modificados correctamente.");
                Clase_Global.EventoGlobal = ("Modificacion en "+ strTabla + " al codigo " + strCodigo);
                Bitacora bit = new Bitacora();
                bit.grabar("17");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la modificación, contacte a IT");
                Console.WriteLine(err.Message);
                Clase_Global.EventoGlobal = ("Error al modificacion en " + strTabla + " al codigo " + strCodigo);
                Bitacora bit = new Bitacora();
                bit.grabar("18");
                return null;
            }
        }
        public OdbcDataReader eliminar(int intConsulta, string strCodigo)
        {
            string strTabla;
            
                string strConsulta = "";
                if (intConsulta == 0)
                {
                    strTabla = "tbl_empleado";
                    strConsulta = "UPDATE tbl_empleado set estado_empleado= 0 where pk_id_empleado= " + strCodigo + ";";
                }
                else if (intConsulta == 1)
                {
                    strTabla = "tbl_paciente";
                    strConsulta = "UPDATE tbl_paciente set estado_paciente= 0 where pk_id_paciente= " + strCodigo + ";";
                }
                else
                {
                    strTabla = "tbl_doctor";
                    strConsulta = "UPDATE tbl_doctor set estado_doctor= 0 where pk_id_doctor= " + strCodigo + ";";
                }
            try
            {
                comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Eliminado Correctamente.");
                Clase_Global.EventoGlobal = ("Eliminar en "+strTabla+" al codigo" + strCodigo);
                Bitacora bit = new Bitacora();
                bit.grabar("19");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la eliminación, contacte a IT");
                Console.WriteLine(err.Message);
                Clase_Global.EventoGlobal = ("Error al eliminar en " + strTabla + " al codigo" + strCodigo);
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
                Clase_Global.EventoGlobal = ("consulta tabla: " + strTabla);
                Bitacora bit = new Bitacora();
                bit.grabar("21");
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido, contacte a IT");
                Console.WriteLine(err.Message);
                Clase_Global.EventoGlobal = ("Error en consulta tabla: " + strTabla);
                Bitacora bit = new Bitacora();
                bit.grabar("22");
                return null;
            }

        }
        //----------------------------Consulta de etiqueta----------------------///
        public OdbcDataReader consulta_etiqueta(string strCodigo)
        {
            try
            {
                string strConsulta = "SELECT nombre_paciente, apellido_paciente FROM tbl_paciente WHERE pk_id_paciente= '" + strCodigo + "';";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                Clase_Global.EventoGlobal = ("Consulta tabla tbl_paciente, Etiqueta");
                Bitacora bit = new Bitacora();
                bit.grabar("21");
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la busqueda de contenido, contacte a IT");
                Console.WriteLine(err.Message);
                Clase_Global.EventoGlobal = ("Error en Consulta tabla tbl_paciente, Etiqueta");
                Bitacora bit = new Bitacora();
                bit.grabar("22");
                return null;
            }



        }
    }
}

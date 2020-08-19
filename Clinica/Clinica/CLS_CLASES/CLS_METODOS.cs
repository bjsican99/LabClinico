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

namespace Clinica.CLS_CLASES
{
    public class CLS_METODOS
    {
        CLS_CONSULTAS consulta = new CLS_CONSULTAS();
        public string siguiente(string strTabla, string strCampo)
        {
            string strCodigo = consulta.obtenerfinal(strTabla, strCampo);
            return strCodigo;
        }
        //----------------------------------metodos de insercion a tablas-------------------------------------------------------//
        public OdbcDataReader Insertar_empleado(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.Insertar("tbl_empleado", str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        public OdbcDataReader Insertar_paciente(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.Insertar("tbl_paciente", str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        public OdbcDataReader Insertar_doctor(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.Insertar("tbl_doctor", str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //---------------------------------metodos de modificacion en tablas -------------------------------------------------------//
        public OdbcDataReader modificar_empleado(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.modificar(0, str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        public OdbcDataReader modificar_paciente(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.modificar(1, str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        public OdbcDataReader modificar_doctor(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.modificar(2, str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //---------------------------------metodos de eliminacion en tablas-------------------------------------------------------//
        public OdbcDataReader eliminar_empleado(string str_codigo)
        {
            return consulta.eliminar(0, str_codigo);

        }
        public OdbcDataReader eliminar_paciente(string str_codigo)
        {
            return consulta.eliminar(1, str_codigo);

        }
        public OdbcDataReader eliminar_doctor(string str_codigo)
        {
            return consulta.eliminar(2, str_codigo);

        }
        //-----------------------------------------metodos de consulta de tablas---------------------------------------//
        public OdbcDataReader consulta_empleado()
        {
            return consulta.consulta("tbl_empleado");
        }
        public OdbcDataReader consulta_paciente()
        {
            return consulta.consulta("tbl_paciente");
        }
        public OdbcDataReader consulta_doctor()
        {
            return consulta.consulta("tbl_doctor");
        }
    }
}

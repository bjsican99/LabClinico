using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLS_CLASES
{
    class CLS_METODOS
    {
        CLS_CONSULTAS consulta = new CLS_CONSULTAS();
        public string siguiente(string str_tabla, string str_campo)
        {
            string llave = consulta.obtenerfinal(str_tabla, str_campo);
            return llave;
        }
        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader Insertar_empleado(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit,  string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.Insertar_empleado(str_codigo,str_nombre, str_apellido, str_dpi, str_direccion, str_nit,  str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificar_empleado(string str_codigo, string str_nombre, string str_apellido, string str_dpi, string str_direccion, string str_nit, string str_fechanacimiento, string str_fechaingreso, string str_telefono, string str_correo, string str_genero, string str_estadocivil, string str_estado)
        {
            return consulta.modificar_empleado(str_codigo, str_nombre, str_apellido, str_dpi, str_direccion, str_nit, str_fechanacimiento, str_fechaingreso, str_telefono, str_correo, str_genero, str_estadocivil, str_estado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminar_empleado(string str_codigo)
        {
            return consulta.eliminar_empleado(str_codigo);

        }

        public OdbcDataReader consulta_empleado()
        {
            return consulta.consulta_empleados();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    class Conexion
    {

        public OdbcConnection conexion()
        {
            //CREACCION DE LA CONEXCION ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=BD_LabClinico");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }

        //METODO PARA CERRAR LA CONEXION
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }

    }








}

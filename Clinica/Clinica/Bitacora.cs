using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Net;
using CrystalDecisions.Web.HtmlReportRender;

namespace Clinica
{
    class Bitacora
    {
        public void grabar(string idEvento)
        {
            ip();
            string idLogin1 = Clase_Global.idGlobal;
            Conexion cn = new Conexion();
            string direhost = Clase_Global.ipGlobal;
            string fecha = DateTime.Now.ToString("HH:mm:ss");
            string hora1 = DateTime.Now.ToLongDateString();
            string horabitacora = fecha + " " + hora1;


            // Console.WriteLine(idLogin1 +"    8749846    "+ hora + direhost);
            try
            {
                string cadena = "INSERT INTO tbl_bitacora (fk_iduser_bitacora, fk_idtipoevent_bitacora, horaingreso_bitacora, direchost_bitacora) VALUES ('" + idLogin1 + "', '" + idEvento + "','" + horabitacora + "','" + direhost + "') ;";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo ingresar a bitacora");
            }
        }
        public void ip()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Clase_Global.ipGlobal = myIP;
        }


    }
}

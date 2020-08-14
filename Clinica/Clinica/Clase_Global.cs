using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    class Clase_Global
    {
        private static string v_idGlobal = "";
        public static string idGlobal
        {
            get { return v_idGlobal; }
            set { v_idGlobal = value; }
        }

        private static string v_ipGlobal = "";
        public static string ipGlobal
        {
            get { return v_ipGlobal; }
            set { v_ipGlobal = value; }
        }
    }
}


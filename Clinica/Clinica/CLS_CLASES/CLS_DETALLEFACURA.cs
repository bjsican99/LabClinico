using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLS_CLASES
{
    class CLS_DETALLEFACURA
    {
        private string strIdDetallefactura;
        private string strIdEncabezado;
        private string stridExamen;
        private string strSubtotal;

        public string StrIdDetallefactura { get => strIdDetallefactura; set => strIdDetallefactura = value; }
        public string StrIdEncabezado { get => strIdEncabezado; set => strIdEncabezado = value; }
        public string StridExamen { get => stridExamen; set => stridExamen = value; }
        public string StrSubtotal { get => strSubtotal; set => strSubtotal = value; }
    }
}

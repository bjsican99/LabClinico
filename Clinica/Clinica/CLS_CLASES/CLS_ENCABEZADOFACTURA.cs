using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.CLS_CLASES
{
    class CLS_ENCABEZADOFACTURA
    {
        private string strIdEncabezado;
        private string strNoSerie;
        private string strNombre;
        private string strApellido;
        private string strNit;
        private string strFecha;
        private string strTotal;
        private string strIdTipoPago;

        public string StrIdEncabezado { get => strIdEncabezado; set => strIdEncabezado = value; }
        public string StrNoSerie { get => strNoSerie; set => strNoSerie = value; }
        public string StrNombre { get => strNombre; set => strNombre = value; }
        public string StrApellido { get => strApellido; set => strApellido = value; }
        public string StrNit { get => strNit; set => strNit = value; }
        public string StrFecha { get => strFecha; set => strFecha = value; }
        public string StrTotal { get => strTotal; set => strTotal = value; }
        public string StrIdTipoPago { get => strIdTipoPago; set => strIdTipoPago = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.CLS_CLASES
{
    class CLS_FACTURACION
    {
        Conexion con = new Conexion();
        OdbcTransaction transaction = null;
        string strSql = "";
        public bool InsertarFactura(CLS_ENCABEZADOFACTURA Factura, List<CLS_DETALLEFACURA> LstDetalleFactura)
        {
            int bandera = 0;
            var resultado = con.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand cmd = resultado.Item1.CreateCommand();
            cmd.Transaction = transaction;
            try
            {
                strSql = "INSERT INTO tbl_encabezadofactura (pk_id_encabezadofactura, numserie_encabezadofactura, nombre_encabezadofactura, apellido_encabezadofactura, nit_encabezadofactura, fechaorden_encabezadofactura, total_encabezadofactura, fk_idtipopago_encabezadofactura ) VALUES ("+Factura.StrIdEncabezado+",'" + Factura.StrNoSerie + "','" + Factura.StrNombre +"','" + Factura.StrApellido + "'," + Factura.StrNit + ",'" + Factura.StrFecha + "'," + Factura.StrTotal + "," + Factura.StrIdTipoPago + ");";
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("encabezado guardado");

                foreach (CLS_DETALLEFACURA detallefactura in LstDetalleFactura)
                {
                    try
                    {
                        strSql = "INSERT INTO tbl_detallefactura (fk_idencabezado_detallefactura, fk_idexamen_detallefactura, subtotal_detallefactura) VALUES (" + detallefactura.StrIdEncabezado + "," + detallefactura.StridExamen + "," + detallefactura.StrSubtotal +");";
                        cmd.CommandText = strSql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Detalles guardado");
                    }
                    catch (OdbcException err)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error Rollback realizado en detalles"+ err.Message);
                        Console.WriteLine("eroro", err.Message);
                        bandera = 1;

                        return false;

                    }

                }

            }
            catch (OdbcException err)
            {
                transaction.Rollback();
                MessageBox.Show("Error Rollback realizado en encabezado" + err.Message);
                bandera = 1;
                return false;
            }
            if (bandera == 0)
            {
                transaction.Commit();
                MessageBox.Show("realizando commit datos guardados");
            }
            else
            {
                bandera = 0;
            }
            return true;

        }
    }
}

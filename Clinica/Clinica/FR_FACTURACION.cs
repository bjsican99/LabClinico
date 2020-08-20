//BRIAN SANTIZO FORM
//0901-17-1483
using Clinica.CLS_CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clinica
{
    public partial class FR_FACTURACION : Form
    {
        CLS_METODOS metodos = new CLS_METODOS();
        CLS_VALIDACION validacion = new CLS_VALIDACION();
        Conexion con = new Conexion();
        const string strNoSerie = "4DC789A";
        string strCodigo = "";
        //BRIAN SANTIZO
        //PARAMETROS DE LA FACTURA QUE DEBEN SER INICIALIZADOS 
        private int y;
        private float width;

        //RUTA DE LA IMAGEN/MARCA DE AGUA DE LA FACTURA
        string umglogo = @"C:\LabClinico\Clinica\Iconos\umglogo.png";

        public FR_FACTURACION()
        {
            InitializeComponent();
            cbo_examen_lleado();
            cbo_tipo_pago_lleado();
            obtenercodigo();
            bloqueo();
            txt_no_serie.Text = strNoSerie;
        }
        //Bloqueo de campos 
        public void bloqueo()
        {
            txt_no_factura.Enabled = false;
            txt_no_serie.Enabled = false;
            txt_precio.Enabled = false;
            dtp_fecha.Enabled = false;

        }
        //fondo semitransparente de panel
        private void pnl_factura_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnl_factura.BackColor = Color.FromArgb(25, 0, 0, 0);
        }
        //obtine el prximo codigo de factura 
        public void obtenercodigo()
        {
            strCodigo = metodos.siguiente("tbl_encabezadofactura", "pk_id_encabezadofactura");
            txt_no_factura.Text = strCodigo;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //BRIAN SANTIZO
            //SE CREA UNA VARIABLE LA CUAL CONTIENE, TIPO, TAMAÑO Y ESTILO DE LETRA
            Font font = new Font("Corbel", 14, FontStyle.Bold, GraphicsUnit.Point);
            //VARIABLE DONDE SE GUARDA LA IMAGEN/MARCA DE AGUA DE LA FACTURA
            Image img = Image.FromFile(umglogo);
            //BRIAN SANTIZO
            //CODIGO PARA CREAR LA FACTURA DE UNA FORMA 'MANUAL' 

            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20)); e.Graphics.DrawImage(img, new Rectangle(0, y += 20, 300, 300));
            e.Graphics.DrawString("Laboratorio Clinico UMG", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Guatemala, Ciudad de Guatemala", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Dirección: 15 calle A, Zona 10", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Telefono: 5000-4020", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("N# Factura: " + txt_no_serie.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Fecha: " + txt_no_factura.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Nombre: " + txt_nombre.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Examen: " + txt_apellido.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Total a pagar: " + txt_total.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Dicen que algunos nacen para sanadores", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("unos pocos selectos.", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

        }
        //LLenado de cbo_tipopago
        public void cbo_tipo_pago_lleado()
        {
            cbo_tipopago.Items.Clear();
            try
            {
                string strSql = "SELECT * FROM tbl_pago;";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbo_tipopago.Items.Add(reader[1].ToString());
                }
                cbo_tipopago.Items.Insert(0, "Seleccione un Item.");
                cbo_tipopago.SelectedIndex = 0;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
        //llenado de cbo_examen
        public void cbo_examen_lleado()
        {
            cbo_examen.Items.Clear();
            try
            {
                string strSql = "SELECT * FROM tbl_examen WHERE estado_laboratorio = '1';";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbo_examen.Items.Add(reader[1].ToString());
                }
                cbo_examen.Items.Insert(0, "Seleccione un Item.");
                cbo_examen.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        //consulta y llenado automatico del campo precio
        public void llenado_precio()
        {
            try
            {
                string strSql = "SELECT precio_examen FROM tbl_examen WHERE nombre_examen = '" + cbo_examen.Text + "';";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_precio.Text= reader[0].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        //consulta para tipo pago
        public string consulta_tipo_pago()
        {
            try
            {
                string strSql = "SELECT pk_id_pago FROM tbl_pago WHERE tipo_pago = '" + cbo_tipopago.Text + "';";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader[0].ToString();
                    
                }
                return null;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }

        }
        //llenado de campo codigo de Datagridview dgv_facturacion
        public void llenado_codigo_dgv()
        {
            strCodigo = null;
            try
            {
                string strSql = "SELECT pk_id_examen FROM tbl_examen WHERE nombre_examen = '" + cbo_examen.Text + "';";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    strCodigo = reader[0].ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        public string consulta_codigoexamen(string strExamen)
        {
            
            try
            {
                string strSql = "SELECT pk_id_examen FROM tbl_examen WHERE nombre_examen = '" + strExamen + "';";
                OdbcCommand command = new OdbcCommand(strSql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader[0].ToString();
                }
                return null;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }

        }


        //Construcción del formato de dgv_facturacion
        DataTable dt_factura = new DataTable();
        private void FR_FACTURACION_Load(object sender, EventArgs e)
        {
            dt_factura.Columns.Add("Código");
            dt_factura.Columns.Add("Nombre examen");
            dt_factura.Columns.Add("Precio");
            dgv_facturacion.DataSource = dt_factura;

        }
        /// para eliminar una fila del datagridview
        public void eliminar_fila()
        {
            if(dgv_facturacion.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
            else
            {
                dgv_facturacion.Rows.Remove(dgv_facturacion.CurrentRow);
                total();
            }
        }
        //funcion para el calculo del total
        public void total()
        {
            float fltTotal = 0;
            for (int intContador = 0; intContador < dgv_facturacion.Rows.Count; intContador++)
            {
                fltTotal += Convert.ToSingle(dgv_facturacion.Rows[intContador].Cells[2].Value);
            }
            txt_total.Text = Convert.ToString(fltTotal);
        }
        List<CLS_DETALLEFACURA> lisDetalle = new List<CLS_DETALLEFACURA>();
        //llenado de lista detalles
        public void detalles()
        {
           
            CLS_DETALLEFACURA detallefactura = new CLS_DETALLEFACURA();
            for (int intContador = 0; intContador < dgv_facturacion.Rows.Count-1; intContador++)
            {
                detallefactura.StrIdDetallefactura= Convert.ToString(dgv_facturacion.Rows[intContador].Cells[0].Value);
                detallefactura.StrIdEncabezado = txt_no_factura.Text;
                detallefactura.StridExamen = consulta_codigoexamen(Convert.ToString(dgv_facturacion.Rows[intContador].Cells[1].Value));
                detallefactura.StrSubtotal = Convert.ToString(dgv_facturacion.Rows[intContador].Cells[2].Value);
                lisDetalle.Add(detallefactura);
            }
        }
        CLS_ENCABEZADOFACTURA encabezadofactura = new CLS_ENCABEZADOFACTURA();
        //llendo de datos para encabezado
        public void encabezado()
        {
           
            encabezadofactura.StrIdEncabezado = txt_no_factura.Text;
            encabezadofactura.StrNoSerie = txt_no_serie.Text;
            encabezadofactura.StrNombre = txt_nombre.Text;
            encabezadofactura.StrApellido = txt_apellido.Text;
            encabezadofactura.StrNit = txt_nit.Text;
            encabezadofactura.StrFecha = dtp_fecha.Value.ToString(dtp_fecha.CustomFormat = "yyyy-MM-dd HH:mm:ss");
            encabezadofactura.StrTotal = txt_total.Text;
            encabezadofactura.StrIdTipoPago = consulta_tipo_pago();
        }
        //confirmacion de facturacion
        private void btn_confirma_facturacion_Click(object sender, EventArgs e)
        {
            CLS_FACTURACION insercion = new CLS_FACTURACION();
            //BRIAN SANTIZO
            //IMPRIMIR
            encabezado();
            detalles();
            bool prue = insercion.InsertarFactura(encabezadofactura, lisDetalle);
            /*Bitacora bit = new Bitacora();
            bit.grabar("25");
            printDocument1.Print();*/
        }

        private void cbo_examen_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenado_precio();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CamposLetras(e);
        }
        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CamposLetras(e);
        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CampoNumerico(e);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DataRow dR_fila = dt_factura.NewRow();

            dR_fila["Código"] = strCodigo;
            dR_fila["Nombre examen"] = cbo_examen.Text;
            dR_fila["Precio"] = txt_precio.Text;
            dt_factura.Rows.Add(dR_fila);
            total();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            eliminar_fila();
        }
    }
}

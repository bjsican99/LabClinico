//BRIAN SANTIZO FORM
//0901-17-1483
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib; //LIBRERIA DE CODIGO DE BARRAS
using Clinica.CLS_CLASES;

namespace Clinica
{
    public partial class FR_ETIQUETA : Form
    {
        private Image imgFinal;
        CLS_METODOS metodos = new CLS_METODOS();
        CLS_VALIDACION validacion = new CLS_VALIDACION();

        public FR_ETIQUETA()
        {
            InitializeComponent();
            bloquear();
        }

        private void FR_ETIQUETA_Load(object sender, EventArgs e)
        {

        }
        private void pnl_etiqueta_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnl_etiqueta.BackColor = Color.FromArgb(25, 0, 0, 0);
        }
        public void bloquear()
        {
            pnl_codigobarras.Enabled = false;
            txt_apellido.Enabled = false;
            txt_nombre.Enabled = false;
            btn_generar.Enabled = false;
            btn_guardar.Enabled = false; 
        }
        public void Limpiar()
        {
            txt_codigo.Text = null;
            txt_nombre.Text = null;
            txt_apellido.Text = null;
            btn_generar.Enabled = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //BRIAN SANTIZO
            //CODIGO PARA CONVERTIR A IMAGEN LO QUE ESTA DE FONDO EN EL PANEL
            //YA QUE EL CODIGO DE BARRAS SE SETEA COMO IMAGEN DE FONDO
            Image imgFinal = (Image)pnl_codigobarras.BackgroundImage.Clone();
            SaveFileDialog Cajadedialogoguardar = new SaveFileDialog();
            Cajadedialogoguardar.AddExtension = true;
            Cajadedialogoguardar.Filter = "Image PNG (*.png )|*.png ";
            Cajadedialogoguardar.ShowDialog();
            if (!string.IsNullOrEmpty(Cajadedialogoguardar.FileName))
            {
                imgFinal.Save(Cajadedialogoguardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
            bloquear();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //BRIAN SANTIZO
            //EXTRAE TODO LO QUE ESTE DENTRO DEL PANEL A SI ANCHO Y ALTO 
            //SE PONE AQUI PARA QUE SEA LO QUE ESTE DENTRO DEL DOCUMENTO DE IMPRESION
            Bitmap bm = new Bitmap(pnl_codigobarras.Width, pnl_codigobarras.Height);
            pnl_codigobarras.DrawToBitmap(bm, new Rectangle(0, 0, pnl_codigobarras.Width, pnl_codigobarras.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

            //BRIAN SANTIZO
            //CODIGO PARA LA GENERACION DE EL CODIGO DE BARRAS DENTRO DEL PANEL
            
            btn_guardar.Enabled = true;
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            pnl_codigobarras.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, txt_codigo.Text+"_"+txt_nombre.Text+"_"+txt_apellido.Text , Color.Black, Color.White, 400, 100);
            Image imgFinal = (Image)pnl_codigobarras.BackgroundImage.Clone();
            Bitacora bit = new Bitacora();
            bit.grabar("23");
            Limpiar();
        }

        bool boBandera;
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CampoNumerico(e);
            if (Char.IsNumber(e.KeyChar))
            {
                boBandera = true;
            }
            else
            {
                boBandera = false;
            }
            
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (boBandera==true && txt_codigo.Text != "")
            {
                OdbcDataReader mostrar = metodos.consulta_etiqueta(txt_codigo.Text);
                try
                {
                    mostrar.Read();
                    txt_nombre.Text = mostrar.GetString(0);
                    txt_apellido.Text = mostrar.GetString(1);
                    btn_generar.Enabled = true;
                }
                catch (Exception err)
                {
                    btn_generar.Enabled = false;
                    Limpiar();
                    MessageBox.Show("Código no existente");
                    Console.WriteLine(err.Message);
                }
            }
        }
    }
}

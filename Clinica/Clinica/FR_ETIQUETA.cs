//BRIAN SANTIZO FORM
//0901-17-1483
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib; //LIBRERIA DE CODIGO DE BARRAS

namespace Clinica
{
    public partial class FR_ETIQUETA : Form
    {
        private Image imgFinal;
       

        public FR_ETIQUETA()
        {
            InitializeComponent();
        }

        private void FR_ETIQUETA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BRIAN SANTIZO
            //CODIGO PARA LA GENERACION DE EL CODIGO DE BARRAS DENTRO DEL PANEL
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            pnl_codigobarras.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128,txt_codigo.Text,Color.Black, Color.White, 400,100);
            Image imgFinal = (Image)pnl_codigobarras.BackgroundImage.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
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
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //BRIAN SANTIZO
            //EXTRAE TODO LO QUE ESTE DENTRO DEL PANEL A SI ANCHO Y ALTO 
            //SE PONE AQUI PARA QUE SEA LO QUE ESTE DENTRO DEL DOCUMENTO DE IMPRESION
            Bitmap bm = new Bitmap(pnl_codigobarras.Width,pnl_codigobarras.Height);
            pnl_codigobarras.DrawToBitmap(bm, new Rectangle(0, 0, pnl_codigobarras.Width, pnl_codigobarras.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BRIAN SANTIZO
            //IMPRESION
            printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FR_TOTAL usu = new FR_TOTAL();
            usu.Show();
            this.Hide();
        }
    }
}

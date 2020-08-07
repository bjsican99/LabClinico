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
using BarcodeLib;

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
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panel1.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128,textBox1.Text,Color.Black, Color.White, 400,100);
            Image imgFinal = (Image)panel1.BackgroundImage.Clone();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panel1.BackgroundImage.Clone();
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
            Bitmap bm = new Bitmap(panel1.Width,panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, panel1.Width, panel1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();






        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += printDocument1_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog()== DialogResult.OK) {



                doc.Print();
            
            
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}

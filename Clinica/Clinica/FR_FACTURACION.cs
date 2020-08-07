using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FR_FACTURACION : Form
    {
        private int y;
        private float width;

        string umglogo = @"C:\LabClinico\Clinica\Iconos\umglogo.png";

        public FR_FACTURACION()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Font font = new Font("Corbel", 14, FontStyle.Bold, GraphicsUnit.Point);
            Image img = Image.FromFile(umglogo);


            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20)); e.Graphics.DrawImage(img, new Rectangle(0, y += 20, 300, 300));
            e.Graphics.DrawString("Laboratorio Clinico UMG", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Guatemala, Ciudad de Guatemala", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Dirección: 15 calle A, Zona 10", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Telefono: 5000-4020", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("N# Factura: " +TX_FACTURA.Text  , font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Fecha: " +TX_FECHA.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Nombre: "+TX_NOMBRE.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Examen: "+TX_EXAMEN.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Total a pagar: "+TX_TOTAL.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Dicen que algunos nacen para sanadores", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("unos pocos selectos.", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

            






        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

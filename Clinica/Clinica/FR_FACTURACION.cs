//BRIAN SANTIZO FORM
//0901-17-1483
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
        //BRIAN SANTIZO
        //PARAMETROS DE LA FACTURA QUE DEBEN SER INICIALIZADOS 
        private int y;
        private float width;

        //RUTA DE LA IMAGEN/MARCA DE AGUA DE LA FACTURA
        string umglogo = @"C:\LabClinico\Clinica\Iconos\umglogo.png";  

        public FR_FACTURACION()
        {
            InitializeComponent();
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
            e.Graphics.DrawString("N# Factura: " +txt_factura.Text  , font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Fecha: " +txt_fecha.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Nombre: "+txt_nombre.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Examen: "+txt_examen.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Total a pagar: "+txt_total.Text, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Dicen que algunos nacen para sanadores", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("unos pocos selectos.", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

            






        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BRIAN SANTIZO
            //IMPRIMIR
            printDocument1.Print();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FR_FACTURACION_Load(object sender, EventArgs e)
        {

        }
    }
}

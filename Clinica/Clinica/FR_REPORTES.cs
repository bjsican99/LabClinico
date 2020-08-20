/*
 * Bryan Mazariegos 0901-17-1001
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Drawing.Printing;
using System.Security.Policy;

namespace Clinica
{
    public partial class FR_REPORTES : Form
    {
        public FR_REPORTES()
        {
            InitializeComponent();
            if (Clase_Global.TipoGlobal != "1")
            {
            }
            else
            {
                
            }



        }

        private void pnl_reportes_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnl_reportes.BackColor = Color.FromArgb(25, 0, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes.FR_REGPACIENTES fr = new Reportes.FR_REGPACIENTES();
            fr.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Reportes.FR_RGANANCIAS fr = new Reportes.FR_RGANANCIAS();
            fr.Show();
        }

        private void btn_acciones_usuario_Click(object sender, EventArgs e)
        {
            Reportes.FR_RBTACORA fr = new Reportes.FR_RBTACORA();
            fr.Show();
        }

        private void btn_examenes_ultima_visita_Click(object sender, EventArgs e)
        {
            Reportes.FR_REXAMEN fr = new Reportes.FR_REXAMEN();
            fr.Show();
        }

        private void btn_resultado_examenes_Click(object sender, EventArgs e)
        {
            Reportes.FR_RRESULTADOS fr = new Reportes.FR_RRESULTADOS();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes.FR_RUVISITA fr = new Reportes.FR_RUVISITA();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes.FR_RHPACIENTE fr = new Reportes.FR_RHPACIENTE();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FR_RFACTURA fr = new Reportes.FR_RFACTURA();
            fr.Show();
        }
    }
}

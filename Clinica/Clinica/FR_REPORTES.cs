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
    }
}

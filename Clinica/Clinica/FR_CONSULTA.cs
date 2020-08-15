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
    public partial class FR_CONSULTA : Form
    {
        CLS_METODOS metodos = new CLS_METODOS();

        public FR_CONSULTA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = metodos.consulta_empleado();
            try
            {
                while (mostrar.Read())
                {
                    dgv_consulta.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7), mostrar.GetString(8), mostrar.GetString(9), mostrar.GetString(10), mostrar.GetString(11), mostrar.GetString(12));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void FR_CONSULTA_Load(object sender, EventArgs e)
        {
            dgv_consulta.Rows.Clear();
            mostrar_consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_consulta.Rows.Clear();
            mostrar_consulta();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dgv_consulta.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

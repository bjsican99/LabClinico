//BRIAN SANTIZO FORM
//0901-17-1483
using Clinica.CLS_CLASES;
using System;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FR_EMPLEADO : Form
    {
        CLS_METODOS metodos = new CLS_METODOS();
        string str_codigo="";
        public FR_EMPLEADO()
        {
            InitializeComponent();
            bloqueo();
        }

        string str_fechanacimineto = "";
        string str_fechaingreso = "";
        string str_genero = "";
        string str_estadocivil = "";
        string str_estado = "";

        public void obtenercodigo()
        {
            str_codigo = metodos.siguiente("tbl_empleado", "pk_id_empleado");
            txt_codigo.Text = str_codigo;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            panel1.BackColor = Color.FromArgb(25, 0, 0, 0);
        }

        public void bloqueo()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = false;
            txt_apellido.Enabled = false;
            txt_direccion.Enabled = false;
            txt_dpi.Enabled = false;
            txt_nit.Enabled = false;
            dtp_fechaingreso.Enabled = false;
            dtp_fechanacimiento.Enabled = false;
            cbo_estado.Enabled = false;
            cbo_estadocivil.Enabled = false;
            cbo_genero.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_consultar.Enabled = true;
        }
        public void desbloqueo()
        {
            txt_codigo.Enabled = false;
            txt_nombre.Enabled = true;
            txt_apellido.Enabled = true;
            txt_direccion.Enabled = true;
            txt_dpi.Enabled = true;
            txt_nit.Enabled = true;
            dtp_fechaingreso.Enabled = true;
            dtp_fechanacimiento.Enabled = true;
            cbo_estado.Enabled = true;
            cbo_estadocivil.Enabled = true;
            cbo_genero.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
            btn_consultar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_guardar.Enabled = true;
        }
        public void limpiar()
        {
            //LIMPIAR
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_direccion.Text = "";
            txt_dpi.Text = "";
            txt_nit.Text = "";
            dtp_fechaingreso.Value.ToString(DateTime.Now.ToShortDateString());
            dtp_fechanacimiento.Value.ToString(DateTime.Now.ToShortDateString());
            cbo_estado.Text = "";
            cbo_estadocivil.Text = "";
            cbo_genero.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_apellido.Text = "";
            cbo_estadocivil.Text = ("");
        }
        
        public void Fechas()
        {
            str_fechanacimineto = dtp_fechanacimiento.Value.ToString(dtp_fechanacimiento.CustomFormat = "yyyy-MM-dd");
            str_fechaingreso = dtp_fechaingreso.Value.ToString(dtp_fechaingreso.CustomFormat = "yyyy-MM-dd");
        }
        public void comparacioncombobox()
        {
            if (cbo_genero.SelectedItem.ToString() == "Masculino")
            {
                str_genero = "1";
            }
            else
            {
                str_genero = "0";
            }
            if (cbo_estadocivil.SelectedItem.ToString() == "Casado")
            {
                str_estadocivil = "1";
            }
            else
            {
                str_estadocivil = "0";
            }
            if (cbo_estado.SelectedItem.ToString() == "Activo")
            {
                str_estado = "1";
            }
            else
            {
                str_estado = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dt_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Fechas();
            comparacioncombobox();
            OdbcDataReader cita = metodos.Insertar_empleado(str_codigo, txt_nombre.Text,txt_apellido.Text,txt_dpi.Text,txt_direccion.Text,txt_nit.Text,str_fechanacimineto,str_fechaingreso,txt_telefono.Text,txt_correo.Text,str_genero,str_estadocivil,str_estado);
            limpiar();
            bloqueo();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Fechas();
            comparacioncombobox();
            OdbcDataReader cita = metodos.modificar_empleado(txt_codigo.Text, txt_nombre.Text, txt_apellido.Text, txt_dpi.Text, txt_direccion.Text, txt_nit.Text, str_fechanacimineto, str_fechaingreso, txt_telefono.Text, txt_correo.Text, str_genero, str_estadocivil, str_estado);
            limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = metodos.eliminar_empleado(txt_codigo.Text);
            limpiar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            obtenercodigo();
            desbloqueo();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            FR_CONSULTA consulta = new FR_CONSULTA();
            consulta.ShowDialog();

            if (consulta.DialogResult == DialogResult.OK)
            {
                /*Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_descripcion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_valor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();*/
            }
        }

        private void FR_EMPLEADO_Load(object sender, EventArgs e)
        {
            bloqueo();
        }
    }
}

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
    public partial class FR_DOCTOR : Form
    {
        CLS_METODOS metodos = new CLS_METODOS();
        CLS_VALIDACION validacion = new CLS_VALIDACION();
        string strCodigo = "";
        public FR_DOCTOR()
        {
            InitializeComponent();
            bloqueo();
        }

        private void FR_DOCTOR_Load(object sender, EventArgs e)
        {

        }
        string strFechanacimineto = "";
        string strFechaingreso = "";
        string strGenero = "";
        string strEstadocivil = "";
        string strEstado = "";

        public void obtenercodigo()
        {
            strCodigo = metodos.siguiente("tbl_doctor", "pk_id_doctor");
            txt_codigo.Text = strCodigo;
        }
        private void pnl_doctor_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnl_doctor.BackColor = Color.FromArgb(25, 0, 0, 0);
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
            btn_nuevo.Enabled = true;
        }
        public void desbloqueo_ingreso()
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
            btn_consultar.Enabled = true;
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_guardar.Enabled = true;
        }
        public void desbloqueo_modificar_eliminar()
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
            btn_consultar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = true;
        }
        public void limpiar()
        {
            //LIMPIAR
            txt_codigo.Text = "";
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
            strFechanacimineto = dtp_fechanacimiento.Value.ToString(dtp_fechanacimiento.CustomFormat = "yyyy-MM-dd");
            strFechaingreso = dtp_fechaingreso.Value.ToString(dtp_fechaingreso.CustomFormat = "yyyy-MM-dd");
        }
        public void comparacioncombobox()
        {
            if (cbo_genero.SelectedItem.ToString() == "Masculino")
            {
                strGenero = "1";
            }
            else
            {
                strGenero = "0";
            }
            if (cbo_estadocivil.SelectedItem.ToString() == "Casado")
            {
                strEstadocivil = "1";
            }
            else
            {
                strEstadocivil = "0";
            }
            if (cbo_estado.SelectedItem.ToString() == "Activo")
            {
                strEstado = "1";
            }
            else
            {
                strEstado = "0";
            }
        }

        public void llenadocombobox(string strLlenadogenero, string strLlenadoestadocivil, string strLlenadoestado)
        {
            if (strLlenadogenero == "1")
            {
                strGenero = "Masculino";
            }
            else
            {
                strGenero = "Femenino";
            }
            if (strLlenadoestadocivil == "1")
            {
                strEstadocivil = "Casado";
            }
            else
            {
                strEstadocivil = "Soltero";
            }
            if (strLlenadoestado == "1")
            {
                strEstado = "Activo";
            }
            else
            {
                strEstado = "Desactivo";
            }
        }



        private void dt_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Fechas();
            comparacioncombobox();
            OdbcDataReader cita = metodos.Insertar_doctor(strCodigo, txt_nombre.Text, txt_apellido.Text, txt_dpi.Text, txt_direccion.Text, txt_nit.Text, strFechanacimineto, strFechaingreso, txt_telefono.Text, txt_correo.Text, strGenero, strEstadocivil, strEstado);
            limpiar();
            bloqueo();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Fechas();
            comparacioncombobox();
            OdbcDataReader cita = metodos.modificar_doctor(txt_codigo.Text, txt_nombre.Text, txt_apellido.Text, txt_dpi.Text, txt_direccion.Text, txt_nit.Text, strFechanacimineto, strFechaingreso, txt_telefono.Text, txt_correo.Text, strGenero, strEstadocivil, strEstado);
            limpiar();
            bloqueo();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = metodos.eliminar_doctor(txt_codigo.Text);
            limpiar();
            bloqueo();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            obtenercodigo();
            desbloqueo_ingreso();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            limpiar();
            FR_CONSULTADOCTOR consulta = new FR_CONSULTADOCTOR();
            consulta.ShowDialog();

            if (consulta.DialogResult == DialogResult.OK)
            {
                txt_codigo.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[0].Value.ToString();
                txt_nombre.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[1].Value.ToString();
                txt_apellido.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[2].Value.ToString();
                txt_dpi.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[3].Value.ToString();
                txt_direccion.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[4].Value.ToString();
                txt_nit.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[5].Value.ToString();
                dtp_fechanacimiento.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[6].Value.ToString();
                dtp_fechaingreso.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[7].Value.ToString();
                txt_telefono.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[8].Value.ToString();
                txt_correo.Text = consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].
                    Cells[9].Value.ToString();
                llenadocombobox(consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].Cells[10].Value.ToString(), consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].Cells[11].Value.ToString(), consulta.dgv_consulta.Rows[consulta.dgv_consulta.CurrentRow.Index].Cells[12].Value.ToString());

                cbo_genero.Text = strGenero;
                cbo_estadocivil.Text = strEstadocivil;
                cbo_estado.Text = strEstado;
                desbloqueo_modificar_eliminar();
            }
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CamposLetrasTexto(e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CamposLetrasTexto(e);
        }

        private void txt_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CampoNumerico(e);
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CamposNumerosYLetras(e);
        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CampoNumerico(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CampoNumerico(e);
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.CamposNumerosYLetras(e);
        }
    }
}

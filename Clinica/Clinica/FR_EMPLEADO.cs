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
        string strCodigo = "";
        CLS_VALIDACION validacion = new CLS_VALIDACION();
        public FR_EMPLEADO()
        {
            InitializeComponent();
            limpiar();
            bloqueo();
            if (Clase_Global.TipoGlobal != "1")
            {
                btn_consultar.Enabled = false;
            }
            else
            {
                btn_consultar.Enabled = true;
            }
        }

        string strFechanacimineto = "";
        string strFechaingreso = "";
        string strGenero = "";
        string strEstadocivil = "";
        string strEstado = "";

        public void obtenercodigo()
        {
            strCodigo = metodos.siguiente("tbl_empleado", "pk_id_empleado");
            txt_codigo.Text = strCodigo;
        }
        private void pnl_empleado_Paint(object sender, PaintEventArgs e)
        {
            //CODIGO PARA HACER TRASLUCIDO EL PANEL
            pnl_empleado.BackColor = Color.FromArgb(25, 0, 0, 0);
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
            btn_consultar.Enabled = false;
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
        //validacion de Campos vacios
        public bool validacion_campos_vacios()
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("El campo codigo no puede estar vacío");
                return false;
            }
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Debe llenar el campo: Nombres");
                return false;
            }
            if (txt_apellido.Text == "")
            {
                MessageBox.Show("Debe llenar el campo: Apellidos");
                return false;
            }
            if (txt_dpi.Text == "")
            {
                MessageBox.Show("Debe llenar el campo: DPI");
                return false;
            }
            if (txt_direccion.Text == "")
            {
                MessageBox.Show("Debe llenar el campo: Dirección");
                return false;
            }
            if (txt_nit.Text == "")
            {
                MessageBox.Show("Debe llenar el campo: NIT solo digitos");
                return false;
            }
            if (cbo_genero.Text == "")
            {
                MessageBox.Show("Debe seleccionar un elemento del campo: Genero");
                return false;
            }
            if (cbo_estadocivil.Text == "")
            {
                MessageBox.Show("Debe seleccionar un elemento del campo: Estado civil");
                return false;
            }
            if (cbo_estado.Text == "")
            {
                MessageBox.Show("Debe seleccionar un elemento del campo: Estado");
                return false;
            }
            return true;

        }

        public void Fechas()
        {
            strFechanacimineto = dtp_fechanacimiento.Value.ToString(dtp_fechanacimiento.CustomFormat = "yyyy-MM-dd");
            strFechaingreso = dtp_fechaingreso.Value.ToString(dtp_fechaingreso.CustomFormat = "yyyy-MM-dd");
        }
        public void comparacioncombobox()
        {
            //comparacion de genero
            if (cbo_genero.SelectedItem.ToString() == "Masculino")
            {
                strGenero = "1";
            }
            else
            {
                strGenero = "0";
            }
            //comparacion estado civil
            if (cbo_estadocivil.SelectedItem.ToString() == "Casado")
            {
                strEstadocivil = "1";
            }
            else if (cbo_estadocivil.SelectedItem.ToString() == "Soltero")
            {
                strEstadocivil = "2";
            }
            else if (cbo_estadocivil.SelectedItem.ToString() == "Divorciado")
            {
                strEstadocivil = "3";
            }
            else
            {
                strEstadocivil = "4";
            }
            //comparacion para ver si esta activo o no 
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
            //comparacion para cbo_genero
            if (strLlenadogenero == "1")
            {
                strGenero = "Masculino";
            }
            else
            {
                strGenero = "Femenino";
            }
            //comparacion para cbo_estadocivil
            if (strLlenadoestadocivil == "1")
            {
                strEstadocivil = "Casado";
            }
            else if (strLlenadoestadocivil == "2")
            {
                strEstadocivil = "Soltero";
            }
            else if (strLlenadoestadocivil == "3")
            {
                strEstadocivil = "Divorciado";
            }
            else if (strLlenadoestadocivil == "4")
            {
                strEstadocivil = "Viudo";
            }
            //comparacion para cbo_estado
            if (strLlenadoestado == "1")
            {
                strEstado = "Activo";
            }
            else
            {
                strEstado = "Desactivo";
            }
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validacion_campos_vacios())
            {
                Bitacora bit = new Bitacora();
                bit.grabar("11");
                Fechas();
                comparacioncombobox();
                metodos.Insertar_empleado(strCodigo, txt_nombre.Text, txt_apellido.Text, txt_dpi.Text, txt_direccion.Text, txt_nit.Text, strFechanacimineto, strFechaingreso, txt_telefono.Text, txt_correo.Text, strGenero, strEstadocivil, strEstado);
                limpiar();
                bloqueo();
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validacion_campos_vacios())
            {
                Bitacora bit = new Bitacora();
                bit.grabar("12");
                Fechas();
                comparacioncombobox();
                metodos.modificar_empleado(txt_codigo.Text, txt_nombre.Text, txt_apellido.Text, txt_dpi.Text, txt_direccion.Text, txt_nit.Text, strFechanacimineto, strFechaingreso, txt_telefono.Text, txt_correo.Text, strGenero, strEstadocivil, strEstado);
                limpiar();
                bloqueo();
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("13");
            metodos.eliminar_empleado(txt_codigo.Text);
            limpiar();
            bloqueo();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.grabar("10");
            limpiar();
            obtenercodigo();
            desbloqueo_ingreso();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            /*
              * Codigo Estraido del  usuario de github imogollonh del repositorio Bienestar_SCM 
              * del link https://github.com/imogollonh/Bienestar_SCM 
              * 
              * adaptado a proyecto por Bryan Mazariegos 0901-17-1001 al proyecto LabClinico 
              */
            Bitacora bit = new Bitacora();
            bit.grabar("14");
            limpiar();
            FR_CONSULTA consulta = new FR_CONSULTA();
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

        private void FR_EMPLEADO_Load(object sender, EventArgs e)
        {
            bloqueo();
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

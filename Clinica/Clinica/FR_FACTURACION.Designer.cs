namespace Clinica
{
    partial class FR_FACTURACION
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_FACTURACION));
            this.lbl_facturacion = new System.Windows.Forms.Label();
            this.lbl_factura = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_no_serie = new System.Windows.Forms.TextBox();
            this.txt_no_factura = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_confimar_facturacion = new System.Windows.Forms.Button();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pnl_factura = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_deshacer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_facturacion = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_tipopago = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_pago = new System.Windows.Forms.Label();
            this.cbo_examen = new System.Windows.Forms.ComboBox();
            this.lbl_examen = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.pnl_factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_facturacion
            // 
            this.lbl_facturacion.AutoSize = true;
            this.lbl_facturacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_facturacion.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_facturacion.Location = new System.Drawing.Point(251, 3);
            this.lbl_facturacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_facturacion.Name = "lbl_facturacion";
            this.lbl_facturacion.Size = new System.Drawing.Size(134, 29);
            this.lbl_facturacion.TabIndex = 0;
            this.lbl_facturacion.Text = "Facturación";
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_factura.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_factura.Location = new System.Drawing.Point(318, 32);
            this.lbl_factura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(106, 29);
            this.lbl_factura.TabIndex = 1;
            this.lbl_factura.Text = "No. Serie";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre.Location = new System.Drawing.Point(14, 65);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(96, 29);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_apellido.Location = new System.Drawing.Point(318, 65);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(98, 29);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numero.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_numero.Location = new System.Drawing.Point(14, 32);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(133, 29);
            this.lbl_numero.TabIndex = 5;
            this.lbl_numero.Text = "No. Factura";
            // 
            // txt_no_serie
            // 
            this.txt_no_serie.Location = new System.Drawing.Point(465, 41);
            this.txt_no_serie.Margin = new System.Windows.Forms.Padding(2);
            this.txt_no_serie.Name = "txt_no_serie";
            this.txt_no_serie.Size = new System.Drawing.Size(146, 20);
            this.txt_no_serie.TabIndex = 6;
            // 
            // txt_no_factura
            // 
            this.txt_no_factura.Location = new System.Drawing.Point(151, 41);
            this.txt_no_factura.Margin = new System.Windows.Forms.Padding(2);
            this.txt_no_factura.Name = "txt_no_factura";
            this.txt_no_factura.Size = new System.Drawing.Size(155, 20);
            this.txt_no_factura.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(114, 74);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(192, 20);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(419, 74);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(192, 20);
            this.txt_apellido.TabIndex = 9;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_confimar_facturacion
            // 
            this.btn_confimar_facturacion.BackColor = System.Drawing.Color.White;
            this.btn_confimar_facturacion.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confimar_facturacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_confimar_facturacion.Image")));
            this.btn_confimar_facturacion.Location = new System.Drawing.Point(532, 309);
            this.btn_confimar_facturacion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confimar_facturacion.Name = "btn_confimar_facturacion";
            this.btn_confimar_facturacion.Size = new System.Drawing.Size(79, 72);
            this.btn_confimar_facturacion.TabIndex = 11;
            this.btn_confimar_facturacion.UseVisualStyleBackColor = false;
            this.btn_confimar_facturacion.Click += new System.EventHandler(this.btn_confirma_facturacion_Click);
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(114, 104);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(192, 20);
            this.txt_nit.TabIndex = 13;
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nit_KeyPress);
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_nit.Location = new System.Drawing.Point(14, 92);
            this.lbl_nit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(51, 29);
            this.lbl_nit.TabIndex = 12;
            this.lbl_nit.Text = "NIT";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha.Location = new System.Drawing.Point(318, 94);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(74, 29);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.Text = "Fecha";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(389, 362);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(122, 20);
            this.txt_total.TabIndex = 16;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_total.Location = new System.Drawing.Point(288, 353);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(97, 29);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "Total   Q";
            // 
            // pnl_factura
            // 
            this.pnl_factura.Controls.Add(this.btn_regresar);
            this.pnl_factura.Controls.Add(this.btn_deshacer);
            this.pnl_factura.Controls.Add(this.label2);
            this.pnl_factura.Controls.Add(this.dgv_facturacion);
            this.pnl_factura.Controls.Add(this.btn_agregar);
            this.pnl_factura.Controls.Add(this.txt_precio);
            this.pnl_factura.Controls.Add(this.label1);
            this.pnl_factura.Controls.Add(this.cbo_tipopago);
            this.pnl_factura.Controls.Add(this.lbl_tipo_pago);
            this.pnl_factura.Controls.Add(this.cbo_examen);
            this.pnl_factura.Controls.Add(this.lbl_examen);
            this.pnl_factura.Controls.Add(this.dtp_fecha);
            this.pnl_factura.Controls.Add(this.lbl_total);
            this.pnl_factura.Controls.Add(this.btn_confimar_facturacion);
            this.pnl_factura.Controls.Add(this.txt_total);
            this.pnl_factura.Controls.Add(this.lbl_fecha);
            this.pnl_factura.Controls.Add(this.txt_nit);
            this.pnl_factura.Controls.Add(this.lbl_nit);
            this.pnl_factura.Controls.Add(this.txt_apellido);
            this.pnl_factura.Controls.Add(this.txt_nombre);
            this.pnl_factura.Controls.Add(this.txt_no_factura);
            this.pnl_factura.Controls.Add(this.txt_no_serie);
            this.pnl_factura.Controls.Add(this.lbl_numero);
            this.pnl_factura.Controls.Add(this.lbl_apellido);
            this.pnl_factura.Controls.Add(this.lbl_nombre);
            this.pnl_factura.Controls.Add(this.lbl_factura);
            this.pnl_factura.Controls.Add(this.lbl_facturacion);
            this.pnl_factura.Location = new System.Drawing.Point(18, 17);
            this.pnl_factura.Name = "pnl_factura";
            this.pnl_factura.Size = new System.Drawing.Size(638, 415);
            this.pnl_factura.TabIndex = 18;
            this.pnl_factura.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_factura_Paint);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(604, 2);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(34, 33);
            this.btn_regresar.TabIndex = 81;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.Image = ((System.Drawing.Image)(resources.GetObject("btn_deshacer.Image")));
            this.btn_deshacer.Location = new System.Drawing.Point(512, 222);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(51, 39);
            this.btn_deshacer.TabIndex = 80;
            this.btn_deshacer.UseVisualStyleBackColor = true;
            this.btn_deshacer.Click += new System.EventHandler(this.btn_deshacer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(527, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = "Facturar";
            // 
            // dgv_facturacion
            // 
            this.dgv_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facturacion.Location = new System.Drawing.Point(18, 222);
            this.dgv_facturacion.Name = "dgv_facturacion";
            this.dgv_facturacion.Size = new System.Drawing.Size(494, 128);
            this.dgv_facturacion.TabIndex = 78;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Corbel", 17F, System.Drawing.FontStyle.Bold);
            this.btn_agregar.Location = new System.Drawing.Point(357, 170);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(143, 39);
            this.btn_agregar.TabIndex = 77;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(114, 170);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(192, 20);
            this.txt_precio.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 75;
            this.label1.Text = "Precio  Q";
            // 
            // cbo_tipopago
            // 
            this.cbo_tipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipopago.FormattingEnabled = true;
            this.cbo_tipopago.Location = new System.Drawing.Point(419, 136);
            this.cbo_tipopago.Name = "cbo_tipopago";
            this.cbo_tipopago.Size = new System.Drawing.Size(192, 21);
            this.cbo_tipopago.TabIndex = 73;
            // 
            // lbl_tipo_pago
            // 
            this.lbl_tipo_pago.AutoSize = true;
            this.lbl_tipo_pago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo_pago.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_tipo_pago.Location = new System.Drawing.Point(306, 127);
            this.lbl_tipo_pago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo_pago.Name = "lbl_tipo_pago";
            this.lbl_tipo_pago.Size = new System.Drawing.Size(115, 29);
            this.lbl_tipo_pago.TabIndex = 72;
            this.lbl_tipo_pago.Text = "Tipo pago";
            // 
            // cbo_examen
            // 
            this.cbo_examen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_examen.FormattingEnabled = true;
            this.cbo_examen.Location = new System.Drawing.Point(114, 135);
            this.cbo_examen.Name = "cbo_examen";
            this.cbo_examen.Size = new System.Drawing.Size(192, 21);
            this.cbo_examen.TabIndex = 71;
            this.cbo_examen.SelectedIndexChanged += new System.EventHandler(this.cbo_examen_SelectedIndexChanged);
            // 
            // lbl_examen
            // 
            this.lbl_examen.AutoSize = true;
            this.lbl_examen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_examen.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_examen.Location = new System.Drawing.Point(13, 126);
            this.lbl_examen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_examen.Name = "lbl_examen";
            this.lbl_examen.Size = new System.Drawing.Size(97, 29);
            this.lbl_examen.TabIndex = 70;
            this.lbl_examen.Text = "Examen";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(419, 101);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fecha.Size = new System.Drawing.Size(118, 20);
            this.dtp_fecha.TabIndex = 69;
            // 
            // FR_FACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.pnl_factura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FR_FACTURACION";
            this.Text = "FR_FACTURACION";
            this.Load += new System.EventHandler(this.FR_FACTURACION_Load);
            this.pnl_factura.ResumeLayout(false);
            this.pnl_factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_facturacion;
        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_no_serie;
        private System.Windows.Forms.TextBox txt_no_factura;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_confimar_facturacion;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel pnl_factura;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cbo_examen;
        private System.Windows.Forms.Label lbl_examen;
        private System.Windows.Forms.ComboBox cbo_tipopago;
        private System.Windows.Forms.Label lbl_tipo_pago;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_facturacion;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deshacer;
        private System.Windows.Forms.Button btn_regresar;
    }
}
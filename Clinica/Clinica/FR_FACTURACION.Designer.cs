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
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pnl_factura = new System.Windows.Forms.Panel();
            this.dtp_fechaingreso = new System.Windows.Forms.DateTimePicker();
            this.lbl_examen = new System.Windows.Forms.Label();
            this.cbo_Examen = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_factura.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_facturacion
            // 
            this.lbl_facturacion.AutoSize = true;
            this.lbl_facturacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_facturacion.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_facturacion.Location = new System.Drawing.Point(237, 14);
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
            this.lbl_factura.Location = new System.Drawing.Point(403, 49);
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
            this.lbl_nombre.Location = new System.Drawing.Point(17, 89);
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
            this.lbl_apellido.Location = new System.Drawing.Point(321, 89);
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
            this.lbl_numero.Location = new System.Drawing.Point(4, 49);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(133, 29);
            this.lbl_numero.TabIndex = 5;
            this.lbl_numero.Text = "No. Factura";
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(513, 58);
            this.txt_serie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(101, 20);
            this.txt_serie.TabIndex = 6;
            this.txt_serie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(136, 58);
            this.txt_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(99, 20);
            this.txt_factura.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(117, 98);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(192, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(422, 98);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(192, 20);
            this.txt_apellido.TabIndex = 9;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.White;
            this.btn_imprimir.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(467, 352);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(169, 45);
            this.btn_imprimir.TabIndex = 11;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(117, 136);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(192, 20);
            this.txt_nit.TabIndex = 13;
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_nit.Location = new System.Drawing.Point(68, 127);
            this.lbl_nit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(45, 29);
            this.lbl_nit.TabIndex = 12;
            this.lbl_nit.Text = "Nit";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha.Location = new System.Drawing.Point(345, 127);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(74, 29);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.Text = "Fecha";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(178, 352);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(240, 20);
            this.txt_total.TabIndex = 16;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(26, 341);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(63, 29);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "Total";
            // 
            // pnl_factura
            // 
            this.pnl_factura.Controls.Add(this.comboBox1);
            this.pnl_factura.Controls.Add(this.label1);
            this.pnl_factura.Controls.Add(this.cbo_Examen);
            this.pnl_factura.Controls.Add(this.lbl_examen);
            this.pnl_factura.Controls.Add(this.dtp_fechaingreso);
            this.pnl_factura.Controls.Add(this.lbl_total);
            this.pnl_factura.Controls.Add(this.btn_imprimir);
            this.pnl_factura.Controls.Add(this.txt_total);
            this.pnl_factura.Controls.Add(this.lbl_fecha);
            this.pnl_factura.Controls.Add(this.txt_nit);
            this.pnl_factura.Controls.Add(this.lbl_nit);
            this.pnl_factura.Controls.Add(this.txt_apellido);
            this.pnl_factura.Controls.Add(this.txt_nombre);
            this.pnl_factura.Controls.Add(this.txt_factura);
            this.pnl_factura.Controls.Add(this.txt_serie);
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
            // dtp_fechaingreso
            // 
            this.dtp_fechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaingreso.Location = new System.Drawing.Point(422, 133);
            this.dtp_fechaingreso.Name = "dtp_fechaingreso";
            this.dtp_fechaingreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fechaingreso.Size = new System.Drawing.Size(118, 20);
            this.dtp_fechaingreso.TabIndex = 69;
            // 
            // lbl_examen
            // 
            this.lbl_examen.AutoSize = true;
            this.lbl_examen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_examen.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_examen.Location = new System.Drawing.Point(16, 167);
            this.lbl_examen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_examen.Name = "lbl_examen";
            this.lbl_examen.Size = new System.Drawing.Size(97, 29);
            this.lbl_examen.TabIndex = 70;
            this.lbl_examen.Text = "Examen";
            // 
            // cbo_Examen
            // 
            this.cbo_Examen.FormattingEnabled = true;
            this.cbo_Examen.Location = new System.Drawing.Point(117, 176);
            this.cbo_Examen.Name = "cbo_Examen";
            this.cbo_Examen.Size = new System.Drawing.Size(192, 21);
            this.cbo_Examen.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(321, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "forma ";
            // 
            // FR_FACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.pnl_factura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FR_FACTURACION";
            this.Text = "FR_FACTURACION";
            this.Load += new System.EventHandler(this.FR_FACTURACION_Load);
            this.pnl_factura.ResumeLayout(false);
            this.pnl_factura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_facturacion;
        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Panel pnl_factura;
        private System.Windows.Forms.DateTimePicker dtp_fechaingreso;
        private System.Windows.Forms.ComboBox cbo_Examen;
        private System.Windows.Forms.Label lbl_examen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
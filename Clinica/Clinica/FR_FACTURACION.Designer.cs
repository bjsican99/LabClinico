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
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_facturacion
            // 
            this.lbl_facturacion.AutoSize = true;
            this.lbl_facturacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_facturacion.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_facturacion.Location = new System.Drawing.Point(337, 27);
            this.lbl_facturacion.Name = "lbl_facturacion";
            this.lbl_facturacion.Size = new System.Drawing.Size(227, 40);
            this.lbl_facturacion.TabIndex = 0;
            this.lbl_facturacion.Text = "FACTURACION";
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_factura.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factura.Location = new System.Drawing.Point(56, 92);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(106, 37);
            this.lbl_factura.TabIndex = 1;
            this.lbl_factura.Text = "# Serie";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(56, 195);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(120, 37);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(56, 254);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(120, 37);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numero.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(56, 145);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(137, 37);
            this.lbl_numero.TabIndex = 5;
            this.lbl_numero.Text = "# Factura";
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(259, 105);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(318, 22);
            this.txt_serie.TabIndex = 6;
            this.txt_serie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(259, 158);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(318, 22);
            this.txt_factura.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(259, 208);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(318, 22);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(259, 267);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(318, 22);
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
            this.btn_imprimir.Location = new System.Drawing.Point(628, 231);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(225, 55);
            this.btn_imprimir.TabIndex = 11;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(259, 325);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(318, 22);
            this.txt_nit.TabIndex = 13;
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(56, 312);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(55, 37);
            this.lbl_nit.TabIndex = 12;
            this.lbl_nit.Text = "Nit";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(56, 370);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(91, 37);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(259, 383);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(318, 22);
            this.txt_fecha.TabIndex = 15;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(259, 443);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(318, 22);
            this.txt_total.TabIndex = 16;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(56, 430);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(80, 37);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "Total";
            // 
            // FR_FACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_factura);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_factura);
            this.Controls.Add(this.lbl_facturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_FACTURACION";
            this.Text = "FR_FACTURACION";
            this.Load += new System.EventHandler(this.FR_FACTURACION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
    }
}
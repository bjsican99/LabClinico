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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TX_FACTURA = new System.Windows.Forms.TextBox();
            this.TX_FECHA = new System.Windows.Forms.TextBox();
            this.TX_NOMBRE = new System.Windows.Forms.TextBox();
            this.TX_EXAMEN = new System.Windows.Forms.TextBox();
            this.TX_TOTAL = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "# Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Examen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // TX_FACTURA
            // 
            this.TX_FACTURA.Location = new System.Drawing.Point(240, 115);
            this.TX_FACTURA.Name = "TX_FACTURA";
            this.TX_FACTURA.Size = new System.Drawing.Size(217, 22);
            this.TX_FACTURA.TabIndex = 6;
            this.TX_FACTURA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TX_FECHA
            // 
            this.TX_FECHA.Location = new System.Drawing.Point(240, 168);
            this.TX_FECHA.Name = "TX_FECHA";
            this.TX_FECHA.Size = new System.Drawing.Size(217, 22);
            this.TX_FECHA.TabIndex = 7;
            // 
            // TX_NOMBRE
            // 
            this.TX_NOMBRE.Location = new System.Drawing.Point(240, 218);
            this.TX_NOMBRE.Name = "TX_NOMBRE";
            this.TX_NOMBRE.Size = new System.Drawing.Size(217, 22);
            this.TX_NOMBRE.TabIndex = 8;
            // 
            // TX_EXAMEN
            // 
            this.TX_EXAMEN.Location = new System.Drawing.Point(240, 277);
            this.TX_EXAMEN.Name = "TX_EXAMEN";
            this.TX_EXAMEN.Size = new System.Drawing.Size(217, 22);
            this.TX_EXAMEN.TabIndex = 9;
            // 
            // TX_TOTAL
            // 
            this.TX_TOTAL.Location = new System.Drawing.Point(240, 334);
            this.TX_TOTAL.Name = "TX_TOTAL";
            this.TX_TOTAL.Size = new System.Drawing.Size(217, 22);
            this.TX_TOTAL.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FR_FACTURACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TX_TOTAL);
            this.Controls.Add(this.TX_EXAMEN);
            this.Controls.Add(this.TX_NOMBRE);
            this.Controls.Add(this.TX_FECHA);
            this.Controls.Add(this.TX_FACTURA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_FACTURACION";
            this.Text = "FR_FACTURACION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TX_FACTURA;
        private System.Windows.Forms.TextBox TX_FECHA;
        private System.Windows.Forms.TextBox TX_NOMBRE;
        private System.Windows.Forms.TextBox TX_EXAMEN;
        private System.Windows.Forms.TextBox TX_TOTAL;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
    }
}
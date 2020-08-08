namespace Clinica
{
    partial class FR_ETIQUETA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_ETIQUETA));
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.pnl_codigobarras = new System.Windows.Forms.Panel();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.White;
            this.btn_generar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(190, 78);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(146, 48);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.White;
            this.btn_guardar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(374, 78);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(146, 48);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_codigobarras
            // 
            this.pnl_codigobarras.BackColor = System.Drawing.Color.White;
            this.pnl_codigobarras.Location = new System.Drawing.Point(182, 323);
            this.pnl_codigobarras.Name = "pnl_codigobarras";
            this.pnl_codigobarras.Size = new System.Drawing.Size(532, 172);
            this.pnl_codigobarras.TabIndex = 2;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(182, 255);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(532, 22);
            this.txt_codigo.TabIndex = 3;
            this.txt_codigo.Text = " ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(557, 78);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(146, 48);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(175, 206);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(315, 37);
            this.lbl_codigo.TabIndex = 5;
            this.lbl_codigo.Text = "Ingreso Nombre/Codigo";
            // 
            // FR_ETIQUETA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.pnl_codigobarras);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_ETIQUETA";
            this.Text = "FR_ETIQUETA";
            this.Load += new System.EventHandler(this.FR_ETIQUETA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel pnl_codigobarras;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_codigo;
    }
}
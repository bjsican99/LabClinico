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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.pnl_etiqueta = new System.Windows.Forms.Panel();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_etiqueta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.White;
            this.btn_generar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.Location = new System.Drawing.Point(433, 75);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(79, 72);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.White;
            this.btn_guardar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(512, 293);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(79, 72);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // pnl_codigobarras
            // 
            this.pnl_codigobarras.BackColor = System.Drawing.Color.Gray;
            this.pnl_codigobarras.Location = new System.Drawing.Point(51, 225);
            this.pnl_codigobarras.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_codigobarras.Name = "pnl_codigobarras";
            this.pnl_codigobarras.Size = new System.Drawing.Size(399, 140);
            this.pnl_codigobarras.TabIndex = 2;
            // 
            // txt_codigo
            // 
            this.txt_codigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_codigo.Location = new System.Drawing.Point(220, 56);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(172, 20);
            this.txt_codigo.TabIndex = 3;
            this.txt_codigo.Text = " ";
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(602, 2);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(34, 33);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_codigo.Location = new System.Drawing.Point(20, 47);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(178, 29);
            this.lbl_codigo.TabIndex = 5;
            this.lbl_codigo.Text = "Codigo paciente";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre.Location = new System.Drawing.Point(20, 95);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(189, 29);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "Nombre paciente";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(220, 104);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(172, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.Text = " ";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_apellido.Location = new System.Drawing.Point(20, 137);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(191, 29);
            this.lbl_apellido.TabIndex = 9;
            this.lbl_apellido.Text = "Apellido paciente";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(220, 146);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(172, 20);
            this.txt_apellido.TabIndex = 8;
            this.txt_apellido.Text = " ";
            // 
            // pnl_etiqueta
            // 
            this.pnl_etiqueta.Controls.Add(this.label1);
            this.pnl_etiqueta.Controls.Add(this.lbl_eliminar);
            this.pnl_etiqueta.Controls.Add(this.lbl_codigo);
            this.pnl_etiqueta.Controls.Add(this.btn_regresar);
            this.pnl_etiqueta.Controls.Add(this.btn_guardar);
            this.pnl_etiqueta.Controls.Add(this.lbl_apellido);
            this.pnl_etiqueta.Controls.Add(this.pnl_codigobarras);
            this.pnl_etiqueta.Controls.Add(this.txt_codigo);
            this.pnl_etiqueta.Controls.Add(this.txt_apellido);
            this.pnl_etiqueta.Controls.Add(this.btn_generar);
            this.pnl_etiqueta.Controls.Add(this.txt_nombre);
            this.pnl_etiqueta.Controls.Add(this.lbl_nombre);
            this.pnl_etiqueta.Location = new System.Drawing.Point(18, 17);
            this.pnl_etiqueta.Name = "pnl_etiqueta";
            this.pnl_etiqueta.Size = new System.Drawing.Size(638, 415);
            this.pnl_etiqueta.TabIndex = 10;
            this.pnl_etiqueta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_etiqueta_Paint);
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eliminar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eliminar.Location = new System.Drawing.Point(428, 149);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(94, 29);
            this.lbl_eliminar.TabIndex = 66;
            this.lbl_eliminar.Text = "Generar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Eliminar";
            // 
            // FR_ETIQUETA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.pnl_etiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FR_ETIQUETA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_ETIQUETA";
            this.Load += new System.EventHandler(this.FR_ETIQUETA_Load);
            this.pnl_etiqueta.ResumeLayout(false);
            this.pnl_etiqueta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel pnl_codigobarras;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Panel pnl_etiqueta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_eliminar;
    }
}
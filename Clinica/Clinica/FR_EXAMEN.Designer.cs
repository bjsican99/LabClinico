namespace Clinica
{
    partial class FR_EXAMEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_EXAMEN));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.pnl_blanco = new System.Windows.Forms.Panel();
            this.btn_muestra = new System.Windows.Forms.Button();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.cbn_tipo = new System.Windows.Forms.ComboBox();
            this.btn_mensaje = new System.Windows.Forms.Button();
            this.lbl_paciente = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.pnl_blanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(33, 159);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(124, 37);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // pnl_blanco
            // 
            this.pnl_blanco.BackColor = System.Drawing.Color.White;
            this.pnl_blanco.Controls.Add(this.btn_muestra);
            this.pnl_blanco.Controls.Add(this.txt_estado);
            this.pnl_blanco.Controls.Add(this.cbn_tipo);
            this.pnl_blanco.Controls.Add(this.btn_mensaje);
            this.pnl_blanco.Controls.Add(this.lbl_paciente);
            this.pnl_blanco.Controls.Add(this.btn_ingresar);
            this.pnl_blanco.Controls.Add(this.lbl_titulo);
            this.pnl_blanco.Controls.Add(this.txt_valor);
            this.pnl_blanco.Controls.Add(this.txt_nombre);
            this.pnl_blanco.Controls.Add(this.txt_codigo);
            this.pnl_blanco.Controls.Add(this.lbl_tipo);
            this.pnl_blanco.Controls.Add(this.lbl_valor);
            this.pnl_blanco.Controls.Add(this.lbl_codigo);
            this.pnl_blanco.Controls.Add(this.lbl_nombre);
            this.pnl_blanco.Location = new System.Drawing.Point(44, 37);
            this.pnl_blanco.Name = "pnl_blanco";
            this.pnl_blanco.Size = new System.Drawing.Size(820, 463);
            this.pnl_blanco.TabIndex = 2;
            // 
            // btn_muestra
            // 
            this.btn_muestra.BackColor = System.Drawing.Color.White;
            this.btn_muestra.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muestra.Location = new System.Drawing.Point(513, 251);
            this.btn_muestra.Name = "btn_muestra";
            this.btn_muestra.Size = new System.Drawing.Size(253, 41);
            this.btn_muestra.TabIndex = 20;
            this.btn_muestra.Text = "Muestra";
            this.btn_muestra.UseVisualStyleBackColor = false;
            this.btn_muestra.Click += new System.EventHandler(this.btn_muestra_Click);
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(243, 364);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(189, 22);
            this.txt_estado.TabIndex = 19;
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // cbn_tipo
            // 
            this.cbn_tipo.FormattingEnabled = true;
            this.cbn_tipo.Location = new System.Drawing.Point(243, 298);
            this.cbn_tipo.Name = "cbn_tipo";
            this.cbn_tipo.Size = new System.Drawing.Size(189, 24);
            this.cbn_tipo.TabIndex = 18;
            // 
            // btn_mensaje
            // 
            this.btn_mensaje.BackColor = System.Drawing.Color.White;
            this.btn_mensaje.Image = ((System.Drawing.Image)(resources.GetObject("btn_mensaje.Image")));
            this.btn_mensaje.Location = new System.Drawing.Point(604, 93);
            this.btn_mensaje.Name = "btn_mensaje";
            this.btn_mensaje.Size = new System.Drawing.Size(76, 59);
            this.btn_mensaje.TabIndex = 17;
            this.btn_mensaje.UseVisualStyleBackColor = false;
            this.btn_mensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_paciente
            // 
            this.lbl_paciente.AutoSize = true;
            this.lbl_paciente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paciente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paciente.Location = new System.Drawing.Point(33, 351);
            this.lbl_paciente.Name = "lbl_paciente";
            this.lbl_paciente.Size = new System.Drawing.Size(201, 37);
            this.lbl_paciente.TabIndex = 15;
            this.lbl_paciente.Text = "E. Laboratorio";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.White;
            this.btn_ingresar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(513, 181);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(253, 41);
            this.btn_ingresar.TabIndex = 14;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.B_INGRESAR_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(264, 29);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(254, 37);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "Ingreso Examenes";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(243, 232);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(189, 22);
            this.txt_valor.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(243, 172);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(189, 22);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_codigo_KeyPress
            // 
            this.txt_codigo.Location = new System.Drawing.Point(243, 111);
            this.txt_codigo.Name = "txt_codigo_KeyPress";
            this.txt_codigo.Size = new System.Drawing.Size(189, 22);
            this.txt_codigo.TabIndex = 6;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(33, 285);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(75, 37);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(33, 219);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(86, 37);
            this.lbl_valor.TabIndex = 4;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(33, 98);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(110, 37);
            this.lbl_codigo.TabIndex = 3;
            this.lbl_codigo.Text = "Codigo";
            // 
            // FR_EXAMEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnl_blanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_EXAMEN";
            this.Text = "FR_EXAMEN";
            this.Load += new System.EventHandler(this.FR_EXAMEN_Load);
            this.pnl_blanco.ResumeLayout(false);
            this.pnl_blanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Panel pnl_blanco;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lbl_paciente;
        private System.Windows.Forms.Button btn_mensaje;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.ComboBox cbn_tipo;
        private System.Windows.Forms.Button btn_muestra;
    }
}
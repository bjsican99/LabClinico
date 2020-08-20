namespace Clinica
{
    partial class FR_LOGIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_LOGIN));
            this.ptb_imagen = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.pnl_blanco = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregarusu = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.BTN_AYUDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagen)).BeginInit();
            this.pnl_blanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptb_imagen
            // 
            this.ptb_imagen.BackColor = System.Drawing.Color.Transparent;
            this.ptb_imagen.Image = ((System.Drawing.Image)(resources.GetObject("ptb_imagen.Image")));
            this.ptb_imagen.Location = new System.Drawing.Point(198, 38);
            this.ptb_imagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_imagen.Name = "ptb_imagen";
            this.ptb_imagen.Size = new System.Drawing.Size(128, 128);
            this.ptb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_imagen.TabIndex = 0;
            this.ptb_imagen.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_usuario.Location = new System.Drawing.Point(3, 174);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(125, 37);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario:";
            this.lbl_usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(97, 213);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(321, 40);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.TextChanged += new System.EventHandler(this.tBIngresoUsu_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(97, 309);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(321, 40);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextChanged += new System.EventHandler(this.TX_INGRESOPASSWORD_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_password.Location = new System.Drawing.Point(3, 270);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(151, 37);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // pnl_blanco
            // 
            this.pnl_blanco.BackColor = System.Drawing.Color.White;
            this.pnl_blanco.Controls.Add(this.BTN_AYUDA);
            this.pnl_blanco.Controls.Add(this.btn_salir);
            this.pnl_blanco.Controls.Add(this.btn_agregarusu);
            this.pnl_blanco.Controls.Add(this.btn_aceptar);
            this.pnl_blanco.Controls.Add(this.ptb_imagen);
            this.pnl_blanco.Controls.Add(this.lbl_usuario);
            this.pnl_blanco.Controls.Add(this.txt_password);
            this.pnl_blanco.Controls.Add(this.txt_usuario);
            this.pnl_blanco.Controls.Add(this.lbl_password);
            this.pnl_blanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pnl_blanco.Location = new System.Drawing.Point(21, 22);
            this.pnl_blanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_blanco.Name = "pnl_blanco";
            this.pnl_blanco.Size = new System.Drawing.Size(556, 502);
            this.pnl_blanco.TabIndex = 6;
            this.pnl_blanco.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.White;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(457, 18);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(65, 53);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_agregarusu
            // 
            this.btn_agregarusu.BackColor = System.Drawing.Color.White;
            this.btn_agregarusu.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregarusu.Image")));
            this.btn_agregarusu.Location = new System.Drawing.Point(386, 18);
            this.btn_agregarusu.Name = "btn_agregarusu";
            this.btn_agregarusu.Size = new System.Drawing.Size(65, 53);
            this.btn_agregarusu.TabIndex = 6;
            this.btn_agregarusu.UseVisualStyleBackColor = false;
            this.btn_agregarusu.Click += new System.EventHandler(this.B_AGREGARUSU_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.White;
            this.btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.Image")));
            this.btn_aceptar.Location = new System.Drawing.Point(407, 359);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 92);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTN_AYUDA
            // 
            this.BTN_AYUDA.BackColor = System.Drawing.Color.White;
            this.BTN_AYUDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AYUDA.Location = new System.Drawing.Point(25, 25);
            this.BTN_AYUDA.Name = "BTN_AYUDA";
            this.BTN_AYUDA.Size = new System.Drawing.Size(114, 66);
            this.BTN_AYUDA.TabIndex = 8;
            this.BTN_AYUDA.Text = "?   Ayuda";
            this.BTN_AYUDA.UseVisualStyleBackColor = false;
            this.BTN_AYUDA.Click += new System.EventHandler(this.BTN_AYUDA_Click);
            // 
            // FR_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.pnl_blanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FR_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagen)).EndInit();
            this.pnl_blanco.ResumeLayout(false);
            this.pnl_blanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_imagen;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel pnl_blanco;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_agregarusu;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button BTN_AYUDA;
    }
}


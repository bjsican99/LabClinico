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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TX_INGRESOUSUARIO = new System.Windows.Forms.TextBox();
            this.TX_INGRESOPASSWORD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_VALIDACIÓN = new System.Windows.Forms.Button();
            this.B_AGREGARUSU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(3, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TX_INGRESOUSUARIO
            // 
            this.TX_INGRESOUSUARIO.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_INGRESOUSUARIO.Location = new System.Drawing.Point(97, 213);
            this.TX_INGRESOUSUARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TX_INGRESOUSUARIO.Name = "TX_INGRESOUSUARIO";
            this.TX_INGRESOUSUARIO.Size = new System.Drawing.Size(321, 23);
            this.TX_INGRESOUSUARIO.TabIndex = 2;
            this.TX_INGRESOUSUARIO.TextChanged += new System.EventHandler(this.tBIngresoUsu_TextChanged);
            // 
            // TX_INGRESOPASSWORD
            // 
            this.TX_INGRESOPASSWORD.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_INGRESOPASSWORD.Location = new System.Drawing.Point(97, 309);
            this.TX_INGRESOPASSWORD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TX_INGRESOPASSWORD.Name = "TX_INGRESOPASSWORD";
            this.TX_INGRESOPASSWORD.Size = new System.Drawing.Size(321, 23);
            this.TX_INGRESOPASSWORD.TabIndex = 4;
            this.TX_INGRESOPASSWORD.TextChanged += new System.EventHandler(this.TX_INGRESOPASSWORD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(3, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.B_AGREGARUSU);
            this.panel1.Controls.Add(this.B_VALIDACIÓN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TX_INGRESOPASSWORD);
            this.panel1.Controls.Add(this.TX_INGRESOUSUARIO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 470);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // B_VALIDACIÓN
            // 
            this.B_VALIDACIÓN.BackColor = System.Drawing.Color.White;
            this.B_VALIDACIÓN.Image = ((System.Drawing.Image)(resources.GetObject("B_VALIDACIÓN.Image")));
            this.B_VALIDACIÓN.Location = new System.Drawing.Point(407, 359);
            this.B_VALIDACIÓN.Name = "B_VALIDACIÓN";
            this.B_VALIDACIÓN.Size = new System.Drawing.Size(95, 92);
            this.B_VALIDACIÓN.TabIndex = 5;
            this.B_VALIDACIÓN.UseVisualStyleBackColor = false;
            this.B_VALIDACIÓN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // B_AGREGARUSU
            // 
            this.B_AGREGARUSU.BackColor = System.Drawing.Color.White;
            this.B_AGREGARUSU.Image = ((System.Drawing.Image)(resources.GetObject("B_AGREGARUSU.Image")));
            this.B_AGREGARUSU.Location = new System.Drawing.Point(29, 375);
            this.B_AGREGARUSU.Name = "B_AGREGARUSU";
            this.B_AGREGARUSU.Size = new System.Drawing.Size(89, 76);
            this.B_AGREGARUSU.TabIndex = 6;
            this.B_AGREGARUSU.UseVisualStyleBackColor = false;
            // 
            // FR_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 503);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FR_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TX_INGRESOUSUARIO;
        private System.Windows.Forms.TextBox TX_INGRESOPASSWORD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_VALIDACIÓN;
        private System.Windows.Forms.Button B_AGREGARUSU;
    }
}


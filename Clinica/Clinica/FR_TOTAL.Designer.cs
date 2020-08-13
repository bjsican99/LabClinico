namespace Clinica
{
    partial class FR_TOTAL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TOTAL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.pnl_negro = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.ptb_imagen = new System.Windows.Forms.PictureBox();
            this.timer_horafecha = new System.Windows.Forms.Timer(this.components);
            this.btn_personal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_contenedor.SuspendLayout();
            this.pnl_negro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_personal);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_factura);
            this.panel1.Controls.Add(this.btn_reportes);
            this.panel1.Controls.Add(this.btn_usuario);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 601);
            this.panel1.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_salir.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(0, 526);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_salir.Size = new System.Drawing.Size(275, 75);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_factura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_factura.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.ForeColor = System.Drawing.Color.White;
            this.btn_factura.Image = ((System.Drawing.Image)(resources.GetObject("btn_factura.Image")));
            this.btn_factura.Location = new System.Drawing.Point(0, 150);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(275, 75);
            this.btn_factura.TabIndex = 4;
            this.btn_factura.Text = "Facturación";
            this.btn_factura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_factura.UseVisualStyleBackColor = false;
            this.btn_factura.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.Location = new System.Drawing.Point(0, 75);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(275, 75);
            this.btn_reportes.TabIndex = 3;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuario.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario.Image")));
            this.btn_usuario.Location = new System.Drawing.Point(0, 0);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(275, 75);
            this.btn_usuario.TabIndex = 1;
            this.btn_usuario.Text = "I. Paciente";
            this.btn_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.White;
            this.pnl_contenedor.Controls.Add(this.pnl_negro);
            this.pnl_contenedor.Controls.Add(this.ptb_imagen);
            this.pnl_contenedor.Location = new System.Drawing.Point(272, 1);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(932, 604);
            this.pnl_contenedor.TabIndex = 1;
            this.pnl_contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.P_CONTENEDOR_Paint);
            // 
            // pnl_negro
            // 
            this.pnl_negro.BackColor = System.Drawing.Color.Teal;
            this.pnl_negro.Controls.Add(this.lbl_fecha);
            this.pnl_negro.Controls.Add(this.lbl_hora);
            this.pnl_negro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_negro.Location = new System.Drawing.Point(0, 554);
            this.pnl_negro.Name = "pnl_negro";
            this.pnl_negro.Size = new System.Drawing.Size(932, 50);
            this.pnl_negro.TabIndex = 1;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(540, 5);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(84, 35);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(174, 5);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(72, 35);
            this.lbl_hora.TabIndex = 0;
            this.lbl_hora.Text = "Hora";
            this.lbl_hora.Click += new System.EventHandler(this.lbl_hora_Click);
            // 
            // ptb_imagen
            // 
            this.ptb_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptb_imagen.Image = ((System.Drawing.Image)(resources.GetObject("ptb_imagen.Image")));
            this.ptb_imagen.Location = new System.Drawing.Point(240, 132);
            this.ptb_imagen.Name = "ptb_imagen";
            this.ptb_imagen.Size = new System.Drawing.Size(416, 333);
            this.ptb_imagen.TabIndex = 0;
            this.ptb_imagen.TabStop = false;
            // 
            // timer_horafecha
            // 
            this.timer_horafecha.Enabled = true;
            this.timer_horafecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_personal
            // 
            this.btn_personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_personal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personal.ForeColor = System.Drawing.Color.White;
            this.btn_personal.Image = ((System.Drawing.Image)(resources.GetObject("btn_personal.Image")));
            this.btn_personal.Location = new System.Drawing.Point(0, 225);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(275, 75);
            this.btn_personal.TabIndex = 6;
            this.btn_personal.Text = "I. Personal";
            this.btn_personal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 75);
            this.button2.TabIndex = 7;
            this.button2.Text = "Etiqueta";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 75);
            this.button3.TabIndex = 8;
            this.button3.Text = "Examenes";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 75);
            this.button1.TabIndex = 9;
            this.button1.Text = "I. Doctor";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FR_TOTAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 604);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_TOTAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_TOTAL";
            this.panel1.ResumeLayout(false);
            this.pnl_contenedor.ResumeLayout(false);
            this.pnl_negro.ResumeLayout(false);
            this.pnl_negro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.PictureBox ptb_imagen;
        private System.Windows.Forms.Panel pnl_negro;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer timer_horafecha;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}
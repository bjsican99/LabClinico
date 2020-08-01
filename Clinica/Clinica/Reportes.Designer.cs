namespace Clinica
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Txt_FechaFin = new System.Windows.Forms.Label();
            this.Txt_FechaIni = new System.Windows.Forms.Label();
            this.Date_FechaIni = new System.Windows.Forms.DateTimePicker();
            this.Txt_Titulo = new System.Windows.Forms.Label();
            this.Txt_Generar = new System.Windows.Forms.Label();
            this.Txt_Regresar = new System.Windows.Forms.Label();
            this.Btn_Generer = new System.Windows.Forms.Button();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.DG_Pacientes = new System.Windows.Forms.DataGridView();
            this.DG_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Date_FechaFin);
            this.panel1.Controls.Add(this.Txt_FechaFin);
            this.panel1.Controls.Add(this.Txt_FechaIni);
            this.panel1.Controls.Add(this.Date_FechaIni);
            this.panel1.Controls.Add(this.Txt_Titulo);
            this.panel1.Controls.Add(this.Txt_Generar);
            this.panel1.Controls.Add(this.Txt_Regresar);
            this.panel1.Controls.Add(this.Btn_Generer);
            this.panel1.Controls.Add(this.Btn_Regresar);
            this.panel1.Controls.Add(this.DG_Pacientes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 458);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Date_FechaFin
            // 
            this.Date_FechaFin.Location = new System.Drawing.Point(233, 94);
            this.Date_FechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.Date_FechaFin.Name = "Date_FechaFin";
            this.Date_FechaFin.Size = new System.Drawing.Size(126, 20);
            this.Date_FechaFin.TabIndex = 37;
            // 
            // Txt_FechaFin
            // 
            this.Txt_FechaFin.AutoSize = true;
            this.Txt_FechaFin.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FechaFin.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaFin.Location = new System.Drawing.Point(244, 68);
            this.Txt_FechaFin.Name = "Txt_FechaFin";
            this.Txt_FechaFin.Size = new System.Drawing.Size(61, 25);
            this.Txt_FechaFin.TabIndex = 36;
            this.Txt_FechaFin.Text = "Generar";
            // 
            // Txt_FechaIni
            // 
            this.Txt_FechaIni.AutoSize = true;
            this.Txt_FechaIni.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FechaIni.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaIni.Location = new System.Drawing.Point(42, 68);
            this.Txt_FechaIni.Name = "Txt_FechaIni";
            this.Txt_FechaIni.Size = new System.Drawing.Size(83, 25);
            this.Txt_FechaIni.TabIndex = 35;
            this.Txt_FechaIni.Text = "Fecha inicial";
            // 
            // Date_FechaIni
            // 
            this.Date_FechaIni.Location = new System.Drawing.Point(36, 94);
            this.Date_FechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.Date_FechaIni.Name = "Date_FechaIni";
            this.Date_FechaIni.Size = new System.Drawing.Size(126, 20);
            this.Date_FechaIni.TabIndex = 34;
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.AutoSize = true;
            this.Txt_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Titulo.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titulo.Location = new System.Drawing.Point(186, 10);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(243, 39);
            this.Txt_Titulo.TabIndex = 33;
            this.Txt_Titulo.Text = "Pacientes registrados";
            // 
            // Txt_Generar
            // 
            this.Txt_Generar.AutoSize = true;
            this.Txt_Generar.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Generar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Generar.Location = new System.Drawing.Point(650, 430);
            this.Txt_Generar.Name = "Txt_Generar";
            this.Txt_Generar.Size = new System.Drawing.Size(89, 25);
            this.Txt_Generar.TabIndex = 32;
            this.Txt_Generar.Text = "Generar PDF";
            // 
            // Txt_Regresar
            // 
            this.Txt_Regresar.AutoSize = true;
            this.Txt_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Regresar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Regresar.Location = new System.Drawing.Point(766, 430);
            this.Txt_Regresar.Name = "Txt_Regresar";
            this.Txt_Regresar.Size = new System.Drawing.Size(68, 25);
            this.Txt_Regresar.TabIndex = 31;
            this.Txt_Regresar.Text = "Regresar";
            this.Txt_Regresar.Click += new System.EventHandler(this.Txt_Regresar_Click);
            // 
            // Btn_Generer
            // 
            this.Btn_Generer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Generer.Image")));
            this.Btn_Generer.Location = new System.Drawing.Point(654, 351);
            this.Btn_Generer.Name = "Btn_Generer";
            this.Btn_Generer.Size = new System.Drawing.Size(81, 76);
            this.Btn_Generer.TabIndex = 30;
            this.Btn_Generer.UseVisualStyleBackColor = true;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.Location = new System.Drawing.Point(751, 351);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(83, 76);
            this.Btn_Regresar.TabIndex = 29;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // DG_Pacientes
            // 
            this.DG_Pacientes.BackgroundColor = System.Drawing.Color.Silver;
            this.DG_Pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Pacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_Codigo,
            this.DG_Nombre,
            this.DG_Apellido,
            this.DG_FechaRegistro,
            this.DG_Telefono});
            this.DG_Pacientes.Location = new System.Drawing.Point(21, 157);
            this.DG_Pacientes.Name = "DG_Pacientes";
            this.DG_Pacientes.Size = new System.Drawing.Size(584, 150);
            this.DG_Pacientes.TabIndex = 28;
            this.DG_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DG_Codigo
            // 
            this.DG_Codigo.HeaderText = "Codigo";
            this.DG_Codigo.Name = "DG_Codigo";
            // 
            // DG_Nombre
            // 
            this.DG_Nombre.HeaderText = "Nombre";
            this.DG_Nombre.Name = "DG_Nombre";
            // 
            // DG_Apellido
            // 
            this.DG_Apellido.HeaderText = "Apellido";
            this.DG_Apellido.Name = "DG_Apellido";
            // 
            // DG_FechaRegistro
            // 
            this.DG_FechaRegistro.HeaderText = "Fecha de registro";
            this.DG_FechaRegistro.Name = "DG_FechaRegistro";
            // 
            // DG_Telefono
            // 
            this.DG_Telefono.HeaderText = "Teléfono";
            this.DG_Telefono.Name = "DG_Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(414, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 56);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bryan Mazariegos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DG_Pacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Telefono;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Generer;
        private System.Windows.Forms.Label Txt_Regresar;
        private System.Windows.Forms.Label Txt_Generar;
        private System.Windows.Forms.Label Txt_Titulo;
        private System.Windows.Forms.DateTimePicker Date_FechaFin;
        private System.Windows.Forms.Label Txt_FechaFin;
        private System.Windows.Forms.Label Txt_FechaIni;
        private System.Windows.Forms.DateTimePicker Date_FechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
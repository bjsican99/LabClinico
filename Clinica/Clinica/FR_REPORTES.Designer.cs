namespace Clinica
{
    partial class FR_REPORTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_REPORTES));
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_IMPRIMIR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Txt_FechaFin = new System.Windows.Forms.Label();
            this.Txt_FechaIni = new System.Windows.Forms.Label();
            this.Date_FechaIni = new System.Windows.Forms.DateTimePicker();
            this.Txt_Titulo = new System.Windows.Forms.Label();
            this.Txt_Generar = new System.Windows.Forms.Label();
            this.Txt_Regresar = new System.Windows.Forms.Label();
            this.DG_Pacientes = new System.Windows.Forms.DataGridView();
            this.DG_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.B_IMPRIMIR);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Date_FechaFin);
            this.panel1.Controls.Add(this.Txt_FechaFin);
            this.panel1.Controls.Add(this.Txt_FechaIni);
            this.panel1.Controls.Add(this.Date_FechaIni);
            this.panel1.Controls.Add(this.Txt_Titulo);
            this.panel1.Controls.Add(this.Txt_Generar);
            this.panel1.Controls.Add(this.Txt_Regresar);
            this.panel1.Controls.Add(this.DG_Pacientes);
            this.panel1.Location = new System.Drawing.Point(53, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 460);
            this.panel1.TabIndex = 29;
            // 
            // B_IMPRIMIR
            // 
            this.B_IMPRIMIR.BackColor = System.Drawing.Color.White;
            this.B_IMPRIMIR.Image = ((System.Drawing.Image)(resources.GetObject("B_IMPRIMIR.Image")));
            this.B_IMPRIMIR.Location = new System.Drawing.Point(30, 354);
            this.B_IMPRIMIR.Name = "B_IMPRIMIR";
            this.B_IMPRIMIR.Size = new System.Drawing.Size(106, 82);
            this.B_IMPRIMIR.TabIndex = 42;
            this.B_IMPRIMIR.UseVisualStyleBackColor = false;
            this.B_IMPRIMIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(570, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 98);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Buscar";
            // 
            // Date_FechaFin
            // 
            this.Date_FechaFin.Location = new System.Drawing.Point(303, 120);
            this.Date_FechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_FechaFin.Name = "Date_FechaFin";
            this.Date_FechaFin.Size = new System.Drawing.Size(167, 22);
            this.Date_FechaFin.TabIndex = 37;
            // 
            // Txt_FechaFin
            // 
            this.Txt_FechaFin.AutoSize = true;
            this.Txt_FechaFin.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FechaFin.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaFin.Location = new System.Drawing.Point(164, 376);
            this.Txt_FechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_FechaFin.Name = "Txt_FechaFin";
            this.Txt_FechaFin.Size = new System.Drawing.Size(119, 37);
            this.Txt_FechaFin.TabIndex = 36;
            this.Txt_FechaFin.Text = "Generar";
            // 
            // Txt_FechaIni
            // 
            this.Txt_FechaIni.AutoSize = true;
            this.Txt_FechaIni.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FechaIni.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaIni.Location = new System.Drawing.Point(40, 72);
            this.Txt_FechaIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_FechaIni.Name = "Txt_FechaIni";
            this.Txt_FechaIni.Size = new System.Drawing.Size(173, 37);
            this.Txt_FechaIni.TabIndex = 35;
            this.Txt_FechaIni.Text = "Fecha inicial";
            // 
            // Date_FechaIni
            // 
            this.Date_FechaIni.Location = new System.Drawing.Point(47, 120);
            this.Date_FechaIni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_FechaIni.Name = "Date_FechaIni";
            this.Date_FechaIni.Size = new System.Drawing.Size(167, 22);
            this.Date_FechaIni.TabIndex = 34;
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.AutoSize = true;
            this.Txt_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Titulo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titulo.Location = new System.Drawing.Point(248, 12);
            this.Txt_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(292, 37);
            this.Txt_Titulo.TabIndex = 33;
            this.Txt_Titulo.Text = "Pacientes registrados";
            // 
            // Txt_Generar
            // 
            this.Txt_Generar.AutoSize = true;
            this.Txt_Generar.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Generar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Generar.Location = new System.Drawing.Point(867, 529);
            this.Txt_Generar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Generar.Name = "Txt_Generar";
            this.Txt_Generar.Size = new System.Drawing.Size(123, 34);
            this.Txt_Generar.TabIndex = 32;
            this.Txt_Generar.Text = "Generar PDF";
            // 
            // Txt_Regresar
            // 
            this.Txt_Regresar.AutoSize = true;
            this.Txt_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Regresar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Regresar.Location = new System.Drawing.Point(1021, 529);
            this.Txt_Regresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Regresar.Name = "Txt_Regresar";
            this.Txt_Regresar.Size = new System.Drawing.Size(95, 34);
            this.Txt_Regresar.TabIndex = 31;
            this.Txt_Regresar.Text = "Regresar";
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
            this.DG_Pacientes.Location = new System.Drawing.Point(30, 162);
            this.DG_Pacientes.Margin = new System.Windows.Forms.Padding(4);
            this.DG_Pacientes.Name = "DG_Pacientes";
            this.DG_Pacientes.RowHeadersWidth = 51;
            this.DG_Pacientes.Size = new System.Drawing.Size(677, 185);
            this.DG_Pacientes.TabIndex = 28;
            this.DG_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Pacientes_CellContentClick);
            // 
            // DG_Codigo
            // 
            this.DG_Codigo.HeaderText = "Codigo";
            this.DG_Codigo.MinimumWidth = 6;
            this.DG_Codigo.Name = "DG_Codigo";
            this.DG_Codigo.Width = 125;
            // 
            // DG_Nombre
            // 
            this.DG_Nombre.HeaderText = "Nombre";
            this.DG_Nombre.MinimumWidth = 6;
            this.DG_Nombre.Name = "DG_Nombre";
            this.DG_Nombre.Width = 125;
            // 
            // DG_Apellido
            // 
            this.DG_Apellido.HeaderText = "Apellido";
            this.DG_Apellido.MinimumWidth = 6;
            this.DG_Apellido.Name = "DG_Apellido";
            this.DG_Apellido.Width = 125;
            // 
            // DG_FechaRegistro
            // 
            this.DG_FechaRegistro.HeaderText = "Fecha de registro";
            this.DG_FechaRegistro.MinimumWidth = 6;
            this.DG_FechaRegistro.Name = "DG_FechaRegistro";
            this.DG_FechaRegistro.Width = 125;
            // 
            // DG_Telefono
            // 
            this.DG_Telefono.HeaderText = "Teléfono";
            this.DG_Telefono.MinimumWidth = 6;
            this.DG_Telefono.Name = "DG_Telefono";
            this.DG_Telefono.Width = 125;
            // 
            // FR_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 513);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_REPORTES";
            this.Text = "FR_REPORTES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_IMPRIMIR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Date_FechaFin;
        private System.Windows.Forms.Label Txt_FechaFin;
        private System.Windows.Forms.Label Txt_FechaIni;
        private System.Windows.Forms.DateTimePicker Date_FechaIni;
        private System.Windows.Forms.Label Txt_Titulo;
        private System.Windows.Forms.Label Txt_Generar;
        private System.Windows.Forms.Label Txt_Regresar;
        private System.Windows.Forms.DataGridView DG_Pacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Telefono;
    }
}
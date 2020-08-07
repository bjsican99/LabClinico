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
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_nombrepaciente = new System.Windows.Forms.TextBox();
            this.lbl_nombrepaciente = new System.Windows.Forms.Label();
            this.txt_codigopaciente = new System.Windows.Forms.TextBox();
            this.lbl_codigopaciente = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_fechafinal = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.Date_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbl_imprimir = new System.Windows.Forms.Label();
            this.lbl_fechainicio = new System.Windows.Forms.Label();
            this.Date_FechaIni = new System.Windows.Forms.DateTimePicker();
            this.Txt_Titulo = new System.Windows.Forms.Label();
            this.Txt_Generar = new System.Windows.Forms.Label();
            this.Txt_Regresar = new System.Windows.Forms.Label();
            this.DG_Pacientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_eliminar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.lbl_modificar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.txt_nombrepaciente);
            this.panel1.Controls.Add(this.lbl_nombrepaciente);
            this.panel1.Controls.Add(this.txt_codigopaciente);
            this.panel1.Controls.Add(this.lbl_codigopaciente);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.lbl_fechafinal);
            this.panel1.Controls.Add(this.lbl_buscar);
            this.panel1.Controls.Add(this.Date_FechaFin);
            this.panel1.Controls.Add(this.lbl_imprimir);
            this.panel1.Controls.Add(this.lbl_fechainicio);
            this.panel1.Controls.Add(this.Date_FechaIni);
            this.panel1.Controls.Add(this.Txt_Titulo);
            this.panel1.Controls.Add(this.Txt_Generar);
            this.panel1.Controls.Add(this.Txt_Regresar);
            this.panel1.Controls.Add(this.DG_Pacientes);
            this.panel1.Location = new System.Drawing.Point(53, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 476);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eliminar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eliminar.Location = new System.Drawing.Point(420, 446);
            this.lbl_eliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(124, 37);
            this.lbl_eliminar.TabIndex = 52;
            this.lbl_eliminar.Text = "Eliminar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(427, 354);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(105, 89);
            this.btn_eliminar.TabIndex = 51;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modificar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modificar.Location = new System.Drawing.Point(539, 446);
            this.lbl_modificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(138, 37);
            this.lbl_modificar.TabIndex = 50;
            this.lbl_modificar.Text = "Modificar";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(567, 354);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(105, 89);
            this.btn_modificar.TabIndex = 48;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_nombrepaciente
            // 
            this.txt_nombrepaciente.Location = new System.Drawing.Point(545, 124);
            this.txt_nombrepaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombrepaciente.Name = "txt_nombrepaciente";
            this.txt_nombrepaciente.Size = new System.Drawing.Size(208, 22);
            this.txt_nombrepaciente.TabIndex = 47;
            // 
            // lbl_nombrepaciente
            // 
            this.lbl_nombrepaciente.AutoSize = true;
            this.lbl_nombrepaciente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrepaciente.Location = new System.Drawing.Point(377, 111);
            this.lbl_nombrepaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombrepaciente.Name = "lbl_nombrepaciente";
            this.lbl_nombrepaciente.Size = new System.Drawing.Size(150, 37);
            this.lbl_nombrepaciente.TabIndex = 46;
            this.lbl_nombrepaciente.Text = "Nombre.p";
            // 
            // txt_codigopaciente
            // 
            this.txt_codigopaciente.Location = new System.Drawing.Point(545, 82);
            this.txt_codigopaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_codigopaciente.Name = "txt_codigopaciente";
            this.txt_codigopaciente.Size = new System.Drawing.Size(208, 22);
            this.txt_codigopaciente.TabIndex = 45;
            // 
            // lbl_codigopaciente
            // 
            this.lbl_codigopaciente.AutoSize = true;
            this.lbl_codigopaciente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigopaciente.Location = new System.Drawing.Point(377, 74);
            this.lbl_codigopaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigopaciente.Name = "lbl_codigopaciente";
            this.lbl_codigopaciente.Size = new System.Drawing.Size(136, 37);
            this.lbl_codigopaciente.TabIndex = 44;
            this.lbl_codigopaciente.Text = "Codigo.p";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.White;
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(29, 354);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(107, 82);
            this.btn_imprimir.TabIndex = 42;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(701, 354);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(99, 89);
            this.btn_buscar.TabIndex = 41;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_fechafinal
            // 
            this.lbl_fechafinal.AutoSize = true;
            this.lbl_fechafinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechafinal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechafinal.Location = new System.Drawing.Point(23, 111);
            this.lbl_fechafinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechafinal.Name = "lbl_fechafinal";
            this.lbl_fechafinal.Size = new System.Drawing.Size(156, 37);
            this.lbl_fechafinal.TabIndex = 40;
            this.lbl_fechafinal.Text = "Fecha final";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buscar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.Location = new System.Drawing.Point(708, 446);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(103, 37);
            this.lbl_buscar.TabIndex = 39;
            this.lbl_buscar.Text = "Buscar";
            // 
            // Date_FechaFin
            // 
            this.Date_FechaFin.Location = new System.Drawing.Point(203, 122);
            this.Date_FechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_FechaFin.Name = "Date_FechaFin";
            this.Date_FechaFin.Size = new System.Drawing.Size(167, 22);
            this.Date_FechaFin.TabIndex = 37;
            // 
            // lbl_imprimir
            // 
            this.lbl_imprimir.AutoSize = true;
            this.lbl_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_imprimir.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imprimir.Location = new System.Drawing.Point(23, 439);
            this.lbl_imprimir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_imprimir.Name = "lbl_imprimir";
            this.lbl_imprimir.Size = new System.Drawing.Size(119, 37);
            this.lbl_imprimir.TabIndex = 36;
            this.lbl_imprimir.Text = "Generar";
            // 
            // lbl_fechainicio
            // 
            this.lbl_fechainicio.AutoSize = true;
            this.lbl_fechainicio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechainicio.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechainicio.Location = new System.Drawing.Point(23, 74);
            this.lbl_fechainicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechainicio.Name = "lbl_fechainicio";
            this.lbl_fechainicio.Size = new System.Drawing.Size(173, 37);
            this.lbl_fechainicio.TabIndex = 35;
            this.lbl_fechainicio.Text = "Fecha inicial";
            // 
            // Date_FechaIni
            // 
            this.Date_FechaIni.Location = new System.Drawing.Point(203, 82);
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
            this.DG_Pacientes.Location = new System.Drawing.Point(29, 162);
            this.DG_Pacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DG_Pacientes.Name = "DG_Pacientes";
            this.DG_Pacientes.RowHeadersWidth = 51;
            this.DG_Pacientes.Size = new System.Drawing.Size(725, 185);
            this.DG_Pacientes.TabIndex = 28;
            this.DG_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Pacientes_CellContentClick);
            // 
            // FR_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 534);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FR_REPORTES";
            this.Text = "FR_REPORTES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_fechafinal;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.DateTimePicker Date_FechaFin;
        private System.Windows.Forms.Label lbl_imprimir;
        private System.Windows.Forms.Label lbl_fechainicio;
        private System.Windows.Forms.DateTimePicker Date_FechaIni;
        private System.Windows.Forms.Label Txt_Titulo;
        private System.Windows.Forms.Label Txt_Generar;
        private System.Windows.Forms.Label Txt_Regresar;
        private System.Windows.Forms.DataGridView DG_Pacientes;
        private System.Windows.Forms.TextBox txt_nombrepaciente;
        private System.Windows.Forms.Label lbl_nombrepaciente;
        private System.Windows.Forms.TextBox txt_codigopaciente;
        private System.Windows.Forms.Label lbl_codigopaciente;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_modificar;
    }
}
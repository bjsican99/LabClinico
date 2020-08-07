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
            this.TX_NOMBREPACIENTECONSULTA = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_codigopaciente = new System.Windows.Forms.TextBox();
            this.Lbl_CodPaciente = new System.Windows.Forms.Label();
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.TX_NOMBREPACIENTECONSULTA);
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Controls.Add(this.txt_codigopaciente);
            this.panel1.Controls.Add(this.Lbl_CodPaciente);
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
            this.panel1.Location = new System.Drawing.Point(40, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 374);
            this.panel1.TabIndex = 29;
            // 
            // TX_NOMBREPACIENTECONSULTA
            // 
            this.TX_NOMBREPACIENTECONSULTA.Location = new System.Drawing.Point(409, 101);
            this.TX_NOMBREPACIENTECONSULTA.Name = "TX_NOMBREPACIENTECONSULTA";
            this.TX_NOMBREPACIENTECONSULTA.Size = new System.Drawing.Size(157, 20);
            this.TX_NOMBREPACIENTECONSULTA.TabIndex = 47;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(283, 90);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(116, 29);
            this.Lbl_Nombre.TabIndex = 46;
            this.Lbl_Nombre.Text = "Nombre.p";
            // 
            // txt_codigopaciente
            // 
            this.txt_codigopaciente.Location = new System.Drawing.Point(409, 67);
            this.txt_codigopaciente.Name = "txt_codigopaciente";
            this.txt_codigopaciente.Size = new System.Drawing.Size(157, 20);
            this.txt_codigopaciente.TabIndex = 45;
            // 
            // Lbl_CodPaciente
            // 
            this.Lbl_CodPaciente.AutoSize = true;
            this.Lbl_CodPaciente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodPaciente.Location = new System.Drawing.Point(283, 60);
            this.Lbl_CodPaciente.Name = "Lbl_CodPaciente";
            this.Lbl_CodPaciente.Size = new System.Drawing.Size(105, 29);
            this.Lbl_CodPaciente.TabIndex = 44;
            this.Lbl_CodPaciente.Text = "Codigo.p";
            // 
            // B_IMPRIMIR
            // 
            this.B_IMPRIMIR.BackColor = System.Drawing.Color.White;
            this.B_IMPRIMIR.Image = ((System.Drawing.Image)(resources.GetObject("B_IMPRIMIR.Image")));
            this.B_IMPRIMIR.Location = new System.Drawing.Point(22, 288);
            this.B_IMPRIMIR.Margin = new System.Windows.Forms.Padding(2);
            this.B_IMPRIMIR.Name = "B_IMPRIMIR";
            this.B_IMPRIMIR.Size = new System.Drawing.Size(80, 67);
            this.B_IMPRIMIR.TabIndex = 42;
            this.B_IMPRIMIR.UseVisualStyleBackColor = false;
            this.B_IMPRIMIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(536, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 77);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fecha final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Buscar";
            // 
            // Date_FechaFin
            // 
            this.Date_FechaFin.Location = new System.Drawing.Point(152, 99);
            this.Date_FechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.Date_FechaFin.Name = "Date_FechaFin";
            this.Date_FechaFin.Size = new System.Drawing.Size(126, 20);
            this.Date_FechaFin.TabIndex = 37;
            // 
            // Txt_FechaFin
            // 
            this.Txt_FechaFin.AutoSize = true;
            this.Txt_FechaFin.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FechaFin.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaFin.Location = new System.Drawing.Point(107, 306);
            this.Txt_FechaFin.Name = "Txt_FechaFin";
            this.Txt_FechaFin.Size = new System.Drawing.Size(94, 29);
            this.Txt_FechaFin.TabIndex = 36;
            this.Txt_FechaFin.Text = "Generar";
            // 
            // Txt_FechaIni
            // 
            this.Txt_FechaIni.AutoSize = true;
            this.Txt_FechaIni.BackColor = System.Drawing.Color.Transparent;
            this.Txt_FechaIni.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaIni.Location = new System.Drawing.Point(17, 60);
            this.Txt_FechaIni.Name = "Txt_FechaIni";
            this.Txt_FechaIni.Size = new System.Drawing.Size(139, 29);
            this.Txt_FechaIni.TabIndex = 35;
            this.Txt_FechaIni.Text = "Fecha inicial";
            // 
            // Date_FechaIni
            // 
            this.Date_FechaIni.Location = new System.Drawing.Point(152, 67);
            this.Date_FechaIni.Margin = new System.Windows.Forms.Padding(2);
            this.Date_FechaIni.Name = "Date_FechaIni";
            this.Date_FechaIni.Size = new System.Drawing.Size(126, 20);
            this.Date_FechaIni.TabIndex = 34;
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.AutoSize = true;
            this.Txt_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Titulo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titulo.Location = new System.Drawing.Point(186, 10);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(231, 29);
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
            // 
            // DG_Pacientes
            // 
            this.DG_Pacientes.BackgroundColor = System.Drawing.Color.Silver;
            this.DG_Pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Pacientes.Location = new System.Drawing.Point(22, 132);
            this.DG_Pacientes.Name = "DG_Pacientes";
            this.DG_Pacientes.RowHeadersWidth = 51;
            this.DG_Pacientes.Size = new System.Drawing.Size(508, 150);
            this.DG_Pacientes.TabIndex = 28;
            this.DG_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Pacientes_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(349, 296);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(68, 51);
            this.btn_modificar.TabIndex = 48;
            this.btn_modificar.Text = "button1";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // FR_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 417);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox TX_NOMBREPACIENTECONSULTA;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox txt_codigopaciente;
        private System.Windows.Forms.Label Lbl_CodPaciente;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_modificar;
    }
}
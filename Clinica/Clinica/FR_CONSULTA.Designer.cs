namespace Clinica
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TX_NOMBREPACIENTECONSULTA = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.TX_CODIGOPACIENTECONSULTA = new System.Windows.Forms.TextBox();
            this.Lbl_CodPaciente = new System.Windows.Forms.Label();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.B_BUSCAR = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Regresar = new System.Windows.Forms.Label();
            this.DG_Pacientes = new System.Windows.Forms.DataGridView();
            this.DG_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_REGRESARCONSULTA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.B_REGRESARCONSULTA);
            this.panel1.Controls.Add(this.TX_NOMBREPACIENTECONSULTA);
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Controls.Add(this.TX_CODIGOPACIENTECONSULTA);
            this.panel1.Controls.Add(this.Lbl_CodPaciente);
            this.panel1.Controls.Add(this.Lbl_Buscar);
            this.panel1.Controls.Add(this.B_BUSCAR);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Controls.Add(this.Lbl_Regresar);
            this.panel1.Controls.Add(this.DG_Pacientes);
            this.panel1.Location = new System.Drawing.Point(29, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 442);
            this.panel1.TabIndex = 29;
            // 
            // TX_NOMBREPACIENTECONSULTA
            // 
            this.TX_NOMBREPACIENTECONSULTA.Location = new System.Drawing.Point(163, 182);
            this.TX_NOMBREPACIENTECONSULTA.Margin = new System.Windows.Forms.Padding(4);
            this.TX_NOMBREPACIENTECONSULTA.Name = "TX_NOMBREPACIENTECONSULTA";
            this.TX_NOMBREPACIENTECONSULTA.Size = new System.Drawing.Size(208, 22);
            this.TX_NOMBREPACIENTECONSULTA.TabIndex = 43;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(83, 145);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(241, 37);
            this.Lbl_Nombre.TabIndex = 42;
            this.Lbl_Nombre.Text = "Nombre Paciente";
            // 
            // TX_CODIGOPACIENTECONSULTA
            // 
            this.TX_CODIGOPACIENTECONSULTA.Location = new System.Drawing.Point(163, 117);
            this.TX_CODIGOPACIENTECONSULTA.Margin = new System.Windows.Forms.Padding(4);
            this.TX_CODIGOPACIENTECONSULTA.Name = "TX_CODIGOPACIENTECONSULTA";
            this.TX_CODIGOPACIENTECONSULTA.Size = new System.Drawing.Size(208, 22);
            this.TX_CODIGOPACIENTECONSULTA.TabIndex = 41;
            // 
            // Lbl_CodPaciente
            // 
            this.Lbl_CodPaciente.AutoSize = true;
            this.Lbl_CodPaciente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodPaciente.Location = new System.Drawing.Point(83, 80);
            this.Lbl_CodPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CodPaciente.Name = "Lbl_CodPaciente";
            this.Lbl_CodPaciente.Size = new System.Drawing.Size(226, 37);
            this.Lbl_CodPaciente.TabIndex = 40;
            this.Lbl_CodPaciente.Text = "Codigo paciente";
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.Location = new System.Drawing.Point(509, 181);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(103, 37);
            this.Lbl_Buscar.TabIndex = 39;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // B_BUSCAR
            // 
            this.B_BUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("B_BUSCAR.Image")));
            this.B_BUSCAR.Location = new System.Drawing.Point(503, 108);
            this.B_BUSCAR.Margin = new System.Windows.Forms.Padding(4);
            this.B_BUSCAR.Name = "B_BUSCAR";
            this.B_BUSCAR.Size = new System.Drawing.Size(88, 69);
            this.B_BUSCAR.TabIndex = 38;
            this.B_BUSCAR.UseVisualStyleBackColor = true;
            this.B_BUSCAR.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(248, 12);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(443, 49);
            this.Lbl_Titulo.TabIndex = 33;
            this.Lbl_Titulo.Text = "Consulta de laboratorios";
            // 
            // Lbl_Regresar
            // 
            this.Lbl_Regresar.AutoSize = true;
            this.Lbl_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Regresar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Regresar.Location = new System.Drawing.Point(1017, 529);
            this.Lbl_Regresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Regresar.Name = "Lbl_Regresar";
            this.Lbl_Regresar.Size = new System.Drawing.Size(95, 34);
            this.Lbl_Regresar.TabIndex = 31;
            this.Lbl_Regresar.Text = "Regresar";
            // 
            // DG_Pacientes
            // 
            this.DG_Pacientes.BackgroundColor = System.Drawing.Color.Silver;
            this.DG_Pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Pacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DG_Codigo,
            this.DG_Nombre,
            this.DG_FechaRegistro});
            this.DG_Pacientes.Location = new System.Drawing.Point(43, 230);
            this.DG_Pacientes.Margin = new System.Windows.Forms.Padding(4);
            this.DG_Pacientes.Name = "DG_Pacientes";
            this.DG_Pacientes.RowHeadersWidth = 51;
            this.DG_Pacientes.Size = new System.Drawing.Size(602, 216);
            this.DG_Pacientes.TabIndex = 28;
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
            // DG_FechaRegistro
            // 
            this.DG_FechaRegistro.HeaderText = "Fecha de registro";
            this.DG_FechaRegistro.MinimumWidth = 6;
            this.DG_FechaRegistro.Name = "DG_FechaRegistro";
            this.DG_FechaRegistro.Width = 125;
            // 
            // B_REGRESARCONSULTA
            // 
            this.B_REGRESARCONSULTA.BackColor = System.Drawing.Color.Transparent;
            this.B_REGRESARCONSULTA.ForeColor = System.Drawing.Color.White;
            this.B_REGRESARCONSULTA.Image = ((System.Drawing.Image)(resources.GetObject("B_REGRESARCONSULTA.Image")));
            this.B_REGRESARCONSULTA.Location = new System.Drawing.Point(682, 314);
            this.B_REGRESARCONSULTA.Margin = new System.Windows.Forms.Padding(4);
            this.B_REGRESARCONSULTA.Name = "B_REGRESARCONSULTA";
            this.B_REGRESARCONSULTA.Size = new System.Drawing.Size(111, 94);
            this.B_REGRESARCONSULTA.TabIndex = 44;
            this.B_REGRESARCONSULTA.UseVisualStyleBackColor = false;
            this.B_REGRESARCONSULTA.Click += new System.EventHandler(this.Btn_Regresar_Click_1);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Button B_BUSCAR;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Regresar;
        private System.Windows.Forms.DataGridView DG_Pacientes;
        private System.Windows.Forms.TextBox TX_CODIGOPACIENTECONSULTA;
        private System.Windows.Forms.Label Lbl_CodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaRegistro;
        private System.Windows.Forms.TextBox TX_NOMBREPACIENTECONSULTA;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Button B_REGRESARCONSULTA;
    }
}
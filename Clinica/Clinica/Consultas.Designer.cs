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
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Regresar = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.DG_Pacientes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG_FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_CodPaciente = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Txt_Nombre);
            this.panel1.Controls.Add(this.Lbl_Nombre);
            this.panel1.Controls.Add(this.Txt_codigo);
            this.panel1.Controls.Add(this.Lbl_CodPaciente);
            this.panel1.Controls.Add(this.Lbl_Buscar);
            this.panel1.Controls.Add(this.Btn_Buscar);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Controls.Add(this.Lbl_Regresar);
            this.panel1.Controls.Add(this.Btn_Regresar);
            this.panel1.Controls.Add(this.DG_Pacientes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 458);
            this.panel1.TabIndex = 29;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.Location = new System.Drawing.Point(382, 147);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(52, 24);
            this.Lbl_Buscar.TabIndex = 39;
            this.Lbl_Buscar.Text = "Buscar";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(377, 88);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(66, 56);
            this.Btn_Buscar.TabIndex = 38;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(186, 10);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(268, 39);
            this.Lbl_Titulo.TabIndex = 33;
            this.Lbl_Titulo.Text = "Consulta de laboratorios";
            // 
            // Lbl_Regresar
            // 
            this.Lbl_Regresar.AutoSize = true;
            this.Lbl_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Regresar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Regresar.Location = new System.Drawing.Point(763, 430);
            this.Lbl_Regresar.Name = "Lbl_Regresar";
            this.Lbl_Regresar.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Regresar.TabIndex = 31;
            this.Lbl_Regresar.Text = "Regresar";
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
            this.DG_FechaRegistro});
            this.DG_Pacientes.Location = new System.Drawing.Point(32, 212);
            this.DG_Pacientes.Name = "DG_Pacientes";
            this.DG_Pacientes.Size = new System.Drawing.Size(523, 150);
            this.DG_Pacientes.TabIndex = 28;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bryan Mazariegos";
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
            // DG_FechaRegistro
            // 
            this.DG_FechaRegistro.HeaderText = "Fecha de registro";
            this.DG_FechaRegistro.Name = "DG_FechaRegistro";
            // 
            // Lbl_CodPaciente
            // 
            this.Lbl_CodPaciente.AutoSize = true;
            this.Lbl_CodPaciente.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_CodPaciente.Location = new System.Drawing.Point(62, 65);
            this.Lbl_CodPaciente.Name = "Lbl_CodPaciente";
            this.Lbl_CodPaciente.Size = new System.Drawing.Size(120, 26);
            this.Lbl_CodPaciente.TabIndex = 40;
            this.Lbl_CodPaciente.Text = "Codigo paciente";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(122, 95);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(157, 20);
            this.Txt_codigo.TabIndex = 41;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(122, 148);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(157, 20);
            this.Txt_Nombre.TabIndex = 43;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nombre.Location = new System.Drawing.Point(62, 118);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(129, 26);
            this.Lbl_Nombre.TabIndex = 42;
            this.Lbl_Nombre.Text = "Nombre Paciente";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(879, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Pacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Regresar;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.DataGridView DG_Pacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_CodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG_FechaRegistro;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Nombre;
    }
}
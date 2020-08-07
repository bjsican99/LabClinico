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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_PACIENTE = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_INGRESAR = new System.Windows.Forms.Button();
            this.B_ACTUALIZAR = new System.Windows.Forms.Button();
            this.DG_EXAMENES = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TX_TIPO = new System.Windows.Forms.TextBox();
            this.TX_VALOR = new System.Windows.Forms.TextBox();
            this.TX_CIENTIFICO = new System.Windows.Forms.TextBox();
            this.TX_NOMBRE = new System.Windows.Forms.TextBox();
            this.TX_CODIGO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EXAMENES)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CB_PACIENTE);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.B_INGRESAR);
            this.panel1.Controls.Add(this.B_ACTUALIZAR);
            this.panel1.Controls.Add(this.DG_EXAMENES);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TX_TIPO);
            this.panel1.Controls.Add(this.TX_VALOR);
            this.panel1.Controls.Add(this.TX_CIENTIFICO);
            this.panel1.Controls.Add(this.TX_NOMBRE);
            this.panel1.Controls.Add(this.TX_CODIGO);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 463);
            this.panel1.TabIndex = 2;
            // 
            // CB_PACIENTE
            // 
            this.CB_PACIENTE.FormattingEnabled = true;
            this.CB_PACIENTE.Items.AddRange(new object[] {
            "Solter@",
            "Casad@"});
            this.CB_PACIENTE.Location = new System.Drawing.Point(243, 407);
            this.CB_PACIENTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_PACIENTE.Name = "CB_PACIENTE";
            this.CB_PACIENTE.Size = new System.Drawing.Size(189, 24);
            this.CB_PACIENTE.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "C. Paciente";
            // 
            // B_INGRESAR
            // 
            this.B_INGRESAR.BackColor = System.Drawing.Color.White;
            this.B_INGRESAR.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_INGRESAR.Location = new System.Drawing.Point(526, 407);
            this.B_INGRESAR.Name = "B_INGRESAR";
            this.B_INGRESAR.Size = new System.Drawing.Size(253, 41);
            this.B_INGRESAR.TabIndex = 14;
            this.B_INGRESAR.Text = "Ingresar";
            this.B_INGRESAR.UseVisualStyleBackColor = false;
            // 
            // B_ACTUALIZAR
            // 
            this.B_ACTUALIZAR.BackColor = System.Drawing.Color.White;
            this.B_ACTUALIZAR.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ACTUALIZAR.Location = new System.Drawing.Point(526, 94);
            this.B_ACTUALIZAR.Name = "B_ACTUALIZAR";
            this.B_ACTUALIZAR.Size = new System.Drawing.Size(253, 41);
            this.B_ACTUALIZAR.TabIndex = 13;
            this.B_ACTUALIZAR.Text = "Actualizar";
            this.B_ACTUALIZAR.UseVisualStyleBackColor = false;
            // 
            // DG_EXAMENES
            // 
            this.DG_EXAMENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_EXAMENES.Location = new System.Drawing.Point(526, 159);
            this.DG_EXAMENES.Name = "DG_EXAMENES";
            this.DG_EXAMENES.RowHeadersWidth = 51;
            this.DG_EXAMENES.RowTemplate.Height = 24;
            this.DG_EXAMENES.Size = new System.Drawing.Size(253, 229);
            this.DG_EXAMENES.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingreso Examenes";
            // 
            // TX_TIPO
            // 
            this.TX_TIPO.Location = new System.Drawing.Point(243, 350);
            this.TX_TIPO.Name = "TX_TIPO";
            this.TX_TIPO.Size = new System.Drawing.Size(189, 22);
            this.TX_TIPO.TabIndex = 10;
            // 
            // TX_VALOR
            // 
            this.TX_VALOR.Location = new System.Drawing.Point(243, 286);
            this.TX_VALOR.Name = "TX_VALOR";
            this.TX_VALOR.Size = new System.Drawing.Size(189, 22);
            this.TX_VALOR.TabIndex = 9;
            // 
            // TX_CIENTIFICO
            // 
            this.TX_CIENTIFICO.Location = new System.Drawing.Point(243, 228);
            this.TX_CIENTIFICO.Name = "TX_CIENTIFICO";
            this.TX_CIENTIFICO.Size = new System.Drawing.Size(189, 22);
            this.TX_CIENTIFICO.TabIndex = 8;
            // 
            // TX_NOMBRE
            // 
            this.TX_NOMBRE.Location = new System.Drawing.Point(243, 172);
            this.TX_NOMBRE.Name = "TX_NOMBRE";
            this.TX_NOMBRE.Size = new System.Drawing.Size(189, 22);
            this.TX_NOMBRE.TabIndex = 7;
            // 
            // TX_CODIGO
            // 
            this.TX_CODIGO.Location = new System.Drawing.Point(243, 111);
            this.TX_CODIGO.Name = "TX_CODIGO";
            this.TX_CODIGO.Size = new System.Drawing.Size(189, 22);
            this.TX_CODIGO.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "N. Cientifico";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(621, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 59);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FR_EXAMEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_EXAMEN";
            this.Text = "FR_EXAMEN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EXAMENES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TX_TIPO;
        private System.Windows.Forms.TextBox TX_VALOR;
        private System.Windows.Forms.TextBox TX_CIENTIFICO;
        private System.Windows.Forms.TextBox TX_NOMBRE;
        private System.Windows.Forms.TextBox TX_CODIGO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_EXAMENES;
        private System.Windows.Forms.Button B_ACTUALIZAR;
        private System.Windows.Forms.Button B_INGRESAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_PACIENTE;
        private System.Windows.Forms.Button button1;
    }
}
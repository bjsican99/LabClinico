namespace Clinica
{
    partial class FR_CELMAIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_CELMAIL));
            this.lbl_paciente = new System.Windows.Forms.Label();
            this.cbo_paciente = new System.Windows.Forms.ComboBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.btn_ingresartelefono = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_alergia = new System.Windows.Forms.Label();
            this.txt_alergia = new System.Windows.Forms.TextBox();
            this.btn_alergia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_paciente
            // 
            this.lbl_paciente.AutoSize = true;
            this.lbl_paciente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_paciente.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paciente.Location = new System.Drawing.Point(59, 65);
            this.lbl_paciente.Name = "lbl_paciente";
            this.lbl_paciente.Size = new System.Drawing.Size(125, 37);
            this.lbl_paciente.TabIndex = 0;
            this.lbl_paciente.Text = "Paciente";
            // 
            // cbo_paciente
            // 
            this.cbo_paciente.FormattingEnabled = true;
            this.cbo_paciente.Location = new System.Drawing.Point(241, 78);
            this.cbo_paciente.Name = "cbo_paciente";
            this.cbo_paciente.Size = new System.Drawing.Size(214, 24);
            this.cbo_paciente.TabIndex = 1;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(59, 136);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(127, 37);
            this.lbl_telefono.TabIndex = 2;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(59, 208);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(102, 37);
            this.lbl_correo.TabIndex = 3;
            this.lbl_correo.Text = "Correo";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(243, 151);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(214, 22);
            this.txt_telefono.TabIndex = 4;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(241, 221);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(214, 22);
            this.txt_correo.TabIndex = 5;
            // 
            // btn_ingresartelefono
            // 
            this.btn_ingresartelefono.BackColor = System.Drawing.Color.White;
            this.btn_ingresartelefono.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresartelefono.Location = new System.Drawing.Point(140, 365);
            this.btn_ingresartelefono.Name = "btn_ingresartelefono";
            this.btn_ingresartelefono.Size = new System.Drawing.Size(152, 72);
            this.btn_ingresartelefono.TabIndex = 6;
            this.btn_ingresartelefono.Text = "I. Telefono";
            this.btn_ingresartelefono.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 72);
            this.button1.TabIndex = 7;
            this.button1.Text = "I. Correo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(298, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 72);
            this.button2.TabIndex = 8;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_alergia
            // 
            this.lbl_alergia.AutoSize = true;
            this.lbl_alergia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_alergia.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alergia.Location = new System.Drawing.Point(59, 286);
            this.lbl_alergia.Name = "lbl_alergia";
            this.lbl_alergia.Size = new System.Drawing.Size(106, 37);
            this.lbl_alergia.TabIndex = 9;
            this.lbl_alergia.Text = "Alergia";
            // 
            // txt_alergia
            // 
            this.txt_alergia.Location = new System.Drawing.Point(241, 299);
            this.txt_alergia.Name = "txt_alergia";
            this.txt_alergia.Size = new System.Drawing.Size(214, 22);
            this.txt_alergia.TabIndex = 10;
            // 
            // btn_alergia
            // 
            this.btn_alergia.BackColor = System.Drawing.Color.White;
            this.btn_alergia.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alergia.Location = new System.Drawing.Point(298, 365);
            this.btn_alergia.Name = "btn_alergia";
            this.btn_alergia.Size = new System.Drawing.Size(152, 72);
            this.btn_alergia.TabIndex = 11;
            this.btn_alergia.Text = "Alergia";
            this.btn_alergia.UseVisualStyleBackColor = false;
            // 
            // FR_CELMAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.btn_alergia);
            this.Controls.Add(this.txt_alergia);
            this.Controls.Add(this.lbl_alergia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ingresartelefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.cbo_paciente);
            this.Controls.Add(this.lbl_paciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_CELMAIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_CELMAIL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_paciente;
        private System.Windows.Forms.ComboBox cbo_paciente;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Button btn_ingresartelefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_alergia;
        private System.Windows.Forms.TextBox txt_alergia;
        private System.Windows.Forms.Button btn_alergia;
    }
}
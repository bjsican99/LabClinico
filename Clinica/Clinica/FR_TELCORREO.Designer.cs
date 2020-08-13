namespace Clinica
{
    partial class FR_TELCORREO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_TELCORREO));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ingresartelefono = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.cbo_personal = new System.Windows.Forms.ComboBox();
            this.lbl_personal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(388, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 72);
            this.button2.TabIndex = 20;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 72);
            this.button1.TabIndex = 19;
            this.button1.Text = "I. Correo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_ingresartelefono
            // 
            this.btn_ingresartelefono.BackColor = System.Drawing.Color.White;
            this.btn_ingresartelefono.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresartelefono.Location = new System.Drawing.Point(72, 369);
            this.btn_ingresartelefono.Name = "btn_ingresartelefono";
            this.btn_ingresartelefono.Size = new System.Drawing.Size(152, 72);
            this.btn_ingresartelefono.TabIndex = 18;
            this.btn_ingresartelefono.Text = "I. Telefono";
            this.btn_ingresartelefono.UseVisualStyleBackColor = false;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(272, 265);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(214, 22);
            this.txt_correo.TabIndex = 17;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(274, 195);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(214, 22);
            this.txt_telefono.TabIndex = 16;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(90, 252);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(102, 37);
            this.lbl_correo.TabIndex = 15;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(90, 180);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(127, 37);
            this.lbl_telefono.TabIndex = 14;
            this.lbl_telefono.Text = "Telefono";
            // 
            // cbo_personal
            // 
            this.cbo_personal.FormattingEnabled = true;
            this.cbo_personal.Location = new System.Drawing.Point(272, 122);
            this.cbo_personal.Name = "cbo_personal";
            this.cbo_personal.Size = new System.Drawing.Size(214, 24);
            this.cbo_personal.TabIndex = 13;
            // 
            // lbl_personal
            // 
            this.lbl_personal.AutoSize = true;
            this.lbl_personal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personal.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personal.Location = new System.Drawing.Point(90, 109);
            this.lbl_personal.Name = "lbl_personal";
            this.lbl_personal.Size = new System.Drawing.Size(124, 37);
            this.lbl_personal.TabIndex = 12;
            this.lbl_personal.Text = "Personal";
            // 
            // FR_TELCORREO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ingresartelefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.cbo_personal);
            this.Controls.Add(this.lbl_personal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_TELCORREO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_TELCORREO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ingresartelefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.ComboBox cbo_personal;
        private System.Windows.Forms.Label lbl_personal;
    }
}
namespace Clinica
{
    partial class FR_CORREO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_CORREO));
            this.txt_para = new System.Windows.Forms.TextBox();
            this.txt_asunto = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_para = new System.Windows.Forms.Label();
            this.lbl_asunto = new System.Windows.Forms.Label();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_para
            // 
            this.txt_para.Location = new System.Drawing.Point(135, 115);
            this.txt_para.Margin = new System.Windows.Forms.Padding(2);
            this.txt_para.Name = "txt_para";
            this.txt_para.Size = new System.Drawing.Size(267, 20);
            this.txt_para.TabIndex = 2;
            this.txt_para.TextChanged += new System.EventHandler(this.txt_para_TextChanged);
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(135, 159);
            this.txt_asunto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(267, 20);
            this.txt_asunto.TabIndex = 3;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.White;
            this.btn_enviar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Image = ((System.Drawing.Image)(resources.GetObject("btn_enviar.Image")));
            this.btn_enviar.Location = new System.Drawing.Point(346, 297);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(74, 69);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.BackColor = System.Drawing.Color.Transparent;
            this.lbl_para.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_para.Location = new System.Drawing.Point(36, 104);
            this.lbl_para.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(59, 29);
            this.lbl_para.TabIndex = 6;
            this.lbl_para.Text = "Para";
            // 
            // lbl_asunto
            // 
            this.lbl_asunto.AutoSize = true;
            this.lbl_asunto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_asunto.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asunto.Location = new System.Drawing.Point(36, 148);
            this.lbl_asunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_asunto.Name = "lbl_asunto";
            this.lbl_asunto.Size = new System.Drawing.Size(84, 29);
            this.lbl_asunto.TabIndex = 7;
            this.lbl_asunto.Text = "Asunto";
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(135, 197);
            this.txt_mensaje.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(267, 96);
            this.txt_mensaje.TabIndex = 10;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(637, 1);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(38, 39);
            this.btn_regresar.TabIndex = 11;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(130, 23);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(216, 29);
            this.lbl_titulo.TabIndex = 12;
            this.lbl_titulo.Text = "ENVIO DE CORREO ";
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mensaje.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(36, 186);
            this.lbl_mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(98, 29);
            this.lbl_mensaje.TabIndex = 13;
            this.lbl_mensaje.Text = "Mensaje";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(244, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 71);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_adjuntar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adjuntar PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enviar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(135, 78);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(168, 20);
            this.txt_codigo.TabIndex = 17;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged_1);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // FR_CORREO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.lbl_asunto);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.txt_para);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FR_CORREO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_CORREO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_para;
        private System.Windows.Forms.TextBox txt_asunto;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Label lbl_asunto;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}
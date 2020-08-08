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
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.lbl_cc = new System.Windows.Forms.Label();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_para
            // 
            this.txt_para.Location = new System.Drawing.Point(180, 135);
            this.txt_para.Name = "txt_para";
            this.txt_para.Size = new System.Drawing.Size(328, 22);
            this.txt_para.TabIndex = 2;
            this.txt_para.TextChanged += new System.EventHandler(this.TX_PARA_TextChanged);
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(180, 274);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(328, 22);
            this.txt_asunto.TabIndex = 3;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.White;
            this.btn_enviar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(128, 427);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(125, 48);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.BackColor = System.Drawing.Color.Transparent;
            this.lbl_para.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_para.Location = new System.Drawing.Point(48, 122);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(74, 37);
            this.lbl_para.TabIndex = 6;
            this.lbl_para.Text = "Para";
            // 
            // lbl_asunto
            // 
            this.lbl_asunto.AutoSize = true;
            this.lbl_asunto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_asunto.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asunto.Location = new System.Drawing.Point(48, 261);
            this.lbl_asunto.Name = "lbl_asunto";
            this.lbl_asunto.Size = new System.Drawing.Size(106, 37);
            this.lbl_asunto.TabIndex = 7;
            this.lbl_asunto.Text = "Asunto";
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(180, 203);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(328, 22);
            this.txt_cc.TabIndex = 8;
            // 
            // lbl_cc
            // 
            this.lbl_cc.AutoSize = true;
            this.lbl_cc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cc.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cc.Location = new System.Drawing.Point(48, 190);
            this.lbl_cc.Name = "lbl_cc";
            this.lbl_cc.Size = new System.Drawing.Size(48, 37);
            this.lbl_cc.TabIndex = 9;
            this.lbl_cc.Text = "Cc";
            this.lbl_cc.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(180, 354);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(328, 22);
            this.txt_mensaje.TabIndex = 10;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.White;
            this.btn_regresar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(356, 427);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(125, 48);
            this.btn_regresar.TabIndex = 11;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(173, 28);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(271, 37);
            this.lbl_titulo.TabIndex = 12;
            this.lbl_titulo.Text = "ENVIO DE CORREO ";
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mensaje.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(48, 341);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(122, 37);
            this.lbl_mensaje.TabIndex = 13;
            this.lbl_mensaje.Text = "Mensaje";
            // 
            // FR_CORREO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.lbl_cc);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.lbl_asunto);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.txt_para);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_CORREO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_CORREO";
            this.Load += new System.EventHandler(this.FR_CORREO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_para;
        private System.Windows.Forms.TextBox txt_asunto;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Label lbl_asunto;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Label lbl_cc;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_mensaje;
    }
}
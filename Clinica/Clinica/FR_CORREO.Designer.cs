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
            this.TX_PARA = new System.Windows.Forms.TextBox();
            this.TX_ASUNTO = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_CC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_MENSAJE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TX_PARA
            // 
            this.TX_PARA.Location = new System.Drawing.Point(156, 41);
            this.TX_PARA.Name = "TX_PARA";
            this.TX_PARA.Size = new System.Drawing.Size(234, 22);
            this.TX_PARA.TabIndex = 2;
            // 
            // TX_ASUNTO
            // 
            this.TX_ASUNTO.Location = new System.Drawing.Point(156, 131);
            this.TX_ASUNTO.Name = "TX_ASUNTO";
            this.TX_ASUNTO.Size = new System.Drawing.Size(234, 22);
            this.TX_ASUNTO.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(449, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asunto";
            // 
            // TX_CC
            // 
            this.TX_CC.Location = new System.Drawing.Point(156, 90);
            this.TX_CC.Name = "TX_CC";
            this.TX_CC.Size = new System.Drawing.Size(234, 22);
            this.TX_CC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cc";
            // 
            // TX_MENSAJE
            // 
            this.TX_MENSAJE.Location = new System.Drawing.Point(156, 185);
            this.TX_MENSAJE.Name = "TX_MENSAJE";
            this.TX_MENSAJE.Size = new System.Drawing.Size(234, 22);
            this.TX_MENSAJE.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(449, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FR_CORREO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TX_MENSAJE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TX_CC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TX_ASUNTO);
            this.Controls.Add(this.TX_PARA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_CORREO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_CORREO";
            this.Load += new System.EventHandler(this.FR_CORREO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TX_PARA;
        private System.Windows.Forms.TextBox TX_ASUNTO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_CC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_MENSAJE;
        private System.Windows.Forms.Button button1;
    }
}
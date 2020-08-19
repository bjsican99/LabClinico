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
            this.pnl_reportes = new System.Windows.Forms.Panel();
            this.lbl_reportes = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.lbl_reporteganacias = new System.Windows.Forms.Label();
            this.btn_acciones_usuario = new System.Windows.Forms.Button();
            this.lbl_reportebitacora = new System.Windows.Forms.Label();
            this.btn_examenes_ultima_visita = new System.Windows.Forms.Button();
            this.lbl_historial_examenes = new System.Windows.Forms.Label();
            this.btn_resultado_examenes = new System.Windows.Forms.Button();
            this.lbl_resultados_examenes = new System.Windows.Forms.Label();
            this.pnl_reportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_reportes
            // 
            this.pnl_reportes.BackColor = System.Drawing.Color.White;
            this.pnl_reportes.Controls.Add(this.btn_resultado_examenes);
            this.pnl_reportes.Controls.Add(this.lbl_resultados_examenes);
            this.pnl_reportes.Controls.Add(this.btn_examenes_ultima_visita);
            this.pnl_reportes.Controls.Add(this.lbl_historial_examenes);
            this.pnl_reportes.Controls.Add(this.btn_acciones_usuario);
            this.pnl_reportes.Controls.Add(this.lbl_reportebitacora);
            this.pnl_reportes.Controls.Add(this.btn_consultar);
            this.pnl_reportes.Controls.Add(this.lbl_reporteganacias);
            this.pnl_reportes.Controls.Add(this.lbl_reportes);
            this.pnl_reportes.Location = new System.Drawing.Point(18, 17);
            this.pnl_reportes.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_reportes.Name = "pnl_reportes";
            this.pnl_reportes.Size = new System.Drawing.Size(638, 415);
            this.pnl_reportes.TabIndex = 29;
            this.pnl_reportes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_reportes_Paint);
            // 
            // lbl_reportes
            // 
            this.lbl_reportes.AutoSize = true;
            this.lbl_reportes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reportes.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportes.Location = new System.Drawing.Point(236, 9);
            this.lbl_reportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reportes.Name = "lbl_reportes";
            this.lbl_reportes.Size = new System.Drawing.Size(105, 29);
            this.lbl_reportes.TabIndex = 59;
            this.lbl_reportes.Text = "Reportes";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.White;
            this.btn_consultar.ForeColor = System.Drawing.Color.White;
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.Location = new System.Drawing.Point(26, 53);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(79, 72);
            this.btn_consultar.TabIndex = 63;
            this.btn_consultar.UseVisualStyleBackColor = false;
            // 
            // lbl_reporteganacias
            // 
            this.lbl_reporteganacias.AutoSize = true;
            this.lbl_reporteganacias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reporteganacias.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reporteganacias.Location = new System.Drawing.Point(110, 80);
            this.lbl_reporteganacias.Name = "lbl_reporteganacias";
            this.lbl_reporteganacias.Size = new System.Drawing.Size(191, 29);
            this.lbl_reporteganacias.TabIndex = 62;
            this.lbl_reporteganacias.Text = "Reporte Ganacias";
            // 
            // btn_acciones_usuario
            // 
            this.btn_acciones_usuario.BackColor = System.Drawing.Color.White;
            this.btn_acciones_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_acciones_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_acciones_usuario.Image")));
            this.btn_acciones_usuario.Location = new System.Drawing.Point(26, 142);
            this.btn_acciones_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_acciones_usuario.Name = "btn_acciones_usuario";
            this.btn_acciones_usuario.Size = new System.Drawing.Size(79, 72);
            this.btn_acciones_usuario.TabIndex = 65;
            this.btn_acciones_usuario.UseVisualStyleBackColor = false;
            // 
            // lbl_reportebitacora
            // 
            this.lbl_reportebitacora.AutoSize = true;
            this.lbl_reportebitacora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reportebitacora.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportebitacora.Location = new System.Drawing.Point(110, 156);
            this.lbl_reportebitacora.Name = "lbl_reportebitacora";
            this.lbl_reportebitacora.Size = new System.Drawing.Size(223, 58);
            this.lbl_reportebitacora.TabIndex = 64;
            this.lbl_reportebitacora.Text = "Reporte de acciones \r\n      de usuario";
            // 
            // btn_examenes_ultima_visita
            // 
            this.btn_examenes_ultima_visita.BackColor = System.Drawing.Color.White;
            this.btn_examenes_ultima_visita.ForeColor = System.Drawing.Color.White;
            this.btn_examenes_ultima_visita.Image = ((System.Drawing.Image)(resources.GetObject("btn_examenes_ultima_visita.Image")));
            this.btn_examenes_ultima_visita.Location = new System.Drawing.Point(26, 228);
            this.btn_examenes_ultima_visita.Margin = new System.Windows.Forms.Padding(2);
            this.btn_examenes_ultima_visita.Name = "btn_examenes_ultima_visita";
            this.btn_examenes_ultima_visita.Size = new System.Drawing.Size(79, 72);
            this.btn_examenes_ultima_visita.TabIndex = 67;
            this.btn_examenes_ultima_visita.UseVisualStyleBackColor = false;
            // 
            // lbl_historial_examenes
            // 
            this.lbl_historial_examenes.AutoSize = true;
            this.lbl_historial_examenes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_historial_examenes.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_historial_examenes.Location = new System.Drawing.Point(110, 228);
            this.lbl_historial_examenes.Name = "lbl_historial_examenes";
            this.lbl_historial_examenes.Size = new System.Drawing.Size(244, 58);
            this.lbl_historial_examenes.TabIndex = 66;
            this.lbl_historial_examenes.Text = "Historial de examenes \r\n    del paciente";
            // 
            // btn_resultado_examenes
            // 
            this.btn_resultado_examenes.BackColor = System.Drawing.Color.White;
            this.btn_resultado_examenes.ForeColor = System.Drawing.Color.White;
            this.btn_resultado_examenes.Image = ((System.Drawing.Image)(resources.GetObject("btn_resultado_examenes.Image")));
            this.btn_resultado_examenes.Location = new System.Drawing.Point(26, 315);
            this.btn_resultado_examenes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resultado_examenes.Name = "btn_resultado_examenes";
            this.btn_resultado_examenes.Size = new System.Drawing.Size(79, 72);
            this.btn_resultado_examenes.TabIndex = 69;
            this.btn_resultado_examenes.UseVisualStyleBackColor = false;
            // 
            // lbl_resultados_examenes
            // 
            this.lbl_resultados_examenes.AutoSize = true;
            this.lbl_resultados_examenes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resultados_examenes.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultados_examenes.Location = new System.Drawing.Point(108, 333);
            this.lbl_resultados_examenes.Name = "lbl_resultados_examenes";
            this.lbl_resultados_examenes.Size = new System.Drawing.Size(233, 29);
            this.lbl_resultados_examenes.TabIndex = 68;
            this.lbl_resultados_examenes.Text = "Resultado de examen";
            // 
            // FR_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.pnl_reportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FR_REPORTES";
            this.Text = "FR_REPORTES";
            this.pnl_reportes.ResumeLayout(false);
            this.pnl_reportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_reportes;
        private System.Windows.Forms.Label lbl_reportes;
        private System.Windows.Forms.Button btn_resultado_examenes;
        private System.Windows.Forms.Label lbl_resultados_examenes;
        private System.Windows.Forms.Button btn_examenes_ultima_visita;
        private System.Windows.Forms.Label lbl_historial_examenes;
        private System.Windows.Forms.Button btn_acciones_usuario;
        private System.Windows.Forms.Label lbl_reportebitacora;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label lbl_reporteganacias;
    }
}
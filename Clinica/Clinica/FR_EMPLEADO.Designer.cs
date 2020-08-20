namespace Clinica
{
    partial class FR_EMPLEADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_EMPLEADO));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_estadocivil = new System.Windows.Forms.Label();
            this.cbo_estadocivil = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.pnl_empleado = new System.Windows.Forms.Panel();
            this.lbl_nuevo = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.dtp_fechaingreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.lbl_eliminar = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.lbl_consultar = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_ingreso = new System.Windows.Forms.Label();
            this.lbl_nacimiento = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_dpi = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.pnl_empleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(15, 50);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(96, 29);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(15, 89);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(98, 29);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(170, 61);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(126, 20);
            this.txt_nombre.TabIndex = 7;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_estadocivil
            // 
            this.lbl_estadocivil.AutoSize = true;
            this.lbl_estadocivil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estadocivil.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadocivil.Location = new System.Drawing.Point(326, 93);
            this.lbl_estadocivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estadocivil.Name = "lbl_estadocivil";
            this.lbl_estadocivil.Size = new System.Drawing.Size(132, 29);
            this.lbl_estadocivil.TabIndex = 8;
            this.lbl_estadocivil.Text = "Estado Civil";
            // 
            // cbo_estadocivil
            // 
            this.cbo_estadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estadocivil.FormattingEnabled = true;
            this.cbo_estadocivil.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Divorciado",
            "Viudo"});
            this.cbo_estadocivil.Location = new System.Drawing.Point(481, 104);
            this.cbo_estadocivil.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_estadocivil.Name = "cbo_estadocivil";
            this.cbo_estadocivil.Size = new System.Drawing.Size(126, 21);
            this.cbo_estadocivil.TabIndex = 9;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(326, 140);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(84, 29);
            this.lbl_estado.TabIndex = 10;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genero.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(326, 49);
            this.lbl_genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(87, 29);
            this.lbl_genero.TabIndex = 16;
            this.lbl_genero.Text = "Genero";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(170, 99);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(126, 20);
            this.txt_apellido.TabIndex = 24;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // pnl_empleado
            // 
            this.pnl_empleado.BackColor = System.Drawing.Color.White;
            this.pnl_empleado.Controls.Add(this.lbl_nuevo);
            this.pnl_empleado.Controls.Add(this.btn_nuevo);
            this.pnl_empleado.Controls.Add(this.cbo_genero);
            this.pnl_empleado.Controls.Add(this.dtp_fechaingreso);
            this.pnl_empleado.Controls.Add(this.dtp_fechanacimiento);
            this.pnl_empleado.Controls.Add(this.lbl_guardar);
            this.pnl_empleado.Controls.Add(this.lbl_eliminar);
            this.pnl_empleado.Controls.Add(this.btn_eliminar);
            this.pnl_empleado.Controls.Add(this.lbl_modificar);
            this.pnl_empleado.Controls.Add(this.btn_modificar);
            this.pnl_empleado.Controls.Add(this.btn_consultar);
            this.pnl_empleado.Controls.Add(this.lbl_consultar);
            this.pnl_empleado.Controls.Add(this.txt_codigo);
            this.pnl_empleado.Controls.Add(this.lbl_codigo);
            this.pnl_empleado.Controls.Add(this.cbo_estado);
            this.pnl_empleado.Controls.Add(this.txt_correo);
            this.pnl_empleado.Controls.Add(this.lbl_correo);
            this.pnl_empleado.Controls.Add(this.txt_telefono);
            this.pnl_empleado.Controls.Add(this.lbl_telefono);
            this.pnl_empleado.Controls.Add(this.lbl_ingreso);
            this.pnl_empleado.Controls.Add(this.lbl_nacimiento);
            this.pnl_empleado.Controls.Add(this.txt_nit);
            this.pnl_empleado.Controls.Add(this.lbl_nit);
            this.pnl_empleado.Controls.Add(this.btn_guardar);
            this.pnl_empleado.Controls.Add(this.lbl_direccion);
            this.pnl_empleado.Controls.Add(this.txt_direccion);
            this.pnl_empleado.Controls.Add(this.lbl_dpi);
            this.pnl_empleado.Controls.Add(this.txt_dpi);
            this.pnl_empleado.Controls.Add(this.lbl_nombre);
            this.pnl_empleado.Controls.Add(this.lbl_apellido);
            this.pnl_empleado.Controls.Add(this.txt_apellido);
            this.pnl_empleado.Controls.Add(this.txt_nombre);
            this.pnl_empleado.Controls.Add(this.lbl_estadocivil);
            this.pnl_empleado.Controls.Add(this.cbo_estadocivil);
            this.pnl_empleado.Controls.Add(this.lbl_estado);
            this.pnl_empleado.Controls.Add(this.lbl_genero);
            this.pnl_empleado.Location = new System.Drawing.Point(18, 17);
            this.pnl_empleado.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_empleado.Name = "pnl_empleado";
            this.pnl_empleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnl_empleado.Size = new System.Drawing.Size(638, 415);
            this.pnl_empleado.TabIndex = 27;
            this.pnl_empleado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_empleado_Paint);
            // 
            // lbl_nuevo
            // 
            this.lbl_nuevo.AutoSize = true;
            this.lbl_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nuevo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevo.Location = new System.Drawing.Point(104, 377);
            this.lbl_nuevo.Name = "lbl_nuevo";
            this.lbl_nuevo.Size = new System.Drawing.Size(80, 29);
            this.lbl_nuevo.TabIndex = 71;
            this.lbl_nuevo.Text = "Nuevo";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.White;
            this.btn_nuevo.ForeColor = System.Drawing.Color.Wheat;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.Location = new System.Drawing.Point(101, 303);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(83, 76);
            this.btn_nuevo.TabIndex = 70;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // cbo_genero
            // 
            this.cbo_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbo_genero.Location = new System.Drawing.Point(481, 61);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(126, 21);
            this.cbo_genero.TabIndex = 69;
            // 
            // dtp_fechaingreso
            // 
            this.dtp_fechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaingreso.Location = new System.Drawing.Point(170, 252);
            this.dtp_fechaingreso.Name = "dtp_fechaingreso";
            this.dtp_fechaingreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fechaingreso.Size = new System.Drawing.Size(126, 20);
            this.dtp_fechaingreso.TabIndex = 68;
            // 
            // dtp_fechanacimiento
            // 
            this.dtp_fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechanacimiento.Location = new System.Drawing.Point(170, 219);
            this.dtp_fechanacimiento.Name = "dtp_fechanacimiento";
            this.dtp_fechanacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fechanacimiento.Size = new System.Drawing.Size(126, 20);
            this.dtp_fechanacimiento.TabIndex = 67;
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_guardar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guardar.Location = new System.Drawing.Point(190, 377);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(95, 29);
            this.lbl_guardar.TabIndex = 66;
            this.lbl_guardar.Text = "Guardar";
            // 
            // lbl_eliminar
            // 
            this.lbl_eliminar.AutoSize = true;
            this.lbl_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eliminar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eliminar.Location = new System.Drawing.Point(389, 375);
            this.lbl_eliminar.Name = "lbl_eliminar";
            this.lbl_eliminar.Size = new System.Drawing.Size(98, 29);
            this.lbl_eliminar.TabIndex = 65;
            this.lbl_eliminar.Text = "Eliminar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(394, 305);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(79, 72);
            this.btn_eliminar.TabIndex = 64;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modificar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modificar.Location = new System.Drawing.Point(278, 377);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(110, 29);
            this.lbl_modificar.TabIndex = 63;
            this.lbl_modificar.Text = "Modificar";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(294, 305);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(79, 72);
            this.btn_modificar.TabIndex = 62;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.White;
            this.btn_consultar.ForeColor = System.Drawing.Color.White;
            this.btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.Image")));
            this.btn_consultar.Location = new System.Drawing.Point(492, 305);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(79, 72);
            this.btn_consultar.TabIndex = 61;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // lbl_consultar
            // 
            this.lbl_consultar.AutoSize = true;
            this.lbl_consultar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_consultar.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consultar.Location = new System.Drawing.Point(487, 375);
            this.lbl_consultar.Name = "lbl_consultar";
            this.lbl_consultar.Size = new System.Drawing.Size(111, 29);
            this.lbl_consultar.TabIndex = 60;
            this.lbl_consultar.Text = "Consultar";
            // 
            // txt_codigo_KeyPress
            // 
            this.txt_codigo.Location = new System.Drawing.Point(170, 23);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo_KeyPress";
            this.txt_codigo.Size = new System.Drawing.Size(126, 20);
            this.txt_codigo.TabIndex = 59;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(15, 14);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(85, 29);
            this.lbl_codigo.TabIndex = 58;
            this.lbl_codigo.Text = "Código";
            // 
            // cbo_estado
            // 
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.cbo_estado.Location = new System.Drawing.Point(481, 149);
            this.cbo_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(126, 21);
            this.cbo_estado.TabIndex = 57;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(481, 231);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(126, 20);
            this.txt_correo.TabIndex = 56;
            this.txt_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correo_KeyPress);
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(326, 219);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(81, 29);
            this.lbl_correo.TabIndex = 55;
            this.lbl_correo.Text = "Correo";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(481, 190);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(126, 20);
            this.txt_telefono.TabIndex = 54;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(326, 178);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(102, 29);
            this.lbl_telefono.TabIndex = 53;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // lbl_ingreso
            // 
            this.lbl_ingreso.AutoSize = true;
            this.lbl_ingreso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingreso.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingreso.Location = new System.Drawing.Point(15, 246);
            this.lbl_ingreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ingreso.Name = "lbl_ingreso";
            this.lbl_ingreso.Size = new System.Drawing.Size(155, 29);
            this.lbl_ingreso.TabIndex = 51;
            this.lbl_ingreso.Text = "Fecha Ingreso";
            // 
            // lbl_nacimiento
            // 
            this.lbl_nacimiento.AutoSize = true;
            this.lbl_nacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nacimiento.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nacimiento.Location = new System.Drawing.Point(15, 209);
            this.lbl_nacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nacimiento.Name = "lbl_nacimiento";
            this.lbl_nacimiento.Size = new System.Drawing.Size(155, 29);
            this.lbl_nacimiento.TabIndex = 49;
            this.lbl_nacimiento.Text = "F. Nacimiento";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(481, 23);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(126, 20);
            this.txt_nit.TabIndex = 48;
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nit_KeyPress);
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nit.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(326, 14);
            this.lbl_nit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(45, 29);
            this.lbl_nit.TabIndex = 47;
            this.lbl_nit.Text = "Nit";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.White;
            this.btn_guardar.ForeColor = System.Drawing.Color.Wheat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(198, 303);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(83, 76);
            this.btn_guardar.TabIndex = 35;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(14, 167);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(110, 29);
            this.lbl_direccion.TabIndex = 40;
            this.lbl_direccion.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(170, 178);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(126, 20);
            this.txt_direccion.TabIndex = 39;
            // 
            // lbl_dpi
            // 
            this.lbl_dpi.AutoSize = true;
            this.lbl_dpi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dpi.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpi.Location = new System.Drawing.Point(14, 129);
            this.lbl_dpi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dpi.Name = "lbl_dpi";
            this.lbl_dpi.Size = new System.Drawing.Size(51, 29);
            this.lbl_dpi.TabIndex = 38;
            this.lbl_dpi.Text = "DPI";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(170, 140);
            this.txt_dpi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(126, 20);
            this.txt_dpi.TabIndex = 37;
            this.txt_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpi_KeyPress);
            // 
            // FR_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 447);
            this.Controls.Add(this.pnl_empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FR_EMPLEADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO USUARIO";
            this.Load += new System.EventHandler(this.FR_EMPLEADO_Load);
            this.pnl_empleado.ResumeLayout(false);
            this.pnl_empleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_estadocivil;
        private System.Windows.Forms.ComboBox cbo_estadocivil;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Panel pnl_empleado;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_dpi;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_ingreso;
        private System.Windows.Forms.Label lbl_nacimiento;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.DateTimePicker dtp_fechanacimiento;
        private System.Windows.Forms.Label lbl_guardar;
        private System.Windows.Forms.Label lbl_eliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label lbl_consultar;
        private System.Windows.Forms.DateTimePicker dtp_fechaingreso;
        private System.Windows.Forms.ComboBox cbo_genero;
        private System.Windows.Forms.Label lbl_nuevo;
        private System.Windows.Forms.Button btn_nuevo;
    }
}
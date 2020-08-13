create database if not exists LabClinico;
Use LabClinico;
#---Usuarios-parte1---------------------------------------------
create table if not exists tbl_login(
	pk_id_login 					int,
    usuario_login 					varchar(45),
    contraseña_login 				varchar(45),
    estado_login					int,
    fk_idempleado_login				int,#fk
    fk_idpermiso_login				int
);
create table if not exists tbl_empleado(
	pk_id_empleado 					int,#pk
    nombre_empleado					varchar(20),
    apellido_empleado				varchar(20),
    dpi_empleado					int,
    direccion_empleado				varchar(50),
    nit_empleado					int,
    fechanacimiento_empleado		date,
    fechaingreso_empleado			date,
    telefono_empleado				int,
    correo_empleado					varchar(50),
    genero_empleado					int,#genero
    fk_idestadocivil_empleado		int,#fk estado civil
    estado_empleado					int#estado activo o suspendido.
);
create table if not exists tbl_permiso(
	pk_id_permiso					int,
    tipo_permiso					varchar(25),
    descripcon_permiso				varchar(50)
);
#---bitacora-parte2-------------------------------------------
create table if not exists tbl_bitacora(
	pk_id_bitacora					int, #pk
    fk_iduser_bitacora				int,#fk
    fk_idtipoevent_bitacora			int, #fk
    horaingreso_bitacora			date,
    direchost_bitacora				varchar(20)
);
create table if not exists tbl_tipoevento(
	pk_id_tipoevento				int,#pk
    descripcione_tipoevento			varchar(50)
);
create table if not exists tbl_detallebitacora(
	pk_id_detallebitacora			int,
    fk_idbitacora_detallebitacora	int not null,
    estado_detallebitacora			int not null
);
#---pacientes-doctores-parte3---------------------------------
create table if not exists tbl_paciente(
	pk_id_paciente 					int,#pk
    nombre_paciente					varchar(20),
    apellido_paciente				varchar(20),
    dpi_paciente					int,
    direccion_paciente				varchar(50),
    nit_paciente					int,
    fechanacimiento_paciente		date,
    fechaingreso_paciente			date,
    telefono_paciente				int,
    correo_paciente					varchar(50),
    genero_paciente					int,#genero
    fk_idestadocivil_paciente		int,#fk estado civil
    estado_paciente					int#estado activo o suspendido.
);
create table if not exists tbl_referencia(
	pk_id_referencia				int,
    fk_idpaciente_referencia		int,
    fk_iddoctor_referencia			int
);
create table if not exists tbl_alergia(
	pk_id_alergia					int,
    fk_idpaciente_alergia			int,
    descripcion_alergia				varchar(50)
);
#---muestras-parte4-------------------------------------------
create table if not exists tbl_muestra(
	pk_id_muestra					int,
    fk_idpaciente_muestra			int,
    fechaobtencion_muestra			date,
    descripcion_muestra				varchar(50),
    estado_muestra					int
);
create table if not exists tbl_procesomuestra(
	pk_id_procesomuestra			int,
    fk_idmuestra_procesomuestra		int,
    fk_idexman_procesomuestra		int,
    fk_iddoctor_procesomuestra		int,
    fecha_procesomuestra			date,
    observaciones_procesomuestra	varchar(50)
);
#---factura-pago-parte5----------------------------------------
Create table if not exists tbl_encabezadofactura(
	pk_id_encabezadofactura			int,
    numserie_encabezadofactura		varchar(30),
    numfactura_encabezadofactura	varchar(50),
    nombre_encabezadofactura		varchar(30),
    apellido_encabezadofactura		varchar(30),
    nit_encabezadofactura			int,
    fechaorden_encabezadofactura	datetime,
    total_encabezadofactura			double,
    fk_idtipopago_encabezadofactura	int #fk
);
create table if not exists tbl_detallefactura(
	pk_id_detallefactura			int,
    fk_idencabezado_detallefactura	int,
    fk_idexamen_detallefactura		int,
    subtotal_detallefactura			double
);
create table if not exists tbl_pago(
	pk_id_pago						int,
    tipo_pago						varchar(50)
);
#---doctores-laboratorio-parte6---------------------------------
create table if not exists tbl_doctor(
	pk_id_doctor 					int,#PK
    nombre_doctor					varchar(20),
    apellido_doctor					varchar(20),
    dpi_doctor						int,
    direccion_doctor				varchar(50),
    nit_doctor						int,
    fechanacimiento_doctor			date,
    fechaingreso_doctor				date,
    telefono_doctor					int,
    correo_doctor					varchar(50),
    genero_doctor					int,#genero
    fk_idestadocivil_doctor			int,#fk estado civil
    estado_doctor					int#Estado activo o suspendido.
);
#---laboratorio-parte7------------------------------------------
create table if not exists tbl_laboratorio(
	pk_id_laboratorio				int,
    nombre_laboratorio				varchar(30),
    direccion_laboratorio			varchar(30),
    telefono_laboratorio			varchar(15),
    email_laboratorio				varchar(50),
    estado_laboratorio				int
);
create table if not exists tbl_examen(
	pk_id_examen					int,
    nombre_examen					varchar(30),
    precio_examen					double,
    fk_idtipoexam_examen			int,
    fk_idlaboratorio_examen			int,
    estado_laboratorio				int
);
create table if not exists tbl_tipoexamen(
	pk_id_tipoexamen				int,
    nom_tipoexamen					varchar(35),
    descripcion_tipoexamen			varchar(35),
    estado_laboratorio				int
);
#---tablas adicionales-parte8-----------------------------------
create table if not exists tbl_estadocivil(
	pk_id_estadocivil					int,
    tipo_estadocivil					varchar(15)
);


##-----llavez-primarias---------------------------------------
#---------------llaves-primarias-parte1-----------------------
alter table tbl_login change pk_id_login pk_id_login int auto_increment primary key;
alter table tbl_empleado change pk_id_empleado pk_id_empleado int auto_increment primary key;
alter table tbl_permiso change pk_id_permiso pk_id_permiso int auto_increment primary key;
#---------------llaves-primarias-parte2-----------------------
alter table tbl_bitacora change pk_id_bitacora pk_id_bitacora int auto_increment primary key;
alter table tbl_tipoevento change pk_id_tipoevento pk_id_tipoevento int auto_increment primary key;
alter table tbl_detallebitacora change pk_id_detallebitacora pk_id_detallebitacora int auto_increment primary key;
#---------------llaves-primarias-parte3-----------------------
alter table tbl_paciente change pk_id_paciente pk_id_paciente int auto_increment primary key;
alter table tbl_referencia change pk_id_referencia pk_id_referencia int auto_increment primary key;
alter table tbl_alergia change pk_id_alergia pk_id_alergia int auto_increment primary key;
#---------------llaves-primarias-parte4-----------------------
alter table tbl_muestra change pk_id_muestra pk_id_muestra int auto_increment primary key;
alter table tbl_procesomuestra change pk_id_procesomuestra pk_id_procesomuestra int auto_increment primary key;
#---------------llaves-primarias-parte5-----------------------
alter table tbl_encabezadofactura change pk_id_encabezadofactura pk_id_encabezadofactura int auto_increment primary key;
alter table tbl_detallefactura change pk_id_detallefactura pk_id_detallefactura int auto_increment primary key;
alter table tbl_pago change pk_id_pago pk_id_pago int auto_increment primary key;
#---------------llaves-primarias-parte6-----------------------
alter table tbl_doctor change pk_id_doctor pk_id_doctor int auto_increment primary key;
#---------------llaves-primarias-parte7-----------------------
alter table tbl_examen change pk_id_examen pk_id_examen int auto_increment primary key;
alter table tbl_tipoexamen change pk_id_tipoexamen pk_id_tipoexamen int auto_increment primary key;
alter table tbl_laboratorio change pk_id_laboratorio pk_id_laboratorio int auto_increment primary key;
#---------------llaves-primarias-parte8-----------------------
alter table tbl_estadocivil change pk_id_estadocivil pk_id_estadocivil int auto_increment primary key;

##----llaves-foraneas-----------------------------------------
#--------------llaves-foraneas-parte1-------------------------
alter table tbl_login add constraint fk_per_user foreign key(fk_idempleado_login) references tbl_empleado (pk_id_empleado);
alter table tbl_login add constraint fk_perm_user foreign key(fk_idempleado_login) references tbl_permiso(pk_id_permiso);
alter table tbl_empleado add constraint fk_emp_ecivil foreign key(fk_idestadocivil_empleado) references tbl_estadocivil(pk_id_estadocivil);
#--------------llaves-foraneas-parte2-------------------------
alter table tbl_bitacora add constraint fk_bita_user foreign key(fk_iduser_bitacora) references tbl_login (pk_id_login);
alter table tbl_bitacora add constraint fk_bita_tevnt foreign key(fk_idtipoevent_bitacora) references tbl_tipoevento(pk_id_tipoevento);
alter table tbl_detallebitacora add constraint fk_dbita_bita foreign key(fk_idbitacora_detallebitacora) references tbl_bitacora(pk_id_bitacora);
#--------------llaves-foraneas-parte3-------------------------
alter table tbl_paciente add constraint fk_paci_ecivil foreign key(fk_idestadocivil_paciente) references tbl_estadocivil(pk_id_estadocivil);
alter table tbl_referencia add constraint fk_ref_paci foreign key(fk_idpaciente_referencia) references tbl_paciente(pk_id_paciente);
alter table tbl_referencia add constraint fk_ref_doct foreign key(fk_iddoctor_referencia) references tbl_doctor(pk_id_doctor);
alter table tbl_alergia add constraint fk_aler_paci foreign key(fk_idpaciente_alergia) references tbl_paciente(pk_id_paciente);
#--------------llaves-foraneas-parte4-------------------------
alter table tbl_muestra add constraint fk_mues_paci foreign key(fk_idpaciente_muestra) references tbl_paciente(pk_id_paciente);
alter table tbl_procesomuestra add constraint fk_proc_mues foreign key(fk_idmuestra_procesomuestra) references tbl_muestra(pk_id_muestra);
alter table tbl_procesomuestra add constraint fk_proc_exam foreign key(fk_idexman_procesomuestra) references tbl_examen(pk_id_examen);
alter table tbl_procesomuestra add constraint fk_proc_doc foreign key(fk_iddoctor_procesomuestra) references tbl_doctor(pk_id_doctor);
#--------------llaves-foraneas-parte5-------------------------
alter table tbl_encabezadofactura add constraint fk_efac_tpago foreign key(fk_idtipopago_encabezadofactura) references tbl_pago(pk_id_pago);
alter table tbl_detallefactura add constraint fk_dfac_efac foreign key(fk_idencabezado_detallefactura) references tbl_encabezadofactura(pk_id_encabezadofactura);
alter table tbl_detallefactura add constraint fk_exam_dfac foreign key(fk_idexamen_detallefactura) references tbl_examen(pk_id_examen);
#--------------llaves-foraneas-parte6-------------------------
alter table tbl_doctor add constraint fk_doc_ecivil foreign key(fk_idestadocivil_doctor) references tbl_estadocivil(pk_id_estadocivil);
#--------------llaves-foraneas-parte7-------------------------
alter table tbl_examen add constraint fk_exam_texam foreign key(fk_idtipoexam_examen) references tbl_tipoexamen(pk_id_tipoexamen);
alter table tbl_examen add constraint fk_exam_lab foreign key(fk_idlaboratorio_examen) references tbl_laboratorio(pk_id_laboratorio);




create database if not exists LabClinico;
Use LabClinico;
#--------------------------------------
create table if not exists tbl_login(
	pk_id_login 					int,
    usuario_login 					varchar(45),
    contraseña_login 				varchar(45),
    estado_login					int,
    fk_idpersona_login				int,#fk
    fk_idpermiso_login				int
);
create table if not exists tbl_persona(
	pk_id_persona 					int,#PK
    nombre_persona					varchar(20),
    apellido_persona				varchar(20),
    telefono_persona				int,
    dpi_persona						int,
    direccion_persona				varchar(50),
    email_persona					varchar(50),
    fechanacimiento_persona			date,
    fechaingreso_persona			date,
    genero_persona					int,
    estado_persona					int,
    estadocivil_persona				int,
    alergias						varchar(50),
    tipo_persona					int#1)empleado, 2)doctores, 3)paciente/cliente
);
create table if not exists tbl_permiso(
	pk_id_permiso					int,
    tipo__permiso					varchar(25),
    descripcon_permiso				varchar(50)
);
#------------------llaves primarias-----------------
alter table tbl_login change pk_id_login pk_id_login int auto_increment primary key;
alter table tbl_persona change pk_id_persona pk_id_persona int auto_increment primary key;
alter table tbl_permiso change pk_id_permiso pk_id_permiso int auto_increment primary key;
#-----------------Relaciones------------------------
alter table tbl_login add constraint fk_per_user foreign key(fk_idpersona_login) references tbl_persona (pk_id_persona);
alter table tbl_login add constraint fk_perm_user foreign key(fk_idpermiso_login) references tbl_permiso(pk_id_permiso);
#---Bitacora------------------------
create table if not exists tbl_bitacora(
	pk_id_bitacora					int, #PK
    fk_iduser_bitacora				int,#FK
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
#-------LLaves Primarias---------------
alter table tbl_bitacora change pk_id_bitacora pk_id_bitacora int auto_increment primary key;
alter table tbl_tipoevento change pk_id_tipoevento pk_id_tipoevento int auto_increment primary key;
alter table tbl_detallebitacora change pk_id_detallebitacora pk_id_detallebitacora int auto_increment primary key;

#------Relaciones Llaves Foraneas---------
alter table tbl_bitacora add constraint fk_bita_user foreign key(fk_iduser_bitacora) references tbl_login (pk_id_login);
alter table tbl_bitacora add constraint fk_bita_tevnt foreign key(fk_idtipoevent_bitacora) references tbl_tipoevento(pk_id_tipoevento);
alter table tbl_detallebitacora add constraint fk_dbita_bita foreign key(fk_idbitacora_detallebitacora) references tbl_bitacora(pk_id_bitacora);

#------------------------------------------------------
create table if not exists tbl_referencia(
	pk_id_referencia			int,
    fk_idpersona_referencia		int,
    fk_idrefdoc_referencia		int
);
create table if not exists tbl_refdoc(
	pk_id_refdoc				int,
    fk_idpersona_refdoc			int
);
Create table if not exists tbl_encabezadofactura(
	pk_id_encabezadofactura			int,
    numserie_encabezadofactura		varchar(30),
    numfactura_encabezadofactura	varchar(50),
    fk_idpersona_encabezadofactura	int, #fk
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
create table if not exists tbl_examen(
	pk_id_examen					int,
    nombre_examen					varchar(30),
    precio_examen					double,
    fk_idtipoexam_examen			int,
    fk_idlaboratorio_examen			int
);
create table if not exists tbl_tipoexamen(
	pk_id_tipoexamen				int,
    nom_tipoexamen					varchar(35),
    descripcion_tipoexamen			varchar(35)
);
create table if not exists tbl_laboratorio(
	pk_id_laboratorio				int,
    nombre_laboratorio				varchar(30),
    direccion_laboratorio			varchar(30),
    telefono_laboratorio			varchar(15),
    email_laboratorio				varchar(50)
);

#-----Llavez Primarias-----------------
alter table tbl_refdoc change pk_id_refdoc pk_id_refdoc int auto_increment primary key;
alter table tbl_referencia change pk_id_referencia pk_id_referencia int auto_increment primary key;
alter table tbl_encabezadofactura change pk_id_encabezadofactura pk_id_encabezadofactura int auto_increment primary key;
alter table tbl_detallefactura change pk_id_detallefactura pk_id_detallefactura int auto_increment primary key;
alter table tbl_examen change pk_id_examen pk_id_examen int auto_increment primary key;
alter table tbl_pago change pk_id_pago pk_id_pago int auto_increment primary key;
alter table tbl_tipoexamen change pk_id_tipoexamen pk_id_tipoexamen int auto_increment primary key;
alter table tbl_laboratorio change pk_id_laboratorio pk_id_laboratorio int auto_increment primary key;
#-----Llaves foraneas--------------
alter table tbl_referencia add constraint fk_per_ref foreign key(fk_idpersona_referencia) references tbl_persona(pk_id_persona);
alter table tbl_refdoc add constraint fk_doc_per foreign key(fk_idpersona_refdoc) references tbl_persona(pk_id_persona);
alter table tbl_referencia add constraint fk_pa_ref foreign key(fk_idrefdoc_referencia) references tbl_refdoc(pk_id_refdoc);
alter table tbl_encabezadofactura add constraint fk_enf_paci foreign key (fk_idpersona_encabezadofactura) references tbl_persona (pk_id_persona);
alter table tbl_encabezadofactura add constraint fk_enf_tpag foreign key (fk_idtipopago_encabezadofactura) references tbl_pago (pk_id_pago);
alter table tbl_detallefactura add constraint fk_dfac_efac foreign key (fk_idencabezado_detallefactura) references tbl_encabezadofactura (pk_id_encabezadofactura);
alter table tbl_detallefactura add constraint fk_dfac_exam foreign key (fk_idexamen_detallefactura) references tbl_examen (pk_id_examen);
alter table tbl_examen add constraint fk_exam_texam foreign key(fk_idtipoexam_examen) references tbl_tipoexamen(pk_id_tipoexamen);
alter table tbl_examen add constraint fk_exa_labo foreign key(fk_idlaboratorio_examen) references tbl_laboratorio(pk_id_laboratorio);

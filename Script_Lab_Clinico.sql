create database if not exists LabClinico;
Use LabClinico;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

#---Usuarios-parte1---------------------------------------------
create table if not exists tbl_login(
	pk_id_login 					int,
    usuario_login 					varchar(45),
    contraseña_login 				varchar(45),
    estado_login					int(2),
    fk_idempleado_login				int(9),#fk
    fk_idpermiso_login				int(9)
);
create table if not exists tbl_empleado(
	pk_id_empleado 					int,#pk
    nombre_empleado					varchar(20),
    apellido_empleado				varchar(20),
    dpi_empleado					int(15),
    direccion_empleado				varchar(50),
    nit_empleado					int(15),
    fechanacimiento_empleado		date,
    fechaingreso_empleado			date,
    telefono_empleado				int(9),
    correo_empleado					varchar(50),
    genero_empleado					int(2),#genero
    fk_idestadocivil_empleado		int(9),#fk estado civil
    estado_empleado					int(2)#estado activo o suspendido.
);
create table if not exists tbl_permiso(
	pk_id_permiso					int,
    tipo_permiso					varchar(25),
    descripcon_permiso				varchar(50)
);
#---bitacora-parte2-------------------------------------------
create table if not exists tbl_bitacora(
	pk_id_bitacora					int, #pk
    fk_iduser_bitacora				int(9),#fk
    fk_idtipoevent_bitacora			int(9), #fk
    horaingreso_bitacora			varchar(50),
    direchost_bitacora				varchar(20),
    detalle_bitacora				varchar(50)
);
create table if not exists tbl_tipoevento(
	pk_id_tipoevento				int,#pk
    descripcione_tipoevento			varchar(50)
);
#---pacientes-doctores-parte3---------------------------------
create table if not exists tbl_paciente(
	pk_id_paciente 					int,#pk
    nombre_paciente					varchar(20),
    apellido_paciente				varchar(20),
    dpi_paciente					int(15),
    direccion_paciente				varchar(50),
    nit_paciente					int(15),
    fechanacimiento_paciente		date,
    fechaingreso_paciente			date,
    telefono_paciente				int(9),
    correo_paciente					varchar(50),
    genero_paciente					int(2),#genero
    fk_idestadocivil_paciente		int(9),#fk estado civil
    estado_paciente					int(2)#estado activo o suspendido.
);
create table if not exists tbl_referencia(
	pk_id_referencia				int,
    fk_idpaciente_referencia		int(9),
    fk_iddoctor_referencia			int(9)
);
create table if not exists tbl_alergia(
	pk_id_alergia					int,
    fk_idpaciente_alergia			int(9),
    descripcion_alergia				varchar(50)
);
#---muestras-parte4-------------------------------------------
create table if not exists tbl_muestra(
	pk_id_muestra					int,
    fk_idpaciente_muestra			int(9),
    fechaobtencion_muestra			date,
    descripcion_muestra				varchar(50),
    estado_muestra					int(2)
);
create table if not exists tbl_procesomuestra(
	pk_id_procesomuestra			int,
    fk_idmuestra_procesomuestra		int(9),
    fk_idexman_procesomuestra		int(9),
    fk_iddoctor_procesomuestra		int(9),
    fecha_procesomuestra			date,
    observaciones_procesomuestra	varchar(50)
);
#---factura-pago-parte5----------------------------------------
Create table if not exists tbl_encabezadofactura(
	pk_id_encabezadofactura			int,
    numserie_encabezadofactura		varchar(30),
    nombre_encabezadofactura		varchar(30),
    apellido_encabezadofactura		varchar(30),
    nit_encabezadofactura			int(15),
    fechaorden_encabezadofactura	datetime,
    total_encabezadofactura			double,
    fk_idtipopago_encabezadofactura	int(9) #fk
);
create table if not exists tbl_detallefactura(
	pk_id_detallefactura			int,
    fk_idencabezado_detallefactura	int(9),
    fk_idexamen_detallefactura		int(9),
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
    dpi_doctor						int(15),
    direccion_doctor				varchar(50),
    nit_doctor						int(15),
    fechanacimiento_doctor			date,
    fechaingreso_doctor				date,
    telefono_doctor					int(9),
    correo_doctor					varchar(50),
    genero_doctor					int(2),#genero
    fk_idestadocivil_doctor			int(9),#fk estado civil
    estado_doctor					int(2)#Estado activo o suspendido.
);
#---laboratorio-parte7------------------------------------------
create table if not exists tbl_laboratorio(
	pk_id_laboratorio				int,
    nombre_laboratorio				varchar(30),
    direccion_laboratorio			varchar(30),
    telefono_laboratorio			varchar(15),
    email_laboratorio				varchar(50),
    estado_laboratorio				int(2)
);
create table if not exists tbl_examen(
	pk_id_examen					int,
    nombre_examen					varchar(30),
    precio_examen					double,
    fk_idtipoexam_examen			int(9),
    fk_idlaboratorio_examen			int(9),
    estado_laboratorio				int(2)
);
create table if not exists tbl_tipoexamen(
	pk_id_tipoexamen				int,
    nom_tipoexamen					varchar(35),
    descripcion_tipoexamen			varchar(35),
    estado_laboratorio				int(2)
);
#---tablas adicionales-parte8-----------------------------------
create table if not exists tbl_estadocivil(
	pk_id_estadocivil					int,
    tipo_estadocivil					varchar(15)
);


##-----llavez-primarias---------------------------------------
#---------------llaves-primarias-parte1-----------------------
alter table tbl_login change pk_id_login pk_id_login int(9) auto_increment primary key;
alter table tbl_empleado change pk_id_empleado pk_id_empleado int(9) auto_increment primary key;
alter table tbl_permiso change pk_id_permiso pk_id_permiso int(9) auto_increment primary key;
#---------------llaves-primarias-parte2-----------------------
alter table tbl_bitacora change pk_id_bitacora pk_id_bitacora int(9) auto_increment primary key;
alter table tbl_tipoevento change pk_id_tipoevento pk_id_tipoevento int(9) auto_increment primary key;
#---------------llaves-primarias-parte3-----------------------
alter table tbl_paciente change pk_id_paciente pk_id_paciente int(9) auto_increment primary key;
alter table tbl_referencia change pk_id_referencia pk_id_referencia int(9) auto_increment primary key;
alter table tbl_alergia change pk_id_alergia pk_id_alergia int(9) auto_increment primary key;
#---------------llaves-primarias-parte4-----------------------
alter table tbl_muestra change pk_id_muestra pk_id_muestra int(9) auto_increment primary key;
alter table tbl_procesomuestra change pk_id_procesomuestra pk_id_procesomuestra int(9) auto_increment primary key;
#---------------llaves-primarias-parte5-----------------------
alter table tbl_encabezadofactura change pk_id_encabezadofactura pk_id_encabezadofactura int(9) auto_increment primary key;
alter table tbl_detallefactura change pk_id_detallefactura pk_id_detallefactura int(9) auto_increment primary key;
alter table tbl_pago change pk_id_pago pk_id_pago int(9) auto_increment primary key;
#---------------llaves-primarias-parte6-----------------------
alter table tbl_doctor change pk_id_doctor pk_id_doctor int(9) auto_increment primary key;
#---------------llaves-primarias-parte7-----------------------
alter table tbl_examen change pk_id_examen pk_id_examen int(9) auto_increment primary key;
alter table tbl_tipoexamen change pk_id_tipoexamen pk_id_tipoexamen int(9) auto_increment primary key;
alter table tbl_laboratorio change pk_id_laboratorio pk_id_laboratorio int(9) auto_increment primary key;
#---------------llaves-primarias-parte8-----------------------
alter table tbl_estadocivil change pk_id_estadocivil pk_id_estadocivil int(9) auto_increment primary key;

##----llaves-foraneas-----------------------------------------
#--------------llaves-foraneas-parte1-------------------------
alter table tbl_login add constraint fk_per_user foreign key(fk_idempleado_login) references tbl_empleado (pk_id_empleado);
alter table tbl_login add constraint fk_perm_user foreign key(fk_idpermiso_login) references tbl_permiso(pk_id_permiso);
alter table tbl_empleado add constraint fk_emp_ecivil foreign key(fk_idestadocivil_empleado) references tbl_estadocivil(pk_id_estadocivil);
#--------------llaves-foraneas-parte2-------------------------
alter table tbl_bitacora add constraint fk_bita_user foreign key(fk_iduser_bitacora) references tbl_login (pk_id_login);
alter table tbl_bitacora add constraint fk_bita_tevnt foreign key(fk_idtipoevent_bitacora) references tbl_tipoevento(pk_id_tipoevento);
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

#--------------Inserts----------------------------------------
#--------------Inserts-Tipo-De-Evento-------------------------
INSERT INTO `labclinico`.`tbl_tipoevento` (`pk_id_tipoevento`, `descripcione_tipoevento`) VALUES
(1, 'Login'),
(2, 'Click Paciente'),
(3, 'Click Reportes'),
(4, 'Click Facturacion'),
(5, 'Click Personal'),
(6, 'Click Examenes'),
(7, 'Click Etiqueta'),
(8, 'Click Ingre Doctor'),
(9, 'Click Salir'),
(10, 'Nuevo Paciente'),
(11, 'Guardar Paciente'),
(12, 'Modificar Paciente'),
(13, 'Eliminar Paciente'),
(14, 'Grabar'),
(15, 'Error Grabar'),
(16, 'Modificar'),
(17, 'Eliminar'),
(18, 'Error Modificar'),
(19, 'Eliminar'),
(20, 'Error Eliminar'),
(21, 'Consulta'),
(22, 'Error Consulta'),
(23, 'Etiqueta'),
(24, 'Buscar'),
(25, 'Imprimir');
#--------------Inserts-Estado-Civil----------------------------
INSERT INTO `labclinico`.`tbl_estadocivil` (`pk_id_estadocivil`, `tipo_estadocivil`) VALUES ('1', 'Soltero');
INSERT INTO `labclinico`.`tbl_estadocivil` (`pk_id_estadocivil`, `tipo_estadocivil`) VALUES ('2', 'Casado');
INSERT INTO `labclinico`.`tbl_estadocivil` (`pk_id_estadocivil`, `tipo_estadocivil`) VALUES ('3', 'Divorciado@');
INSERT INTO `labclinico`.`tbl_estadocivil` (`pk_id_estadocivil`, `tipo_estadocivil`) VALUES ('4', 'Viud@');

#--------------Inserts-Doctores-------------------------------
INSERT INTO `labclinico`.`tbl_doctor` (`pk_id_doctor`, `nombre_doctor`, `apellido_doctor`, `dpi_doctor`, `direccion_doctor`, `nit_doctor`, `fechanacimiento_doctor`, `fechaingreso_doctor`, `telefono_doctor`, `correo_doctor`, `genero_doctor`, `fk_idestadocivil_doctor`, `estado_doctor`) VALUES (1, 'Billy ', 'Sican', 300694437, '7ma Avenida Zona 7', 1234567, '1999-03-02', '2020-08-15', 54689270, 'bjsican@gmail.com', 1, 2, 1);
INSERT INTO `labclinico`.`tbl_doctor` (`pk_id_doctor`, `nombre_doctor`, `apellido_doctor`, `dpi_doctor`, `direccion_doctor`, `nit_doctor`, `fechanacimiento_doctor`, `fechaingreso_doctor`, `telefono_doctor`, `correo_doctor`, `genero_doctor`, `fk_idestadocivil_doctor`, `estado_doctor`) VALUES ('2', 'Julio', 'Morataya', '12345678', 'Zona 8', '1234589', '1998-05-25', '2020-08-15', '12236578', 'jmorataya@gmail.com', '1', '1', '1');
INSERT INTO `labclinico`.`tbl_doctor` (`pk_id_doctor`, `nombre_doctor`, `apellido_doctor`, `dpi_doctor`, `direccion_doctor`, `nit_doctor`, `fechanacimiento_doctor`, `fechaingreso_doctor`, `telefono_doctor`, `correo_doctor`, `genero_doctor`, `fk_idestadocivil_doctor`, `estado_doctor`) VALUES ('3', 'Bryan ', 'Mazariegos', '56897812', 'Zona 18', '2356894', '1998-06-25', '2020-08-15', '12356897', 'bmazariegos@gmail.com', '1', '3', '1');

#--------------Inserts-Empleado-------------------------------
INSERT INTO `labclinico`.`tbl_empleado` (`pk_id_empleado`, `nombre_empleado`, `apellido_empleado`, `dpi_empleado`, `direccion_empleado`, `nit_empleado`, `fechanacimiento_empleado`, `fechaingreso_empleado`, `telefono_empleado`, `correo_empleado`, `genero_empleado`, `fk_idestadocivil_empleado`, `estado_empleado`) VALUES
(1, 'Bryan', 'Mazariegos', 1222344, 'kwejflksdjfkjsdkfheow', 3241982, '1998-11-13', '2020-08-18', 12345678, 'bryanesturd3@gmail.com', 1, 1, 1),
(2, 'Billy', 'Sican', 300694437, '7ma Avenida Zona 7', 1234567, '1999-03-02', '2020-08-15', 54689270, 'bjsican@gmail.com', 1, 2, 1),
(3, 'Julio', 'Morataya', 300694475, '8va Calle Zona 7', 1234567, '1998-07-25', '2020-08-15', 69874512, 'jmorataya@gmail.com', 1, 3, 1),
(4, 'Brian', 'Santizo', 300765925, '9na Calle Zona 18', 2356478, '1998-06-25', '2020-08-15', 23568945, 'bsantizo@gmail.com', 1, 4, 1),
(5, 'Bryan ', 'Mazariegos', 300789562, '5Av zona 18 ', 2345789, '1998-07-26', '2000-08-15', 56892321, 'bmazariegos@gmail.com', 1, 1, 1),
(6, 'Jeshua ', 'Matias', 300694523, '7ma Calle Zona 7', 5468925, '1999-03-02', '2020-08-15', 54689250, 'bjsicanm2@gmail.com', 1, 1, 1),
(7, 'Bryanmm', 'Mazariegosmm', 12231, 'wdsad', 23, '1998-07-26', '2000-08-18', 12321332, 'dshgd', 1, 1, 0),
(8, 'prueba', 'mprue', 1123321, '123sfd', 234565, '2000-02-11', '2020-08-18', 23454355, 'brye3@gmail.com', 1, 3, 1);
#--------------Inserts-Laboratorio----------------------------
INSERT INTO `labclinico`.`tbl_laboratorio` (`pk_id_laboratorio`, `nombre_laboratorio`, `direccion_laboratorio`, `telefono_laboratorio`, `email_laboratorio`, `estado_laboratorio`) VALUES (1, 'San Juan de Dios', '8va Calle Zona 1', '5689235', 'sjdios@gmail.com', 1);
INSERT INTO `labclinico`.`tbl_laboratorio` (`pk_id_laboratorio`, `nombre_laboratorio`, `direccion_laboratorio`, `telefono_laboratorio`, `email_laboratorio`, `estado_laboratorio`) VALUES ('2', 'Centro medico ', '9na calle zona 7', '1232654', 'cmedico@gmail.com', '1');

#--------------Inserts-Permiso---------------------------------
INSERT INTO `labclinico`.`tbl_permiso` (`pk_id_permiso`, `tipo_permiso`, `descripcon_permiso`) VALUES
(1, 'Admin', 'Administrador'),
(2, 'User', 'Usuario');
#--------------Inserts-Login----------------------------------
INSERT INTO `labclinico`.`tbl_login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `estado_login`, `fk_idempleado_login`, `fk_idpermiso_login`) VALUES
(1, 'bjsican', 'bjsican', 1, 1, 1),
(2, 'jmorataya', 'morataya', 1, 2, 2),
(3, 'Bryan', '131198', 1, 1, 1);
#--------------Inserts-Paciente-------------------------------
INSERT INTO `labclinico`.`tbl_paciente` (`pk_id_paciente`, `nombre_paciente`, `apellido_paciente`, `dpi_paciente`, `direccion_paciente`, `nit_paciente`, `fechanacimiento_paciente`, `fechaingreso_paciente`, `telefono_paciente`, `correo_paciente`, `genero_paciente`, `fk_idestadocivil_paciente`, `estado_paciente`) VALUES
(1, 'bryan', 'Mazariegos', 1311223, 'sjahdakjhdah', 1234567, '1998-11-13', '2020-08-18', 12345678, 'bryanqgnailcom', 1, 1, 1),
(2, 'bryan', 'mazariegos', 123123, '123fsdfd', 12314325, '1998-11-13', '2020-08-18', 243, '2133sdf', 1, 2, 0);
INSERT INTO `labclinico`.`tbl_paciente` (`pk_id_paciente`, `nombre_paciente`, `apellido_paciente`, `dpi_paciente`, `direccion_paciente`, `nit_paciente`, `fechanacimiento_paciente`, `fechaingreso_paciente`, `telefono_paciente`, `correo_paciente`, `genero_paciente`, `fk_idestadocivil_paciente`, `estado_paciente`) VALUES ('3', 'Billy ', 'Sican', '1234565', 'zona 7', '12345678', '1999-02-03', '2020-08-20', '54689270', 'bjsican@gmail.com', '1', '1', '1');
INSERT INTO `labclinico`.`tbl_paciente` (`pk_id_paciente`, `nombre_paciente`, `apellido_paciente`, `dpi_paciente`, `direccion_paciente`, `nit_paciente`, `fechanacimiento_paciente`, `fechaingreso_paciente`, `telefono_paciente`, `correo_paciente`, `genero_paciente`, `fk_idestadocivil_paciente`, `estado_paciente`) VALUES ('4', 'Julio ', 'Morataya', '235689', 'Zona 8', '78982562', '1998-05-26', '2020-08-20', '56897841', 'jmorataya@gmail.com', '1', '1', '1');

#--------------Inserts-Pago-----------------------------------
INSERT INTO `labclinico`.`tbl_pago` (`pk_id_pago`, `tipo_pago`) VALUES
(1, 'Efectivo'),
(2, 'Cheque'),
(3, 'Deposito'),
(4, 'Seguro');
#--------------Inserts-Doctores-------------------------------
INSERT INTO `labclinico`.`tbl_bitacora` (`pk_id_bitacora`, `fk_iduser_bitacora`, `fk_idtipoevent_bitacora`, `horaingreso_bitacora`, `direchost_bitacora`, `detalle_bitacora`) VALUES
(1, 1, 1, '15:49:39 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(2, 3, 9, '15:49:53 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(3, 3, 1, '15:50:11 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(4, 3, 2, '15:50:17 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(5, 3, 10, '15:50:20 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(6, 3, 15, '15:52:29 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(7, 3, 11, '15:52:29 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente 1'),
(8, 3, 14, '15:52:36 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(9, 3, 21, '15:52:37 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(10, 3, 21, '15:52:39 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(11, 3, 21, '15:52:41 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(12, 3, 21, '15:52:41 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(13, 3, 21, '15:52:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(14, 3, 21, '15:52:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(15, 3, 21, '15:52:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(16, 3, 14, '15:52:51 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(17, 3, 21, '15:52:51 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(18, 3, 14, '15:52:54 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(19, 3, 21, '15:52:55 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(20, 3, 5, '15:53:08 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(21, 3, 21, '15:53:08 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(22, 3, 17, '15:53:58 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(23, 3, 21, '15:54:01 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryan  5'),
(24, 3, 18, '15:54:43 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(25, 3, 5, '16:01:14 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryan  5'),
(26, 3, 5, '16:01:16 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(27, 3, 15, '16:03:28 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(28, 3, 8, '16:03:47 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado 7'),
(29, 3, 5, '16:03:50 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(30, 3, 21, '16:03:51 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(31, 3, 19, '16:04:20 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(32, 3, 17, '16:04:48 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(33, 3, 21, '16:04:51 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryanmm 7'),
(34, 3, 19, '16:04:57 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(35, 3, 8, '16:06:38 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(36, 3, 21, '16:06:40 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(37, 3, 5, '16:06:44 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_doctor'),
(38, 3, 21, '16:06:46 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(39, 3, 21, '16:07:00 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(40, 3, 19, '16:07:15 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(41, 3, 17, '16:07:39 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(42, 3, 21, '16:07:40 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryanmm 7'),
(43, 3, 21, '16:07:44 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(44, 3, 19, '16:07:50 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(45, 3, 9, '16:09:12 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(46, 3, 1, '16:18:21 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(47, 3, 5, '16:18:27 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(48, 3, 21, '16:18:29 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(49, 3, 17, '16:18:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(50, 3, 21, '16:18:43 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryanmm 7'),
(51, 3, 19, '16:18:49 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(52, 3, 9, '16:20:57 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(53, 3, 1, '16:29:26 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(54, 3, 2, '16:29:32 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(55, 3, 14, '16:29:34 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(56, 3, 21, '16:29:34 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(57, 3, 14, '16:29:43 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(58, 3, 21, '16:29:44 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(59, 3, 10, '16:29:49 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(60, 3, 15, '16:31:07 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(61, 3, 11, '16:31:07 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente 2'),
(62, 3, 14, '16:31:13 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(63, 3, 21, '16:31:13 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(64, 3, 13, '16:31:19 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(65, 3, 19, '16:31:20 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(66, 3, 21, '16:32:29 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(67, 3, 12, '16:32:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(68, 3, 17, '16:32:44 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(69, 3, 14, '16:32:44 martes, 18 de agosto de 2020', '10.3.0.1', 'bryan 2'),
(70, 3, 21, '16:32:44 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(71, 3, 13, '16:32:58 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(72, 3, 19, '16:33:02 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(73, 3, 21, '16:33:29 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(74, 3, 9, '16:33:33 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(75, 3, 1, '16:56:08 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(76, 3, 2, '16:56:12 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(77, 3, 14, '16:56:13 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(78, 3, 21, '16:56:14 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(79, 3, 13, '16:56:18 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(80, 3, 19, '16:56:19 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(81, 3, 21, '16:59:26 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(82, 3, 12, '16:59:35 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(83, 3, 17, '16:59:36 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(84, 3, 14, '16:59:38 martes, 18 de agosto de 2020', '10.3.0.1', 'bryan 2'),
(85, 3, 21, '16:59:38 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(86, 3, 2, '17:01:31 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(87, 3, 2, '17:01:33 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(88, 3, 14, '17:01:35 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(89, 3, 21, '17:01:35 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(90, 3, 13, '17:01:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(91, 3, 19, '17:01:43 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(92, 3, 21, '17:02:29 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(93, 3, 5, '17:02:36 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(94, 3, 21, '17:02:38 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(95, 3, 17, '17:02:51 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(96, 3, 21, '17:02:53 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryanmm 7'),
(97, 3, 19, '17:02:58 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(98, 3, 9, '17:03:41 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(99, 3, 1, '17:06:58 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(100, 3, 5, '17:07:01 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(101, 3, 21, '17:07:02 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(102, 3, 17, '17:07:09 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(103, 3, 21, '17:07:11 martes, 18 de agosto de 2020', '10.3.0.1', 'Bryanmm 7'),
(104, 3, 19, '17:07:16 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(105, 3, 9, '17:07:28 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(106, 3, 1, '17:13:05 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(107, 3, 2, '17:13:09 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(108, 3, 10, '17:13:11 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(109, 3, 9, '17:13:46 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(110, 3, 1, '17:28:18 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(111, 3, 2, '17:29:03 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(112, 3, 14, '17:29:04 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(113, 3, 21, '17:29:04 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(114, 3, 12, '17:29:09 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(115, 3, 17, '17:29:10 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(116, 3, 14, '17:29:36 martes, 18 de agosto de 2020', '10.3.0.1', 'bryan 2'),
(117, 3, 21, '17:29:36 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(118, 3, 13, '17:29:39 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(119, 3, 19, '17:29:40 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(120, 3, 21, '17:31:34 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(121, 3, 9, '17:33:44 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(122, 3, 1, '17:35:08 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(123, 3, 9, '17:35:13 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(124, 3, 1, '17:36:39 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(125, 3, 2, '17:36:58 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(126, 3, 14, '17:37:01 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(127, 3, 21, '17:37:02 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(128, 3, 12, '17:37:18 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(129, 3, 17, '17:37:23 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(130, 3, 14, '17:37:26 martes, 18 de agosto de 2020', '10.3.0.1', 'bryan 2'),
(131, 3, 21, '17:37:32 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(132, 3, 13, '17:37:42 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(133, 3, 19, '17:37:44 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(134, 3, 21, '17:38:25 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(135, 3, 9, '17:38:28 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(136, 3, 1, '18:18:05 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(137, 3, 2, '18:18:13 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(138, 3, 14, '18:18:18 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(139, 3, 21, '18:18:20 martes, 18 de agosto de 2020', '10.3.0.1', 'consulta tabla: tbl_paciente'),
(140, 3, 12, '18:18:38 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(141, 3, 17, '18:18:43 martes, 18 de agosto de 2020', '10.3.0.1', 'Modificacion en tbl_paciente al codigo 2'),
(142, 3, 14, '18:18:50 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(143, 3, 21, '18:18:52 martes, 18 de agosto de 2020', '10.3.0.1', 'consulta tabla: tbl_paciente'),
(144, 3, 13, '18:19:00 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(145, 3, 19, '18:19:03 martes, 18 de agosto de 2020', '10.3.0.1', 'Eliminar en tbl_paciente al codigo2'),
(146, 3, 14, '18:19:05 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(147, 3, 21, '18:19:07 martes, 18 de agosto de 2020', '10.3.0.1', 'consulta tabla: tbl_paciente'),
(148, 3, 9, '18:19:14 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_paciente'),
(149, 3, 1, '18:54:27 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(150, 3, 2, '18:54:32 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(151, 3, 9, '18:54:39 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(152, 3, 1, '19:02:13 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(153, 3, 2, '19:02:16 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(154, 3, 9, '19:02:27 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(155, 3, 1, '19:09:00 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(156, 3, 2, '19:09:03 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(157, 3, 9, '19:09:08 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(158, 2, 1, '19:09:38 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(159, 2, 2, '19:09:59 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(160, 2, 9, '19:10:41 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(161, 3, 1, '19:13:44 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(162, 3, 5, '19:13:47 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(163, 3, 10, '19:13:57 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(164, 3, 11, '19:15:26 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(165, 3, 15, '19:15:28 martes, 18 de agosto de 2020', '10.3.0.1', 'Insercion en tbl_empleado al codigo8'),
(166, 3, 14, '19:15:33 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado 8'),
(167, 3, 21, '19:15:33 martes, 18 de agosto de 2020', '10.3.0.1', 'consulta tabla: tbl_empleado'),
(168, 3, 12, '19:15:52 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(169, 3, 17, '19:15:55 martes, 18 de agosto de 2020', '10.3.0.1', 'Modificacion en tbl_empleado al codigo 8'),
(170, 3, 14, '19:16:00 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(171, 3, 21, '19:16:00 martes, 18 de agosto de 2020', '10.3.0.1', 'consulta tabla: tbl_empleado'),
(172, 3, 13, '19:16:18 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(173, 3, 19, '19:16:20 martes, 18 de agosto de 2020', '10.3.0.1', 'Eliminar en tbl_empleado al codigo8'),
(174, 3, 14, '19:16:22 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(175, 3, 21, '19:16:22 martes, 18 de agosto de 2020', '10.3.0.1', 'consulta tabla: tbl_empleado'),
(176, 3, 12, '19:17:05 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado'),
(177, 3, 17, '19:17:07 martes, 18 de agosto de 2020', '10.3.0.1', 'Modificacion en tbl_empleado al codigo 8'),
(178, 3, 10, '19:17:10 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(179, 3, 11, '19:17:12 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(180, 3, 16, '19:17:16 martes, 18 de agosto de 2020', '10.3.0.1', 'Error al insertar en tbl_empleado al codigo9'),
(181, 3, 10, '19:17:35 martes, 18 de agosto de 2020', '10.3.0.1', 'tbl_empleado 9'),
(182, 3, 8, '19:17:59 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(183, 3, 9, '19:18:13 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(184, 2, 1, '19:35:48 martes, 18 de agosto de 2020', '10.3.0.1', ''),
(185, 2, 2, '19:35:57 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(186, 2, 3, '19:35:59 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(187, 2, 4, '19:36:01 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(188, 2, 6, '19:36:10 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(189, 2, 7, '19:36:11 martes, 18 de agosto de 2020', '10.3.0.1', ' '),
(190, 2, 9, '19:36:21 martes, 18 de agosto de 2020', '10.3.0.1', ' ');


INSERT INTO `labclinico`.`tbl_encabezadofactura` (`pk_id_encabezadofactura`, `numserie_encabezadofactura`, `nombre_encabezadofactura`, `apellido_encabezadofactura`, `nit_encabezadofactura`, `fechaorden_encabezadofactura`, `total_encabezadofactura`, `fk_idtipopago_encabezadofactura`) VALUES ('1', 'A', 'Pedro', 'Lopez', '123456', '2020-05-05', '2500', '1');
INSERT INTO `labclinico`.`tbl_encabezadofactura` (`pk_id_encabezadofactura`, `numserie_encabezadofactura`, `nombre_encabezadofactura`, `apellido_encabezadofactura`, `nit_encabezadofactura`, `fechaorden_encabezadofactura`, `total_encabezadofactura`, `fk_idtipopago_encabezadofactura`) VALUES ('2', 'A', 'Jose', 'Jimenez', '321654', '2020-05-05', '4500', '1');
INSERT INTO `labclinico`.`tbl_encabezadofactura` (`pk_id_encabezadofactura`, `numserie_encabezadofactura`, `nombre_encabezadofactura`, `apellido_encabezadofactura`, `nit_encabezadofactura`, `fechaorden_encabezadofactura`, `total_encabezadofactura`, `fk_idtipopago_encabezadofactura`) VALUES ('3', 'A', 'Andres', 'Ramirez', '741852', '2020-05-06', '2800', '2');
INSERT INTO `labclinico`.`tbl_encabezadofactura` (`pk_id_encabezadofactura`, `numserie_encabezadofactura`, `nombre_encabezadofactura`, `apellido_encabezadofactura`, `nit_encabezadofactura`, `fechaorden_encabezadofactura`, `total_encabezadofactura`, `fk_idtipopago_encabezadofactura`) VALUES ('4', 'A', 'Luis', 'Perez', '963822', '2020-05-10', '5000', '2');
INSERT INTO `labclinico`.`tbl_encabezadofactura` (`pk_id_encabezadofactura`, `numserie_encabezadofactura`, `nombre_encabezadofactura`, `apellido_encabezadofactura`, `nit_encabezadofactura`, `fechaorden_encabezadofactura`, `total_encabezadofactura`, `fk_idtipopago_encabezadofactura`) VALUES ('5', 'A', 'Ignasio', 'Sosa', '369852', '2020-05-10', '200', '1');
INSERT INTO `labclinico`.`tbl_encabezadofactura` (`pk_id_encabezadofactura`, `numserie_encabezadofactura`, `nombre_encabezadofactura`, `apellido_encabezadofactura`, `nit_encabezadofactura`, `fechaorden_encabezadofactura`, `total_encabezadofactura`, `fk_idtipopago_encabezadofactura`) VALUES ('6', 'A', 'Laura', 'Lopez', '574598', '2020-06-7', '100', '1');

INSERT INTO `labclinico`.`tbl_tipoexamen` (`pk_id_tipoexamen`, `nom_tipoexamen`, `descripcion_tipoexamen`, `estado_laboratorio`) VALUES ('1', 'Examen1', 'Descripcion1', '1');
INSERT INTO `labclinico`.`tbl_tipoexamen` (`pk_id_tipoexamen`, `nom_tipoexamen`, `descripcion_tipoexamen`, `estado_laboratorio`) VALUES ('2', 'Examen2', 'Descripcion2', '1');
INSERT INTO `labclinico`.`tbl_tipoexamen` (`pk_id_tipoexamen`, `nom_tipoexamen`, `descripcion_tipoexamen`, `estado_laboratorio`) VALUES ('3', 'Examen3', 'Descripcion3', '1');
INSERT INTO `labclinico`.`tbl_tipoexamen` (`pk_id_tipoexamen`, `nom_tipoexamen`, `descripcion_tipoexamen`, `estado_laboratorio`) VALUES ('4', 'Examen4', 'Descripcion4', '1');

INSERT INTO `labclinico`.`tbl_examen` (`pk_id_examen`, `nombre_examen`, `precio_examen`, `fk_idtipoexam_examen`, `fk_idlaboratorio_examen`, `estado_laboratorio`) VALUES ('1', 'Examen1', '100', '1', '1', '1');
INSERT INTO `labclinico`.`tbl_examen` (`pk_id_examen`, `nombre_examen`, `precio_examen`, `fk_idtipoexam_examen`, `fk_idlaboratorio_examen`, `estado_laboratorio`) VALUES ('2', 'Examen2', '200', '2', '1', '1');
INSERT INTO `labclinico`.`tbl_examen` (`pk_id_examen`, `nombre_examen`, `precio_examen`, `fk_idtipoexam_examen`, `fk_idlaboratorio_examen`, `estado_laboratorio`) VALUES ('3', 'Examen3', '300', '3', '1', '1');

INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('1', '0001', '1', '1000');
INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('2', '0001', '2', '1500');
INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('3', '0002', '1', '4500');
INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('4', '0003', '3', '2800');
INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('5', '0004', '3', '5000');
INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('6', '0005', '1', '200');
INSERT INTO `labclinico`.`tbl_detallefactura` (`pk_id_detallefactura`, `fk_idencabezado_detallefactura`, `fk_idexamen_detallefactura`, `subtotal_detallefactura`) VALUES ('7', '0006', '3', '100');

INSERT INTO `labclinico`.`tbl_alergia` (`pk_id_alergia`, `fk_idpaciente_alergia`, `descripcion_alergia`) VALUES ('1', '1', 'Alergia al polvo');
INSERT INTO `labclinico`.`tbl_alergia` (`pk_id_alergia`, `fk_idpaciente_alergia`, `descripcion_alergia`) VALUES ('2', '1', 'Alergia al polen');
INSERT INTO `labclinico`.`tbl_alergia` (`pk_id_alergia`, `fk_idpaciente_alergia`, `descripcion_alergia`) VALUES ('3', '1', 'Alergio a los gatos');
INSERT INTO `labclinico`.`tbl_alergia` (`pk_id_alergia`, `fk_idpaciente_alergia`, `descripcion_alergia`) VALUES ('4', '2', 'Alergia a las flores');

INSERT INTO `labclinico`.`tbl_muestra` (`pk_id_muestra`, `fk_idpaciente_muestra`, `fechaobtencion_muestra`, `descripcion_muestra`, `estado_muestra`) VALUES ('1', '1', '2020-08-20', 'Muestra de sangre', '1');
INSERT INTO `labclinico`.`tbl_muestra` (`pk_id_muestra`, `fk_idpaciente_muestra`, `fechaobtencion_muestra`, `descripcion_muestra`, `estado_muestra`) VALUES ('2', '2', '2020-08-20', 'Muestra de orina', '1');
INSERT INTO `labclinico`.`tbl_muestra` (`pk_id_muestra`, `fk_idpaciente_muestra`, `fechaobtencion_muestra`, `descripcion_muestra`, `estado_muestra`) VALUES ('3', '2', '2020-08-20', 'Muestra de sangre', '1');

INSERT INTO `labclinico`.`tbl_procesomuestra` (`pk_id_procesomuestra`, `fk_idmuestra_procesomuestra`, `fk_idexman_procesomuestra`, `fk_iddoctor_procesomuestra`, `fecha_procesomuestra`, `observaciones_procesomuestra`) VALUES ('1', '1', '1', '1', '2020-08-20', 'color de sangre no es correcto');
INSERT INTO `labclinico`.`tbl_procesomuestra` (`pk_id_procesomuestra`, `fk_idmuestra_procesomuestra`, `fk_idexman_procesomuestra`, `fk_iddoctor_procesomuestra`, `fecha_procesomuestra`, `observaciones_procesomuestra`) VALUES ('2', '1', '2', '1', '2020-08-20', 'celulas muertas');
INSERT INTO `labclinico`.`tbl_procesomuestra` (`pk_id_procesomuestra`, `fk_idmuestra_procesomuestra`, `fk_idexman_procesomuestra`, `fk_iddoctor_procesomuestra`, `fecha_procesomuestra`, `observaciones_procesomuestra`) VALUES ('3', '2', '1', '2', '2020-08-20', 'Celulas encontradas');

INSERT INTO `labclinico`.`tbl_referencia` (`pk_id_referencia`, `fk_idpaciente_referencia`, `fk_iddoctor_referencia`) VALUES ('1', '1', '2');
INSERT INTO `labclinico`.`tbl_referencia` (`pk_id_referencia`, `fk_idpaciente_referencia`, `fk_iddoctor_referencia`) VALUES ('2', '2', '1');
INSERT INTO `labclinico`.`tbl_referencia` (`pk_id_referencia`, `fk_idpaciente_referencia`, `fk_iddoctor_referencia`) VALUES ('3', '1', '3');
INSERT INTO `labclinico`.`tbl_referencia` (`pk_id_referencia`, `fk_idpaciente_referencia`, `fk_iddoctor_referencia`) VALUES ('4', '3', '1');
INSERT INTO `labclinico`.`tbl_referencia` (`pk_id_referencia`, `fk_idpaciente_referencia`, `fk_iddoctor_referencia`) VALUES ('5', '4', '2');


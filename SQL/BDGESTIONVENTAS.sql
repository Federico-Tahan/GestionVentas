create database PoliRubro

use PoliRubro


create table Rubro(
id_rubro int identity(1,1),
rubro varchar(50),
baja_logica int
constraint pk_id_rubro primary key (id_rubro)
)

create table Roles(
id_roles int identity(1,1),
nombre varchar(20)
constraint pk_id_rol primary key (id_roles)
)

create table Marca(
id_Marca int identity(1,1),
Marca varchar(50),
baja_logica int
constraint pk_id_Marca primary key (id_Marca))

create table Localidad(
	id_localidad int identity(1,1),
	Localidad varchar(50),
	baja_logica int
	constraint pk_id_localidad primary key (id_localidad)
)


create table UnidadMedida(
id_UnidadMedida int identity(1,1),
Unidad_Medida varchar(50),
baja_logica int,
cant_decimal int
constraint pk_id_UnidadMedida primary key (id_UnidadMedida))


create table accion(
id_accion int,
accion varchar(100),
constraint pk_id_accion primary key(id_accion)
)

create table Producto(
id_producto int identity(1,1),
id_rubro int,
id_marca int,
nombre varchar(50),
descripcion varchar(600),
precio money,
descuento int,
stock money,
stock_minimo money,
id_unidad_medida int,
baja_logica int
constraint pk_id_producto primary key(id_producto),
constraint fk_id_rubro foreign key(id_rubro) references Rubro(id_rubro),
constraint fk_id_marca foreign key(id_marca) references Marca(id_marca),
constraint fk_id_unidad_medida foreign key(id_unidad_medida) references UnidadMedida(id_unidadMedida)
)


create table Empleados(
DNI bigint,
nombre varchar(40),
apelldio varchar(40),
calle varchar(100),
altura int,
departamento varchar(30),
piso int,
telefono bigint,
email varchar(60),
baja_logica int,
id_localidad int
constraint pk_dnii primary key (DNI),
constraint fk_id_localidad foreign key(id_localidad) references Localidad(id_localidad)
)

create table Usuarios(
id_usuario int identity(1,1),
dni bigint,
alias varchar(20),
contraseña varchar(30),
baja_logica int,
id_rol int,
constraint pk_id_usuario primary key (id_usuario),
constraint fk_DNI foreign key (dni) references Empleados(DNI)
)

create table Cliente(
DNI bigint,
nombre varchar(40),
apellido varchar(40),
telefono bigint,
email varchar(60)
constraint pk_DNI primary key (DNI)
)

create table HistorialPagoCliente(
id_pago int identity(1,1),
DNI bigint,
monto money,
fecha datetime
constraint pk_id_pago primary key (id_pago),
constraint fk_id_cliente foreign key (DNI) references Cliente(DNI)
)

create table FormaDePago(
id_formapago int identity(1,1),
formapago varchar(40),
baja_logica int
constraint pk_id_formapago primary key (id_formapago)
)


create table Venta(
id_venta int identity(1,1),
fecha datetime,
id_formaPago int,
nombre varchar(40),
apellido varchar(40),
id_cliente bigint,
id_usuario int,
monto_pagado money,
Bajalogica int
constraint pk_id_venta primary key(id_venta),
constraint fk_id_Formapago foreign key(id_formaPago) references FormaDePago(id_formapago),
constraint fk_id_usuarioo foreign key (id_usuario) references Usuarios(id_usuario)
)


create table Detalle_Venta(
id_detalle int identity(1,1),
id_venta int,
id_producto int,
cantidad int,
precio money,
descuento int,
baja_logica int,
constraint pk_id_detalle primary key(id_detalle),
constraint fk_id_venta foreign key (id_venta) references Venta(id_venta),
constraint fk_id_prod foreign key (id_producto) references Producto(id_producto)
)


create table bitacora (
id_bitacora int identity(1,1),
id_usuario int,
fecha datetime,
id_accion int
constraint pk_idbitacora primary key (id_bitacora),
constraint fk_idusuario foreign key (id_usuario) references usuarios(id_usuario)
)


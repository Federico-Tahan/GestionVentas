USE [master]
GO
/****** Object:  Database [PoliRubro]    Script Date: 12/5/2023 23:27:00 ******/
CREATE DATABASE [PoliRubro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PoliRubro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PoliRubro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PoliRubro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PoliRubro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PoliRubro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PoliRubro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PoliRubro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PoliRubro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PoliRubro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PoliRubro] SET ARITHABORT OFF 
GO
ALTER DATABASE [PoliRubro] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PoliRubro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PoliRubro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PoliRubro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PoliRubro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PoliRubro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PoliRubro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PoliRubro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PoliRubro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PoliRubro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PoliRubro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PoliRubro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PoliRubro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PoliRubro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PoliRubro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PoliRubro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PoliRubro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PoliRubro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PoliRubro] SET  MULTI_USER 
GO
ALTER DATABASE [PoliRubro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PoliRubro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PoliRubro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PoliRubro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PoliRubro] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PoliRubro]
GO
/****** Object:  UserDefinedFunction [dbo].[F_DeudaTotal]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   function [dbo].[F_DeudaTotal](
	@id_cliente bigint
)
returns money as
begin
		
		declare @totalDeuda money
		declare @pagoTotal money

		SELECT @totalDeuda = SUM(cantidad * (precio - (precio * dv.descuento)/100))
		FROM Detalle_Venta dv
		JOIN Venta v ON dv.id_venta = v.id_venta
		WHERE v.id_cliente = @id_cliente AND id_formaPago = 1

	if(@totalDeuda is null)
	begin
		set @totalDeuda = 0
	end
	else
	begin
		select @pagoTotal = dbo.F_TotalPagoVenta(@id_cliente) + dbo.F_TotalPagoHistPago(@id_cliente) 

		set @totalDeuda = @totalDeuda - @pagoTotal
	end



	return @totalDeuda 

end
GO
/****** Object:  UserDefinedFunction [dbo].[F_TotalPagoHistPago]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   function [dbo].[F_TotalPagoHistPago](
	@id_cliente bigint
)
returns money as
begin
	declare @pagototal money
		select @pagototal = SUM(monto)
		from HistorialPagoCliente
		where DNI = @id_cliente and Baja_Logica = 0
		group by DNI

	if(@pagototal is null)
	begin
		set @pagototal = 0
	end

	return @pagototal 
end
GO
/****** Object:  UserDefinedFunction [dbo].[F_TotalPagoVenta]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   function [dbo].[F_TotalPagoVenta](
	@id_cliente bigint
)
returns money as
begin
	declare @pagototal money
		select @pagototal = SUM(monto_pagado)
		from Venta
		where id_cliente = @id_cliente and id_formaPago = 1 and  BajaLogica = 0
		group by id_cliente

	if(@pagototal is null)
	begin
		set @pagototal = 0
	end

	return @pagototal 
end
GO
/****** Object:  Table [dbo].[accion]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accion](
	[id_accion] [int] NOT NULL,
	[accion] [varchar](100) NULL,
 CONSTRAINT [pk_id_accion] PRIMARY KEY CLUSTERED 
(
	[id_accion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id_bitacora] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[fecha] [datetime] NULL,
	[id_accion] [int] NULL,
 CONSTRAINT [pk_idbitacora] PRIMARY KEY CLUSTERED 
(
	[id_bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[DNI] [bigint] NOT NULL,
	[nombre] [varchar](40) NULL,
	[apellido] [varchar](40) NULL,
	[telefono] [bigint] NULL,
	[email] [varchar](60) NULL,
 CONSTRAINT [pk_DNI] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuracion]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuracion](
	[CUIT] [varchar](13) NULL,
	[Logo] [image] NULL,
	[NombreEmpresa] [varchar](50) NULL,
	[direccion] [varchar](200) NULL,
	[Licencia] [varchar](200) NULL,
	[id_tema] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NULL,
	[id_producto] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [money] NULL,
	[descuento] [int] NULL,
	[baja_logica] [int] NULL,
 CONSTRAINT [pk_id_detalle] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[DNI] [bigint] NOT NULL,
	[nombre] [varchar](40) NULL,
	[apelldio] [varchar](40) NULL,
	[calle] [varchar](100) NULL,
	[altura] [int] NULL,
	[departamento] [varchar](30) NULL,
	[piso] [int] NULL,
	[telefono] [bigint] NULL,
	[email] [varchar](60) NULL,
	[baja_logica] [int] NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [pk_dnii] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaDePago]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaDePago](
	[id_formapago] [int] IDENTITY(1,1) NOT NULL,
	[formapago] [varchar](40) NULL,
	[baja_logica] [int] NULL,
 CONSTRAINT [pk_id_formapago] PRIMARY KEY CLUSTERED 
(
	[id_formapago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialPagoCliente]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialPagoCliente](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [bigint] NULL,
	[monto] [money] NULL,
	[fecha] [datetime] NULL,
	[Baja_Logica] [int] NULL,
 CONSTRAINT [pk_id_pago] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[Localidad] [varchar](50) NULL,
	[baja_logica] [int] NULL,
 CONSTRAINT [pk_id_localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NULL,
	[baja_logica] [int] NULL,
 CONSTRAINT [pk_id_Marca] PRIMARY KEY CLUSTERED 
(
	[id_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_rubro] [int] NULL,
	[id_marca] [int] NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](600) NULL,
	[precio] [money] NULL,
	[descuento] [int] NULL,
	[stock] [money] NULL,
	[stock_minimo] [money] NULL,
	[id_unidad_medida] [int] NULL,
	[baja_logica] [int] NULL,
 CONSTRAINT [pk_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id_roles] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
 CONSTRAINT [pk_id_rol] PRIMARY KEY CLUSTERED 
(
	[id_roles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rubro]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rubro](
	[id_rubro] [int] IDENTITY(1,1) NOT NULL,
	[rubro] [varchar](50) NULL,
	[baja_logica] [int] NULL,
 CONSTRAINT [pk_id_rubro] PRIMARY KEY CLUSTERED 
(
	[id_rubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tema]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tema](
	[id_tema] [int] NULL,
	[tema] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadMedida]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadMedida](
	[id_UnidadMedida] [int] IDENTITY(1,1) NOT NULL,
	[Unidad_Medida] [varchar](50) NULL,
	[baja_logica] [int] NULL,
	[cant_decimal] [int] NULL,
 CONSTRAINT [pk_id_UnidadMedida] PRIMARY KEY CLUSTERED 
(
	[id_UnidadMedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [bigint] NULL,
	[alias] [varchar](20) NULL,
	[contraseña] [varchar](30) NULL,
	[baja_logica] [int] NULL,
	[id_rol] [int] NULL,
 CONSTRAINT [pk_id_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[id_formaPago] [int] NULL,
	[nombre] [varchar](40) NULL,
	[apellido] [varchar](40) NULL,
	[id_cliente] [bigint] NULL,
	[id_usuario] [int] NULL,
	[monto_pagado] [money] NULL,
	[Bajalogica] [int] NULL,
 CONSTRAINT [pk_id_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Configuracion] ([CUIT], [Logo], [NombreEmpresa], [direccion], [Licencia], [id_tema]) VALUES (N'0', 0x, N'', N'', N'IFO3x56zs9OQCGsRHUSBvaKjcvVmfKVoI5paDwyfRFg=', 1)
GO
INSERT [dbo].[Empleados] ([DNI], [nombre], [apelldio], [calle], [altura], [departamento], [piso], [telefono], [email], [baja_logica], [id_localidad]) VALUES (0, N'Admin', N'Admin', N'a', 2, N'', 2, 0, N'', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[FormaDePago] ON 

INSERT [dbo].[FormaDePago] ([id_formapago], [formapago], [baja_logica]) VALUES (1, N'Fiado', 0)
INSERT [dbo].[FormaDePago] ([id_formapago], [formapago], [baja_logica]) VALUES (2, N'Efectivo', 0)
INSERT [dbo].[FormaDePago] ([id_formapago], [formapago], [baja_logica]) VALUES (3, N'Tarjeta Debito', 0)
INSERT [dbo].[FormaDePago] ([id_formapago], [formapago], [baja_logica]) VALUES (4, N'Mercado Pago', 0)
SET IDENTITY_INSERT [dbo].[FormaDePago] OFF
GO
SET IDENTITY_INSERT [dbo].[Localidad] ON 

INSERT [dbo].[Localidad] ([id_localidad], [Localidad], [baja_logica]) VALUES (1, N'Cordoba', 0)
SET IDENTITY_INSERT [dbo].[Localidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([id_Marca], [Marca], [baja_logica]) VALUES (1, N'<<Mostrar Todas>>', 0)
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id_roles], [nombre]) VALUES (1, N'Gerente')
INSERT [dbo].[Roles] ([id_roles], [nombre]) VALUES (2, N'Vendedor')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Rubro] ON 

INSERT [dbo].[Rubro] ([id_rubro], [rubro], [baja_logica]) VALUES (1, N'<<Mostrar Todos>>', 0)
SET IDENTITY_INSERT [dbo].[Rubro] OFF
GO
INSERT [dbo].[Tema] ([id_tema], [tema]) VALUES (1, N'CodeFlow System')
INSERT [dbo].[Tema] ([id_tema], [tema]) VALUES (2, N'Esmeralda')
INSERT [dbo].[Tema] ([id_tema], [tema]) VALUES (3, N'Ligth')
INSERT [dbo].[Tema] ([id_tema], [tema]) VALUES (4, N'Dark')
GO
SET IDENTITY_INSERT [dbo].[UnidadMedida] ON 

INSERT [dbo].[UnidadMedida] ([id_UnidadMedida], [Unidad_Medida], [baja_logica], [cant_decimal]) VALUES (1, N'<<Mostrar Todas>>', 0, 0)
SET IDENTITY_INSERT [dbo].[UnidadMedida] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [dni], [alias], [contraseña], [baja_logica], [id_rol]) VALUES (1, 0, N'admin', N'wFVcL0vmduY=', 0, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [fk_idusuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [fk_idusuario]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [fk_id_prod] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [fk_id_prod]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [fk_id_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Venta] ([id_venta])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [fk_id_venta]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [fk_id_localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [fk_id_localidad]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_id_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marca] ([id_Marca])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_id_marca]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_id_rubro] FOREIGN KEY([id_rubro])
REFERENCES [dbo].[Rubro] ([id_rubro])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_id_rubro]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [fk_id_unidad_medida] FOREIGN KEY([id_unidad_medida])
REFERENCES [dbo].[UnidadMedida] ([id_UnidadMedida])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [fk_id_unidad_medida]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_DNI] FOREIGN KEY([dni])
REFERENCES [dbo].[Empleados] ([DNI])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_DNI]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [fk_idRol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[Roles] ([id_roles])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [fk_idRol]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [fk_id_Formapago] FOREIGN KEY([id_formaPago])
REFERENCES [dbo].[FormaDePago] ([id_formapago])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [fk_id_Formapago]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [fk_id_usuarioo] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [fk_id_usuarioo]
GO
/****** Object:  StoredProcedure [dbo].[AltaFactura]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[AltaFactura] (
	@id_formapago int,
	@nombre varchar(40),
	@apellido varchar(40),
	@id_cliente bigint,
	@id_usuario int,
	@monto_pagado money,
	@IDFACTURA int output
)as

	declare @cliente int

	if(@id_cliente = 0)
	begin
		set @cliente = null
	end
	else
	begin
		set @cliente = @id_cliente
	end
	insert into Venta values (GETDATE(),@id_formapago,@nombre,@apellido,@cliente,@id_usuario,@monto_pagado,0)

	set @IDFACTURA = SCOPE_IDENTITY()


GO
/****** Object:  StoredProcedure [dbo].[SP_AltaCliente]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_AltaCliente](
	@DNI bigint,
	@nombre varchar(40),
	@apellido varchar(40),
	@telefono bigint,
	@email varchar(40)
)as
	insert into Cliente values(@DNI,@nombre,@apellido,@telefono,@email)
GO
/****** Object:  StoredProcedure [dbo].[SP_AltaDetalle]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaDetalle](
	@id_factura int,
	@id_producto int,
	@cantidad money,
	@precio money,
	@descuento int

)as
	insert into Detalle_Venta values (@id_factura,@id_producto,@cantidad,@precio,@descuento,0)

	update Producto
	set stock = stock - @cantidad
	where id_producto = @id_producto

	declare @stockactual int

	select @stockactual = stock 
	from Producto
	where id_producto = @id_producto

	if(@stockactual = 0)
	begin
		update Producto
		set baja_logica = 1
		where id_producto = @id_producto
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_AltaFormaPago]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaFormaPago](
	@nombre varchar(60)
)as
	insert into FormaDePago values(@nombre,0)
GO
/****** Object:  StoredProcedure [dbo].[SP_AltaLocalidad]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaLocalidad]
(
	@nombre varchar(60)
)as
	insert into Localidad values(@nombre,0)
GO
/****** Object:  StoredProcedure [dbo].[SP_AltaMarca]    Script Date: 12/5/2023 23:27:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaMarca](
	@nombre varchar(60)
)as

	insert into Marca values(@nombre,0)
GO
/****** Object:  StoredProcedure [dbo].[SP_AltaPago]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaPago](
	@DNI bigint,
	@monto money

)as
	insert into HistorialPagoCliente values(@DNI,@monto,GETDATE(),0)

GO
/****** Object:  StoredProcedure [dbo].[SP_AltaRubro]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaRubro](
	@nombre varchar(60)
)as

	insert into Rubro values(@nombre,0)

GO
/****** Object:  StoredProcedure [dbo].[SP_AltaUnidadMed]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_AltaUnidadMed](
	@nombre varchar(60),
	@decimales int
)as

	insert into UnidadMedida values(@nombre,0,@decimales)
GO
/****** Object:  StoredProcedure [dbo].[SP_BajaPago]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_BajaPago](
	@id_pago int
)as
	update HistorialPagoCliente
	set Baja_Logica = 1
	where id_pago = @id_pago
GO
/****** Object:  StoredProcedure [dbo].[SP_CacelarDetalle]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_CacelarDetalle](
	@id_factura int
)as
	UPDATE producto
	SET stock = stock + cantidad,
		baja_logica = 0
	FROM Producto t1
	INNER JOIN Detalle_Venta t2 ON t1.id_producto = t2.id_producto
	where t2.id_venta = @id_factura

	delete Detalle_Venta
	where id_venta = @id_factura
GO
/****** Object:  StoredProcedure [dbo].[SP_CacelarVenta]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_CacelarVenta](
	@id_factura int
)as
	update Venta
	set Bajalogica = 1
	where id_venta = @id_factura

	UPDATE producto
	SET stock = stock + cantidad,
		baja_logica = 0
	FROM Producto t1
	INNER JOIN Detalle_Venta t2 ON t1.id_producto = t2.id_producto
	where t2.id_venta = @id_factura

	update Detalle_Venta
	set baja_logica = 1
	where id_venta = @id_factura
GO
/****** Object:  StoredProcedure [dbo].[SP_CARGAR_FormaPago]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_CARGAR_FormaPago](
	@modo int

)as

	if(@modo = 0)
	begin
		select * from FormaDePago
		where baja_logica = 0

	end
	else if (@modo = 1)
	begin
			select * from FormaDePago
			where baja_logica = 1
	end
	else
	begin
		select * from FormaDePago

	end

GO
/****** Object:  StoredProcedure [dbo].[SP_CheckLogin]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_CheckLogin](
	@usuario varchar(50),
	@contraseña varchar(50)
)as
	select *
	from Usuarios
	where @usuario = alias and @contraseña = contraseña
GO
/****** Object:  StoredProcedure [dbo].[SP_DeudasClientes]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_DeudasClientes]
as

	select DNI, nombre+ ' ' + apellido'NombreCompleto',dbo.F_DeudaTotal(DNI)'DeudaCliente'
	from Cliente
	where dbo.F_DeudaTotal(DNI) > 0
GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTEALIAS]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_EXISTEALIAS](
	@ALIAS VARCHAR(40)
)as
	select * from Usuarios where alias = @ALIAS
GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTEDNI]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_EXISTEDNI](
	@DNI bigint
)as
	select * from Usuarios where DNI= @DNI

GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTEDNICli]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_EXISTEDNICli](
	@DNI bigint
)as
	select * from Cliente where @DNI = DNI
GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTELicencia]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_EXISTELicencia]
as
	select Licencia
	from Configuracion
GO
/****** Object:  StoredProcedure [dbo].[SP_FaltaStock]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_FaltaStock]
as
	Select * from Producto
	where stock <= stock_minimo
GO
/****** Object:  StoredProcedure [dbo].[SP_GeneradoxEmpleado]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_GeneradoxEmpleado]
as
	SELECT CONCAT(Year(v.fecha), '/', MONTH(v.fecha))'Fecha',u.id_usuario,e.nombre, e.apelldio,e.DNI, COUNT(v.id_venta)'CantVentas',SUM(dv.cantidad * dv.precio - (dv.cantidad * dv.precio * dv.descuento / 100)) AS Dinero_Generado
	FROM Venta v
	JOIN Detalle_Venta dv ON v.id_venta = dv.id_venta
	JOIN Usuarios u ON u.id_usuario = v.id_usuario
	JOIN Empleados e ON u.dni = e.DNI
	WHERE v.Bajalogica = 0 and MONTH(v.fecha) = MONTH(GETDATE()) and YEAR(GETDATE())= YEAR(v.fecha)
	GROUP BY u.id_usuario, e.nombre, e.apelldio,e.DNI, MONTH(v.fecha),YEAR(v.fecha)
GO
/****** Object:  StoredProcedure [dbo].[SP_GeneradoXMarca]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_GeneradoXMarca]
as
	select p.id_Marca, r.Marca, SUM(cantidad * (dv.precio - (dv.precio * dv.descuento)/100))'Generado'
	from Venta v
	join Detalle_Venta dv on dv.id_venta = v.id_venta
	join Producto p on p.id_producto = dv.id_producto
	join Marca r on r.id_Marca = p.id_Marca
	group by p.id_Marca, r.Marca
GO
/****** Object:  StoredProcedure [dbo].[SP_GeneradoXRubro]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_GeneradoXRubro]
as
	select p.id_rubro, r.rubro, SUM(cantidad * (dv.precio - (dv.precio * dv.descuento)/100))'Generado'
	from Venta v
	join Detalle_Venta dv on dv.id_venta = v.id_venta
	join Producto p on p.id_producto = dv.id_producto
	join Rubro r on r.id_rubro = p.id_rubro
	group by p.id_rubro, r.rubro
GO
/****** Object:  StoredProcedure [dbo].[SP_InfoEmpresa]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_InfoEmpresa](
	@cuit varchar(20),
	@nombre varchar(50),
	@direccion varchar(100),
	@imagen Image
)as
	update Configuracion
	set CUIT = @cuit,
		NombreEmpresa = @nombre,
		direccion = @direccion,
		Logo = @imagen
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Tema]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_Insert_Tema](
	@id int
)as
	update Configuracion
	set id_tema = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_Insertar_Usuario]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_Insertar_Usuario](
	@DNI bigint,
	@nombre varchar(150),
	@apellido varchar(150),
	@calle varchar(150),
	@altura int,
	@piso int,
	@departamento varchar(100),
	@localidad int,
	@Telefono bigint,
	@Email varchar(40),
	@Alias varchar(150),
	@contraseña varchar(32),
	@id_rol int
)as
begin
	insert into Empleados values(@DNI,@nombre,@apellido,@calle,@altura,@departamento,@piso,@Telefono,@Email,0,@localidad)
	insert into Usuarios values(@DNI,@alias,@contraseña,0,@id_rol)
end

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarKey]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_InsertarKey](
  @key varchar(200)
)
as
	update Configuracion
	set Licencia = @key
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarProducto]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*----------CRUD PRODUCTOS--------*/
create procedure [dbo].[SP_InsertarProducto](
	@id_rubro int,
	@id_marca int,
	@nombre varchar(50),
	@descripcion varchar(600),
	@precio money,
	@descuento int,
	@stock decimal,
	@stock_minimo decimal,
	@id_unidadMedida int
)as
	insert into Producto values (@id_rubro,@id_marca,@nombre,@descripcion,@precio,@descuento,@stock,@stock_minimo,@id_unidadMedida,0)
GO
/****** Object:  StoredProcedure [dbo].[SP_Logeado]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_Logeado](
	@usuario varchar(50),
	@contraseña varchar(50)
)as
	select e.DNI,e.nombre,e.apelldio,r.id_roles, u.id_usuario
	from Usuarios u 
	join Empleados e on u.dni = e.DNI
	join Roles r on u.id_rol = r.id_roles
	where u.contraseña = @contraseña and u.alias = @usuario

GO
/****** Object:  StoredProcedure [dbo].[SP_ModficarVenta]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_ModficarVenta](
	@id_factura int,
	@id_formapago int,
	@nombre varchar(40),
	@apellido varchar(40),
	@id_cliente bigint,
	@id_usuario int,
	@monto_pagado money
)as
	update Venta
	set id_formaPago = @id_formapago,
		nombre = @nombre,
		apellido = @apellido,
		id_cliente = @id_cliente,
		id_usuario = @id_usuario,
		monto_pagado = @monto_pagado
	where id_venta = @id_factura


GO
/****** Object:  StoredProcedure [dbo].[SP_Modificar_Usuario]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_Modificar_Usuario](
	@id_usuario int,
	@DNI bigint,
	@nombre varchar(150),
	@apellido varchar(150),
	@calle varchar(150),
	@altura int,
	@piso int,
	@departamento varchar(100),
	@localidad int,
	@Telefono bigint,
	@Email varchar(40),
	@Alias varchar(150),
	@contraseña varchar(32),
	@id_rol int,
	@bajaLogica int
)as
begin
	
	update usuarios
	set alias = @alias,
		contraseña = @contraseña,
		baja_logica = @bajaLogica,
		id_rol = @id_rol
	where id_usuario = @id_usuario

	update Empleados
	set nombre = @nombre,
		apelldio = @apellido,
		calle = @calle,
		altura = @altura,
		piso = @piso,
		departamento = @departamento,
		id_localidad = @localidad,
		telefono = @Telefono,
		email = @Email,
		baja_logica = @bajaLogica
	where DNI in (select DNI
				  from Usuarios
				  where id_usuario = @id_usuario)
end

GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarCliente]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_ModificarCliente](
	@DNINuevo bigint,
	@DNI bigint,
	@nombre varchar(40),
	@apellido varchar(40),
	@telefono bigint,
	@email varchar(40)
)as
	

	update Cliente
	set DNI = @DNINuevo,
		nombre = @nombre,
		apellido = @apellido,
		telefono = @telefono,
		email = @email
	where DNI = @DNI

	update Venta 
	set id_cliente = @DNINuevo
	where id_cliente = @DNI

	update HistorialPagoCliente
	set DNI = @DNINuevo
	where DNI = @DNI
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarProductow]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_ModificarProductow](
	@id_producto int,
	@id_rubro int,
	@id_marca int,
	@nombre varchar(50),
	@descripcion varchar(600),
	@precio money,
	@descuento int,
	@stock decimal,
	@stock_minimo decimal,
	@id_unidadMedida int,
	@baja_logica int
)as
	update Producto
	set id_rubro = @id_rubro,
		id_marca = @id_marca,
		nombre = @nombre,
		descripcion = @descripcion,
		precio = @precio,
		descuento = @descuento,
		stock = @stock,
		stock_minimo = @stock_minimo,
		baja_logica = @baja_logica,
		id_unidad_medida = @id_unidadMedida
		where id_producto = @id_producto
	
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_Marcas]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create    procedure [dbo].[SP_OBTENER_Marcas](
@modo int
)as
	if (@modo =0)
	begin
		select * from Marca
	end
	else if (@modo =1)
	begin
		select * from Marca
		where id_Marca != 1
	end
	else 
	begin
		select * from Marca
		where id_Marca != 1 and baja_logica = 0
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_ROL]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create   procedure [dbo].[SP_OBTENER_ROL]
as
	select * from Roles
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_Rubro]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create    procedure [dbo].[SP_OBTENER_Rubro](
@modo int
)as
	if (@modo =0)
	begin
		select * from Rubro
	end
	else if (@modo =1)
	begin
		select * from Rubro
		where id_rubro != 1
	end
	else 
	begin
		select * from Rubro
		where id_rubro != 1 and baja_logica = 0
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_OBTENER_UnidadMedida]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create    procedure [dbo].[SP_OBTENER_UnidadMedida](
@modo int
)as
	if (@modo =0)
	begin
		select * from UnidadMedida
	end
	else if(@modo = 1)
	begin
		select * from UnidadMedida
		where id_UnidadMedida != 1
	end
	else 
	begin
		select * from UnidadMedida
		where id_UnidadMedida != 1 and baja_logica = 0
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerLocalidad]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_ObtenerLocalidad](
	@modo int
)
as
	if(@modo = 0)
	begin
	select id_localidad, Localidad,baja_logica
	from Localidad
	where baja_logica = 0
	end
	else if(@modo = 1)
	begin
	select id_localidad, Localidad,baja_logica
	from Localidad
	where baja_logica = 1
	end
	else if(@modo = 2)
	begin
	select id_localidad, Localidad,baja_logica
	from Localidad
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProductoMarcaRubro]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_ObtenerProductoMarcaRubro](

	@rubro int,
	@marca int
)as
	
	if(@rubro = 1 and @marca = 1)
	begin

		select id_producto,r.id_rubro, r.rubro,m.id_Marca,m.Marca,p.nombre,descripcion,precio,descuento,stock,stock_minimo,um.id_UnidadMedida, um.Unidad_Medida, p.baja_logica, um.cant_decimal from Producto p
		join Marca m on p.id_marca = m.id_Marca
		join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
		join Rubro r on r.id_rubro = p.id_rubro
		where p.baja_logica = 0

	end
	else if(@rubro !=1 and @marca =1)
	begin
		select id_producto,r.id_rubro, r.rubro,m.id_Marca,m.Marca,p.nombre,descripcion,precio,descuento,stock,stock_minimo,um.id_UnidadMedida, um.Unidad_Medida, p.baja_logica, um.cant_decimal from Producto p
		join Marca m on p.id_marca = m.id_Marca
		join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
		join Rubro r on r.id_rubro = p.id_rubro
		where p.baja_logica = 0  and @rubro = p.id_rubro
	end
	else if(@rubro = 1 and @marca !=1)
	begin
		select id_producto,r.id_rubro, r.rubro,m.id_Marca,m.Marca,p.nombre,descripcion,precio,descuento,stock,stock_minimo,um.id_UnidadMedida, um.Unidad_Medida, p.baja_logica, um.cant_decimal from Producto p
		join Marca m on p.id_marca = m.id_Marca
		join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
		join Rubro r on r.id_rubro = p.id_rubro
		where p.baja_logica = 0  and @marca = p.id_marca
	end
	else
	begin
		select id_producto,r.id_rubro, r.rubro,m.id_Marca,m.Marca,p.nombre,descripcion,precio,descuento,stock,stock_minimo,um.id_UnidadMedida, um.Unidad_Medida, p.baja_logica, um.cant_decimal from Producto p
		join Marca m on p.id_marca = m.id_Marca
		join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
		join Rubro r on r.id_rubro = p.id_rubro
		where p.baja_logica = 0  and @rubro = p.id_rubro and @marca = p.id_marca
	end
	
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerProductos]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ObtenerProductos]( 
	@modo int

)as
	if(@modo != 0 and @modo != 1)
	begin
		select id_producto,r.id_rubro, r.rubro,m.id_Marca,m.Marca,p.nombre,descripcion,precio,descuento,stock,stock_minimo,um.id_UnidadMedida, um.Unidad_Medida, p.baja_logica, um.cant_decimal from Producto p
		join Marca m on p.id_marca = m.id_Marca
		join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
		join Rubro r on r.id_rubro = p.id_rubro
	end
	else
	begin
		select id_producto,r.id_rubro, r.rubro,m.id_Marca,m.Marca,p.nombre,descripcion,precio,descuento,stock,stock_minimo,um.id_UnidadMedida, um.Unidad_Medida, p.baja_logica, um.cant_decimal from Producto p
		join Marca m on p.id_marca = m.id_Marca
		join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
		join Rubro r on r.id_rubro = p.id_rubro
		where p.baja_logica = @modo
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerUsuarios]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_ObtenerUsuarios](
	@modo int
)as
		

		if(@modo = 1)
		begin
			select u.alias, u.contraseña,u.baja_logica,e.DNI,e.nombre,e.apelldio,e.calle,e.altura,e.piso,e.departamento,e.telefono,e.email,l.id_localidad,l.Localidad, u.id_usuario,u.id_rol,r.nombre
			from Usuarios u 
			join Empleados e on u.dni = e.dni
			join Localidad l on l.id_localidad = e.id_localidad
			join roles r on r.id_roles = u.id_rol
			where u.baja_logica = 1

		end
		else if (@modo = 2)
		begin
			select u.alias, u.contraseña,u.baja_logica,e.DNI,e.nombre,e.apelldio,e.calle,e.altura,e.piso,e.departamento,e.telefono,e.email,l.id_localidad,l.Localidad, u.id_usuario,u.id_rol,r.nombre
			from Usuarios u 
			join Empleados e on u.dni = e.dni
			join Localidad l on l.id_localidad = e.id_localidad
			join roles r on r.id_roles = u.id_rol

		end
		else if (@modo = 0)
		begin
			select u.alias, u.contraseña,u.baja_logica,e.DNI,e.nombre,e.apelldio,e.calle,e.altura,e.piso,e.departamento,e.telefono,e.email,l.id_localidad,l.Localidad, u.id_usuario,u.id_rol,r.nombre
			from Usuarios u 
			join Empleados e on u.dni = e.dni
			join Localidad l on l.id_localidad = e.id_localidad
			join roles r on r.id_roles = u.id_rol
			where u.baja_logica = 0
		end

GO
/****** Object:  StoredProcedure [dbo].[SP_RecaudadoHoy]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_RecaudadoHoy]
as
	select SUM(cantidad * (precio - (precio * dv.descuento)/100))
	from Venta v
	join Detalle_Venta dv on dv.id_venta = v.id_venta
	WHERE CAST(fecha AS date) = CAST(GETDATE() AS date)
GO
/****** Object:  StoredProcedure [dbo].[SP_Reporte_Recaudacion]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_Reporte_Recaudacion](
		@tipoFecha int)as
		
		if(@tipoFecha = 1)
		begin
			select  CONCAT(Year(v.fecha), '/', MONTH(v.fecha), '/', DAY(v.fecha))'Fecha', v.id_formaPago, fp.formapago,SUM(cantidad * (precio - (precio * dv.descuento)/100))'Recaudado'
			from Venta v
			join Detalle_Venta dv on v.id_venta = dv.id_venta
			join FormaDePago fp on v.id_formaPago = fp.id_formapago
			group by v.id_formaPago, fp.formapago, Year(v.fecha), MONTH(v.fecha),DAY(v.fecha)
		end
		else if(@tipoFecha = 2)
		begin
			select  CONCAT(Year(v.fecha), '/', MONTH(v.fecha))'Fecha', v.id_formaPago, fp.formapago, SUM(cantidad * (precio - (precio * dv.descuento)/100))'Recaudado'
			from Venta v
			join Detalle_Venta dv on v.id_venta = dv.id_venta
			join FormaDePago fp on v.id_formaPago = fp.id_formapago
			group by v.id_formaPago, fp.formapago, Year(v.fecha), MONTH(v.fecha)
		end
		else if(@tipoFecha = 3)
		begin
			select  str(Year(v.fecha))'Fecha', v.id_formaPago, fp.formapago, SUM(cantidad * (precio - (precio * dv.descuento)/100))'Recaudado'
			from Venta v
			join Detalle_Venta dv on v.id_venta = dv.id_venta
			join FormaDePago fp on v.id_formaPago = fp.id_formapago
			group by v.id_formaPago, fp.formapago, Year(v.fecha)
		end
		
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteTOPproductos]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_ReporteTOPproductos]
as
	SELECT top 10 dv.id_producto, nombre,descripcion,p.precio,SUM(CANTIDAD)'Cantidad_Vendida',stock_minimo,stock,m.Marca,r.rubro
	from Detalle_Venta dv
	join Producto p on dv.id_producto = p.id_producto
	join Rubro r on r.id_rubro = p.id_rubro
	join Marca m on m.id_Marca = p.id_marca
	group by dv.id_producto, nombre,descripcion,p.precio,stock_minimo,stock,m.Marca,r.rubro
	order by 1 desc
GO
/****** Object:  StoredProcedure [dbo].[SP_Tema]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_Tema]
as
	select * from Tema
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerClientes]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerClientes]
as
	select *, dbo.F_DeudaTotal(DNI)as 'Debe'from Cliente
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerConfig]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerConfig]
as
	select * from Configuracion
		
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerDetalles]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerDetalles](
	 @id_factura int
)as
	select id_detalle,cantidad,dv.precio,dv.descuento,p.id_producto,p.nombre,p.descripcion,p.id_unidad_medida,um.Unidad_Medida,um.cant_decimal,p.id_marca,m.Marca,p.id_rubro,r.rubro
	from Detalle_Venta dv
	 join Producto p on p.id_producto = dv.id_producto
	 join Marca m on p.id_marca = m.id_Marca
	 join UnidadMedida um on um.id_UnidadMedida = p.id_unidad_medida
	 join Rubro r on r.id_rubro = p.id_rubro
	where id_venta = @id_factura
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerFacturas]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerFacturas]
as

	select id_venta,fecha,f.id_formaPago,f.formapago,v.nombre,v.apellido,c.DNI,u.id_usuario,u.dni,e.nombre,e.apelldio,monto_pagado,v.Bajalogica
	from Venta v
	join FormaDePago f on f.id_formapago = v.id_formaPago
	left join Cliente c on c.DNI = v.id_cliente
	join Usuarios u on u.id_usuario = v.id_usuario
	join Empleados e on e.DNI = u.dni
	order by id_venta desc
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerFormaPago]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerFormaPago]
as
	select * from FormaDePago
	where baja_logica = 0
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerHistorialPago]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_TraerHistorialPago]
	@modo int
as
	
	if(@modo = 2)
	begin
		select hp.id_pago, hp.DNI, c.nombre, c.apellido, hp.fecha, hp.Baja_Logica,hp.monto
	from HistorialPagoCliente hp 
	join Cliente c on c.DNI = hp.DNI
	order by hp.id_pago desc
	end
	else if(@modo = 1)
	begin
		select hp.id_pago, hp.DNI, c.nombre, c.apellido, hp.fecha, hp.Baja_Logica,hp.monto
	from HistorialPagoCliente hp 
	join Cliente c on c.DNI = hp.DNI
	where hp.Baja_Logica =1
	order by hp.id_pago desc
	end	else if(@modo = 0)
	begin
	select hp.id_pago, hp.DNI, c.nombre, c.apellido, hp.fecha, hp.Baja_Logica,hp.monto
	from HistorialPagoCliente hp 
	join Cliente c on c.DNI = hp.DNI
	where hp.Baja_Logica =0
	order by hp.id_pago desc
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerLocalidad]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerLocalidad]
as
	select * from Localidad
	where baja_logica = 0
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerMarca]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_TraerMarca]
as
	select * from Marca
	where baja_logica = 0
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerRubro]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_TraerRubro]
as
	select * from Rubro
	where baja_logica = 0
GO
/****** Object:  StoredProcedure [dbo].[SP_TraerUnidadMedida]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_TraerUnidadMedida]
(
	@modo int
)
as
if (@modo =0)
	begin
		select * from UnidadMedida
	end
	else
	begin
		select * from UnidadMedida
		where id_UnidadMedida != 1
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateFormaPago]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_UpdateFormaPago]
(
	@id int,
	@nombre varchar(60),
	@baja_logica int
)as
	update FormaDePago
	set formapago = @nombre,
		baja_logica = @baja_logica
	where id_formapago = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateLocalidad]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_UpdateLocalidad]
(
	@id int,
	@nombre varchar(60),
	@baja_logica int
)as
	update Localidad
	set Localidad = @nombre,
		baja_logica = @baja_logica
	where id_localidad = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateMarca]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_UpdateMarca]
(
	@id int,
	@nombre varchar(60),
	@baja_logica int
)as
	update Marca
	set Marca = @nombre,
		baja_logica = @baja_logica
	where id_Marca = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateMedida]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_UpdateMedida]
(
	@id int,
	@nombre varchar(60),
	@decimales int,
	@baja_logica int
)as
	update UnidadMedida
	set Unidad_Medida = @nombre,
		cant_decimal = @decimales,
		baja_logica = @baja_logica
	where id_UnidadMedida = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateRubro]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_UpdateRubro]
(
	@id int,
	@nombre varchar(60),
	@baja_logica int
)as
	update Rubro
	set rubro = @nombre,
		baja_logica = @baja_logica
	where id_rubro = @id
GO
/****** Object:  StoredProcedure [dbo].[SP_VentasdelDia]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_VentasdelDia]
as
	select COUNT(id_venta)
	from Venta
	where DAY(fecha) = DAY(GETDATE()) and MONTH(fecha) = MONTH(GETDATE()) AND YEAR(fecha) = YEAR(GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[SP_VentasdelMES]    Script Date: 12/5/2023 23:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[SP_VentasdelMES]
as
	select COUNT(id_venta)
	from Venta
	where MONTH(fecha) = MONTH(GETDATE()) AND YEAR(fecha) = YEAR(GETDATE())
GO
USE [master]
GO
ALTER DATABASE [PoliRubro] SET  READ_WRITE 
GO

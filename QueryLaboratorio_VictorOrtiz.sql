CREATE DATABASE VentasAlbatros
GO

USE VentasAlbatros
GO

CREATE TABLE Impuestos
(
	CodigoImp int identity(1,1) primary key,
	DescripImp varchar(50) not null,
	PorcentImp decimal(5,2) not null
)
GO

INSERT INTO Impuestos VALUES ('Exento',0)
INSERT INTO Impuestos VALUES ('Importaciones o Ventas',0.15)
INSERT INTO Impuestos VALUES ('Produccion o Importacion',0.18)
GO

CREATE TABLE Productos
(
	CodigoProd int primary key,
	DescripProd varchar(50) not null,
	CantidadProd int not null,
	PrecioProd money not null,
	EstadoProd varchar(10) not null,
	CodigoImp int foreign key references Impuestos(CodigoImp) not null
)
GO

CREATE TABLE Clientes
(
	CodigoCli int primary key,
	NombreCli varchar(50) not null,
	RTN varchar(20) not null,
	DireccionCli varchar(100) not null,
	EstadoCli varchar(10) not null
)
GO

CREATE TABLE Factura_Venta
(
	NumFactura int identity(1,1) primary key,
	FechaFactura date not null,
	/*TotalImp money not null, CAMPO CALCULADO (NORMALIZACION)
	TotalFinal money not null CAMPO CALCULADO (NORMALIZACION) */
)
GO

CREATE TABLE Detalle_Venta
(
	NumDetalle int identity(1,1) primary key,
	NumFactura int foreign key references Factura_Venta(NumFactura) not null,
	CodigoProd int foreign key references Productos(CodigoProd) not null,
	Cantidad int not null,
	Precio money not null,
	CodigoImp int foreign key references Impuestos(CodigoImp) not null
	/*Total money not null CAMPO CALCULADO (NORMALIZACION)*/
)
GO


/*====================PROCEDIMIENTOS ALMACENADOS=======================*/
CREATE PROC sp_InsertProducto
@codigo int,
@descripcion varchar(50),
@cantidad int,
@precio money,
@estado varchar(10),
@codImpuesto int
AS
BEGIN
INSERT INTO Productos (CodigoProd,DescripProd,CantidadProd,PrecioProd,EstadoProd,CodigoImp) VALUES (@codigo,@descripcion,@cantidad,@precio,@estado,@codImpuesto)
END 
GO

CREATE PROC sp_UpdateProducto
@codigo int,
@descripcion varchar(50),
@cantidad int,
@precio money,
@estado varchar(10),
@codImpuesto int
AS
BEGIN
UPDATE Productos SET DescripProd = @descripcion,CantidadProd = @cantidad,PrecioProd = @precio,EstadoProd = @estado,CodigoImp = @codImpuesto WHERE CodigoProd = @codigo
END 
GO

CREATE PROC sp_InsertCliente
@codigo int,
@nombre varchar(50),
@rtn varchar(20),
@direccion varchar(100),
@estado varchar(10)
AS
BEGIN
INSERT INTO Clientes(CodigoCli,NombreCli,RTN,DireccionCli,EstadoCli) VALUES (@codigo,@nombre,@rtn,@direccion,@estado)
END 
GO

CREATE PROC sp_UpdateCliente
@codigo int,
@nombre varchar(50),
@rtn varchar(20),
@direccion varchar(100),
@estado varchar(10)
AS
BEGIN
UPDATE Clientes SET NombreCli = @nombre,RTN = @rtn,DireccionCli = @direccion,EstadoCli = @estado WHERE CodigoCli = @codigo
END 
GO

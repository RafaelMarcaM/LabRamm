-- DDL
CREATE DATABASE LabRamm;
USE [master]
GO
CREATE LOGIN [usrlabramm] WITH PASSWORD=N'12345678',
	DEFAULT_DATABASE=[LabRamm],
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO
USE [LabRamm]
GO
CREATE USER [usrlabramm] FOR LOGIN [usrlabramm]
GO
USE [LabRamm]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrlabramm]
GO

DROP TABLE Cliente;
DROP TABLE Usuario;
DROP TABLE Proveedor;
DROP TABLE Producto;

CREATE TABLE Producto(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	codigo VARCHAR(10) NOT NULL,
	descripcion VARCHAR(250) NOT NULL,
	unidadMedida VARCHAR(20) NOT NULL,
	existencias DECIMAL NOT NULL DEFAULT 0,
	precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
	usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_NAME(),
	registroActivo BIT NULL DEFAULT 1,
	fechaRegistro DATETIME NULL DEFAULT GETDATE()
);
CREATE TABLE Proveedor(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nit BIGINT NOT NULL,
	razonSocial VARCHAR(100) NOT NULL,
	direccion VARCHAR(250) NULL,
	telefono VARCHAR(30) NOT NULL,
	usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_NAME(),
	registroActivo BIT NULL DEFAULT 1,
	fechaRegistro DATETIME NULL DEFAULT GETDATE()
);
CREATE TABLE Usuario(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	usuario VARCHAR(12)NOT NULL,
	clave VARCHAR(250) NOT NULL,
	usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_NAME(),
	registroActivo BIT NULL DEFAULT 1,
	fechaRegistro DATETIME NULL DEFAULT GETDATE()
);
CREATE TABLE Cliente(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nit BIGINT NOT NULL,
	razonSocial VARCHAR(100) NOT NULL,
	telefono VARCHAR(30) NOT NULL,
	usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_NAME(),
	registroActivo BIT NULL DEFAULT 1,
	fechaRegistro DATETIME NULL DEFAULT GETDATE()
);

-- DML
INSERT INTO Producto(codigo, descripcion, unidadMedida, existencias, precioVenta)
VALUES ('BR028', 'Buje de bronze de 28mm', 'unidad', 15, 37);

SELECT * FROM Producto;

CREATE PROC paProductoListar @parametro VARCHAR(50)
AS
  SELECT id, codigo, descripcion, unidadMedida, existencias, precioVenta,
		 usuarioRegistro, fechaRegistro
  FROM Producto
  WHERE registroActivo=1 AND 
		codigo+descripcion+unidadMedida LIKE '%'+REPLACE(@parametro,' ','%')+'%'

EXEC paProductoListar ''

CREATE PROC paClienteListar @parametro VARCHAR(50)
AS
	SELECT id, nit, razonSocial, usuarioRegistro, fechaRegistro 
	FROM Cliente
	WHERE registroActivo = 1 AND
			convert(varchar(15),nit)+razonSocial LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paClienteListar ''

CREATE PROC paUsuarioListar @parametro VARCHAR(50)
AS
	SELECT id, usuario, clave, usuarioRegistro, fechaRegistro 
	FROM Usuario
	WHERE registroActivo = 1 AND
			usuario LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paUsuarioListar ''

CREATE PROC paProveedorListar @parametro VARCHAR(50)
AS
	SELECT id, nit, razonSocial, direccion, telefono, usuarioRegistro, fechaRegistro 
	FROM Proveedor
	WHERE registroActivo = 1 AND
			convert(varchar(15),nit)+razonSocial LIKE '%'+REPLACE(@parametro,' ','%')+'%';

EXEC paProveedorListar ''


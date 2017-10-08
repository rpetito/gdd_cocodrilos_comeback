--###########################################################################
--###########################################################################
-- SCRIPT DE MIGRACION Y CREACION DE OBJETOS NECESARIOS
-- GRUPO: COCODRILOS_COMEBACK
--###########################################################################
--###########################################################################

USE [GD2C2017]
GO

--###########################################################################
--###########################################################################
---------------------VERIFICACION EXISTENCIA DE OBJETOS----------------------
--###########################################################################
--###########################################################################

--###########################################################################
	-------------------------------TABLAS---------------------------------
--###########################################################################
IF OBJECT_ID('COCODRILOS_COMEBACK.FACTURA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.ITEM_FACTURA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ITEM_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.COBRADOR') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.COBRADOR

IF OBJECT_ID('COCODRILOS_COMEBACK.CLIENTE') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.CLIENTE

IF OBJECT_ID('COCODRILOS_COMEBACK.ADMINISTRADOR') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ADMINISTRADOR

IF OBJECT_ID('COCODRILOS_COMEBACK.ROL_USUARIO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ROL_USUARIO

IF OBJECT_ID('COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD

IF OBJECT_ID('COCODRILOS_COMEBACK.ROL') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.FUNCIONALIDAD') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.FUNCIONALIDAD

IF OBJECT_ID('COCODRILOS_COMEBACK.USUARIO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.USUARIO

IF OBJECT_ID('COCODRILOS_COMEBACK.EMPRESA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.RUBRO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.RUBRO

IF OBJECT_ID('COCODRILOS_COMEBACK.SUCURSAL') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.SUCURSAL



--###########################################################################
--###########################################################################
		---------------------CREACION DE SCHEMA----------------------
--###########################################################################
--###########################################################################

IF EXISTS (	SELECT  *
            FROM sys.schemas
            WHERE name = 'COCODRILOS_COMEBACK' ) 
EXEC('DROP SCHEMA [COCODRILOS_COMEBACK]');


IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = 'COCODRILOS_COMEBACK' ) 
EXEC('CREATE SCHEMA [COCODRILOS_COMEBACK] AUTHORIZATION [gd]');
 
GO



--###########################################################################
--###########################################################################
----------------------------CREACION DE TABLAS--------------------------------
--###########################################################################
--###########################################################################

CREATE TABLE COCODRILOS_COMEBACK.USUARIO (
	dni				numeric(18,0) PRIMARY KEY,
	nombre			nvarchar(255),
	apellido		nvarchar(255),
	fecha_nac		datetime,
	mail			nvarchar(255) UNIQUE,
	direccion		nvarchar(255),
	cod_postal		nvarchar(255),
	telefono		varchar(10),
	piso			numeric(2,0),
	localidad		nvarchar(255),
	dpto			nvarchar(10),
	login_fallidos	int DEFAULT 0,
	habilitado		int DEFAULT 0
)


CREATE TABLE COCODRILOS_COMEBACK.SUCURSAL (
	id			int IDENTITY(1,1) PRIMARY KEY,
	nombre		nvarchar(50),
	direccion	nvarchar(50),
	cod_postal	numeric(18,0),
	habilitado	int DEFAULT 0
)


CREATE TABLE COCODRILOS_COMEBACK.COBRADOR (
	dni					numeric(18,0) PRIMARY KEY,
	sucursal			int IDENTITY(1,1),
	username			nvarchar(35),
	cobrador_password	nvarchar(10),
	habilitado			int DEFAULT 0,
	FOREIGN KEY (dni) REFERENCES COCODRILOS_COMEBACK.USUARIO,
	FOREIGN KEY (sucursal) REFERENCES COCODRILOS_COMEBACK.SUCURSAL
)


CREATE TABLE COCODRILOS_COMEBACK.CLIENTE (
	dni			numeric(18,0) PRIMARY KEY,
	habilitado	int DEFAULT 0,
	FOREIGN KEY (dni) REFERENCES COCODRILOS_COMEBACK.USUARIO
)


CREATE TABLE COCODRILOS_COMEBACK.ADMINISTRADOR (
	dni				numeric(18,0) PRIMARY KEY,
	username		nvarchar(35),
	admin_password	nvarchar(10),
	habilitado		int DEFAULT 0,
	FOREIGN KEY (dni) REFERENCES COCODRILOS_COMEBACK.USUARIO
)


CREATE TABLE COCODRILOS_COMEBACK.ROL (
	id				int IDENTITY(1,1) PRIMARY KEY,
	descripcion		nvarchar(255) UNIQUE,
	habilitado		int DEFAULT 0
)


CREATE TABLE COCODRILOS_COMEBACK.ROL_USUARIO (
	id_usuario		numeric(18,0),
	id_rol			int,
	PRIMARY KEY(id_usuario, id_rol),
	FOREIGN KEY (id_usuario) REFERENCES COCODRILOS_COMEBACK.USUARIO,
	FOREIGN KEY (id_rol) REFERENCES COCODRILOS_COMEBACK.ROL
)


CREATE TABLE COCODRILOS_COMEBACK.FUNCIONALIDAD (
	id			int IDENTITY(1,1) PRIMARY KEY,
	descripcion	nvarchar(255)
)


CREATE TABLE COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD (
	id_rol				int,
	id_funcionalidad	int,
	PRIMARY KEY(id_rol, id_funcionalidad),
	FOREIGN KEY (id_rol) REFERENCES COCODRILOS_COMEBACK.ROL,
	FOREIGN KEY (id_funcionalidad) REFERENCES COCODRILOS_COMEBACK.FUNCIONALIDAD
)


CREATE TABLE COCODRILOS_COMEBACK.RUBRO (
	id				numeric(18,0) PRIMARY KEY,
	descripcion		nvarchar(50)
)


CREATE TABLE COCODRILOS_COMEBACK.EMPRESA (
	cuit		nvarchar(50) PRIMARY KEY,
	nombre		nvarchar(255),
	direccion	nvarchar(255),
	rubro		numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.RUBRO,
	habilitado	int DEFAULT 0
)


CREATE TABLE COCODRILOS_COMEBACK.FACTURA (
	numero			numeric(18,0) PRIMARY KEY,
	cliente			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.CLIENTE,
	empresa			nvarchar(50)  FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA,
	fecha_emision	datetime,
	fecha_vto		datetime,
	total			numeric(18,2),
	rendida			int DEFAULT 0
)


CREATE TABLE COCODRILOS_COMEBACK.ITEM_FACTURA (
	item_id			int,
	num_factura		numeric(18,0),
	descripcion		nvarchar(255),
	precio_unitario	numeric(18,2),
	cantidad		numeric(18,0),
	PRIMARY KEY (item_id, num_factura)
)

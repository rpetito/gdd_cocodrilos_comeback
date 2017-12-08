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

IF OBJECT_ID('COCODRILOS_COMEBACK.RENDICION_PAGO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.RENDICION_PAGO

IF OBJECT_ID('COCODRILOS_COMEBACK.RENDICION_PAGO_INCONSISTENCIAS') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.RENDICION_PAGO_INCONSISTENCIAS

IF OBJECT_ID('COCODRILOS_COMEBACK.REGISTRO_PAGO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.REGISTRO_PAGO

IF OBJECT_ID('COCODRILOS_COMEBACK.REGISTRO_PAGO_INCONSISTENCIAS') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.REGISTRO_PAGO_INCONSISTENCIAS

IF OBJECT_ID('COCODRILOS_COMEBACK.DEVOLUCION_FACTURA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.DEVOLUCION_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.ITEM_FACTURA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ITEM_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.FACTURA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.COBRADOR') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.COBRADOR

IF OBJECT_ID('COCODRILOS_COMEBACK.CLIENTE') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.CLIENTE

IF OBJECT_ID('COCODRILOS_COMEBACK.ADMINISTRADOR') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.ADMINISTRADOR

IF OBJECT_ID('COCODRILOS_COMEBACK.USUARIO_SUCURSAL') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.USUARIO_SUCURSAL

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

IF OBJECT_ID('COCODRILOS_COMEBACK.MEDIO_PAGO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.MEDIO_PAGO





--###########################################################################
	-------------------------------PROCEDURES----------------------------
--###########################################################################

IF OBJECT_ID('COCODRILOS_COMEBACK.CARGA_DATOS_INICIALES') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.CARGA_DATOS_INICIALES

IF OBJECT_ID('COCODRILOS_COMEBACK.INGRESAR_USUARIO') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.INGRESAR_USUARIO

IF OBJECT_ID('COCODRILOS_COMEBACK.INHABILITAR_USUARIO') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.INHABILITAR_USUARIO

IF OBJECT_ID('COCODRILOS_COMEBACK.FUNCIONALIDADES_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.FUNCIONALIDADES_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_CLIENTE') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_CLIENTE

IF OBJECT_ID('COCODRILOS_COMEBACK.BAJA_CLIENTE') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BAJA_CLIENTE

IF OBJECT_ID('COCODRILOS_COMEBACK.MODIFICAR_CLIENTE') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_CLIENTE 

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_CLIENTE') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_CLIENTE

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.BAJA_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BAJA_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.MODIFICAR_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_RUBROS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_RUBROS

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_SUCURSAL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_SUCURSAL

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_CLIENTE') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_CLIENTE

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_SUCURSAL_HABILITADA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_SUCURSAL_HABILITADA

IF OBJECT_ID('COCODRILOS_COMEBACK.BAJA_SUCURSAL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BAJA_SUCURSAL

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_TOTALIDAD') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_TOTALIDAD

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_SUCURSAL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_SUCURSAL

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.BAJA_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BAJA_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.MODIFICAR_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.REMOVER_FUNCIONALIDAD_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.REMOVER_FUNCIONALIDAD_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.AGREGAR_FUNCIONALIDAD_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.AGREGAR_FUNCIONALIDAD_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.HABILITAR_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.HABILITAR_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_ROLES') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_ROLES

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_FACTURA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_EMPRESAS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_EMPRESAS

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_FACTURAS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_FACTURAS

IF OBJECT_ID('COCODRILOS_COMEBACK.BAJA_FACTURA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BAJA_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_FALTANTES_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_FALTANTES_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.MODIFICAR_FACTURA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_FACTURA 

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_ITEMS_FACTURA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_ITEMS_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.REGISTRAR_PAGO_FACTURA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.REGISTRAR_PAGO_FACTURA

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_MEDIOS_PAGO') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_MEDIOS_PAGO

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_FACTURAS_MES') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_FACTURAS_MES

IF OBJECT_ID('COCODRILOS_COMEBACK.RENDICION') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.RENDICION

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_SUCURSAL_TOTALIDAD') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_SUCURSAL_TOTALIDAD

IF OBJECT_ID('COCODRILOS_COMEBACK.MODIFICAR_SUCURSAL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_SUCURSAL

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_FACTURAS_PAGAS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_FACTURAS_PAGAS

IF OBJECT_ID('COCODRILOS_COMEBACK.HACER_DEVOLUCION') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.HACER_DEVOLUCION

IF OBJECT_ID('COCODRILOS_COMEBACK.PORCENTAJE_FACTURAS_COBRADAS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.PORCENTAJE_FACTURAS_COBRADAS

IF OBJECT_ID('COCODRILOS_COMEBACK.EMPRESAS_MAYOR_MONTO_RENDIDO') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.EMPRESAS_MAYOR_MONTO_RENDIDO

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_SUCURSAL_DNI') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_SUCURSAL_DNI

IF OBJECT_ID('COCODRILOS_COMEBACK.ASIGNAR_USUARIO_SUCURSAL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ASIGNAR_USUARIO_SUCURSAL

IF OBJECT_ID('COCODRILOS_COMEBACK.ASIGNAR_USUARIO_ROL') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ASIGNAR_USUARIO_ROL

IF OBJECT_ID('COCODRILOS_COMEBACK.CLIENTES_MAS_PAGOS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.CLIENTES_MAS_PAGOS

IF OBJECT_ID('COCODRILOS_COMEBACK.CLIENTES_MAS_CUMPLIDORES') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.CLIENTES_MAS_CUMPLIDORES

IF OBJECT_ID('COCODRILOS_COMEBACK.PORCENTAJE_COBRADAS_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.PORCENTAJE_COBRADAS_EMPRESA



GO
--###########################################################################
	-------------------------------FUNCIONES-----------------------------
--###########################################################################
IF OBJECT_ID('COCODRILOS_COMEBACK.ID_SUCURSAL') IS NOT NULL
DROP FUNCTION COCODRILOS_COMEBACK.ID_SUCURSAL

IF OBJECT_ID('COCODRILOS_COMEBACK.ID_FORMA_PAGO') IS NOT NULL
DROP FUNCTION COCODRILOS_COMEBACK.ID_FORMA_PAGO

IF OBJECT_ID('COCODRILOS_COMEBACK.CANT_INTENTOS_LOGIN_FALLIDOS') IS NOT NULL
DROP FUNCTION COCODRILOS_COMEBACK.CANT_INTENTOS_LOGIN_FALLIDOS

IF OBJECT_ID('COCODRILOS_COMEBACK.STRING_SPLIT') IS NOT NULL
DROP FUNCTION COCODRILOS_COMEBACK.STRING_SPLIT

IF OBJECT_ID('COCODRILOS_COMEBACK.MESES_TRIMESTRE') IS NOT NULL
DROP FUNCTION COCODRILOS_COMEBACK.MESES_TRIMESTRE

IF OBJECT_ID('COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE') IS NOT NULL
DROP FUNCTION COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE





GO
--###########################################################################
	-------------------------------TRIGGERS------------------------------
--###########################################################################






--###########################################################################
	----------------------------------TYPES----------------------------------
--###########################################################################
DROP TYPE COCODRILOS_COMEBACK.LISTA_REGISTRO



GO
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
----------------------------CREACION DE TABLAS-------------------------------
--###########################################################################
--###########################################################################

CREATE TABLE COCODRILOS_COMEBACK.USUARIO (
	dni				numeric(18,0) PRIMARY KEY,
	nombre			nvarchar(255),
	apellido		nvarchar(255),
	username		nvarchar(35) NOT NULL UNIQUE,
	user_password	char(100) NOT NULL,
	mail			nvarchar(255) UNIQUE,
	login_fallidos	int DEFAULT 0,
	habilitado		bit DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.SUCURSAL (
	id			int IDENTITY(1,1) PRIMARY KEY,
	nombre		nvarchar(50),
	direccion	nvarchar(50),
	cod_postal	numeric(18,0) UNIQUE,
	habilitado	bit DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.CLIENTE (
	dni			numeric(18,0) PRIMARY KEY,
	nombre		nvarchar(255) NOT NULL,
	apellido	nvarchar(255) NOT NULL,
	fecha_nac	datetime NOT NULL,
	mail		nvarchar(255) NOT NULL,
	direccion	nvarchar(255) NOT NULL,
	telefono	nvarchar(40) NOT NULL DEFAULT '-',
	piso		int DEFAULT 0,
	dpto		nvarchar(10) DEFAULT '-',
	localidad	nvarchar(50) DEFAULT '-',
	cod_postal	nvarchar(255) NOT NULL,
	habilitado	bit DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.ROL (
	id				int IDENTITY(1,1) PRIMARY KEY,
	descripcion		nvarchar(255) UNIQUE,
	habilitado		bit DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.ROL_USUARIO (
	id_usuario		numeric(18,0),
	id_rol			int,
	habilitado		bit DEFAULT 1,
	PRIMARY KEY(id_usuario, id_rol),
	FOREIGN KEY (id_usuario) REFERENCES COCODRILOS_COMEBACK.USUARIO,
	FOREIGN KEY (id_rol) REFERENCES COCODRILOS_COMEBACK.ROL
)


CREATE TABLE COCODRILOS_COMEBACK.USUARIO_SUCURSAL (
	user_dni		numeric(18,0),
	user_rol_id		int,
	sucursal_id		int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.SUCURSAL,
	PRIMARY KEY(user_dni, user_rol_id, sucursal_id),
	FOREIGN KEY(user_dni, user_rol_id) REFERENCES COCODRILOS_COMEBACK.ROL_USUARIO
) 


CREATE TABLE COCODRILOS_COMEBACK.FUNCIONALIDAD (
	id			int IDENTITY(1,1) PRIMARY KEY,
	descripcion	nvarchar(255) UNIQUE
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
	descripcion		nvarchar(50) UNIQUE
)


CREATE TABLE COCODRILOS_COMEBACK.EMPRESA (
	cuit			nvarchar(50) PRIMARY KEY,
	nombre			nvarchar(255),
	direccion		nvarchar(255),
	dia_rendicion	int DEFAULT 28, 
	rubro			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.RUBRO,
	habilitado		bit DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.FACTURA (
	numero			numeric(18,0),
	cliente			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.CLIENTE ON UPDATE CASCADE,
	empresa			nvarchar(50)  FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	fecha_emision	datetime,
	fecha_vto		datetime,
	total			numeric(18,2),
	pagada			bit DEFAULT 0,
	rendida			bit DEFAULT 0,
	habilitada		bit DEFAULT 1
	PRIMARY KEY(numero, empresa)
)


CREATE TABLE COCODRILOS_COMEBACK.ITEM_FACTURA (
	item_id			int IDENTITY(1,1),
	fact_numero		numeric(18,0),
	fact_empresa	nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	precio_unitario	numeric(18,5),
	cantidad		numeric(18,0),
	PRIMARY KEY (item_id, fact_numero, fact_empresa),
	FOREIGN KEY (fact_numero, fact_empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA
)


CREATE TABLE COCODRILOS_COMEBACK.RENDICION_PAGO(
	rendicion_nro		numeric(18,0),
	cant_facturas		int,
	fecha_rendicion		datetime,
	importe_bruto		numeric(18,2),
	importe_neto		numeric(18,2),
	importe_comision	numeric(18,2),
	porcentaje_comision	numeric(18,2),
	fact_numero			numeric(18,0),
	rendicion_empresa	nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	PRIMARY KEY(rendicion_nro, fact_numero, rendicion_empresa),
	FOREIGN KEY(fact_numero, rendicion_empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA
)


CREATE TABLE COCODRILOS_COMEBACK.RENDICION_PAGO_INCONSISTENCIAS(
	inconsistencia_id	int IDENTITY(1,1) PRIMARY KEY,
	rendicion_nro		numeric(18,0),
	cant_facturas		int,
	fecha_rendicion		datetime,
	importe_bruto		numeric(18,2),
	importe_neto		numeric(18,2),
	importe_comision	numeric(18,2),
	porcentaje_comision	numeric(18,2),
	fact_numero			numeric(18,0),
	rendicion_empresa	nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	FOREIGN KEY(fact_numero, rendicion_empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA
)


CREATE TABLE COCODRILOS_COMEBACK.DEVOLUCION_FACTURA(
	fact_numero				numeric(18,0),
	fact_empresa			nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	dev_motivo				nvarchar(250) DEFAULT 'No especifica'
	PRIMARY KEY(fact_numero, fact_empresa),
	FOREIGN KEY(fact_numero, fact_empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA
)


CREATE TABLE COCODRILOS_COMEBACK.MEDIO_PAGO(
	id			int IDENTITY(1,1) PRIMARY KEY,
	descripcion	nvarchar(50) UNIQUE
)


CREATE TABLE COCODRILOS_COMEBACK.REGISTRO_PAGO(
	pago_id			numeric(18,0) PRIMARY KEY,
	fecha_pago		datetime,
	fact_numero		numeric(18,0),
	empresa			nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	cliente			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.CLIENTE ON UPDATE CASCADE,
	medio_pago_id	int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.MEDIO_PAGO ON UPDATE CASCADE,
	fecha_vto		datetime,
	importe_pago	numeric(20,2),
	sucursal		int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.SUCURSAL ON UPDATE CASCADE,
	FOREIGN KEY(fact_numero, empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA,
)


CREATE TABLE COCODRILOS_COMEBACK.REGISTRO_PAGO_INCONSISTENCIAS(
	incosistencia_id	int PRIMARY KEY IDENTITY(1,1),
	pago_id			numeric(18,0),
	fecha_pago		datetime,
	fact_numero		numeric(18,0),
	empresa			nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	cliente			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.CLIENTE ON UPDATE CASCADE,
	medio_pago_id	int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.MEDIO_PAGO ON UPDATE CASCADE,
	fecha_vto		datetime,
	importe_pago	numeric(20,2),
	sucursal		int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.SUCURSAL ON UPDATE CASCADE,
	FOREIGN KEY(fact_numero, empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA,
)




GO


--###########################################################################
--###########################################################################
--------------------------CREACION DE TIPOS LISTA----------------------------
--###########################################################################
--###########################################################################
CREATE TYPE COCODRILOS_COMEBACK.LISTA_REGISTRO
AS TABLE(
	fact_numero		numeric(18,0),
	fecha_pago		datetime,
	fecha_vto		datetime,
	cliente			numeric(18,0),
	empresa			nvarchar(50),
	importe_pago	numeric(20,2),
	sucursal		int,
	medio_pago_id	int
);
GO



--###########################################################################
--###########################################################################
---------------------------CREACION DE FUNCIONES-----------------------------
--###########################################################################
--###########################################################################
-----------------------------------------------------------------------------
--DEVUELVE EL ID DE LA SUCURSAL A PARTIR DE SU CODIGO POSTAL
-----------------------------------------------------------------------------
CREATE FUNCTION COCODRILOS_COMEBACK.ID_SUCURSAL(@codPos numeric(18,0))
RETURNS int
AS
BEGIN
	RETURN	(SELECT s.id
			FROM COCODRILOS_COMEBACK.SUCURSAL s
			WHERE s.cod_postal = @codPos)
END
GO


------------------------------------------------------------------------------
--DEVUELVE EL ID DEL MEDIO DE PAGO A PARTIR DE SU DESCRIPCION
------------------------------------------------------------------------------
CREATE FUNCTION COCODRILOS_COMEBACK.ID_FORMA_PAGO(@descripcion nvarchar(255))
RETURNS INT
AS
BEGIN
	RETURN (SELECT p.id
			FROM COCODRILOS_COMEBACK.MEDIO_PAGO p
			WHERE p.descripcion = @descripcion)
END
GO


------------------------------------------------------------------------------
--DEVUELVE CANTIDAD DE INTENTOS DE LOGGIN FALLIDOS PARA UN USUARIO DADO
------------------------------------------------------------------------------
CREATE FUNCTION COCODRILOS_COMEBACK.CANT_INTENTOS_LOGIN_FALLIDOS(@username char(35), @password char(100))
RETURNS int
AS
BEGIN

	RETURN (SELECT u.LOGIN_FALLIDOS
			FROM COCODRILOS_COMEBACK.USUARIO u
			WHERE u.USERNAME = @username AND
				  u.USER_PASSWORD = HASHBYTES('SHA2_256', @password)
			)

END
GO 


------------------------------------------------------------------------
---------------------------STRING SPLIT---------------------------------
------------------------------------------------------------------------
CREATE FUNCTION COCODRILOS_COMEBACK.STRING_SPLIT( @stringToSplit nvarchar(255), @character char(1))
RETURNS
 @returnList TABLE ([Name] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX(@character, @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX(@character, @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name

  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END
GO


----------------------------------------------------------------------------

----------------------------------------------------------------------------
CREATE FUNCTION COCODRILOS_COMEBACK.MESES_TRIMESTRE(@trimestre int)
RETURNS @list TABLE (firstMonth	int, secondMonth int, thirdMonth int)
AS
BEGIN


	IF @trimestre = 1
		INSERT INTO @list VALUES (1, 2, 3)
	IF @trimestre = 2 
		INSERT INTO @list VALUES (4, 5, 6)
	IF @trimestre = 3
		INSERT INTO @list VALUES (7, 8, 9)
	IF @trimestre = 4
		INSERT INTO @list VALUES (10, 11, 12)

	RETURN

END
GO


CREATE FUNCTION COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(@fecha datetime, @trimestre int)
RETURNS BIT
AS
BEGIN

	DECLARE @result bit

	IF ((SELECT COUNT(*) 
				 FROM COCODRILOS_COMEBACK.MESES_TRIMESTRE(@trimestre)
				 WHERE	firstMonth = MONTH(@fecha) OR 
						secondMonth = MONTH(@fecha) OR 
						thirdMonth = MONTH(@fecha))) = 1 
		SET @result = 1
	ELSE 
		SET @result = 0

	RETURN @result
END
GO




--###########################################################################
--###########################################################################
-------------CREACION DE PROCEDURES AUXILIARES (NO FUNCIONALES)--------------
--###########################################################################
--###########################################################################

-----------------------------------------------------------------------------
----------------------------INHABILITAR USUARIO------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.INHABILITAR_USUARIO(@dni numeric(18,0)) 
AS
BEGIN TRY

	UPDATE COCODRILOS_COMEBACK.USUARIO
	SET habilitado = 0
	WHERE dni = @dni

	SELECT @@ERROR

END TRY
BEGIN CATCH 
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
---------------------------FUNCIONALIDADES POR ROL---------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.FUNCIONALIDADES_ROL(@rol int)
AS
BEGIN TRY

	SELECT f.id, f.descripcion
	FROM COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD rf JOIN
		 COCODRILOS_COMEBACK.FUNCIONALIDAD f ON rf.id_funcionalidad = f.id
	WHERE rf.id_rol = @rol

END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
-----------------------------BUSCAR CLIENTE----------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.BUSCAR_CLIENTE(
	@nombre nvarchar(255) = NULL,
	@apellido nvarchar(255) = NULL, 
	@dni numeric(18,0) = NULL,
	@habilitado bit = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.CLIENTE c
	WHERE	(@nombre IS NULL OR c.nombre = @nombre) AND
			(@apellido IS NULL OR c.apellido = @apellido) AND
			(@dni IS NULL OR c.dni = @dni) AND
			(@habilitado IS NULL OR c.habilitado = @habilitado)

END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
------------------------------BUSCAR EMPRESA---------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA(
	@nombre nvarchar(255) = NULL,
	@rubro numeric(18,0) = NULL, 
	@cuit nvarchar(50) = NULL,
	@habilitada bit = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.EMPRESA e
	WHERE	(@nombre IS NULL OR e.nombre = @nombre) AND
			(@rubro IS NULL OR e.rubro = @rubro) AND
			(@cuit IS NULL OR e.cuit = @cuit) AND
			(@habilitada IS NULL OR e.habilitado = @habilitada)
END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
---------------------------OBTENER FUNCIONALIDADES----------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_TOTALIDAD
AS
BEGIN TRY
	SELECT *
	FROM COCODRILOS_COMEBACK.FUNCIONALIDAD
END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
-------------------------------HABILITAR ROL---------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.HABILITAR_ROL(@rolID int) 
AS
BEGIN TRY
	UPDATE COCODRILOS_COMEBACK.ROL
	SET habilitado = 1
	WHERE id = @rolID

	SELECT @@ROWCOUNT
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
-------------------------------OBTENER ROLES---------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_ROLES(@nombre nvarchar(255) = NULL, @habilitado bit = NULL)
AS
BEGIN TRY
	SELECT *
	FROM COCODRILOS_COMEBACK.ROL r
	WHERE	(@nombre IS NULL OR r.descripcion = @nombre) AND
			@habilitado IS NULL OR r.habilitado = @habilitado
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
-------------------------------OBTENER RUBROS--------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_RUBROS
AS
BEGIN TRY
	SELECT *
	FROM COCODRILOS_COMEBACK.RUBRO
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

-----------------------------------------------------------------------------
------------------OBTENER FUNCIONALIDADES POR ROL----------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_FUNCIONALIDADES_ROL(@idRol int)
AS
BEGIN TRY
	SELECT f.id, f.descripcion
	FROM COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD rf join COCODRILOS_COMEBACK.FUNCIONALIDAD f on rf.id_funcionalidad = f.id
	WHERE rf.id_rol = @idRol
END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

------------------------------------------------------------------------------
--------------------BUSCAR SUCURSAL HABILITADA--------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.BUSCAR_SUCURSAL_HABILITADA(
	@nombre nvarchar(255) = NULL,
	@direccion nvarchar(255) = NULL, 
	@cod_postal numeric(18,0) = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.SUCURSAL S
	WHERE	(@nombre IS NULL OR S.nombre = @nombre) AND
			(@direccion IS NULL OR s.direccion = @direccion) AND
			(@cod_postal IS NULL OR s.cod_postal = @cod_postal) AND
			(S.habilitado = 1)


END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

------------------------------------------------------------------------------
--------------------BUSCAR SUCURSAL TOTALIDAD--------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.BUSCAR_SUCURSAL_TOTALIDAD(
	@nombre nvarchar(255) = NULL,
	@direccion nvarchar(255) = NULL, 
	@cod_postal numeric(18,0) = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.SUCURSAL S
	WHERE	(@nombre IS NULL OR S.nombre = @nombre) AND
			(@direccion IS NULL OR s.direccion = @direccion) AND
			(@cod_postal IS NULL OR s.cod_postal = @cod_postal)
			


END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
--------------------------OBTENER EMPRESAS-----------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_EMPRESAS(@habilitada bit = NULL)
AS 
BEGIN TRY
	SELECT * 
	FROM COCODRILOS_COMEBACK.EMPRESA 
	WHERE @habilitada IS NULL OR habilitado = @habilitada
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
--------------------------OBTENER FACTURAS-----------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_FACTURAS(
	@numero		numeric(18,0) = NULL,
	@empresa	nvarchar(50) = NULL,
	@pagada		bit = NULL,
	@rendida	bit = NULL,
	@habilitada bit = NULL
)
AS
BEGIN TRY
	SELECT *
	FROM COCODRILOS_COMEBACK.FACTURA f
	WHERE	(@numero IS NULL OR f.numero = @numero) AND
			(@empresa IS NULL OR f.empresa = @empresa) AND
			(@pagada IS NULL OR f.pagada = @pagada) AND
			(@rendida IS NULL OR f.rendida = @rendida) AND
			(@habilitada IS NULL OR f.habilitada = @habilitada)
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

-----------------------------------------------------------------------------
-------------------------OBTENER ITEMS DE FACTURA----------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_ITEMS_FACTURA(@factura numeric(18,0), @empresa nvarchar(50))
AS
BEGIN TRY
	SELECT i.item_id, i.precio_unitario, i.cantidad
	FROM COCODRILOS_COMEBACK.ITEM_FACTURA i
	WHERE i.fact_empresa = @empresa AND i.fact_numero = @factura
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
-------------------------OBTENER ITEMS DE FACTURA----------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_MEDIOS_PAGO
AS
BEGIN TRY
	SELECT * FROM COCODRILOS_COMEBACK.MEDIO_PAGO
END TRY
BEGIN CATCH

END CATCH
GO

-------------------------OBTENER FACTURAS DE UN MES--------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_FACTURAS_MES(@empresa nvarchar(50), @mes int)
AS
BEGIN TRY
	SELECT rp.fact_numero, rp.fecha_pago, rp.empresa, rp.importe_pago, e.dia_rendicion
	FROM COCODRILOS_COMEBACK.REGISTRO_PAGO rp join COCODRILOS_COMEBACK.EMPRESA e on rp.empresa = e.cuit
	WHERE rp.empresa = @empresa AND MONTH(rp.fecha_pago) = @mes
END TRY
BEGIN CATCH
	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

-------------------------------------------------------------------------
-------------------------OBTENER SUCURSALES POR USUARIO------------------
-------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_SUCURSAL_DNI(
		@user_dni decimal(18,0)
		)
		AS
		BEGIN TRY
			SELECT s.id, s.nombre, s.direccion, s.cod_postal, s.habilitado FROM COCODRILOS_COMEBACK.USUARIO_SUCURSAL us JOIN COCODRILOS_COMEBACK.SUCURSAL s on us.sucursal_id = s.id  WHERE us.user_dni = @user_dni AND s.habilitado = 1
		END TRY
		BEGIN CATCH
			THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
		END CATCH
		GO

-------------------------------------------------------------------------
-------------------------ASIGNAR USUARIO A SUCURSAL------------------
-------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.ASIGNAR_USUARIO_SUCURSAL(
		@user_dni decimal(18,0),
		@user_rol_id int,
		@sucursa_id int
		)
		AS
		BEGIN TRY

		INSERT INTO COCODRILOS_COMEBACK.USUARIO_SUCURSAL(
			user_dni,
			user_rol_id,
			sucursal_id
		) VALUES (
			@user_dni,
			@user_rol_id,
			@sucursa_id
		)
		
		SELECT @@ERROR

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO

-------------------------------------------------------------------------
-------------------------ASIGNAR USUARIO A ROL---------------------------
-------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.ASIGNAR_USUARIO_ROL(
		@id_usuario decimal(18,0),
		@id_rol int,
		@habilitado bit
		)
		AS
		BEGIN TRY

		INSERT INTO COCODRILOS_COMEBACK.ROL_USUARIO(
			id_usuario,
			id_rol,
			habilitado
		) VALUES (
			@id_usuario,
			@id_rol,
			@habilitado
		)

		SELECT @@ERROR

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO



--###########################################################################
--###########################################################################
----------------------------CREACION DE TRIGGERS-----------------------------
--###########################################################################
--###########################################################################





--###########################################################################
	---------------------CARGA DE DATOS INICIALES-----------------------
--###########################################################################

CREATE PROCEDURE COCODRILOS_COMEBACK.CARGA_DATOS_INICIALES 
AS
BEGIN

	
	--ROLES
	INSERT INTO COCODRILOS_COMEBACK.ROL(
		descripcion
	) VALUES ('admin')

	INSERT INTO COCODRILOS_COMEBACK.ROL(
		descripcion
	) VALUES ('cobrador')


	--FUNCIONALIDADES
	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('ABM Clientes')
	
	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('ABM Empresas')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('ABM Sucursales')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('ABM Facturas')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('Registro Pago de Facturas')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('Rendición Facturas Cobradas')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('Devoluciones')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('Listado Estadístico')

	INSERT INTO COCODRILOS_COMEBACK.FUNCIONALIDAD(
		descripcion
	) VALUES ('ABM Rol')


	--FUNCIONALIDADES A ROLES
	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,1)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,2)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,3)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,4)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,5)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,6)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,7)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,8)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (1,9)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (2,5)

	INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD(
		id_rol,
		id_funcionalidad
	) VALUES (2,7)


	--USUARIO ADMIN
	INSERT INTO COCODRILOS_COMEBACK.USUARIO(
		dni,
		nombre,
		username,
		user_password
	) VALUES (0, 'Administrador General', 'admin', HASHBYTES('SHA2_256', CONVERT(char(100),'w23e')))


	INSERT INTO COCODRILOS_COMEBACK.ROL_USUARIO(
		id_usuario,
		id_rol
	) VALUES (0, 1)


END
GO

EXEC('COCODRILOS_COMEBACK.CARGA_DATOS_INICIALES')
GO




--###########################################################################
--###########################################################################
---------------------------------MIGRACION-----------------------------------
--###########################################################################
--###########################################################################

----------------------------------------------------------------------------
--------------------------------CLIENTE-------------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.CLIENTE (
	dni,
	apellido,
	nombre,
	fecha_nac,
	mail,
	direccion,
	cod_postal
)	SELECT  DISTINCT(m.[Cliente-Dni]), 
			m.[Cliente-Apellido],
			m.[Cliente-Nombre],
			m.[Cliente-Fecha_Nac],
			m.Cliente_Mail,
			m.Cliente_Direccion,
			m.Cliente_Codigo_Postal
			FROM gd_esquema.Maestra m
			ORDER BY m.[Cliente-Dni]


----------------------------------------------------------------------------
---------------------------------RUBRO--------------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.RUBRO (
	id,
	descripcion
)	SELECT	DISTINCT(m.Empresa_Rubro),
			m.Rubro_Descripcion
	FROM gd_esquema.Maestra m
	WHERE m.Empresa_Rubro IS NOT NULL


----------------------------------------------------------------------------
--------------------------------EMPRESA-------------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.EMPRESA (
	cuit,
	nombre,
	direccion,
	rubro
)	SELECT	DISTINCT(m.Empresa_Cuit),
			m.Empresa_Nombre,
			m.Empresa_Direccion,
			m.Empresa_Rubro
	FROM gd_esquema.Maestra m


----------------------------------------------------------------------------
----------------------------MEDIOS DE PAGO----------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.MEDIO_PAGO (
	descripcion
)	SELECT DISTINCT(m.FormaPagoDescripcion) 
	FROM gd_esquema.Maestra m 
	WHERE m.FormaPagoDescripcion IS NOT NULL


----------------------------------------------------------------------------
-------------------------------SUCURSAL-------------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.SUCURSAL (
	nombre,
	direccion,
	cod_postal
)	SELECT	DISTINCT(m.Sucursal_Nombre),
			m.Sucursal_Dirección,
			m.Sucursal_Codigo_Postal
	FROM gd_esquema.Maestra m
	WHERE m.Sucursal_Nombre IS NOT NULL


----------------------------------------------------------------------------
-------------------------------FACTURA--------------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.FACTURA (
	numero,
	cliente,
	empresa,
	fecha_emision,
	fecha_vto,
	total,
	pagada,
	rendida
)	SELECT	m.Nro_Factura,
			m.[Cliente-Dni],
			m.Empresa_Cuit,
			m.Factura_Fecha,
			m.Factura_Fecha_Vencimiento,
			m.Factura_Total,
			CASE WHEN (	SELECT count(*)
						FROM gd_esquema.Maestra m2 
						WHERE m.Nro_Factura = m2.Nro_Factura AND m2.Pago_nro IS NOT NULL 
						GROUP BY m2.Nro_Factura) > 0 
				THEN 1 ELSE 0 END,
			CASE WHEN (	SELECT count(*) 
						FROM gd_esquema.Maestra m2 
						WHERE m.Nro_Factura = m2.Nro_Factura AND m2.Rendicion_Nro IS NOT NULL 
						GROUP BY m2.Nro_Factura) > 0 
				THEN 1 ELSE 0 END
	FROM	gd_esquema.Maestra m
	GROUP BY	Nro_Factura, 
				[Cliente-Dni], 
				Empresa_Cuit,
				Factura_Fecha, 
				Factura_Fecha_Vencimiento, 
				Factura_Total
	ORDER BY Nro_Factura


----------------------------------------------------------------------------
--------------------------REGISTRO DE PAGOS---------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.REGISTRO_PAGO (
	pago_id,
	fact_numero,
	fecha_pago,
	empresa,
	cliente,
	medio_pago_id,
	fecha_vto,
	importe_pago,
	sucursal
)	SELECT	Pago_nro,
			Nro_Factura,
			Pago_Fecha,
			Empresa_Cuit,
			[Cliente-Dni],
			COCODRILOS_COMEBACK.ID_FORMA_PAGO(FormaPagoDescripcion),
			Factura_Fecha_Vencimiento,
			Factura_Total,
			COCODRILOS_COMEBACK.ID_SUCURSAL(Sucursal_Codigo_Postal)
	 FROM	gd_esquema.Maestra
	 WHERE	Nro_Factura IS NOT NULL AND
			Pago_Fecha IS NOT NULL AND
			Empresa_Cuit IS NOT NULL AND
			[Cliente-Dni] IS NOT NULL AND
			FormaPagoDescripcion IS NOT NULL AND
			Factura_Fecha_Vencimiento IS NOT NULL AND
			Factura_Total IS NOT NULL AND
			Sucursal_Codigo_Postal IS NOT NULL AND
			Nro_Factura IN (SELECT f.numero
							FROM COCODRILOS_COMEBACK.FACTURA f
							WHERE f.pagada = 1)
	 GROUP BY	Pago_nro, Nro_Factura, Pago_Fecha, Empresa_Cuit, 
				[Cliente-Dni], FormaPagoDescripcion, Factura_Fecha_Vencimiento, 
				Factura_Total, Sucursal_Codigo_Postal


----------------------------------------------------------------------------
-------------------REGISTRO DE PAGOS INCOSISTENCIAS-------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.REGISTRO_PAGO_INCONSISTENCIAS (
	pago_id,
	fact_numero,
	fecha_pago,
	empresa,
	cliente,
	medio_pago_id,
	fecha_vto,
	importe_pago,
	sucursal
) 	SELECT	Pago_nro,
			Nro_Factura,
			Pago_Fecha,
			Empresa_Cuit,
			[Cliente-Dni],
			COCODRILOS_COMEBACK.ID_FORMA_PAGO(FormaPagoDescripcion),
			Factura_Fecha_Vencimiento,
			Factura_Total,
			COCODRILOS_COMEBACK.ID_SUCURSAL(Sucursal_Codigo_Postal)
	FROM gd_esquema.Maestra
	WHERE Nro_Factura NOT IN (SELECT f.fact_numero FROM COCODRILOS_COMEBACK.REGISTRO_PAGO f)
	GROUP BY	Pago_nro, Nro_Factura, Pago_Fecha, Empresa_Cuit, 
				[Cliente-Dni], FormaPagoDescripcion, Factura_Fecha_Vencimiento, 
				Factura_Total, Sucursal_Codigo_Postal



----------------------------------------------------------------------------
-------------------------RENDICION DE PAGOS---------------------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.RENDICION_PAGO (
	rendicion_nro,
	cant_facturas,
	fact_numero,
	fecha_rendicion,
	importe_bruto,
	importe_neto,
	importe_comision,
	porcentaje_comision,
	rendicion_empresa
)	SELECT	m.Rendicion_Nro,
			(SELECT COUNT(DISTINCT(m2.Nro_Factura)) 
			 FROM gd_esquema.Maestra m2 
			 WHERE m2.Rendicion_Nro = m.Rendicion_Nro 
			 GROUP BY m2.Rendicion_Nro),
			m.Nro_Factura,
			m.Factura_Fecha_Vencimiento,
			SUM(m.Factura_Total),
			SUM(m.Factura_Total) - SUM(m.ItemRendicion_Importe), 
			SUM(m.ItemRendicion_Importe),
			(SUM(m.ItemRendicion_Importe) / SUM(m.Factura_Total)) * 100,
			m.Empresa_Cuit Empresa
	FROM gd_esquema.Maestra m
	WHERE	m.Nro_Factura IN (SELECT f.numero FROM COCODRILOS_COMEBACK.FACTURA f WHERE f.rendida = 1) AND
			m.Rendicion_Nro IS NOT NULL AND
			m.Factura_Fecha IS NOT NULL AND
			m.Factura_Total IS NOT NULL AND
			m.ItemRendicion_Importe IS NOT NULL AND
			m.Empresa_Cuit IS NOT NULL
	GROUP BY m.Rendicion_Nro, MONTH(m.Rendicion_Fecha), m.Empresa_Cuit, m.Nro_Factura, m.Factura_Fecha_Vencimiento


----------------------------------------------------------------------------
--------------------RENDICION DE PAGOS INCOSISTENCIAS-----------------------
----------------------------------------------------------------------------
INSERT INTO COCODRILOS_COMEBACK.RENDICION_PAGO_INCONSISTENCIAS (
	rendicion_nro,
	cant_facturas,
	fact_numero,
	fecha_rendicion,
	importe_bruto,
	importe_neto,
	importe_comision,
	porcentaje_comision,
	rendicion_empresa
) SELECT	m.Rendicion_Nro,
			ISNULL(	(SELECT COUNT(DISTINCT(m2.Nro_Factura)) 
					 FROM gd_esquema.Maestra m2 
					 WHERE m2.Rendicion_Nro = m.Rendicion_Nro 
					 GROUP BY m2.Rendicion_Nro), 0),
					 m.Nro_Factura,
			m.Factura_Fecha_Vencimiento,
			SUM(ISNULL(m.Factura_Total,0)),
			SUM(ISNULL(m.Factura_Total,0)) - SUM(ISNULL(m.ItemRendicion_Importe,0)), 
			SUM(ISNULL(m.ItemRendicion_Importe,0)),
			(SUM(ISNULL(m.ItemRendicion_Importe,0)) / SUM(ISNULL(m.Factura_Total,1))) * 100,
			m.Empresa_Cuit Empresa
	FROM gd_esquema.Maestra m
	GROUP BY m.Rendicion_Nro, MONTH(m.Rendicion_Fecha), m.Empresa_Cuit, m.Nro_Factura, m.Factura_Fecha_Vencimiento
	HAVING m.Nro_Factura NOT IN (SELECT r.fact_numero FROM COCODRILOS_COMEBACK.RENDICION_PAGO r)


----------------------------------------------------------------------------
----------------------------ITEM FACTURA------------------------------------
----------------------------------------------------------------------------
DECLARE @fact_numero		numeric(18,0)
DECLARE @fact_total			numeric(18,2)		
DECLARE @item_monto			numeric(18,2)
DECLARE @item_cant			numeric(18,0)
DECLARE @fact_empresa		nvarchar(50)
DECLARE @sum_monto_act		numeric(18,2)
DECLARE @fact_numero_act	numeric(18,0)

DECLARE c_items CURSOR FOR 
	SELECT TOP 500 m.Nro_Factura, m.Factura_Total, m.ItemFactura_Monto, m.ItemFactura_Cantidad, m.Empresa_Cuit
	FROM gd_esquema.Maestra m
	ORDER BY m.Nro_Factura

OPEN c_items
FETCH NEXT FROM c_items INTO @fact_numero, @fact_total, @item_monto, @item_cant, @fact_empresa

SET @fact_numero_act = @fact_numero

WHILE(@@FETCH_STATUS = 0)
	BEGIN
		SET @sum_monto_act = 0
		WHILE(@@FETCH_STATUS = 0 AND @fact_numero_act = @fact_numero)
			BEGIN
				WHILE(@@FETCH_STATUS = 0 AND @sum_monto_act < @fact_total)
					BEGIN
						SET @sum_monto_act = @sum_monto_act + ISNULL(@item_monto, 0)
						INSERT INTO COCODRILOS_COMEBACK.ITEM_FACTURA (
							fact_numero,
							fact_empresa,
							precio_unitario,
							cantidad
						) VALUES (
							@fact_numero,
							@fact_empresa,
							(@item_monto / @item_cant),
							@item_cant
						)
						FETCH NEXT FROM c_items INTO @fact_numero, @fact_total, @item_monto, @item_cant, @fact_empresa
					END
				FETCH NEXT FROM c_items INTO @fact_numero, @fact_total, @item_monto, @item_cant, @fact_empresa
			END
		SET @fact_numero_act = @fact_numero
	END

CLOSE c_items
DEALLOCATE c_items




GO
--###########################################################################
--###########################################################################
------------------------------FUNCIONALIDADES--------------------------------
--###########################################################################
--###########################################################################
---------------------------------------------------
-------------------LOGIN USUARIO-------------------
---------------------------------------------------

CREATE PROCEDURE COCODRILOS_COMEBACK.INGRESAR_USUARIO (
	@username char(35),
	@password char(100)
) 
AS
BEGIN

	DECLARE @status int = 999;
	DECLARE @userDNI numeric(18,0);

	IF EXISTS (	
		SELECT u.USERNAME
		FROM COCODRILOS_COMEBACK.USUARIO u
		WHERE u.USERNAME = @username AND u.habilitado = 1
		) 

		BEGIN
			IF (SELECT u.USER_PASSWORD
				FROM COCODRILOS_COMEBACK.USUARIO u
				WHERE u.USERNAME = @username) = HASHBYTES('SHA2_256', @password)
					BEGIN
						IF( COCODRILOS_COMEBACK.CANT_INTENTOS_LOGIN_FALLIDOS(@username, @password) < 3)
							BEGIN
								UPDATE COCODRILOS_COMEBACK.USUARIO
								SET login_fallidos = 0
								WHERE username = @username

								SET @status = @@ERROR
							END
						ELSE
							BEGIN

								SET @userDNI = (SELECT u.DNI
											    FROM COCODRILOS_COMEBACK.USUARIO u 
											    WHERE u.USERNAME = @username 
													  AND u.USER_PASSWORD = @password
												)
								
								EXEC COCODRILOS_COMEBACK.INHABILITAR_USUARIO @userDNI
								SET @status = 999   --USUARIO INHABILITADO
							END
					END;
			ELSE
				BEGIN
					UPDATE COCODRILOS_COMEBACK.USUARIO 
					SET LOGIN_FALLIDOS = LOGIN_FALLIDOS + 1
					WHERE USERNAME = @username

					SET @status = 1001; --CONSTRASEÑA INCORRECTA
				END;
		END;
	ELSE
		IF EXISTS (	
			SELECT u.USERNAME
			FROM COCODRILOS_COMEBACK.USUARIO u
			WHERE u.USERNAME = @username 
		)
			SET @status = 999; --USUARIO INHABILITADO
		ELSE 
			SET @status = 1002; --USUARIO NO REGISTRADO

	IF(@status = 0) --USUARIO EXISTE Y DEVUELVE LISTADO DE ROLES HABILITADOS
		SELECT r.ID_USUARIO, r.ID_ROL, rol.DESCRIPCION, r.habilitado
		FROM COCODRILOS_COMEBACK.ROL_USUARIO r JOIN COCODRILOS_COMEBACK.ROL rol ON r.ID_ROL = rol.ID
		WHERE r.ID_USUARIO = (SELECT u.DNI
									FROM COCODRILOS_COMEBACK.USUARIO u 
									WHERE u.USERNAME = @username
										  and r.habilitado = 1
									);
	ELSE
		SELECT @status;

END
GO


---------------------------------------------------
-------------------ABM CLIENTES--------------------
---------------------------------------------------

	---------------------------------------------------
	-----------------------ALTA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.ALTA_CLIENTE(
		@dni		numeric(18,0),
		@nombre		nvarchar(255),
		@apellido	nvarchar(255),
		@fecha_nac	datetime,
		@mail		nvarchar(255),
		@direccion	nvarchar(255),
		@telefono   nvarchar(50),
		@piso		int,
		@dpto		nvarchar(10),
		@localidad	nvarchar(50),
		@cod_postal	nvarchar(255)
	) 
	AS 
	BEGIN TRY

		CREATE TABLE #errores (
			message nvarchar(255)
		)
		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.dni = @dni) > 0
			INSERT INTO #errores VALUES (CONCAT('Cliente con DNI ', @dni, ' ya existente.'))

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.mail = @mail) > 0
			INSERT INTO #errores VALUES (CONCAT('Cliente con mail ', @mail, ' ya existente.'))

		IF(SELECT COUNT(*) FROM #errores) = 1
			BEGIN
				INSERT INTO COCODRILOS_COMEBACK.CLIENTE (
					dni,
					nombre,
					apellido,
					fecha_nac,
					mail,
					direccion,
					telefono,
					piso,
					dpto,
					localidad,
					cod_postal
				) VALUES (
					@dni,
					@nombre,
					@apellido,
					@fecha_nac,
					@mail,
					@direccion,
					@telefono,
					@piso,
					@dpto,
					@localidad,
					@cod_postal
				)

			SELECT @@ERROR
		END
	ELSE
		SELECT * FROM #errores

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-----------------------BAJA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.BAJA_CLIENTE(@dni numeric(18,0))
	AS
	BEGIN TRY
		UPDATE COCODRILOS_COMEBACK.CLIENTE
		SET habilitado = 0
		WHERE dni = @dni
		
		SELECT @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-------------------MODIFICACION--------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_CLIENTE(
		@oldDni		numeric(18,0),
		@newDni		numeric(18,0),
		@nombre		nvarchar(255),
		@apellido	nvarchar(255),
		@fecha_nac	datetime,
		@mail		nvarchar(255),
		@direccion	nvarchar(255),
		@telefono	nvarchar(50),
		@piso		int,
		@dpto		nvarchar(10),
		@localidad	nvarchar(50),
		@cod_postal	nvarchar(255),
		@habilitado bit
	) 
	AS
	BEGIN TRY 

		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.dni = @oldDni) = 0
			BEGIN
				INSERT INTO #errores VALUES (CONCAT('Ciente con DNI ', @oldDni, ' que se desea modificar no existe.'))
				SELECT * FROM #errores
			END
		ELSE 
			BEGIN
				IF(@newDni <> @oldDni AND (SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.dni = @newDni) > 0)
					INSERT INTO #errores VALUES (CONCAT('Cliente con DNI ', @newDni, ' ya existente.'))

				IF(@newDni <> @oldDni AND (SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.mail = @mail) > 0)
					INSERT INTO #errores VALUES (CONCAT('Cliente con mail ', @mail, ' ya existente.'))

				IF(SELECT COUNT(*) FROM #errores) = 1
					BEGIN
						UPDATE COCODRILOS_COMEBACK.CLIENTE
						SET 
							dni = @newDni,
							nombre = @nombre,
							apellido = @apellido,
							fecha_nac = @fecha_nac,
							mail = @mail,
							direccion = @direccion,
							telefono = @telefono,
							piso = @piso,
							dpto = @dpto,
							localidad = @localidad,
							cod_postal = @cod_postal,
							habilitado = @habilitado
						WHERE dni = @oldDni

						SELECT @@ROWCOUNT
					END
				ELSE
					SELECT * FROM #errores
			END

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH

	GO


---------------------------------------------------
-------------------ABM EMPRESA---------------------
---------------------------------------------------

	---------------------------------------------------
	-----------------------ALTA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.ALTA_EMPRESA(
		@cuit		nvarchar(50),
		@nombre		nvarchar(255),
		@direccion	nvarchar(255),
		@rubro		numeric(18,0),
		@diaRendicion int
	) 
	AS 
	BEGIN TRY

		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.EMPRESA e WHERE e.cuit = @cuit) > 0
			INSERT INTO #errores VALUES (CONCAT('La empresa con CUIT ', @cuit, ' ya existe.'))

		IF(SELECT COUNT(*) FROM #errores) = 1
			BEGIN
				INSERT INTO COCODRILOS_COMEBACK.EMPRESA (
					cuit,
					nombre,
					direccion,
					dia_rendicion,
					rubro
				) VALUES (
					@cuit,
					@nombre,
					@direccion,
					@diaRendicion,
					@rubro
				)

				SELECT @@ERROR
			END
		ELSE
			SELECT * FROM #errores

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-----------------------BAJA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.BAJA_EMPRESA(@cuit nvarchar(50))
	AS
	BEGIN TRY
		UPDATE COCODRILOS_COMEBACK.EMPRESA
		SET habilitado = 0
		WHERE cuit = @cuit
		
		SELECT @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-------------------MODIFICACION--------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_EMPRESA(
		@oldCuit		nvarchar(50),
		@newCuit		nvarchar(50),
		@nombre			nvarchar(255),
		@direccion		nvarchar(255),
		@fecRendicion	int,
		@rubro			numeric(18,0),
		@habilitado		bit
	) 
	AS
	BEGIN TRY 

		
		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.EMPRESA e WHERE e.cuit = @oldCuit) = 0
			BEGIN
				INSERT INTO #errores VALUES (CONCAT('La empresa con CUIT ', @oldCuit, ' que se desea modificar, no existe.'))
				SELECT * FROM #errores
			END
		ELSE
			BEGIN

				IF(@newCuit <> @oldCuit AND  (SELECT COUNT(*) FROM COCODRILOS_COMEBACK.EMPRESA e WHERE e.cuit = @newCuit) > 0)
					INSERT INTO #errores VALUES (CONCAT('La empresa con CUIT ', @newCuit, ' ya existe.'))

	
				IF(SELECT COUNT(*) FROM #errores) = 1
					BEGIN
						UPDATE COCODRILOS_COMEBACK.EMPRESA
						SET 
							cuit = @newCuit,
							nombre = @nombre,
							direccion = @direccion,
							dia_rendicion = @fecRendicion,
							rubro = @rubro,
							habilitado = @habilitado
						WHERE cuit = @oldCuit

						SELECT @@ROWCOUNT
					END
				ELSE 
					SELECT * FROM #errores
			END

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO



---------------------------------------------------
-------------------ABM SUCURSAL---------------------
---------------------------------------------------

	---------------------------------------------------
	-----------------------ALTA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.ALTA_SUCURSAL(
		@nombre		nvarchar(255),
		@direccion	nvarchar(255),
		@cod_postal	numeric(18,0)
	) 
	AS 
	BEGIN TRY

		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.SUCURSAL s WHERE s.cod_postal = @cod_postal) > 0
			INSERT INTO #errores VALUES (CONCAT('La sucursal con código postal ', @cod_postal, ' ya existe.'))
		
		IF(SELECT COUNT(*) FROM #errores) = 1
			BEGIN
				INSERT INTO COCODRILOS_COMEBACK.SUCURSAL(
					nombre,
					direccion,
					cod_postal
				) VALUES (
					@nombre,
					@direccion,
					@cod_postal
				)

				SELECT @@ERROR
			END
		ELSE
			SELECT * FROM #errores

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-----------------------BAJA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.BAJA_SUCURSAL(@idSucursal int)
	AS
	BEGIN TRY
		UPDATE COCODRILOS_COMEBACK.SUCURSAL
		SET habilitado = 0
		WHERE id = @idSucursal

		update COCODRILOS_COMEBACK.ROL_USUARIO
		SET habilitado = 0 
		WHERE id_usuario IN (SELECT U.dni
					  FROM USUARIO_SUCURSAL US JOIN USUARIO U ON US.user_dni = U.dni JOIN ROL_USUARIO RU ON RU.id_usuario = U.dni
					  WHERE US.sucursal_id = @idSucursal)

		UPDATE COCODRILOS_COMEBACK.USUARIO
		set habilitado = 0
		WHERE dni IN (SELECT u.dni
						FROM USUARIO_SUCURSAL us JOIN USUARIO u ON us.user_dni = u.dni
						WHERE us.sucursal_id = @idSucursal)
		
		SELECT @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO

	---------------------------------------------------
	-------------------MODIFICACION--------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_SUCURSAL(
		@nombre		nvarchar(255),
		@direccion	nvarchar(255),
		@COD_POSTAL	numeric(18,0),
		@habilitado bit,
		@ID			INT
	) 
	AS
	BEGIN TRY 

		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.SUCURSAL s WHERE s.cod_postal = @COD_POSTAL AND s.id <> @ID) > 0
			INSERT INTO #errores VALUES( CONCAT('La sucursal con código postal ', @COD_POSTAL, ' ya existe.'))

		IF(SELECT COUNT(*) FROM #errores) = 1
			BEGIN
				UPDATE COCODRILOS_COMEBACK.SUCURSAL
				SET 
					nombre = @nombre,
					direccion = @direccion,
					cod_postal = @COD_POSTAL,
					habilitado = @habilitado
					WHERE id = @ID

				IF @habilitado = 0
				BEGIN
					UPDATE COCODRILOS_COMEBACK.USUARIO
					SET habilitado = 0
					WHERE DNI IN (SELECT user_dni 
								  FROM COCODRILOS_COMEBACK.USUARIO_SUCURSAL 
								  WHERE sucursal_id = @ID)
				END
				ELSE 
				BEGIN
					UPDATE COCODRILOS_COMEBACK.USUARIO
					SET habilitado = 1
					WHERE DNI IN (SELECT user_dni 
								  FROM COCODRILOS_COMEBACK.USUARIO_SUCURSAL 
								  WHERE sucursal_id = @ID)
				END

				SELECT @@ROWCOUNT
			END
		ELSE
			SELECT * FROM #errores
		

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO
	



---------------------------------------------------
---------------------ABM ROL-----------------------
---------------------------------------------------

	---------------------------------------------------
	-----------------------BAJA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.BAJA_ROL(@rolID int)
	AS
	BEGIN TRY
		UPDATE COCODRILOS_COMEBACK.ROL
		SET habilitado = 0
		WHERE id = @rolID

		DELETE FROM COCODRILOS_COMEBACK.ROL_USUARIO 
		WHERE id_rol = @rolID
		
		SELECT @@ROWCOUNT
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-----------REMOVER FUNCIONALIDAD A ROL-------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.REMOVER_FUNCIONALIDAD_ROL(@rolID int, @funID int) 
	AS
	BEGIN TRY
		DELETE FROM COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD 
		WHERE id_rol = @rolID AND id_funcionalidad = @funID 
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-----------AGREGAR FUNCIONALIDAD A ROL-------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.AGREGAR_FUNCIONALIDAD_ROL(@rolID int, @funID int) 
	AS
	BEGIN TRY
		INSERT INTO COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD (
			id_rol,
			id_funcionalidad
		) VALUES (
			@rolID,
			@funID
		) 
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	---------------------------------------------------
	-----------------------ALTA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.ALTA_ROL(
		@descripcion	nvarchar(255),
		@funcionalities	nvarchar(255) = NULL
	) 
	AS 
	BEGIN TRY

		INSERT INTO COCODRILOS_COMEBACK.ROL (
			descripcion	
		) VALUES (
			@descripcion
		)

		DECLARE @insertedRolID int = (SELECT IDENT_CURRENT('COCODRILOS_COMEBACK.ROL'))
		IF @funcionalities IS NOT NULL

			BEGIN
				DECLARE @actualFunID nvarchar(255)
				DECLARE c_agregar_func CURSOR FOR
					SELECT *
					FROM COCODRILOS_COMEBACK.STRING_SPLIT(@funcionalities, '&')
				OPEN c_agregar_func
				FETCH NEXT FROM c_agregar_func INTO @actualFunID
				WHILE(@@FETCH_STATUS = 0)
					BEGIN
						DECLARE @funIdInt INT = (SELECT (CONVERT(int, @actualFunID)))
						EXEC COCODRILOS_COMEBACK.AGREGAR_FUNCIONALIDAD_ROL @insertedRolID, @funIdInt
						FETCH NEXT FROM c_agregar_func INTO @actualFunID
					END
				CLOSE c_agregar_func
				DEALLOCATE c_agregar_func
			END


		SELECT @@ERROR

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


	-------------------------------------------------------
	-------------------MODIFICACION ROL--------------------
	-------------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_ROL(
		@idRol			int,
		@descripcion	nvarchar(255),
		@funcionalities	nvarchar(255) = NULL,
		@habilitado		bit
	) 
	AS 
	BEGIN TRY

		UPDATE COCODRILOS_COMEBACK.ROL
		SET 
			descripcion = @descripcion,
			habilitado = @habilitado

		WHERE id = @idRol

		IF @funcionalities IS NOT NULL
			BEGIN
				DECLARE @actualFunID1 nvarchar(255)
				DECLARE c_agregar_func1 CURSOR FOR
					SELECT rf.id_funcionalidad
					FROM COCODRILOS_COMEBACK.ROL_FUNCIONALIDAD rf
					WHERE rf.id_rol = @idRol
				OPEN c_agregar_func1
				FETCH NEXT FROM c_agregar_func1 INTO @actualFunID1
				WHILE(@@FETCH_STATUS = 0)
					BEGIN
						DECLARE @funIdInt1 INT = (SELECT (CONVERT(int, @actualFunID1)))
						EXEC COCODRILOS_COMEBACK.REMOVER_FUNCIONALIDAD_ROL @idRol, @funIdInt1
						FETCH NEXT FROM c_agregar_func1 INTO @actualFunID1
					END
				CLOSE c_agregar_func1
				DEALLOCATE c_agregar_func1
			END
			BEGIN
				DECLARE @actualFunID nvarchar(255)
				DECLARE c_agregar_func CURSOR FOR
					SELECT *
					FROM COCODRILOS_COMEBACK.STRING_SPLIT(@funcionalities, '&')
				OPEN c_agregar_func
				FETCH NEXT FROM c_agregar_func INTO @actualFunID
				WHILE(@@FETCH_STATUS = 0)
					BEGIN
						DECLARE @funIdInt INT = (SELECT (CONVERT(int, @actualFunID)))
						EXEC COCODRILOS_COMEBACK.AGREGAR_FUNCIONALIDAD_ROL @idRol, @funIdInt
						FETCH NEXT FROM c_agregar_func INTO @actualFunID
					END
				CLOSE c_agregar_func
				DEALLOCATE c_agregar_func
			END


		SELECT @@ERROR

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO


---------------------------------------------------
-------------------ABM FACTURA---------------------
---------------------------------------------------

	---------------------------------------------------
	-----------------------ALTA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.ALTA_FACTURA(
		@numero			numeric(18,0),
		@cliente		numeric(18,0),
		@empresa		nvarchar(50),
		@fechaEmision	datetime,
		@fechaVto		datetime,
		@total			numeric(18,2),
		@items			nvarchar(max)
	)
	AS
	BEGIN TRY
		
		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.dni = @cliente) = 0
			INSERT INTO #errores VALUES (CONCAT('El cliente con DNI ', @cliente, ' no existe.'))
		
		IF(@fechaVto > @fechaEmision) 
			INSERT INTO #errores VALUES ('La factura tiene facha de vencimiento posterior a la de emisión.')
			
		IF(SELECT COUNT(*) FROM #errores) = 1
			BEGIN
				INSERT INTO COCODRILOS_COMEBACK.FACTURA (
					numero,
					cliente,
					empresa,
					fecha_emision,
					fecha_vto,
					total
				) VALUES (
					@numero,
					@cliente,
					@empresa,
					@fechaEmision,
					@fechaVto,
					@total
				)

				--LA INFORMACION DE LOS ITEMS VENDRA EN FORMATO PRECIO1;CANTIDAD1&PRECIO2;CANTIDAD2&....
				DECLARE @itemInfo nvarchar(255)
				DECLARE @itemCant nvarchar(50)
				DECLARE @itemPrecio nvarchar(50)

				DECLARE c_items CURSOR FOR
					SELECT *
					FROM STRING_SPLIT(@items, '&')

				OPEN c_items
		
				FETCH NEXT FROM c_items INTO @itemInfo

				WHILE(@@FETCH_STATUS = 0)
					BEGIN

						--VOY A LEER EL PRECIO Y LA CANTIDAD DEL ITEM ACTUAL
						DECLARE @precio	nvarchar(50)
						DECLARE @cant	nvarchar(50)

						DECLARE c_item_info CURSOR FOR
							SELECT *
							FROM STRING_SPLIT(@itemInfo, ';')
						OPEN c_item_info
				
						--COMO SIEMPRE VIENEN EN PARES LA INFO (PRECIO Y CANT) SIEMPRE SON DOS ELEMENTOS 
						--EN EL CURSOR, LEO PRIMERO PRECIO Y DESPUES CANTIDAD
						FETCH NEXT FROM c_item_info INTO @precio
						FETCH NEXT FROM c_item_info INTO @cant

						--AGREGO EL ITEM DE LA FACTURA CON SU PRECIO Y CANTIDAD
						INSERT INTO COCODRILOS_COMEBACK.ITEM_FACTURA (
							fact_numero,
							fact_empresa,
							precio_unitario,
							cantidad
						) VALUES (
							@numero,
							@empresa,
							CONVERT(numeric(18,5), @precio),
							CONVERT(numeric(18,0), @cant)
						)

						CLOSE c_item_info
						DEALLOCATE c_item_info

						--LEO SIGUIENTE REGISTRO PRECIO;CANTIDAD
						FETCH NEXT FROM c_items INTO @itemInfo
				
					END

					CLOSE c_items
					DEALLOCATE c_items


				SELECT @@ERROR
			END
		ELSE
			SELECT * FROM #errores
	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO




	---------------------------------------------------
	-----------------------BAJA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.BAJA_FACTURA(
		@numero		numeric(18,0),
		@empresa	nvarchar(50)
	) 
	AS
	BEGIN TRY

		UPDATE COCODRILOS_COMEBACK.FACTURA
		SET habilitada = 0
		WHERE numero = @numero AND empresa = @empresa

		SELECT @@ROWCOUNT

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO




	---------------------------------------------------
	-------------------MODIFICACION--------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_FACTURA(
		@numero			numeric(18,0),
		@empresa		nvarchar(50),
		@cliente		numeric(18,0),
		@fecha_emision	datetime,
		@fecha_vto		datetime,
		@total			numeric(18,2),
		@pagada			bit,
		@rendida		bit,
		@habilitada		bit,
		@items			nvarchar(max)
	)
	AS
	BEGIN TRY

		CREATE TABLE #errores (
			message nvarchar(255)
		)

		INSERT INTO #errores VALUES ('Errores')

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.FACTURA f WHERE f.numero = @numero AND f.empresa = @empresa) = 0
			INSERT INTO #errores VALUES (CONCAT('La factura número ', @numero, ' para le empresa ', @empresa, ' no existe.')) 

		IF(SELECT COUNT(*) FROM COCODRILOS_COMEBACK.CLIENTE c WHERE c.dni = @cliente) = 0
			INSERT INTO #errores VALUES (CONCAT('El cliente seleccionado con DNI ', @cliente, ' no existe.'))


		IF(SELECT COUNT(*) FROM #errores) = 1
			BEGIN
				--MODIFICACION DE FACTURA, LA PK (NUMERO, EMPRESA) NO SE PUEDE MODIFICAR
				UPDATE COCODRILOS_COMEBACK.FACTURA
				SET cliente = @cliente,
					fecha_emision = @fecha_emision,
					fecha_vto = @fecha_vto,
					total = @total,
					pagada = @pagada,
					rendida = @rendida,
					habilitada = @habilitada
				WHERE numero = @numero AND empresa = @empresa
		

				--MODIFICACION DE ITEMS DE LA FACTURA
				--LA INFORMACION DE LOS ITEMS VIENE EN FORMATO 
				--ITEMID1;NUEVOPRECIO1;NUEVACANTIDAD1&ITEMID2;NUEVOPRECIO2;NUEVACANTIDAD3...
				--LA INFORMACION DE LOS ITEMS VENDRA EN FORMATO PRECIO1;CANTIDAD1&PRECIO2;CANTIDAD2&....
				DECLARE @itemInfo nvarchar(255)
				DECLARE @itemCant nvarchar(50)
				DECLARE @itemPrecio nvarchar(50)

				DECLARE c_items_mod CURSOR FOR
					SELECT *
					FROM STRING_SPLIT(@items, '&')

				OPEN c_items_mod
		
				FETCH NEXT FROM c_items_mod INTO @itemInfo

				WHILE(@@FETCH_STATUS = 0)
					BEGIN

						--VOY A LEER EL PRECIO Y LA CANTIDAD DEL ITEM ACTUAL
						DECLARE @id		nvarchar(20)
						DECLARE @precio	nvarchar(50)
						DECLARE @cant	nvarchar(50)

						DECLARE c_item_info_mod CURSOR FOR
							SELECT *
							FROM STRING_SPLIT(@itemInfo, ';')
						OPEN c_item_info_mod 
				
						--COMO SIEMPRE VIENEN EN TUPLAS DE LA FORMA (ID ,PRECIO , CANT) SIEMPRE SON TRES ELEMENTOS 
						--EN EL CURSOR, LEO PRIMERO ID, PRECIO Y DESPUES CANTIDAD
						FETCH NEXT FROM c_item_info_mod INTO @id
						FETCH NEXT FROM c_item_info_mod INTO @precio
						FETCH NEXT FROM c_item_info_mod INTO @cant

						--ACTUALIZO EL ITEM DE LA FACTURA CON SU PRECIO Y CANTIDAD
						UPDATE COCODRILOS_COMEBACK.ITEM_FACTURA
						SET precio_unitario = CONVERT(numeric(18,5), @precio),
							cantidad = CONVERT(int, @cant)
						WHERE	item_id = CONVERT(int, @id) AND 
								fact_empresa = @empresa AND 
								fact_numero = @numero

				
						CLOSE c_item_info_mod 
						DEALLOCATE c_item_info_mod 

						--LEO SIGUIENTE REGISTRO PRECIO;CANTIDAD
						FETCH NEXT FROM c_items_mod INTO @itemInfo
				
					END

				CLOSE c_items_mod 
				DEALLOCATE c_items_mod 

				SELECT @@ERROR
			END
		ELSE
			SELECT * FROM #errores

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO



-----------------------------------------------------
-------------------REGISTRO PAGO---------------------
-----------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.REGISTRAR_PAGO_FACTURA (
	@list AS COCODRILOS_COMEBACK.LISTA_REGISTRO READONLY
)
AS
--BEGIN TRY
begin
	CREATE TABLE #errores (
		errorMessage	nvarchar(255)
	)

	INSERT INTO #errores VALUES ('Errores')


	DECLARE @fecha_pago datetime
	DECLARE @fact_numero numeric(18,0)
	DECLARE @empresa nvarchar(50)
	DECLARE @cliente numeric(18,0)
	DECLARE @medio_pago int
	DECLARE @fecha_vto datetime
	DECLARE @importe numeric(20,2)
	DECLARE @sucursal int

	DECLARE c_registro_pago CURSOR FOR 
		SELECT * FROM @list
	
	OPEN c_registro_pago
	FETCH NEXT FROM c_registro_pago INTO
		@fact_numero,
		@fecha_pago,
		@fecha_vto,
		@cliente,
		@empresa,
		@importe,
		@sucursal,
		@medio_pago
		
	WHILE(@@FETCH_STATUS = 0)
		BEGIN

			--VERIFICO QUE LA EMPRESA ESTE DESHABILITADA Y ARROJA ERROR 
		IF(	SELECT COUNT(*)
			FROM COCODRILOS_COMEBACK.EMPRESA e
			WHERE e.cuit = @empresa AND e.habilitado = 1) = 0
			BEGIN
				INSERT INTO #errores VALUES ('La empresa se encuentre inhabilitada.')
				BREAK
			END

		--VERIFICO EXISTENCIA EN EL SISTEMA DE LA FACTURA QUE SE DESEA PAGAR
		IF NOT EXISTS(	SELECT *
					FROM COCODRILOS_COMEBACK.FACTURA f 
					WHERE f.numero = @fact_numero)
			BEGIN
				INSERT INTO #errores VALUES ('La factura no se encuentra cargada en sistema. Se deberà cargarla desde Alta de Factura primeramente.')
				BREAK
				--SELECT errorMessage FROM #errores
			END
		 ELSE
			BEGIN

				IF (SELECT COUNT(*) FROM COCODRILOS_COMEBACK.REGISTRO_PAGO r WHERE r.fact_numero = @fact_numero) > 0
					INSERT INTO #errores VALUES (CONCAT('La factura numero ', @fact_numero, ' ya se encuentra pagada. Eliminela de la selección.'))

				--IF (SELECT f.fecha_vto FROM COCODRILOS_COMEBACK.FACTURA f WHERE f.numero = @fact_numero) <> @fecha_vto
				--	INSERT INTO #errores VALUES ('La fecha de vencimiento difiere con la cargada en sistema, por favor verifique el valor ingresado.')
					

				IF(SELECT f.total FROM COCODRILOS_COMEBACK.FACTURA f WHERE f.numero = @fact_numero) <> @importe
					INSERT INTO #errores VALUES ('El importe difiere con el cargado en el sistema, por favor verifique le valor ingresado.')
		
				IF (SELECT COUNT(*) FROM #errores) = 1
					BEGIN
						INSERT INTO COCODRILOS_COMEBACK.REGISTRO_PAGO(
							pago_id,
							fact_numero,
							fecha_pago,
							fecha_vto,
							empresa,
							cliente,
							importe_pago,
							medio_pago_id,
							sucursal
						) VALUES (
							(SELECT TOP 1 r.pago_id FROM COCODRILOS_COMEBACK.REGISTRO_PAGO r ORDER BY r.pago_id DESC) + 1,
							@fact_numero,
							@fecha_pago,
							@fecha_vto,
							@empresa,
							@cliente,
							@importe,
							@medio_pago,
							@sucursal
						)

					END
				ELSE
					BREAK
			END

			FETCH NEXT FROM c_registro_pago INTO
				@fact_numero,
				@fecha_pago,
				@fecha_vto,
				@cliente,
				@empresa,
				@importe,
				@sucursal,
				@medio_pago
		END
	
		IF(SELECT COUNT(*) FROM #errores) > 1
			SELECT errorMessage FROM #errores
		ELSE
			SELECT @@ERROR
	
	end
--END TRY
--BEGIN CATCH
--	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
--END CATCH
GO
---------------------------------------------------
-------------------DEVOLUCION----------------------
---------------------------------------------------


	---------------------------------------------------
	-------------OBTENER FACTURAS PAGAS----------------
	---------------------------------------------------


CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_FACTURAS_PAGAS(
	@FACTURA numeric(18,0) = NULL,
	@CLIENTE NUMERIC(18,0) = NULL, 
	@EMPRESA nvarchar(50) = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.FACTURA F
	WHERE	(@FACTURA IS NULL OR F.numero = @FACTURA) AND
			(@CLIENTE IS NULL OR F.cliente = @CLIENTE) AND
			(@EMPRESA IS NULL OR F.empresa = @EMPRESA) AND
			F.habilitada = 1 AND 
			F.pagada = 1 AND
			F.rendida = 0
			
END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

	---------------------------------------------------
	----------------HACER DEVOLUCION-------------------
	---------------------------------------------------

CREATE PROCEDURE COCODRILOS_COMEBACK.HACER_DEVOLUCION(
			@FACTURA NUMERIC(18,0) = NULL,
			@EMPRESA NVARCHAR(50) = NULL,
			@MOTIVO NVARCHAR(250) = NULL
			)
AS
BEGIN TRY 

	INSERT INTO COCODRILOS_COMEBACK.DEVOLUCION_FACTURA (
		fact_numero,
		fact_empresa,
		dev_motivo
		)
		VALUES (@FACTURA, @EMPRESA, @MOTIVO)

		UPDATE COCODRILOS_COMEBACK.FACTURA 
		SET PAGADA = 0
		WHERE numero = @FACTURA AND empresa = @EMPRESA  and rendida = 0
		
		select @@ERROR

END TRY
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

 

-----------------------------------------------------
----------------RENDICION----------------------------
-----------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.RENDICION(
	@cant_facturas			int,
	@fecha_rendicion		datetime,
	@importe_bruto			numeric(18,2),
	@importe_neto			numeric(18,2),
	@importe_comision		numeric(18,2),
	@porcentaje_comision	numeric(18,2),
	@rendicion_empresa		nvarchar(50),
	@mes_rendicion			int
	) 
	AS 
	BEGIN TRY
		DECLARE @inserted_rendicion int = (select TOP 1 rp.rendicion_nro from COCODRILOS_COMEBACK.RENDICION_PAGO rp order by rp.rendicion_nro desc) + 1

			BEGIN
				DECLARE @actualFact numeric(18,0)
				DECLARE c_agregar_fact CURSOR FOR
					SELECT rp.fact_numero
					FROM COCODRILOS_COMEBACK.REGISTRO_PAGO rp
					WHERE rp.empresa = @rendicion_empresa AND MONTH(rp.fecha_pago) = @mes_rendicion
				OPEN c_agregar_fact
				FETCH NEXT FROM c_agregar_fact INTO @actualFact
				WHILE(@@FETCH_STATUS = 0)
					BEGIN
							INSERT INTO COCODRILOS_COMEBACK.RENDICION_PAGO(
							rendicion_nro,
							cant_facturas,
							fecha_rendicion,
							importe_bruto,
							importe_neto,
							importe_comision,
							porcentaje_comision,
							fact_numero,
							rendicion_empresa
						) VALUES (
							@inserted_rendicion,
							@cant_facturas,
							@fecha_rendicion,
							@importe_bruto,
							@importe_neto,
							@importe_comision,
							@porcentaje_comision,
							@actualFact,
							@rendicion_empresa
						)

						FETCH NEXT FROM c_agregar_fact INTO @actualFact
					END
				CLOSE c_agregar_fact
				DEALLOCATE c_agregar_fact
			END

		SELECT @@ERROR

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO
	


---------------------------------------------------------------
-------------------LISTADO ESTADISTICO-------------------------
---------------------------------------------------------------

	
	---------------------------------------------------------------
	-------------PROCENTAJE FACT COBRADAS POR EMPRESA--------------
	---------------------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.PORCENTAJE_COBRADAS_EMPRESA(
		@año		int,
		@trimestre	int
	) 
	AS
	BEGIN TRY
		SELECT TOP 5 rp.rendicion_empresa as Empresa, 
					(COUNT(rp.fact_numero) / (SELECT COUNT(*) 
											 FROM COCODRILOS_COMEBACK.FACTURA f 
											 WHERE	f.empresa = rp.rendicion_empresa AND 
													COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(f.fecha_emision, @trimestre) = 1)) * 100 as Porcentaje_Facturas_Cobradas
		FROM COCODRILOS_COMEBACK.RENDICION_PAGO rp JOIN
			 COCODRILOS_COMEBACK.EMPRESA e ON rp.rendicion_empresa = e.cuit
		WHERE	YEAR(rp.fecha_rendicion) = @año AND
				COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(rp.fecha_rendicion, @trimestre) = 1
		GROUP BY rp.rendicion_empresa
		ORDER BY (COUNT(rp.fact_numero) / (SELECT COUNT(*) 
											FROM COCODRILOS_COMEBACK.FACTURA f 
											WHERE	f.empresa = rp.rendicion_empresa AND 
												COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(f.fecha_emision, @trimestre) = 1)) * 100 DESC
	END TRY
	BEGIN CATCH

	END CATCH
	GO	


	---------------------------------------------------------------
	-------------EMPRESAS CON MAYOR MONTO RENDIDO-------------------
	---------------------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.EMPRESAS_MAYOR_MONTO_RENDIDO(
			@año int,
			@trimestre int
	)
	AS
	BEGIN TRY

		SELECT TOP 5 r.rendicion_empresa as Empresa, SUM(r.importe_bruto) as Monto_Rendido
		FROM COCODRILOS_COMEBACK.RENDICION_PAGO r
		WHERE	YEAR(r.fecha_rendicion) = @año AND
				COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(r.fecha_rendicion, @trimestre) = 1
		GROUP BY r.rendicion_empresa
		ORDER BY SUM(r.importe_bruto) DESC

	END TRY
	BEGIN CATCH

	END CATCH
	GO


	---------------------------------------------------------------
	--------------------CLIENTES CON MAS PAGOS---------------------
	---------------------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.CLIENTES_MAS_PAGOS(
			@año int,
			@trimestre int
	)
	AS
	BEGIN TRY

		SELECT TOP 5 r.cliente as Cliente, COUNT(r.fact_numero) AS Cantidad
		FROM COCODRILOS_COMEBACK.REGISTRO_PAGO r
		WHERE	YEAR(r.fecha_pago) = @año AND
				COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(r.fecha_pago, @trimestre) = 1
		GROUP BY r.cliente
		ORDER BY COUNT(r.fact_numero) DESC

	END TRY
	BEGIN CATCH

	END CATCH
	GO


	---------------------------------------------------------------
	-----------CLIENTES MAYOR PORCENTAJE FACTURAS PAGAS------------
	---------------------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.CLIENTES_MAS_CUMPLIDORES(
			@año int,
			@trimestre int
	)
	AS
	BEGIN TRY
		
		SELECT TOP 5 
			r.cliente as Cliente,
			(COUNT(r.fact_numero) / (SELECT COUNT(*) FROM COCODRILOS_COMEBACK.FACTURA f WHERE f.cliente = r.cliente)) * 100 as Porcentaje
		FROM COCODRILOS_COMEBACK.REGISTRO_PAGO r
		WHERE	YEAR(r.fecha_pago) = @año AND
				COCODRILOS_COMEBACK.PERTENECE_A_TRIMESTRE(r.fecha_pago, @trimestre) = 1
		GROUP BY r.cliente
		ORDER BY (COUNT(r.fact_numero) / (SELECT COUNT(*) FROM COCODRILOS_COMEBACK.FACTURA f WHERE f.cliente = r.cliente)) * 100 DESC

	END TRY
	BEGIN CATCH

	END CATCH
	GO


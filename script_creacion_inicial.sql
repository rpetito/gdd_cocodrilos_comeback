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

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_CLIENTE_HABILITADO') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_CLIENTE_HABILITADO

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_CLIENTE_TOTALIDAD') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_CLIENTE_TOTALIDAD

IF OBJECT_ID('COCODRILOS_COMEBACK.ALTA_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.ALTA_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.BAJA_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BAJA_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.MODIFICAR_EMPRESA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_EMPRESA

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_EMPRESA_HABILITADA') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA_HABILITADA

IF OBJECT_ID('COCODRILOS_COMEBACK.BUSCAR_EMPRESA_TOTALIDAD') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA_TOTALIDAD

IF OBJECT_ID('COCODRILOS_COMEBACK.OBTENER_RUBROS') IS NOT NULL
DROP PROCEDURE COCODRILOS_COMEBACK.OBTENER_RUBROS

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





GO
--###########################################################################
	-------------------------------TRIGGERS------------------------------
--###########################################################################





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
	PRIMARY KEY(user_dni, sucursal_id),
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
	rendicion_nro		numeric(18,0) PRIMARY KEY,
	cant_facturas		int,
	fecha_rendicion		int,
	importe_bruto		numeric(18,2),
	importe_neto		numeric(18,2),
	importe_comision	numeric(18,2),
	porcentaje_comision	numeric(18,2),
	fact_numero			numeric(18,0),
	rendicion_empresa	nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA ON UPDATE CASCADE,
	FOREIGN KEY(fact_numero, rendicion_empresa) REFERENCES COCODRILOS_COMEBACK.FACTURA
)


CREATE TABLE COCODRILOS_COMEBACK.RENDICION_PAGO_INCONSISTENCIAS(
	inconsistencia_id	int IDENTITY(1,1) PRIMARY KEY,
	rendicion_nro		numeric(18,0),
	cant_facturas		int,
	fecha_rendicion		int,
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
	dev_motivo				nvarchar(250) DEFAULT 'No especifica',
	dev_usuario_aceptante	numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.USUARIO,
	dev_tipo_devolucion		nvarchar(50) NOT NULL,
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
	incosistencia_id	int IDENTITY(1,1),
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





--###########################################################################
--###########################################################################
-------------CREACION DE PROCEDURES AUXILIARES (NO FUNCIONALES)--------------
--###########################################################################
--###########################################################################

-----------------------------------------------------------------------------
-----------------------------INHABILITAR USUARIO-----------------------------
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
			@habilitado IS NULL OR c.habilitado = @habilitado

END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO


-----------------------------------------------------------------------------
--------------------BUSCAR EMPRESA HABILITADA--------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA_HABILITADA(
	@nombre nvarchar(255) = NULL,
	@rubro numeric(18,0) = NULL, 
	@cuit nvarchar(50) = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.EMPRESA e
	WHERE	(@nombre IS NULL OR e.nombre = @nombre) AND
			(@rubro IS NULL OR e.rubro = @rubro) AND
			(@cuit IS NULL OR e.cuit = @cuit) AND
			e.habilitado = 1
END TRY 
BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
END CATCH
GO

-----------------------------------------------------------------------------
---------------------BUSCAR EMPRESA TOTALIDAD--------------------------------
-----------------------------------------------------------------------------
CREATE PROCEDURE COCODRILOS_COMEBACK.BUSCAR_EMPRESA_TOTALIDAD(
	@nombre nvarchar(255) = NULL,
	@rubro numeric(18,0) = NULL, 
	@cuit nvarchar(50) = NULL) 
AS
BEGIN TRY
	
	SELECT *
	FROM COCODRILOS_COMEBACK.EMPRESA e
	WHERE	(@nombre IS NULL OR e.nombre = @nombre) AND
			(@rubro IS NULL OR e.rubro = @rubro) AND
			(@cuit IS NULL OR e.cuit = @cuit)

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
CREATE PROCEDURE COCODRILOS_COMEBACK.OBTENER_ROLES(@nombre nvarchar(255) = NULL, @habilitado bit = 1)
AS
BEGIN TRY
	SELECT *
	FROM COCODRILOS_COMEBACK.ROL r
	WHERE	(@nombre IS NULL OR r.descripcion = @nombre) AND
			r.habilitado = @habilitado
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
			(SELECT e.dia_rendicion FROM COCODRILOS_COMEBACK.EMPRESA e WHERE e.cuit = m.Empresa_Cuit),
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
	GROUP BY m.Rendicion_Nro, MONTH(m.Rendicion_Fecha), m.Empresa_Cuit, m.Nro_Factura


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
			(SELECT e.dia_rendicion FROM COCODRILOS_COMEBACK.EMPRESA e WHERE e.cuit = m.Empresa_Cuit),
			SUM(ISNULL(m.Factura_Total,0)),
			SUM(ISNULL(m.Factura_Total,0)) - SUM(ISNULL(m.ItemRendicion_Importe,0)), 
			SUM(ISNULL(m.ItemRendicion_Importe,0)),
			(SUM(ISNULL(m.ItemRendicion_Importe,0)) / SUM(ISNULL(m.Factura_Total,1))) * 100,
			m.Empresa_Cuit Empresa
	FROM gd_esquema.Maestra m
	GROUP BY m.Rendicion_Nro, MONTH(m.Rendicion_Fecha), m.Empresa_Cuit, m.Nro_Factura
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
	SELECT TOP 10 m.Nro_Factura, m.Factura_Total, m.ItemFactura_Monto, m.ItemFactura_Cantidad, m.Empresa_Cuit
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
		SELECT r.ID_USUARIO, r.ID_ROL, rol.DESCRIPCION
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
	--BEGIN TRY 
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

	--END TRY
	END
	--BEGIN CATCH
	--	THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	--END CATCH

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
		@rubro			decimal(18,0),
		@habilitado		bit
	) 
	AS
	BEGIN TRY 
	
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

	END TRY
	BEGIN CATCH
		IF @@ERROR = 2627 
		THROW 99999, 'Codigo postal incorrecto. Ya existe una sucursal con el codigo postal ingresado.', 1
		ELSE	
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO

/*
	---------------------------------------------------
	-----------------------BAJA------------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.BAJA_SUCURSAL(@cuit nvarchar(50))
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
		@cuit		nvarchar(50),
		@nombre		nvarchar(255),
		@direccion	nvarchar(255),
		@rubro		numeric(18,0),
		@habilitado bit
	) 
	AS
	BEGIN TRY 

		UPDATE COCODRILOS_COMEBACK.EMPRESA
		SET 
			cuit = @cuit,
			nombre = @nombre,
			direccion = @direccion,
			rubro = @rubro,
			habilitado = @habilitado

		SELECT @@ROWCOUNT

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO
	*/


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


	---------------------------------------------------
	-------------------MODIFICACION--------------------
	---------------------------------------------------
	CREATE PROCEDURE COCODRILOS_COMEBACK.MODIFICAR_ROL(
		@rolID			int,
		@descripcion	nvarchar(255),
		@funToRemoveID	int = NULL,
		@funToAddID		nvarchar(255) = NULL
	) 
	AS
	BEGIN TRY 

		UPDATE COCODRILOS_COMEBACK.ROL
		SET 
			descripcion = @descripcion
		WHERE id = @rolID

		IF @funToRemoveID IS NOT NULL
			EXEC COCODRILOS_COMEBACK.REMOVER_FUNCIONALIDAD_ROL @rolID, @funToRemoveID

		IF @funToAddID IS NOT NULL
			BEGIN
				DECLARE @actualFunID nvarchar(255)
				DECLARE c_agregar_func CURSOR FOR
					SELECT *
					FROM COCODRILOS_COMEBACK.STRING_SPLIT(@funToAddID, '&')
				OPEN c_agregar_func
				FETCH NEXT FROM c_agregar_func INTO @actualFunID
				WHILE(@@FETCH_STATUS = 0)
					BEGIN
						DECLARE @funIdInt INT = (SELECT (CONVERT(int, @actualFunID)))
						EXEC COCODRILOS_COMEBACK.AGREGAR_FUNCIONALIDAD_ROL @rolID, @funIdInt
						FETCH NEXT FROM c_agregar_func INTO @actualFunID
					END
				CLOSE c_agregar_func
				DEALLOCATE c_agregar_func
			END

		SELECT @@ROWCOUNT

	END TRY
	BEGIN CATCH
		THROW 99999, 'Algo ha ocurrido. Por favor vuelva a intentar', 1
	END CATCH
	GO

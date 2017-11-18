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

IF OBJECT_ID('COCODRILOS_COMEBACK.REGISTRO_PAGO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.REGISTRO_PAGO

IF OBJECT_ID('COCODRILOS_COMEBACK.DEVOLUCION_FACTURA') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.DEVOLUCION_FACTURA

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

IF OBJECT_ID('COCODRILOS_COMEBACK.RENDICION_PAGO') IS NOT NULL
DROP TABLE COCODRILOS_COMEBACK.RENDICION_PAGO

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
	habilitado		int DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.SUCURSAL (
	id			int IDENTITY(1,1) PRIMARY KEY,
	nombre		nvarchar(50),
	direccion	nvarchar(50),
	cod_postal	numeric(18,0) UNIQUE,
	habilitado	int DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.CLIENTE (
	dni			numeric(18,0) PRIMARY KEY,
	nombre		nvarchar(255),
	apellido	nvarchar(255),
	fecha_nac	datetime,
	mail		nvarchar(255),
	direccion	nvarchar(255),
	cod_postal	nvarchar(255),
	habilitado	int DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.ROL (
	id				int IDENTITY(1,1) PRIMARY KEY,
	descripcion		nvarchar(255) UNIQUE,
	habilitado		int DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.ROL_USUARIO (
	id_usuario		numeric(18,0),
	id_rol			int,
	habilitado		int DEFAULT 1,
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
	cuit		nvarchar(50) PRIMARY KEY,
	nombre		nvarchar(255),
	direccion	nvarchar(255),
	rubro		numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.RUBRO,
	habilitado	int DEFAULT 1
)


CREATE TABLE COCODRILOS_COMEBACK.FACTURA (
	numero			numeric(18,0) PRIMARY KEY,
	cliente			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.CLIENTE,
	empresa			nvarchar(50)  FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA,
	fecha_emision	datetime,
	fecha_vto		datetime,
	total			numeric(18,2),
	pagada			bit DEFAULT 0,
	rendida			bit DEFAULT 0
)


CREATE TABLE COCODRILOS_COMEBACK.ITEM_FACTURA (
	item_id			int,
	num_factura		numeric(18,0),
	descripcion		nvarchar(255),
	precio_unitario	numeric(18,2),
	cantidad		numeric(18,0),
	PRIMARY KEY (item_id, num_factura)
)


CREATE TABLE COCODRILOS_COMEBACK.RENDICION_PAGO(
	rendicion_id	int IDENTITY(1,1) PRIMARY KEY,
	cant_facturas	int,
	fecha_rendicion	datetime,
	importe_neto	numeric(18,2),
	importe_bruto	numeric(18,2),
	porcentaje_comision	numeric(3,2),
	rendicion_empresa	nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA
)


CREATE TABLE COCODRILOS_COMEBACK.DEVOLUCION_FACTURA(
	fact_numero			numeric(18,0) PRIMARY KEY FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.FACTURA,
	usuario_aceptante	numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.USUARIO,
	tipo_devolucion		nvarchar(50) NOT NULL
)


CREATE TABLE COCODRILOS_COMEBACK.MEDIO_PAGO(
	id			int IDENTITY(1,1) PRIMARY KEY,
	descripcion	nvarchar(50) UNIQUE
)


CREATE TABLE COCODRILOS_COMEBACK.REGISTRO_PAGO(
	pago_id			int IDENTITY(1,1) PRIMARY KEY,
	fecha_pago		datetime,
	fact_numero		numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.FACTURA,
	empresa			nvarchar(50) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.EMPRESA,
	cliente			numeric(18,0) FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.CLIENTE,
	medio_pago_id	int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.MEDIO_PAGO,
	fecha_vto		datetime,
	importe_pago	numeric(20,2),
	sucursal		int FOREIGN KEY REFERENCES COCODRILOS_COMEBACK.SUCURSAL
)


GO


--###########################################################################
---------------------------CREACION DE FUNCIONES-----------------------------
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

	/*
	INSERT INTO COCODRILOS_COMEBACK.ADMINISTRADOR(
		dni,
		username,
		admin_password
	) VALUES (0, 'admin', HASHBYTES('SHA2_256', CONVERT(char(100),'w23e')))
	*/

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
	fact_numero,
	fecha_pago,
	empresa,
	cliente,
	medio_pago_id,
	fecha_vto,
	importe_pago,
	sucursal
)	SELECT	Nro_Factura,
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
	 GROUP BY	Nro_Factura, Pago_Fecha, Empresa_Cuit, 
				[Cliente-Dni], FormaPagoDescripcion, Factura_Fecha_Vencimiento, 
				Factura_Total, Sucursal_Codigo_Postal

go

--###########################################################################
--###########################################################################
------------------------------FUNCIONALIDADES--------------------------------
--###########################################################################
--###########################################################################
--DEVUELVE CANTIDAD DE INTENTOS DE LOGGIN FALLIDOS PARA UN USUARIO DADO

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
								UPDATE CODRILOS_COMEBACK.USUARIO
								SET LOGIN_FALLIDOS = 0
								WHERE USERNAME = @username

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


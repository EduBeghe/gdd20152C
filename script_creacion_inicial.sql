USE GD2C2015
GO
/**************************************************  DROP TRABLES  ***************************************************/
IF OBJECT_ID('TODOX2LUCAS.Cancelaciones') IS NOT NULL
DROP TABLE TODOX2LUCAS.Cancelaciones;
IF OBJECT_ID('TODOX2LUCAS.TransaccionesPasajes') IS NOT NULL
DROP TABLE TODOX2LUCAS.TransaccionesPasajes;
IF OBJECT_ID('TODOX2LUCAS.TransaccionesPaquetes') IS NOT NULL
DROP TABLE TODOX2LUCAS.TransaccionesPaquetes;
IF OBJECT_ID('TODOX2LUCAS.Rol_Por_Funcionalidad') IS NOT NULL
DROP TABLE TODOX2LUCAS.Rol_Por_Funcionalidad;
IF OBJECT_ID('TODOX2LUCAS.Funcionalidades') IS NOT NULL
DROP TABLE TODOX2LUCAS.Funcionalidades;
IF OBJECT_ID('TODOX2LUCAS.Canjes') IS NOT NULL
DROP TABLE TODOX2LUCAS.Canjes;
IF OBJECT_ID('TODOX2LUCAS.Productos') IS NOT NULL
DROP TABLE TODOX2LUCAS.Productos;
IF OBJECT_ID('TODOX2LUCAS.Tarjetas') IS NOT NULL
DROP TABLE TODOX2LUCAS.Tarjetas;
IF OBJECT_ID('TODOX2LUCAS.Estados_Aeronaves') IS NOT NULL
DROP TABLE TODOX2LUCAS.Estados_Aeronaves;
IF OBJECT_ID('TODOX2LUCAS.Butacas') IS NOT NULL
DROP TABLE TODOX2LUCAS.Butacas;
IF OBJECT_ID('TODOX2LUCAS.Pasajes') IS NOT NULL
DROP TABLE TODOX2LUCAS.Pasajes;
IF OBJECT_ID('TODOX2LUCAS.Encomiendas') IS NOT NULL
DROP TABLE TODOX2LUCAS.Encomiendas;
IF OBJECT_ID('TODOX2LUCAS.Viajes') IS NOT NULL
DROP TABLE TODOX2LUCAS.Viajes;
IF OBJECT_ID('TODOX2LUCAS.RutasAereas') IS NOT NULL
DROP TABLE TODOX2LUCAS.RutasAereas;
IF OBJECT_ID('TODOX2LUCAS.Aeronaves') IS NOT NULL
DROP TABLE TODOX2LUCAS.Aeronaves;
IF OBJECT_ID('TODOX2LUCAS.Tipos_De_Servicios') IS NOT NULL
DROP TABLE TODOX2LUCAS.Tipos_De_Servicios;
IF OBJECT_ID('TODOX2LUCAS.Clientes') IS NOT NULL
DROP TABLE TODOX2LUCAS.Clientes;
IF OBJECT_ID('TODOX2LUCAS.Auditoria_Login') IS NOT NULL
DROP TABLE TODOX2LUCAS.Auditoria_Login;
IF OBJECT_ID('TODOX2LUCAS.Usuarios') IS NOT NULL
DROP TABLE TODOX2LUCAS.Usuarios;
IF OBJECT_ID('TODOX2LUCAS.Roles') IS NOT NULL
DROP TABLE TODOX2LUCAS.Roles;
IF OBJECT_ID('TODOX2LUCAS.Fabricantes') IS NOT NULL
DROP TABLE TODOX2LUCAS.Fabricantes;
IF OBJECT_ID('TODOX2LUCAS.Ciudades') IS NOT NULL 
DROP TABLE TODOX2LUCAS.Ciudades;
IF OBJECT_ID('TODOX2LUCAS.Agregar_Funcionalidad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Agregar_Funcionalidad;
IF OBJECT_ID('TODOX2LUCAS.Agregar_Rol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Agregar_Rol;
IF OBJECT_ID('TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Nombre_Rol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Nombre_Rol;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Estado_Rol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Estado_Rol;
IF OBJECT_ID('TODOX2LUCAS.Baja_Rol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Baja_Rol;
IF OBJECT_ID('TODOX2LUCAS.Agregar_Tipo_De_Servicio') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Agregar_Tipo_De_Servicio;
IF OBJECT_ID('TODOX2LUCAS.Migrar_Aeronaves') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Migrar_Aeronaves;
IF OBJECT_ID('TODOX2LUCAS.Migrar_Rutas_Aereas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Migrar_Rutas_Aereas;
IF OBJECT_ID('TODOX2LUCAS.actualizarIntentos') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.actualizarIntentos;
IF OBJECT_ID('TODOX2LUCAS.Validar_Login') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Validar_Login;
IF OBJECT_ID('TODOX2LUCAS.Alta_Ruta_Aerea') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Alta_Ruta_Aerea;
IF OBJECT_ID('TODOX2LUCAS.Cancelar_Pasajes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Cancelar_Pasajes;
IF OBJECT_ID('TODOX2LUCAS.Cancelar_Paquetes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Cancelar_Paquetes;
IF OBJECT_ID('TODOX2LUCAS.Baja_Ruta_Aerea') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Baja_Ruta_Aerea;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Ciudades_Ruta_Aereas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Ciudades_Ruta_Aereas;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Servicio_Ruta_Aerea') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Servicio_Ruta_Aerea;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Precios_Ruta_Aerea') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Precios_Ruta_Aerea;
IF OBJECT_ID('TODOX2LUCAS.Baja_Por_Vida_Util') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Baja_Por_Vida_Util;
IF OBJECT_ID('TODOX2LUCAS.Alta_Aeronave') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Alta_Aeronave;
IF OBJECT_ID('TODOX2LUCAS.Generar_Viaje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Generar_Viaje;
IF OBJECT_ID('TODOX2LUCAS.Registrar_Llegada') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Registrar_Llegada;
IF OBJECT_ID('TODOX2LUCAS.Canjear_Millas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Canjear_Millas;
IF OBJECT_ID('TODOX2LUCAS.Pasajes_Mas_Comprados') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Pasajes_Mas_Comprados;
IF OBJECT_ID('TODOX2LUCAS.Aeronaves_Mas_Vacias') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Aeronaves_Mas_Vacias;
IF OBJECT_ID('TODOX2LUCAS.Cliente_Mayoria_Puntos') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Cliente_Mayoria_Puntos;
IF OBJECT_ID('TODOX2LUCAS.Destinos_Mas_Cancelados') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Destinos_Mas_Cancelados;
IF OBJECT_ID('TODOX2LUCAS.Aeronave_Mayoria_Fuera_Servicio') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Aeronave_Mayoria_Fuera_Servicio;
IF OBJECT_ID('TODOX2LUCAS.Sumar_Millas_Pasajes') IS NOT NULL
DROP TRIGGER TODOX2LUCAS.Sumar_Millas_Pasajes;
IF OBJECT_ID('TODOX2LUCAS.Sumar_Millas_Paquetes') IS NOT NULL
DROP TRIGGER TODOX2LUCAS.Sumar_Millas_Paquetes;
GO

/************************************************** CREACION DE TABLAS CON SUS CONSTRAINS ***************************************************/
--CREACION TABLA CIUDADES--
CREATE TABLE TODOX2LUCAS.Ciudades ( 
	Cod_Ciudad int PRIMARY KEY IDENTITY,
	Nombre_Ciudad nvarchar(255),
	Estado_Ciudad bit
)
;
--CREACION TABLA FABRICANTES--
CREATE TABLE TODOX2LUCAS.Fabricantes ( 
	Cod_Fabricante int PRIMARY KEY IDENTITY,
	Nombre_Fabricante nvarchar(255)
)
;
--CREACION TABLA FUNCIONALIDADES--
CREATE TABLE TODOX2LUCAS.Funcionalidades ( 
	Cod_Funcionalidad int PRIMARY KEY IDENTITY,
	Nombre_Funcionalidad nvarchar(255)
)
;
--CREACION TABLA PRODUCTOS--
CREATE TABLE TODOX2LUCAS.Productos ( 
	Cod_Producto int PRIMARY KEY CLUSTERED,
	Descripcion_Producto nvarchar(255),
	Cantidad int
)
;
--CREACION TABLA ROLES--
CREATE TABLE TODOX2LUCAS.Roles ( 
	Cod_Rol int PRIMARY KEY CLUSTERED IDENTITY,
	Nombre_Rol nvarchar(255),
	Estado_Rol bit
)
;
--CREACION TABLA USUARIOS--
CREATE TABLE TODOX2LUCAS.Usuarios ( 
	Usuario_Nombre nvarchar(255) PRIMARY KEY CLUSTERED,
	Contrase�a nvarchar(255) NOT NULL,
	Cod_Rol int REFERENCES TODOX2LUCAS.Roles (Cod_Rol),
	Intentos_Login int NOT NULL DEFAULT 0,
	Estado_Usuario bit
)
;
--CREACION TABLA AUDITORIA LOGIN--
CREATE TABLE TODOX2LUCAS.Auditoria_Login (
	Cod_Auditoria INT IDENTITY(0,1) PRIMARY KEY,
	Usuario_Nombre nvarchar(255) NOT NULL REFERENCES TODOX2LUCAS.Usuarios (Usuario_Nombre),
	Fecha DATETIME NOT NULL DEFAULT GETDATE(),
	Estado BIT NOT NULL,
	Numero_De_Intento INT 
);

--CREACION TABLA ROL POR FUNCIONALIDAD--
CREATE TABLE TODOX2LUCAS.Rol_Por_Funcionalidad ( 
	Cod_Rol int REFERENCES TODOX2LUCAS.Roles (Cod_Rol),
	Cod_Funcionalidad int REFERENCES TODOX2LUCAS.Funcionalidades (Cod_Funcionalidad),
	PRIMARY KEY CLUSTERED (Cod_Rol, Cod_Funcionalidad)
)
;
--CREACION TABLA CLIENTES
CREATE TABLE TODOX2LUCAS.Clientes ( 
	Nro_Dni numeric(18) ,
	Cliente_Nombre nvarchar(255),
	Cliente_Apellido nvarchar(255),
	Cliente_Direccion nvarchar(255),
	Cliente_Telefono numeric(18),
	Cliente_Mail nvarchar(255),
	Cliente_Fecha_Nacimiento datetime,
	Cant_Millas int,
	Usuario_Nombre nvarchar(255) REFERENCES TODOX2LUCAS.Usuarios (Usuario_Nombre),
	PRIMARY KEY CLUSTERED(Nro_Dni,Cliente_Apellido)
)
;
--CREACION TABLA TARJETAS--
CREATE TABLE TODOX2LUCAS.Tarjetas ( 
	Numero_Tarjeta numeric(16) PRIMARY KEY IDENTITY(4345676543213456,1),
	Cod_Seg numeric(3),
	Fecha_Vencimiento datetime,
	Tipo_Tarjeta nvarchar(200),
	Nro_Dni numeric(18),
	Cliente_Apellido nvarchar(255), 
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;
--CREACION TABLA TIPOS DE SERVICIOS--
CREATE TABLE TODOX2LUCAS.Tipos_De_Servicios ( 
	Cod_Tipo_Servicio int PRIMARY KEY IDENTITY,
	Descripcion_Servicio nvarchar(255),
	Precio_Servicio int
)
;
--CREACION TABLA AERONAVES--
CREATE TABLE TODOX2LUCAS.Aeronaves ( 
	Cod_Aeronave int PRIMARY KEY CLUSTERED IDENTITY,
	Matricula nvarchar(255) UNIQUE,
	Fecha_Alta datetime,
	Cod_Fabricante int REFERENCES TODOX2LUCAS.Fabricantes (Cod_Fabricante),
	Modelo nvarchar(255),
	Cod_Tipo_Servicio int REFERENCES TODOX2LUCAS.Tipos_De_Servicios (Cod_Tipo_Servicio),
	Kgs_Disponibles numeric(18)
	
)
;
--CREACION TABLA ESTADOS AERONAVES--
CREATE TABLE TODOX2LUCAS.Estados_Aeronaves ( 
	Cod_Estado int IDENTITY,
	Cod_Aeronave int REFERENCES TODOX2LUCAS.Aeronaves (Cod_Aeronave),
	Fuera_De_Servicio bit,
	Vida_Util bit,
	Fecha_Fuera_Servicio datetime,
	Fecha_Reinicio_Servicio datetime,
	Fecha_Baja_Definitiva datetime,
	PRIMARY KEY CLUSTERED (Cod_Estado, Cod_Aeronave)
)
;
--CREACION TABLA BUTACAS--
CREATE TABLE TODOX2LUCAS.Butacas ( 
	Cod_Aeronave int REFERENCES TODOX2LUCAS.Aeronaves(Cod_Aeronave),
	Cod_Butaca numeric(18),
	Pos_Butaca nvarchar(255),
	Piso_Butaca numeric(18),
	Estado_Butaca bit,
	PRIMARY KEY CLUSTERED(Cod_Aeronave,Cod_Butaca)
)
;
--CREACION TABLA RUTASAEREAS--
CREATE TABLE TODOX2LUCAS.RutasAereas ( 
	Cod_Ruta numeric(18) IDENTITY(65805158,1),
	Cod_Ciudad_Origen int  REFERENCES TODOX2LUCAS.Ciudades (Cod_Ciudad),
	Cod_Ciudad_Destino int REFERENCES TODOX2LUCAS.Ciudades (Cod_Ciudad),
	Cod_Tipo_Servicio int REFERENCES TODOX2LUCAS.Tipos_De_Servicios (Cod_Tipo_Servicio),
	Precio_Base_Pasaje numeric(18,2),
	Precio_Base_Kg numeric(18,2),
	Estado_Ruta bit,
	PRIMARY KEY(Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino)
)
;
--CREACION TABLA VIAJES-- 

CREATE TABLE TODOX2LUCAS.Viajes ( 
	Cod_Viaje int PRIMARY KEY IDENTITY,
	Cod_Ruta numeric(18),
	Cod_Ciudad_Origen int,
	Cod_Ciudad_Destino int,
	Cod_Aeronave int REFERENCES TODOX2LUCAS.Aeronaves (Cod_Aeronave),
	Fecha_Salida datetime,
	Fecha_Llegada datetime,
	Fecha_Llegada_Estimada datetime,
	FOREIGN KEY (Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino) REFERENCES TODOX2LUCAS.RutasAereas (Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino)
)
;
--CREACION TABLA CANJES--
CREATE TABLE TODOX2LUCAS.Canjes ( 
	Cod_Canje int PRIMARY KEY CLUSTERED IDENTITY,
	Nro_Dni numeric(18) ,
	Cliente_Apellido nvarchar(255) ,
	Cod_Producto int REFERENCES TODOX2LUCAS.Productos (Cod_Producto),
	Fecha datetime,
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;
--CREACION TABLA ENCOMIENDAS--

CREATE TABLE TODOX2LUCAS.Encomiendas ( 
	Cod_Encomiendas numeric(18) PRIMARY KEY CLUSTERED,
	Precio_Encomienda numeric(18,2),
	Kgs_A_Enviar numeric(18),
	Fecha_Compra datetime,
	Cod_Viaje int REFERENCES TODOX2LUCAS.Viajes (Cod_Viaje),
	Nro_Dni numeric(18) ,
	Cliente_Apellido nvarchar(255) ,
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;

--CREACION TABLA PASAJES--
CREATE TABLE TODOX2LUCAS.Pasajes ( 
	Cod_Pasaje numeric(18) PRIMARY KEY CLUSTERED,
	Fecha_Viaje datetime,
	Cod_Viaje int REFERENCES TODOX2LUCAS.Viajes (Cod_Viaje),
	Butaca_Asociada numeric(18) ,
	Nro_Dni numeric(18) ,
	Pasaje_Precio numeric(18,2),
	Cliente_Apellido nvarchar(255),
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido),
)
;
--CREACION TABLA TRANSACCIONES PASAJES--
CREATE TABLE TODOX2LUCAS.TransaccionesPasajes ( 
	Numero_Compra int  IDENTITY,
	Cod_Pasaje numeric(18) REFERENCES TODOX2LUCAS.Pasajes (Cod_Pasaje) ,
	Fecha_Transaccion datetime,
	Nro_Dni numeric(18),
	Cliente_Apellido nvarchar(255),
	Forma_De_Pago nvarchar(250),
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido),
	PRIMARY KEY CLUSTERED (Numero_Compra, Cod_Pasaje)
)
;
--CREACION TABLA TRANSACCIONES PAQUETES--

CREATE TABLE TODOX2LUCAS.TransaccionesPaquetes ( 
	Numero_Compra int  IDENTITY,
	Cod_Encomiendas numeric(18) REFERENCES TODOX2LUCAS.Encomiendas (Cod_Encomiendas),
	Fecha_Transaccion datetime,
	Nro_Dni numeric(18),
	Cliente_Apellido nvarchar(255),
	Forma_De_Pago nvarchar(250),
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido),
	PRIMARY KEY CLUSTERED (Numero_Compra, Cod_Encomiendas)
)
;

--CREACION TABLA CANCELACIONES-- 
CREATE TABLE TODOX2LUCAS.Cancelaciones ( 
	Codigo_Devolucion int IDENTITY,
	Fecha_Devolucion datetime,
	Numero_Compra_Pasajes int ,
	Cod_Pasaje numeric(18) ,
	Motivo nvarchar(255),
	Numero_Compra_Paquetes int ,
	Cod_Encomiendas numeric(18),
	PRIMARY KEY CLUSTERED (Codigo_Devolucion, Cod_Pasaje, Cod_Encomiendas),
	FOREIGN KEY (Numero_Compra_Pasajes,Cod_Pasaje) REFERENCES TODOX2LUCAS.TransaccionesPasajes (Numero_Compra,Cod_Pasaje),
	FOREIGN KEY (Numero_Compra_Paquetes,Cod_Encomiendas) REFERENCES TODOX2LUCAS.TransaccionesPaquetes (Numero_Compra,Cod_Encomiendas)
)
;
GO
/************************************************** PROCEDIMIENTOS Y TRIGGERS ***************************************************/
/* ------------ PROCEDIMIENTO PARA AGREGAR FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Agregar_Funcionalidad(@Funcionalidad nvarchar(255))
AS
BEGIN
	BEGIN TRANSACTION
	IF NOT EXISTS(SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Funcionalidades WHERE Nombre_Funcionalidad=@Funcionalidad)
	BEGIN
		INSERT INTO TODOX2LUCAS.Funcionalidades(Nombre_Funcionalidad) 
		VALUES(@Funcionalidad)
	END
	ELSE
	BEGIN
		print 'Ya existe la funcionalidad'
		ROLLBACK
	END
	COMMIT TRANSACTION
END
;
GO

/* ------------ PROCEDIMIENTO PARA AGREGAR ROLES  ------------ */
CREATE PROCEDURE TODOX2LUCAS.Agregar_Rol(@rol nvarchar(255))
AS
BEGIN
	IF NOT EXISTS (SELECT Cod_Rol FROM TODOX2LUCAS.Roles WHERE Nombre_Rol=@rol)
	BEGIN
	INSERT INTO TODOX2LUCAS.Roles(Nombre_Rol,Estado_Rol)
	VALUES (@rol,1)
	END
	ELSE 
	BEGIN
		print 'Ya existe el rol'
	END
END
;
GO

/* ------------ PROCEDIMIENTO QUE AGREGA LAS FUNCIONALIDADES A UN ROL DETERMINADO ------------ */
CREATE PROCEDURE TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad(@rol nvarchar(255),@funcionalidad nvarchar(255))
AS
BEGIN
	DECLARE @codRol int,@codFuncionalidad int;
	SET @codFuncionalidad = (SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Funcionalidades WHERE Nombre_Funcionalidad = @funcionalidad)
	SET @codRol = (SELECT Cod_Rol FROM TODOX2LUCAS.Roles WHERE Nombre_Rol = @rol)
	IF NOT EXISTS(SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Rol_Por_Funcionalidad WHERE Cod_Funcionalidad=@codFuncionalidad)
	BEGIN
		INSERT INTO TODOX2LUCAS.Rol_Por_Funcionalidad(Cod_Rol,Cod_Funcionalidad)
		VALUES (@codRol,@codFuncionalidad)
	END
	ELSE
	BEGIN 
		print 'El rol ya posee esa funcionalidad'
	END
END
; 
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR ROLES Y SUS FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Nombre_Rol(@rol nvarchar(255),@nuevoNombreRol nvarchar(255))
AS
BEGIN
	IF EXISTS (SELECT Cod_Rol FROM TODOX2LUCAS.Roles WHERE Nombre_Rol=@rol)
	BEGIN 
		UPDATE TODOX2LUCAS.Roles
		SET Nombre_Rol = @nuevoNombreRol
		WHERE Nombre_Rol=@rol
	END
	ELSE
	BEGIN
		print 'El rol a modificar no existe'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR EL ESTADO DE UN ROL ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Estado_Rol(@rol nvarchar(255),@estado bit)
AS
BEGIN
	IF EXISTS (SELECT Cod_Rol FROM TODOX2LUCAS.Roles WHERE Nombre_Rol=@rol)
	BEGIN
		UPDATE TODOX2LUCAS.Roles
		SET Estado_Rol = @estado
		WHERE Nombre_Rol=@rol
	END
	ELSE
	BEGIN
		print 'El rol a modificar no existe'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA DAR DE BAJA UN ROL ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Rol(@rol nvarchar(255))
AS
BEGIN
	IF EXISTS (SELECT Cod_Rol FROM TODOX2LUCAS.Roles WHERE Nombre_Rol=@rol)
	BEGIN
		--Si el estado del rol esta en 1 esta activo en 0 esta inactivo--
		UPDATE TODOX2LUCAS.Roles
		SET Estado_Rol = 0
		WHERE Nombre_Rol=@rol
	END
	ELSE
	BEGIN
		print 'El rol que quiere dar de baja no existe'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA AGREGAR LOS TIPOS DE SERVICIOS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Agregar_Tipo_De_Servicio(@tipoServicio nvarchar(255),@precio int)
AS
BEGIN
	IF NOT EXISTS(SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio = @tipoServicio)
	BEGIN
		INSERT INTO TODOX2LUCAS.Tipos_De_Servicios(Descripcion_Servicio,Precio_Servicio)
		VALUES(@tipoServicio,@precio)
	END
END
;
GO

/* ------------ PROCEDIMIENTO QUE MIGRA LOS DATOS DE LA TABLA MAESTRA A LA TABLA DE AERONAVES CON CURSOR ------------ */
CREATE PROCEDURE TODOX2LUCAS.Migrar_Aeronaves
AS
BEGIN
	DECLARE @matricula nvarchar(255),@fecha datetime,@modelo nvarchar(255),@kgs numeric(18),
			@codServicio  int, @codFabricante int, @fabricante nvarchar(255),@servicio nvarchar(255);
	
	DECLARE fila_Aeronave CURSOR FOR
	SELECT DISTINCT Aeronave_Matricula,GETDATE(),
					Aeronave_Fabricante,Aeronave_Modelo,
					Aeronave_KG_Disponibles,Tipo_Servicio
	FROM gd_esquema.Maestra
	
	OPEN fila_Aeronave
	FETCH NEXT FROM fila_Aeronave INTO @matricula,@fecha, @fabricante,@modelo,@kgs,@servicio
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		
		SET @codServicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio =@servicio)
		SET @codFabricante = (SELECT Cod_Fabricante FROM TODOX2LUCAS.Fabricantes WHERE Nombre_Fabricante = @fabricante);
		INSERT INTO TODOX2LUCAS.Aeronaves(Matricula,Fecha_Alta,Cod_Fabricante,Modelo,Cod_Tipo_Servicio,Kgs_Disponibles)
		VALUES (@matricula,@fecha,@codFabricante,@modelo,@codServicio,@kgs)
		
													
		FETCH NEXT FROM fila_Aeronave INTO @matricula,@fecha, @fabricante,@modelo,@kgs,@servicio

	END
	

	CLOSE fila_Aeronave
	DEALLOCATE fila_Aeronave
	

END
GO

/* ------------ PROCEDIMIENTO QUE MIGRA LOS DATOS DE LA TABLA MAESTRA A LA TABLA DE RUTAS AEREAS CON CURSOR ------------ */
CREATE PROCEDURE TODOX2LUCAS.Migrar_Rutas_Aereas
AS
BEGIN
	DECLARE @codRuta numeric(18), @codOrigen int, @codDestino int, @codAeronave int, @codServicio int,
			@precioPasaje numeric(18,2),@precioKg numeric(18,2), @nombreOrigen nvarchar(255),
			@nombreDestino nvarchar(255),@servicio nvarchar(255);
	DECLARE cursor_rutas CURSOR
	FOR 
	SELECT DISTINCT M1.Ruta_Codigo,M1.Ruta_Ciudad_Origen,M1.Ruta_Ciudad_Destino,
				M1.Tipo_Servicio,M1.Ruta_Precio_BasePasaje
	FROM gd_esquema.Maestra M1 
	WHERE M1.Ruta_Precio_BasePasaje != 0
	

	OPEN cursor_rutas
	FETCH NEXT FROM cursor_rutas INTO @codRuta,@nombreOrigen,@nombreDestino,@servicio,@precioPasaje
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @nombreOrigen)
		SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @nombreDestino)
		SET @codServicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio=@servicio)
		SET @precioKg = (SELECT DISTINCT Ruta_Precio_BaseKG
					FROM gd_esquema.Maestra m
					WHERE m.Ruta_Codigo=@codRuta AND m.Ruta_Ciudad_Origen=@nombreOrigen AND
						m.Ruta_Ciudad_Destino=@nombreDestino AND Ruta_Precio_BaseKG != 0)

		INSERT INTO TODOX2LUCAS.RutasAereas(Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Tipo_Servicio,Precio_Base_Pasaje,Precio_Base_Kg,Estado_Ruta)
		VALUES (@codOrigen,@codDestino,@codServicio,@precioPasaje,@precioKg,1)
		
		FETCH NEXT FROM  cursor_rutas INTO @codRuta,@nombreOrigen,@nombreDestino,@servicio,@precioPasaje
	END
	CLOSE cursor_rutas
	DEALLOCATE cursor_rutas
	
END
GO

/* ------------ PROCEDIMIENTO DE LOGIN - SOLO PUEDEN UTILIZARLOS LOS ADMINISTRATIVOS ------------ */


/* ------------ ACTUALIZA INTENTOS DE LOGIN	------------ */
CREATE PROCEDURE TODOX2LUCAS.actualizarIntentos(@username nvarchar(255),@Cantidad int) 
AS
BEGIN
	IF (@Cantidad = 0 )
	BEGIN
		DECLARE @IntentosActuales int;
		UPDATE TODOX2LUCAS.Usuarios 
		SET Intentos_Login = Intentos_Login + 1 
		WHERE Usuario_Nombre = @username
		
		SELECT @IntentosActuales = Intentos_Login 
		FROM TODOX2LUCAS.Usuarios
		WHERE Usuario_Nombre = @username

		IF (@IntentosActuales) >= 3
		BEGIN	
			UPDATE TODOX2LUCAS.Usuarios 
			SET Estado_Usuario = 0 
			WHERE Usuario_Nombre = @username
		END

		INSERT INTO TODOX2LUCAS.Auditoria_Login(Usuario_Nombre,Estado,Numero_De_Intento)
		VALUES((SELECT Usuario_Nombre FROM TODOX2LUCAS.Usuarios WHERE Usuario_Nombre = @username),0,@IntentosActuales)
	END
	ELSE
	BEGIN
		UPDATE TODOX2LUCAS.Usuarios 
		SET Intentos_Login = 0 
		WHERE Usuario_Nombre= @username
		
		INSERT INTO TODOX2LUCAS.Auditoria_Login(Usuario_Nombre,Estado)
		VALUES((SELECT Usuario_Nombre FROM TODOX2LUCAS.Usuarios WHERE Usuario_Nombre= @username),1)
	END
END

GO


/* ------------ PROCEDIMIENTO PARA VALIDAR EL LOGIN ------------ */

CREATE PROCEDURE TODOX2LUCAS.Validar_Login(@username varchar(255),@password varchar(255)) 
AS
BEGIN
	DECLARE @Cantidad int;
	
	SELECT @Cantidad = COUNT(Usuario_Nombre) 
	FROM TODOX2LUCAS.Usuarios
	WHERE Estado_Usuario = 1 AND
		  Usuario_Nombre = @username AND
		  Contrase�a = @password
	
	EXEC TODOX2LUCAS.actualizarIntentos @username,@Cantidad
	
	RETURN @Cantidad
END

GO


/* ------------ ABM DE CIUDADES NO DEBE IMPLEMENTARSE ------------ */

/* ------------ PROCEDIMIENTO PARA DAR DE ALTA UNA RUTA AEREA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Alta_Ruta_Aerea(@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255),
												@servicio nvarchar(255),@preciobasekg numeric(18,2),@preciobasepasaje numeric(18,2))
AS
BEGIN
	DECLARE @codOrigen int,@codDestino int,@codServicio int;
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);
	SET @codServicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio=@servicio);

	IF NOT EXISTS (SELECT r.Cod_Ruta FROM TODOX2LUCAS.RutasAereas r WHERE r.Cod_Ciudad_Origen=@codOrigen AND r.Cod_Ciudad_Destino=@codDestino AND r.Cod_Tipo_Servicio=@codServicio AND r.Precio_Base_Kg=@preciobasekg AND r.Precio_Base_Pasaje=@preciobasepasaje)
	BEGIN
		INSERT INTO TODOX2LUCAS.RutasAereas(Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Tipo_Servicio,Precio_Base_Kg,Precio_Base_Pasaje,Estado_Ruta)
		VALUES(@codOrigen,@codDestino,@codServicio,@preciobasekg,@preciobasepasaje,1)
	END
	ELSE
	BEGIN
		print 'La ruta que intenta dar de alta ya existe'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA CANCELAR PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cancelar_Pasajes(@fecha datetime,@codAeronave int,@codRuta numeric(18),@motivo nvarchar(255))
AS
BEGIN
	INSERT INTO TODOX2LUCAS.Cancelaciones(Fecha_Devolucion,Numero_Compra_Pasajes,Cod_Pasaje,Motivo)
	SELECT @fecha,t.Numero_Compra,p.Cod_Pasaje,@motivo
	FROM TODOX2LUCAS.Pasajes p JOIN TODOX2LUCAS.Viajes v ON (p.Cod_Viaje=v.Cod_Viaje)
								JOIN TODOX2LUCAS.TransaccionesPasajes t ON (T.Cod_Pasaje=P.Cod_Pasaje)
	WHERE v.Cod_Aeronave = @codAeronave OR
			v.Cod_Ruta = @codRuta
	
END
GO

/* ------------ PROCEDIMIENTO PARA CANCELAR PAQUETES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cancelar_Paquetes(@fecha datetime,@codAeronave int,@codRuta numeric(18),@motivo nvarchar(255))
AS
BEGIN
	INSERT INTO TODOX2LUCAS.Cancelaciones(Fecha_Devolucion,Numero_Compra_Paquetes,Cod_Encomiendas,Motivo)
	SELECT @fecha,t.Numero_Compra,e.Cod_Encomiendas,@motivo
	FROM TODOX2LUCAS.Encomiendas e JOIN TODOX2LUCAS.Viajes v ON (e.Cod_Viaje=v.Cod_Viaje)
								JOIN TODOX2LUCAS.TransaccionesPaquetes t ON (T.Cod_Encomiendas=e.Cod_Encomiendas)
	WHERE v.Cod_Aeronave = @codAeronave OR
			v.Cod_Ruta = @codRuta
END
GO

/* ------------ PROCEDIMIENTO PARA DAR DE BAJA UNA RUTA AEREA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Ruta_Aerea(@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255),
												@servicio nvarchar(255),@preciobasekg numeric(18,2),@preciobasepasaje numeric(18,2),@motivo nvarchar(255))
AS
BEGIN
	DECLARE @codOrigen int,@codDestino int,@codServicio int, @codRuta numeric(18);
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);
	SET @codServicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio=@servicio);
	SET @codRuta = (SELECT r.Cod_Ruta FROM TODOX2LUCAS.RutasAereas r WHERE r.Cod_Ciudad_Origen=@codOrigen AND r.Cod_Ciudad_Destino=@codDestino AND r.Cod_Tipo_Servicio=@codServicio AND r.Precio_Base_Kg=@preciobasekg AND r.Precio_Base_Pasaje=@preciobasepasaje)
	
	IF EXISTS ((SELECT r.Cod_Ruta FROM TODOX2LUCAS.RutasAereas r WHERE r.Cod_Ciudad_Origen=@codOrigen AND r.Cod_Ciudad_Destino=@codDestino AND r.Cod_Tipo_Servicio=@codServicio AND r.Precio_Base_Kg=@preciobasekg AND r.Precio_Base_Pasaje=@preciobasepasaje))
	BEGIN
		DECLARE @fecha datetime;
		SET @fecha = getdate();
		--El estado si esta en 1 esta activa, en 0 esta desactivada
		UPDATE TODOX2LUCAS.RutasAereas
		SET Estado_Ruta = 0
		WHERE Cod_Ruta = @codRuta
		
		EXEC TODOX2LUCAS.Cancelar_Pasajes @fecha,NULL,@codRuta,@motivo

		EXEC TODOX2LUCAS.Cancelar_Paquetes @fecha,NULL,@codRuta,@motivo

	END
	ELSE
	BEGIN
		print 'La ruta que quiere dar de baja no existe'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR DATOS DE RUTAS AEREAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Ciudades_Ruta_Aereas(@codRuta numeric(18),@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255))
AS
BEGIN
	DECLARE @codOrigen int,@codDestino int;
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);
	IF (@codDestino = NULL OR @codOrigen = NULL)
	BEGIN
		print 'Las ciudades ingresadas no existen'
	END

	UPDATE TODOX2LUCAS.RutasAereas
	SET Cod_Ciudad_Origen = @codOrigen,
		Cod_Ciudad_Destino = @codDestino
	WHERE Cod_Ruta = @codRuta
	
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR EL TIPO DE SERVICIO DADO POR LA RUTA AEREA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Servicio_Ruta_Aerea(@codRuta numeric(18),@servicio nvarchar(255))
AS
BEGIN
	DECLARE @codServicio int;
	SET @codServicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio=@servicio);
	IF (@codServicio = NULL) 
	BEGIN 
		print 'El servicio ingresado no existe'
	END
	
	UPDATE TODOX2LUCAS.RutasAereas
	SET Cod_Tipo_Servicio = @codServicio
	WHERE Cod_Ruta = @codRuta
	
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR LOS PRECIOS DE UNA RUTA AEREA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Precios_Ruta_Aerea(@codRuta numeric(18),@precioKgs numeric(18,2),@precioPasaje numeric(18,2))
AS
BEGIN
	UPDATE TODOX2LUCAS.RutasAereas
	SET Precio_Base_Kg = @precioKgs,
		Precio_Base_Pasaje = @precioPasaje
	WHERE Cod_Ruta = @codRuta
END
GO

/* ------------ PROCEDMIENTO PARA DAR DE BAJA UNA AERONAVE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Por_Vida_Util(@codAeronave int,@cancelaciones bit)
AS
BEGIN
	DECLARE @fecha datetime,@motivo nvarchar(255);
	SET @fecha = GETDATE();
	SET @motivo = 'Baja por vida util completa';
	
	INSERT INTO TODOX2LUCAS.Estados_Aeronaves (Cod_Aeronave,Vida_Util,Fecha_Baja_Definitiva)
	VALUES(@codAeronave,1,@fecha)

	IF (@cancelaciones = 0)
	BEGIN
		DECLARE @codfabricante int ,@codServicio int,@modelo nvarchar(255);
		SELECT A.Cod_Fabricante,A.Cod_Tipo_Servicio,A.Modelo
		FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Viajes v ON (a.Cod_Aeronave=v.Cod_Aeronave)
		WHERE a.Cod_Aeronave = 2 --@codAeronave
			AND v.Fecha_Salida > @fecha

		--BUSCAR AERONAVE PARA SUPLANTAR--
		--SELECT DISTINCT a1.Cod_Aeronave,v.Cod_Ciudad_Origen
		--FROM TODOX2LUCAS.Aeronaves a1 JOIN TODOX2LUCAS.Viajes v ON (a1.Cod_Aeronave=v.Cod_Aeronave)
		--	GROUP BY a1.Cod_Aeronave,a2.Cod_Aeronave
		--	HAVING SELECT A1.COD_AERONAVE
		--		FROM TODOX2LUCAS.Aeronaves a1 JOIN TODOX2LUCAS.Viajes v ON (a1.Cod_Aeronave=v.Cod_Aeronave)
		--		WHERE
		
	END
	ELSE
	BEGIN
		EXEC TODOX2LUCAS.Cancelar_Pasajes @fecha,@codAeronave,NULL,@motivo
		EXEC TODOX2LUCAS.Cancelar_Paquetes @fecha,@codAeronave,NULL,@motivo
	END
END
GO

/* ------------ PROCEDIMIENTO PARA DAR DE ALTA UNA AERONAVE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Alta_Aeronave(@matricula nvarchar(255),@fecha_Alta datetime,@fabricante nvarchar(255),
											@modelo nvarchar(255),@servicio nvarchar(255), @kgs_Disponibles numeric(18))
AS
BEGIN
	DECLARE @cod_Fabricante int,@cod_Tipo_Servicio int;
	SET @cod_Fabricante = (SELECT Cod_Fabricante FROM TODOX2LUCAS.Fabricantes WHERE Nombre_Fabricante=@fabricante);
	IF (@cod_Fabricante = NULL) 
	BEGIN
		print 'El fabricante ingresado no existe' 
	END
	SET @cod_Tipo_Servicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio = @servicio);
	IF (@cod_Tipo_Servicio = NULL)
	BEGIN 
		print 'El servicio ingresado no existe'
	END

	INSERT INTO TODOX2LUCAS.Aeronaves(Matricula,Fecha_Alta,Cod_Fabricante,Modelo,Cod_Tipo_Servicio,Kgs_Disponibles )
	VALUES(@matricula,@fecha_Alta,@cod_Fabricante,@modelo,@cod_Tipo_Servicio,@kgs_Disponibles)

END
GO

/* ------------ PROCEDIMIENTO PARA GENERAR UN VIAJE ------------ */
CREATE PROCEDURE  TODOX2LUCAS.Generar_Viaje(@codRuta numeric(18),@cod_Aeronave int,@fechaSalida datetime,@fechaLlegada datetime,@fechaLlegadestimada datetime)
AS 
BEGIN
	IF (@fechaSalida > GETDATE() AND @fechaLlegada > @fechaSalida AND @fechaLlegadestimada > @fechaSalida)
	BEGIN
		DECLARE @codOrigen int,@codDestino int;
		SELECT @codOrigen = Cod_Ciudad_Origen, @codDestino = Cod_Ciudad_Destino
		FROM TODOX2LUCAS.RutasAereas
		WHERE Cod_Ruta = @codRuta

		INSERT INTO TODOX2LUCAS.Viajes(Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Aeronave,Fecha_Salida,Fecha_Llegada,Fecha_Llegada_Estimada)
		VALUES(@codRuta,@codOrigen,@codDestino,@cod_Aeronave,@fechaSalida,@fechaLlegada,@fechaLlegadestimada)

	END
	ELSE
	BEGIN
		print 'Las fechas ingresadas son invalidas'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA EL REGISTRO DE LLEGADAS A DESTINO DE LAS AERONAVES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Registrar_Llegada(@matricula nvarchar(255),@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255))
AS
BEGIN
	DECLARE @codOrigen int, @codDestino int;
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);

	SELECT a.Cod_Aeronave,a.Cod_Fabricante,a.Cod_Tipo_Servicio,a.Fecha_Alta,a.Kgs_Disponibles,a.Matricula,a.Modelo,V.Cod_Viaje,V.Cod_Ciudad_Origen,V.Cod_Ciudad_Destino,V.Fecha_Llegada
	FROM TODOX2LUCAS.Aeronaves a JOIN TODOX2LUCAS.Viajes v ON(a.Cod_Aeronave=v.Cod_Aeronave)
	WHERE Matricula = 'WWJ-213' AND V.Cod_Ciudad_Origen = 15 AND V.Cod_Ciudad_Destino= 21
	
	
	
END
GO

/* ------------ PROCEDIMIENTO PARA CANJES CON LAS MILLAS DE UN CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Canjear_Millas(@dni numeric(18),@cliente nvarchar(255),@producto nvarchar(255),@cantidad int)
AS
BEGIN
	IF ((SELECT Cantidad FROM TODOX2LUCAS.Productos p WHERE Descripcion_Producto = @producto) < @cantidad)
	BEGIN
		print 'No hay disponibilidad de stock'
	END
	ELSE 
	BEGIN
		DECLARE @codProducto int;
		SELECT @codProducto = Cod_Producto FROM TODOX2LUCAS.Productos WHERE Descripcion_Producto = @producto
		INSERT INTO TODOX2LUCAS.Canjes(Nro_Dni,Cliente_Apellido,Cod_Producto,Fecha)
		VALUES (@dni,@cliente,@codProducto,GETDATE())

	END
END
GO

/* ------------ PROCEDIMIENTOS PARA LOS LISTADOS ESTADISTICOS ------------ */
/* ------------ Top 5 de los destinos con m�s pasajes comprados ------------ */
CREATE PROCEDURE TODOX2LUCAS.Pasajes_Mas_Comprados
AS
BEGIN
	SELECT TOP 5  COUNT(V.Cod_Ciudad_Destino),V.Cod_Ciudad_Destino,C.Nombre_Ciudad
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
								JOIN TODOX2LUCAS.Ciudades C ON (V.Cod_Ciudad_Destino = C.Cod_Ciudad)
	GROUP BY V.Cod_Ciudad_Destino, C.Nombre_Ciudad
	ORDER BY 1 DESC
END
GO

/* ------------ Top 5 de los destinos con aeronaves m�s vac�as ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronaves_Mas_Vacias
AS
BEGIN
	SELECT TOP 5 C.Nombre_Ciudad,COUNT(B.Cod_Butaca) AS 'CANT_BUTACAS'
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
								JOIN TODOX2LUCAS.Aeronaves A ON(A.Cod_Aeronave=V.Cod_Aeronave)
								JOIN TODOX2LUCAS.Butacas B ON(A.Cod_Aeronave=B.Cod_Aeronave AND P.Butaca_Asociada=B.Cod_Butaca)
								JOIN TODOX2LUCAS.Ciudades C ON (V.Cod_Ciudad_Destino = C.Cod_Ciudad)
	GROUP BY C.Nombre_Ciudad,B.Cod_Butaca,A.Cod_Aeronave
	ORDER BY 2 DESC

END
GO

/* ------------ Top 5 de los Clientes con m�s puntos acumulados a la fecha ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cliente_Mayoria_Puntos
AS
BEGIN
	SELECT TOP 5 Cant_Millas,Cliente_Apellido
	FROM TODOX2LUCAS.Clientes
	ORDER BY 1 DESC
END
GO

/* ------------ Top 5 de los destinos con pasajes cancelados ------------ */
CREATE PROCEDURE TODOX2LUCAS.Destinos_Mas_Cancelados
AS
BEGIN
	SELECT TOP 5 CIU.Nombre_Ciudad,COUNT(C.Cod_Pasaje)
	FROM TODOX2LUCAS.Cancelaciones C JOIN TODOX2LUCAS.Pasajes P ON (C.Cod_Pasaje=P.Cod_Pasaje)
									JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
									JOIN TODOX2LUCAS.Ciudades CIU ON (V.Cod_Ciudad_Destino=CIU.Cod_Ciudad)
	GROUP BY CIU.Nombre_Ciudad
	ORDER BY 2 DESC

END
GO

/* ------------ Top 5 de las aeronaves con mayor cantidad de d�as fuera de servicio ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronave_Mayoria_Fuera_Servicio
AS
BEGIN
	SELECT TOP 5 A.Cod_Aeronave,(DATEDIFF(DAY,E.Fecha_Reinicio_Servicio,E.Fecha_Fuera_Servicio)) AS 'DIAS FUERA DE SERVICIO'
	FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Estados_Aeronaves E ON(A.Cod_Aeronave=E.Cod_Aeronave)
	GROUP BY A.Cod_Aeronave, E.Fecha_Reinicio_Servicio,E.Fecha_Fuera_Servicio
	ORDER BY 2 DESC							
END
GO


/***************************************  TRIGGERS ***********************************************/
-- TRIGGER QUE ACTUALIZA EL ATRIBUTO DE LA TABLA CLIENTES(CANT_MILLAS) ANTE UN INSERT EN LA TABLA DE PASAJES--
GO
CREATE TRIGGER Sumar_Millas_Pasajes
ON TODOX2LUCAS.Pasajes 
AFTER INSERT
AS
BEGIN
	DECLARE @pasaje numeric(18),@millas int,@precio numeric(18,2),@dni numeric(18),@apellido nvarchar(255);
	
	DECLARE cursor_pasajes CURSOR FOR
	SELECT  i.Cod_Pasaje, i.Cliente_Apellido,i.Pasaje_Precio, i.Nro_Dni
	FROM inserted i 
	
	OPEN cursor_pasajes
	FETCH NEXT FROM cursor_pasajes INTO @pasaje ,@apellido,@precio ,@dni 
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		SET @millas = 0;
		SET @millas = (FLOOR(@precio) / 10);

		UPDATE TODOX2LUCAS.Clientes 
		SET Cant_Millas =   @millas + Cant_Millas
		WHERE Nro_Dni = @dni AND Cliente_Apellido = @apellido
	
		FETCH NEXT FROM cursor_pasajes INTO @pasaje ,@apellido,@precio ,@dni 
	END
	CLOSE cursor_pasajes
	DEALLOCATE cursor_pasajes
END
GO

CREATE TRIGGER Sumar_Millas_Paquetes
ON TODOX2LUCAS.Encomiendas 
AFTER INSERT
AS
BEGIN
	DECLARE @encomienda numeric(18),@millas int,@precio numeric(18,2),@dni numeric(18),@apellido nvarchar(255);
	
	DECLARE cursor_encomienda CURSOR FOR
	SELECT  i.Cod_Encomiendas, i.Cliente_Apellido,i.Precio_Encomienda, i.Nro_Dni
	FROM inserted i 
	
	OPEN cursor_encomienda
	FETCH NEXT FROM cursor_encomienda INTO @encomienda ,@apellido,@precio ,@dni 
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		SET @millas = 0;
		SET @millas = (FLOOR(@precio) / 10);

		UPDATE TODOX2LUCAS.Clientes 
		SET Cant_Millas =   @millas + Cant_Millas
		WHERE Nro_Dni = @dni AND Cliente_Apellido = @apellido
	
		FETCH NEXT FROM cursor_encomienda INTO @encomienda ,@apellido,@precio ,@dni 
	END
	CLOSE cursor_encomienda
	DEALLOCATE cursor_encomienda
END
GO

/***************************************  MIGRACIONES DE DATOS ***********************************************/

--MIGRACINON TABLA CIUDADES--
INSERT INTO TODOX2LUCAS.Ciudades(Nombre_Ciudad,Estado_Ciudad)
SELECT DISTINCT Ruta_Ciudad_Destino, 1
FROM gd_esquema.Maestra
UNION
SELECT DISTINCT Ruta_Ciudad_Origen, 1
FROM gd_esquema.Maestra
;
GO
--MIGRACION TABLA FABRICANTES--
INSERT INTO TODOX2LUCAS.Fabricantes(Nombre_Fabricante)
SELECT DISTINCT Aeronave_Fabricante FROM gd_esquema.Maestra
;
GO
--DATOS INICIALES PARA LA TABLA FUNCIONALIDADES--

EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Rol'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificaci�n Rol'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Rol'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Ciudad'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificaci�n Ciudad'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Ciudad'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Aeronave'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificaci�n Aeronave'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Aeronave'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Ruta'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificaci�n Ruta'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Ruta'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Canje Millas'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Compra Pasajes'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Compra Encomiendas'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Consulta Millas'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Devoluci�n'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Generaci�n Viaje'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Listado Estad�stico'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Registro de Usuario'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Registro Llegada Destino'
GO
--DATOS INICIALES PARA LA TABLA DE PRODUCTOS--



--DATOS INICIALES PARA LA TABLA DE ROLES--

EXEC TODOX2LUCAS.Agregar_Rol 'Cliente'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador General'

GO
--DATOS INICIALES PARA LA TABLA USUARIOS--
DECLARE @clave nvarchar(255);
SET @clave = HASHBYTES('SHA2_256','w23e');
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contrase�a,Cod_Rol)
SELECT DISTINCT CONVERT(nvarchar(255),Cli_Dni) + Cli_Apellido, @clave, 1
FROM gd_esquema.Maestra

GO

/* ------------ SET DE USUSARIOS PARA EL TP (EL ABM DE USUARIO NO SE DEBE IMPLEMENTAR) ------------ */
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contrase�a,Cod_Rol,Estado_Usuario)
VALUES('Lucas',HASHBYTES('SHA2_256','w23e'),2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contrase�a,Cod_Rol,Estado_Usuario)
VALUES('Eduardo',HASHBYTES('SHA2_256','w23e'),2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contrase�a,Cod_Rol,Estado_Usuario)
VALUES('Pepe',HASHBYTES('SHA2_256','w23e'),2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contrase�a,Cod_Rol,Estado_Usuario)
VALUES('Roman',HASHBYTES('SHA2_256','w23e'),2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contrase�a,Cod_Rol,Estado_Usuario)
VALUES('Messi',HASHBYTES('SHA2_256','w23e'),2,1)
GO


--DATOS INICIALES PARA LA TABLA ROL POR FUNCIONALIDAD--

EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Rol'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificaci�n Rol'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Rol'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Registro de Usuario'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Ciudad'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificaci�n Ciudad'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Ciudad'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Ruta'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificaci�n Ruta'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Ruta'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Aeronave'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificaci�n Aeronave'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Aeronave'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Generaci�n Viaje'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Registro Llegada Destino'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Compra Pasajes'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Compra Encomiendas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Compra Pasajes'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Compra Encomiendas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Devoluci�n'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Consulta Millas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Canje Millas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Listado Estad�stico'
GO
--MIGRACION CLIENTES--
INSERT INTO TODOX2LUCAS.Clientes(Nro_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Direccion, Cliente_Telefono, Cliente_Mail, Cliente_Fecha_Nacimiento, Cant_Millas, Usuario_Nombre)
SELECT DISTINCT Cli_Dni, Cli_Nombre, Cli_Apellido, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, 0 , CONVERT(nvarchar(255),Cli_Dni) + Cli_Apellido
FROM gd_esquema.Maestra  

GO
--DATOS INICIALES TABLA TARJETAS--




--MIGRACION TABLA TIPOS DE SERVICIOS--

EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Primera Clase' , 2000
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Ejecutivo', 1000
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Turista', 500

GO
--MIGRACION TABLA AERONAVES--
EXEC TODOX2LUCAS.Migrar_Aeronaves

GO
--MIGRACION TABLA ESTADOS AERONAVES--

--esta tabla no necesita de migracion tendra que ir actualizandose a medida que en la aplicacion lo utilicen

--MIGRACION TABLA BUTACAS--
INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca,Estado_Butaca)
SELECT DISTINCT A.Cod_Aeronave,Butaca_Nro,Butaca_Tipo, Butaca_Piso,1
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Aeronaves A ON (A.Matricula = M.Aeronave_Matricula)
WHERE Butaca_Piso!=0 AND Butaca_Tipo !='0'
ORDER BY A.Cod_Aeronave,Butaca_Nro

GO
--MIGRACION TABLA RUTASAEREAS--
EXEC TODOX2LUCAS.Migrar_Rutas_Aereas

GO
--MIGRACION TABLA VIAJES

INSERT INTO TODOX2LUCAS.Viajes(Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Aeronave,Fecha_Salida,Fecha_Llegada,Fecha_Llegada_Estimada)
SELECT DISTINCT r.Cod_Ruta,c1.Cod_Ciudad,c2.Cod_Ciudad,a.Cod_Aeronave,m.FechaSalida,m.FechaLLegada,m.Fecha_LLegada_Estimada
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Ciudades c1 ON(m.Ruta_Ciudad_Origen=c1.Nombre_Ciudad)
							JOIN TODOX2LUCAS.Ciudades c2 ON(m.Ruta_Ciudad_Destino=c2.Nombre_Ciudad)
							JOIN TODOX2LUCAS.RutasAereas r ON (c1.Cod_Ciudad = r.Cod_Ciudad_Origen AND c2.Cod_Ciudad=r.Cod_Ciudad_Destino) 
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula = a.Matricula)

GO
--MIGRACION TABLA CANJES--

--MIGRACION TABLA ENCOMIENDAS--
--tiene q dar 135.658
GO
INSERT INTO TODOX2LUCAS.Encomiendas(Cod_Encomiendas,Precio_Encomienda,Kgs_A_Enviar,Fecha_Compra,Cod_Viaje,Nro_Dni,Cliente_Apellido)
SELECT DISTINCT M.Paquete_Codigo,M.Paquete_Precio,M.Paquete_KG,M.Paquete_FechaCompra,v.Cod_Viaje,C.Nro_Dni,c.Cliente_Apellido
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Clientes C ON(C.Nro_Dni = M.Cli_Dni AND c.Cliente_Apellido=m.Cli_Apellido)
							JOIN TODOX2LUCAS.Ciudades co ON (co.Nombre_Ciudad=m.Ruta_Ciudad_Origen)
							JOIN TODOX2LUCAS.Ciudades cd ON (cd.Nombre_Ciudad=Ruta_Ciudad_Destino)
							JOIN TODOX2LUCAS.RutasAereas r ON (co.Cod_Ciudad=r.Cod_Ciudad_Origen AND cd.Cod_Ciudad=r.Cod_Ciudad_Destino)
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula=a.Matricula)
							JOIN TODOX2LUCAS.Viajes v ON(v.Cod_Ruta =r.Cod_Ruta AND v.Cod_Aeronave=a.Cod_Aeronave AND v.Fecha_Salida=m.FechaSalida AND v.Fecha_Llegada=m.FechaLLegada AND v.Fecha_Llegada_Estimada=m.Fecha_LLegada_Estimada)
							
WHERE M.Paquete_Codigo != 0

GO
--MIGRACION TABLA PASAJES--
-- tendria que dar 265.646

INSERT INTO TODOX2LUCAS.Pasajes(Cod_Pasaje,Fecha_Viaje,Cod_Viaje,Butaca_Asociada,Nro_Dni,Pasaje_Precio,Cliente_Apellido)
SELECT DISTINCT m.Pasaje_Codigo,m.Pasaje_FechaCompra,v.Cod_Viaje,b.Cod_Butaca,c.Nro_Dni,m.Pasaje_Precio,c.Cliente_Apellido
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Ciudades co ON (co.Nombre_Ciudad=m.Ruta_Ciudad_Origen)
							JOIN TODOX2LUCAS.Ciudades cd ON (cd.Nombre_Ciudad=Ruta_Ciudad_Destino)
							JOIN TODOX2LUCAS.RutasAereas r ON (co.Cod_Ciudad=r.Cod_Ciudad_Origen AND cd.Cod_Ciudad=r.Cod_Ciudad_Destino)
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula=a.Matricula)
							JOIN TODOX2LUCAS.Viajes v ON(v.Cod_Ruta =r.Cod_Ruta AND v.Cod_Aeronave=a.Cod_Aeronave AND v.Fecha_Salida=m.FechaSalida AND v.Fecha_Llegada=m.FechaLLegada AND v.Fecha_Llegada_Estimada=m.Fecha_LLegada_Estimada)
							JOIN TODOX2LUCAS.Butacas b ON(b.Cod_Aeronave=a.Cod_Aeronave AND m.Butaca_Nro=b.Cod_Butaca)
							JOIN TODOX2LUCAS.Clientes c ON (c.Nro_Dni=m.Cli_Dni AND c.Cliente_Apellido=m.Cli_Apellido)
WHERE m.Pasaje_Codigo != 0

GO


--MIGRACION TABLA TRANSACCIONES PASAJES--
INSERT INTO TODOX2LUCAS.TransaccionesPasajes(Cod_Pasaje,Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
SELECT DISTINCT p.Cod_Pasaje,m.Pasaje_FechaCompra,c.Nro_Dni,c.Cliente_Apellido,'Efectivo'
FROM TODOX2LUCAS.Pasajes p JOIN TODOX2LUCAS.Clientes c ON (p.Nro_Dni=c.Nro_Dni AND p.Cliente_Apellido=c.Cliente_Apellido)
							JOIN gd_esquema.Maestra m ON (m.Pasaje_Codigo=p.Cod_Pasaje)
							
GO
--MIGRACION TABLA TRANSACCIONES PAQUETES--
INSERT INTO TODOX2LUCAS.TransaccionesPaquetes(Cod_Encomiendas,Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
SELECT DISTINCT e.Cod_Encomiendas,m.Paquete_FechaCompra,c.Nro_Dni,c.Cliente_Apellido,'Efectivo'
FROM TODOX2LUCAS.Encomiendas e JOIN TODOX2LUCAS.Clientes c ON (e.Nro_Dni=c.Nro_Dni AND e.Cliente_Apellido=c.Cliente_Apellido)
							JOIN gd_esquema.Maestra m ON (m.Paquete_Codigo=e.Cod_Encomiendas)
GO

--MIGRACION TABLA CANCELACIONES--
USE GD2C2015
GO
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'TODOX2LUCAS')
BEGIN
	EXEC ('CREATE SCHEMA TODOX2LUCAS AUTHORIZATION gd')
END
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
IF OBJECT_ID('TODOX2LUCAS.Cargar_Butacas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Cargar_Butacas;
IF OBJECT_ID('TODOX2LUCAS.Consulta_Millas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Consulta_Millas;
IF OBJECT_ID('TODOX2LUCAS.Mostrar_Viajes_Disponibles') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Mostrar_Viajes_Disponibles;
IF OBJECT_ID('TODOX2LUCAS.Comprar_Pasajes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Comprar_Pasajes;
IF OBJECT_ID('TODOX2LUCAS.Alta_Cliente') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Alta_Cliente;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Datos_Cliente') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Datos_Cliente;
IF OBJECT_ID('TODOX2LUCAS.Baja_Por_Fuera_De_Servicio') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Baja_Por_Fuera_De_Servicio;
IF OBJECT_ID('TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones;
IF OBJECT_ID('TODOX2LUCAS.GetRuta') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetRuta;
IF OBJECT_ID('TODOX2LUCAS.GetAeronave') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetAeronave;
IF OBJECT_ID('TODOX2LUCAS.GetTipoServicio') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetTipoServicio;
IF OBJECT_ID('TODOX2LUCAS.GetFabricante') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetFabricante;
IF OBJECT_ID('TODOX2LUCAS.GetCliente') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCliente;
IF OBJECT_ID('TODOX2LUCAS.GetViaje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetViaje;
IF OBJECT_ID('TODOX2LUCAS.Comprar_Encomienda') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Comprar_Encomienda;
IF OBJECT_ID('TODOX2LUCAS.Aeronave_Para_Reemplazar') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Aeronave_Para_Reemplazar;
IF OBJECT_ID('TODOX2LUCAS.Baja_Ciudad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Baja_Ciudad;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Nombre_Ciudad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Nombre_Ciudad;
IF OBJECT_ID('TODOX2LUCAS.Alta_Ciudad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Alta_Ciudad;
IF OBJECT_ID('TODOX2LUCAS.Filtrar_Aeronaves') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Filtrar_Aeronaves;
IF OBJECT_ID('TODOX2LUCAS.Filtrar_Roles') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Filtrar_Roles;
IF OBJECT_ID('TODOX2LUCAS.Filtrar_Ciudades') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Filtrar_Ciudades;
IF OBJECT_ID('TODOX2LUCAS.Alta_Ciudad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Alta_Ciudad;
IF OBJECT_ID('TODOX2LUCAS.Filtrar_Rutas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Filtrar_Rutas;
IF OBJECT_ID('TODOX2LUCAS.GetUsuario') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetUsuario;
IF OBJECT_ID('TODOX2LUCAS.GetRol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetRol;
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
	Cantidad int,
	PrecioEnMillas int
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
	Contraseña nvarchar(255) NOT NULL,
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
	Kgs_Disponibles numeric(18),
	Cantidad_Butacas int
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
	IF NOT EXISTS(SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Rol_Por_Funcionalidad WHERE Cod_Funcionalidad=@codFuncionalidad AND Cod_Rol=@codRol)
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
/* ------------ PROCEDIMIENTO QUE AGREGA LAS BUTACAS TOTALES DE CADA AERONAVE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cargar_Butacas
AS
BEGIN
	DECLARE @cod_aeronave int;
	DECLARE cursor_butacas CURSOR FOR
	SELECT Cod_Aeronave
	FROM TODOX2LUCAS.Aeronaves

	OPEN cursor_butacas
	FETCH NEXT FROM cursor_butacas INTO @cod_aeronave
	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE @butacasTotales int;

		SELECT @butacasTotales = COUNT(B.Cod_Butaca)
		FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Butacas B ON (A.Cod_Aeronave=B.Cod_Aeronave)
		WHERE A.Cod_Aeronave = @cod_aeronave

		UPDATE TODOX2LUCAS.Aeronaves
		SET Cantidad_Butacas = @butacasTotales
		WHERE Cod_Aeronave = @cod_aeronave

		FETCH NEXT FROM cursor_butacas INTO @cod_aeronave
	END
	CLOSE cursor_butacas
	DEALLOCATE cursor_butacas
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
		  Contraseña = @password
	
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
	IF NOT EXISTS (SELECT Cod_Viaje FROM TODOX2LUCAS.Viajes WHERE Cod_Ruta=@codRuta)
	BEGIN
		UPDATE TODOX2LUCAS.RutasAereas
		SET Precio_Base_Kg = @precioKgs,
			Precio_Base_Pasaje = @precioPasaje
		WHERE Cod_Ruta = @codRuta
	END
	
END
GO
/* ------------ PROCEDIMIENTO QUE DEVUELVE UNA AERONAVE A SUPLANTAR  ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronave_Para_Reemplazar(@codAeronave int,@aeronaveSuplente int OUT)
AS
BEGIN
	DECLARE @fecha datetime,@codfabricante int ,@codServicio int,@modelo nvarchar(255),@fechaSalida datetime,@fechaLlegadaEstimada datetime,@codViaje int;
	SET @fecha = GETDATE();
	
	SELECT DISTINCT @codfabricante = a.Cod_Fabricante, @modelo = A.Modelo, @codServicio = a.Cod_Tipo_Servicio
	FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Viajes v ON (A.Cod_Aeronave=v.Cod_Aeronave)
									JOIN TODOX2LUCAS.Pasajes P ON (V.Cod_Viaje=P.Cod_Viaje)
									JOIN TODOX2LUCAS.Encomiendas E ON (V.Cod_Viaje=E.Cod_Viaje)
	WHERE a.Cod_Aeronave =  @codAeronave 
	
	--BUSCAR AERONAVE PARA SUPLANTAR--
	SELECT DISTINCT TOP 1 @aeronaveSuplente = a1.Cod_Aeronave
	FROM TODOX2LUCAS.Aeronaves a1 JOIN TODOX2LUCAS.Viajes v ON (a1.Cod_Aeronave=v.Cod_Aeronave)
									JOIN TODOX2LUCAS.Pasajes P ON (V.Cod_Viaje=P.Cod_Viaje)
									JOIN TODOX2LUCAS.Encomiendas E ON (V.Cod_Viaje=E.Cod_Viaje)
	WHERE A1.Cod_Aeronave != 2	 AND
			A1.Cod_Fabricante =	@codfabricante  AND
			A1.Modelo =@modelo  AND
			A1.Cod_Tipo_Servicio = @codServicio  AND
			v.Fecha_Salida != ALL (SELECT DISTINCT Fecha_Salida 
									FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Viajes v ON (A.Cod_Aeronave=v.Cod_Aeronave)
																JOIN TODOX2LUCAS.Pasajes P ON (V.Cod_Viaje=P.Cod_Viaje)
																JOIN TODOX2LUCAS.Encomiendas E ON (V.Cod_Viaje=E.Cod_Viaje)
									WHERE a.Cod_Aeronave =  @codAeronave AND @fecha <= v.Fecha_Salida AND  v.Fecha_Llegada IS NULL)
	RETURN @aeronaveSuplente;
END
GO

/* ------------ PROCEDMIENTO PARA DAR DE BAJA UNA AERONAVE POR VIDA UTIL------------ */
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
		DECLARE @aeronaveSuplente int;
		EXEC TODOX2LUCAS.Aeronave_Para_Reemplazar @codAeronave ,@aeronaveSuplente;
		
		IF (@aeronaveSuplente = NULL)
		BEGIN
			UPDATE TODOX2LUCAS.Viajes
			SET Cod_Aeronave = @aeronaveSuplente
			WHERE Cod_Aeronave = @codAeronave

		END			
		ELSE
		BEGIN
			RETURN -2;
		END

	END
	ELSE
	BEGIN
		EXEC TODOX2LUCAS.Cancelar_Pasajes @fecha,@codAeronave,NULL,@motivo
		EXEC TODOX2LUCAS.Cancelar_Paquetes @fecha,@codAeronave,NULL,@motivo
	END
END
GO
/* AERONAVES QUE LIBRES DE VUELO DADA UNA FECHA*/
/* ------------ PROCEDMIENTO PARA DAR DE BAJA UNA AERONAVE POR FUERA DE SERVICIO ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Por_Fuera_De_Servicio(@codAeronave int,@cancelaciones bit,@fechaReinicio datetime)
AS
BEGIN
	DECLARE @fecha datetime,@motivo nvarchar(255);
	SET @fecha = GETDATE();
	SET @motivo = 'Baja por fuera de servicio';
	
	INSERT INTO TODOX2LUCAS.Estados_Aeronaves (Cod_Aeronave,Fuera_De_Servicio,Fecha_Fuera_Servicio,Fecha_Reinicio_Servicio)
	VALUES(@codAeronave,1,@fecha,@fechaReinicio)

	IF (@cancelaciones = 0)
	BEGIN
		DECLARE @aeronaveSuplente int;
		EXEC TODOX2LUCAS.Aeronave_Para_Reemplazar @codAeronave ,@aeronaveSuplente;
		
		IF (@aeronaveSuplente = NULL)
		BEGIN
			UPDATE TODOX2LUCAS.Viajes
			SET Cod_Aeronave = @aeronaveSuplente
			WHERE Cod_Aeronave = @codAeronave

		END			
		ELSE
		BEGIN
			RETURN -2;
		END

		
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
	IF NOT EXISTS (SELECT Matricula FROM TODOX2LUCAS.Aeronaves WHERE Matricula = @matricula)
	BEGIN
		INSERT INTO TODOX2LUCAS.Aeronaves(Matricula,Fecha_Alta,Cod_Fabricante,Modelo,Cod_Tipo_Servicio,Kgs_Disponibles )
		VALUES(@matricula,@fecha_Alta,@cod_Fabricante,@modelo,@cod_Tipo_Servicio,@kgs_Disponibles)
	END
	ELSE
	BEGIN
		print 'La matricula ya existe'
	END

END
GO

/* ------------ PROCEDIMIENTO PARA GENERAR UN VIAJE ------------ */
CREATE PROCEDURE  TODOX2LUCAS.Generar_Viaje(@codRuta numeric(18),@cod_Aeronave int,@fechaSalida datetime,@fechaLlegadestimada datetime)
AS 
BEGIN
	IF (@fechaSalida > GETDATE() AND @fechaLlegadestimada > @fechaSalida)
	BEGIN
		DECLARE @codOrigen int,@codDestino int;
		SELECT @codOrigen = Cod_Ciudad_Origen, @codDestino = Cod_Ciudad_Destino
		FROM TODOX2LUCAS.RutasAereas
		WHERE Cod_Ruta = @codRuta

		INSERT INTO TODOX2LUCAS.Viajes(Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Aeronave,Fecha_Salida,Fecha_Llegada_Estimada)
		VALUES(@codRuta,@codOrigen,@codDestino,@cod_Aeronave,@fechaSalida,@fechaLlegadestimada)

	END
	ELSE
	BEGIN
		print 'Las fechas ingresadas son invalidas'
	END
END
GO

/* ------------ PROCEDIMIENTO PARA EL REGISTRO DE LLEGADAS A DESTINO DE LAS AERONAVES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Registrar_Llegada(@matricula nvarchar(255),@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255),@fechaLlegada datetime)
AS
BEGIN
	DECLARE @codOrigen int, @codDestino int;
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);

	IF EXISTS (SELECT A.Cod_Aeronave
				FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Viajes V ON (A.Cod_Aeronave=V.Cod_Aeronave)
				WHERE Matricula = @matricula AND V.Cod_Ciudad_Origen = @codOrigen AND V.Cod_Ciudad_Destino=@codDestino AND Fecha_Llegada_Estimada  <= GETDATE() )
	BEGIN
		DECLARE @codAeronave int;
		SELECT @codAeronave = A.Cod_Aeronave
		FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Viajes V ON (A.Cod_Aeronave=V.Cod_Aeronave)
		WHERE Matricula = @matricula AND V.Cod_Ciudad_Origen = @codOrigen AND V.Cod_Ciudad_Destino=@codDestino AND Fecha_Llegada_Estimada  <= GETDATE() 
		
		UPDATE TODOX2LUCAS.Viajes
		SET Fecha_Llegada = @fechaLlegada
		WHERE Cod_Aeronave = @codAeronave AND Cod_Ciudad_Origen = @codOrigen AND Cod_Ciudad_Destino = @codDestino
	
	END
	ELSE
	BEGIN
		print 'La aeronave no debia llegar al destino ingresado'
	END
	
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
		DECLARE @codProducto int, @precioMillas int;
		SELECT @codProducto = Cod_Producto, @precioMillas = PrecioEnMillas
		FROM TODOX2LUCAS.Productos 
		WHERE Descripcion_Producto = @producto
		
		INSERT INTO TODOX2LUCAS.Canjes(Nro_Dni,Cliente_Apellido,Cod_Producto,Fecha)
		VALUES (@dni,@cliente,@codProducto,GETDATE())
		
		UPDATE TODOX2LUCAS.Clientes
		SET Cant_Millas = Cant_Millas - @precioMillas
		WHERE Nro_Dni = @dni AND Cliente_Apellido = @cliente
	END
END
GO
/* ------------ PROCEDIMIENTOS PARA MOSTRAR LOS PASAJES DISPONIBLES SEGUN FECHA Y CIUDADES INGRESADOS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Mostrar_Viajes_Disponibles(@fechaSalida datetime,@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255))
AS
BEGIN
	DECLARE @codOrigen int,@codDestino int,@butacasTotalesAvion int;
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);

	SELECT v.Cod_Viaje, C1.Nombre_Ciudad,C2.Nombre_Ciudad,V.Fecha_Salida,
			(A.Cantidad_Butacas - COUNT(B.Cod_Butaca)) AS 'Butacas Disponibles',
			kilogramos.[Kilogramos Disponibles],
			T.Descripcion_Servicio
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
								JOIN TODOX2LUCAS.Butacas B ON (B.Cod_Aeronave=A.Cod_Aeronave)
								JOIN TODOX2LUCAS.Pasajes P ON (P.Cod_Viaje=V.Cod_Viaje AND P.Butaca_Asociada=B.Cod_Butaca) 
								JOIN TODOX2LUCAS.Tipos_De_Servicios T ON (T.Cod_Tipo_Servicio=A.Cod_Tipo_Servicio)
								JOIN TODOX2LUCAS.Ciudades C1 ON (V.Cod_Ciudad_Origen=C1.Cod_Ciudad)
								JOIN TODOX2LUCAS.Ciudades C2 ON (V.Cod_Ciudad_Destino=C2.Cod_Ciudad)
								JOIN (SELECT V.Cod_Viaje,
											(A.Kgs_Disponibles - SUM(E.Kgs_A_Enviar)) AS 'Kilogramos Disponibles'
										FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
																	JOIN TODOX2LUCAS.Encomiendas E ON (E.Cod_Viaje=V.Cod_Viaje)
										GROUP BY A.Cod_Aeronave,V.Cod_Viaje,A.Kgs_Disponibles
										) AS kilogramos ON (kilogramos.Cod_Viaje=v.Cod_Viaje)
	WHERE Fecha_Salida = @fechaSalida AND v.Cod_Ciudad_Origen=@codOrigen AND v.Cod_Ciudad_Destino=@codDestino
			AND (NOT EXISTS(SELECT * FROM TODOX2LUCAS.Estados_Aeronaves WHERE Cod_Aeronave=A.Cod_Aeronave))
	GROUP BY A.Cod_Aeronave,v.Cod_Viaje,A.Cantidad_Butacas,V.Fecha_Salida,kilogramos.[Kilogramos Disponibles],T.Descripcion_Servicio,C1.Nombre_Ciudad,C2.Nombre_Ciudad
	
END

GO
/* ------------ PROCEDIMIENTOS PARA COMPRAR PASAJES  ------------ */
CREATE PROCEDURE TODOX2LUCAS.Comprar_Pasajes(@butaca int,@codViaje int,@apellido nvarchar(255),@nro_dni numeric(18),
												@formaDePago nvarchar(250),@numero_tarjeta numeric(16),@cod_seg numeric(3),@fecha_vencimiento datetime,
												@tipo_tarjeta nvarchar(200))
AS
BEGIN
	DECLARE @fecha datetime, @precioPasaje numeric(18,2),@precioBasePasaje numeric(18,2),@precioServicio numeric(18),@codPasaje numeric(18) ;

	SELECT  @fecha = Fecha_Salida , @precioBasePasaje = r.Precio_Base_Pasaje,@precioServicio = t.Precio_Servicio
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.RutasAereas R ON (V.Cod_Ruta=R.Cod_Ruta)
								JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(t.Cod_Tipo_Servicio=r.Cod_Tipo_Servicio)
	WHERE V.Cod_Viaje = @codViaje

	SET @precioPasaje = (@precioBasePasaje * @precioServicio)

	INSERT INTO TODOX2LUCAS.Pasajes(Fecha_Viaje,Cod_Viaje,Butaca_Asociada,Nro_Dni,Pasaje_Precio,Cliente_Apellido)
	VALUES(@fecha,@codViaje,@butaca,@nro_dni,@precioPasaje,@apellido)

	SET @codPasaje = (SELECT SCOPE_IDENTITY() FROM TODOX2LUCAS.Pasajes);

	INSERT INTO TODOX2LUCAS.TransaccionesPasajes(Nro_Dni,Cliente_Apellido,Cod_Pasaje,Fecha_Transaccion,Forma_De_Pago)
	VALUES (@nro_dni,@apellido,@codPasaje,GETDATE(),@formaDePago)
	IF (@formaDePago = 'Tarjeta')
	BEGIN
		INSERT INTO TODOX2LUCAS.Tarjetas(Numero_Tarjeta,Cod_Seg,Fecha_Vencimiento,Tipo_Tarjeta,Nro_Dni,Cliente_Apellido)
		VALUES(@numero_tarjeta,@cod_seg,@fecha_vencimiento,@tipo_tarjeta,@nro_dni,@apellido)
	END
END
GO
/* ------------ PROCEDIMIENTOS PARA COMPRAR ENCOMIENDA  ------------ */
CREATE PROCEDURE TODOX2LUCAS.Comprar_Encomienda(@kgs_a_enviar int,@codViaje int,@apellido nvarchar(255),@nro_dni numeric(18),
												@formaDePago nvarchar(250),@numero_tarjeta numeric(16),@cod_seg numeric(3),@fecha_vencimiento datetime,
												@tipo_tarjeta nvarchar(200))
AS
BEGIN
	DECLARE @fecha datetime, @precioEncomienda numeric(18,2),@precioBaseEncomienda numeric(18,2),@precioServicio numeric(18),@codEncomienda numeric(18) ;

	SELECT  @fecha = Fecha_Salida , @precioBaseEncomienda = r.Precio_Base_Kg ,@precioServicio = t.Precio_Servicio
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.RutasAereas R ON (V.Cod_Ruta=R.Cod_Ruta)
								JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(t.Cod_Tipo_Servicio=r.Cod_Tipo_Servicio)
	WHERE V.Cod_Viaje = @codViaje

	SET @precioEncomienda = (@precioBaseEncomienda * @precioServicio)

	INSERT INTO TODOX2LUCAS.Encomiendas(Fecha_Compra,Cod_Viaje,Kgs_A_Enviar,Nro_Dni,Precio_Encomienda,Cliente_Apellido)
	VALUES(@fecha,@codViaje,@kgs_a_enviar,@nro_dni,@precioEncomienda,@apellido)

	SET @codEncomienda = (SELECT SCOPE_IDENTITY() FROM TODOX2LUCAS.Pasajes);

	INSERT INTO TODOX2LUCAS.TransaccionesPaquetes(Nro_Dni,Cliente_Apellido,Cod_Encomiendas,Fecha_Transaccion,Forma_De_Pago)
	VALUES (@nro_dni,@apellido,@codEncomienda,GETDATE(),@formaDePago)

	IF (@formaDePago = 'Tarjeta')
	BEGIN
		INSERT INTO TODOX2LUCAS.Tarjetas(Numero_Tarjeta,Cod_Seg,Fecha_Vencimiento,Tipo_Tarjeta,Nro_Dni,Cliente_Apellido)
		VALUES(@numero_tarjeta,@cod_seg,@fecha_vencimiento,@tipo_tarjeta,@nro_dni,@apellido)
	END
END
GO

/* ------------ PROCEDIMIENTOS PARA DAR DE ALTA UN  CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Alta_Cliente(@nro_dni numeric(18),@apellido nvarchar(255),@nombre nvarchar(255),
											@direccion nvarchar(255),@mail nvarchar(255),@fechaNacimiento datetime,@telefono numeric(18))
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM TODOX2LUCAS.Clientes WHERE Nro_Dni=@nro_dni AND Cliente_Apellido=@apellido)
	BEGIN
		INSERT INTO TODOX2LUCAS.Clientes(Nro_Dni,Cliente_Apellido,Cliente_Nombre,Cliente_Direccion,Cliente_Mail,Cliente_Fecha_Nacimiento,Cliente_Telefono)
		VALUES(@nro_dni,@apellido,@nombre,@direccion,@mail,@fechaNacimiento,@telefono)
	END
	ELSE
	BEGIN
		print 'El cliente ya existe'
		SELECT * 
		FROM TODOX2LUCAS.Clientes WHERE Nro_Dni=@nro_dni AND Cliente_Apellido=@apellido
	END
END
GO
/* ------------ PROCEDIMIENTOS PARA MODIFICAR DATOS DE UN CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Datos_Cliente(@nro_dni numeric(18),@apellido nvarchar(255),@nombre nvarchar(255),
												@direccion nvarchar(255),@mail nvarchar(255),@fechaNacimiento datetime,@telefono nvarchar(255))
AS
BEGIN
	
	UPDATE TODOX2LUCAS.Clientes
	SET Nro_Dni=@nro_dni,
		Cliente_Apellido=@apellido,
		Cliente_Nombre=@nombre,
		Cliente_Direccion=@direccion,
		Cliente_Mail=@mail,
		Cliente_Fecha_Nacimiento=@fechaNacimiento,
		Cliente_Telefono=@telefono
	WHERE Nro_Dni=@nro_dni AND Cliente_Apellido = @apellido
	
END
GO
/* ------------ PROCEDIMIENTO PARA DAR DE ALTA UNA CIUDAD ------------ */
CREATE PROCEDURE TODOX2LUCAS.Alta_Ciudad(@ciudad nvarchar(255))
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudad)
	BEGIN
		INSERT INTO TODOX2LUCAS.Ciudades(Nombre_Ciudad,Estado_Ciudad)
		VALUES(@ciudad,1)
	END
	ELSE
	BEGIN
		print 'Ya existe la ciudad' 
	END
END
GO
/* ------------ PROCEDIMIENTO PARA MODIFICAR UNA CIUDAD ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Nombre_Ciudad(@ciudad nvarchar(255),@nuevoNombre nvarchar(255))
AS
BEGIN
	UPDATE TODOX2LUCAS.Ciudades
	SET Nombre_Ciudad = @nuevoNombre
	WHERE Nombre_Ciudad = @ciudad
END
GO
/* ------------ PROCEDIMIENTO PARA DAR DE BAJA UNA CIUDAD ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Ciudad(@ciudad nvarchar(255))
AS
BEGIN
	UPDATE TODOX2LUCAS.Ciudades
	SET Estado_Ciudad = 0
	WHERE Nombre_Ciudad = @ciudad
END
GO
/* ------------ PROCEDIMIENTOS PARA MOSTRAR MILLAS DE UN CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Consulta_Millas(@dni numeric(18),@apellido nvarchar(255))
AS
BEGIN
	SELECT Cant_Millas
	FROM TODOX2LUCAS.Clientes
	WHERE Nro_Dni = @dni AND Cliente_Apellido = @apellido
END
GO
/* ------------ PROCEDIMIENTOS GETTER RUTA ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetRuta(@codRuta numeric(18),@ciudadOrigen int,@ciudadDestino int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.RutasAereas 
	WHERE Cod_Ruta = @codRuta AND Cod_Ciudad_Origen = @ciudadOrigen AND Cod_Ciudad_Destino = @ciudadDestino
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER AERONAVE ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetAeronave(@codAeronave int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Aeronaves 
	WHERE Cod_Aeronave = @codAeronave
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER TIPO SERVICIO ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetTipoServicio(@codServicio int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Tipos_De_Servicios
	WHERE Cod_Tipo_Servicio = @codServicio
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER FABRICANTE ------------ */
 CREATE PROCEDURE   TODOX2LUCAS.GetFabricante(@codFabricante int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Fabricantes
	WHERE Cod_Fabricante = @codFabricante
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER CLIENTE ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetCliente(@dni numeric(18),@apellido nvarchar(255))
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Clientes
	WHERE Nro_Dni = @dni AND Cliente_Apellido = @apellido
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER VIAJE ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetViaje(@codViaje int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Viajes
	WHERE Cod_Viaje = @codViaje
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER USUARIO ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetUsuario(@usrname nvarchar(255))
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Usuarios
	WHERE Usuario_Nombre = @usrname	
 END
 GO

 /* ------------ PROCEDIMIENTOS GETTER ROL ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetRol(@codRol int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Roles
	WHERE Cod_Rol = @codRol
 END
 GO
/* ------------ PROCEDIMIENTOS PARA LOS LISTADOS ESTADISTICOS ------------ */
/* ------------ Top 5 de los destinos con más pasajes comprados ------------ */
CREATE PROCEDURE TODOX2LUCAS.Pasajes_Mas_Comprados(@fecha_inicio datetime, @fecha_fin datetime)
AS
BEGIN
	SELECT TOP 5  COUNT(V.Cod_Ciudad_Destino),V.Cod_Ciudad_Destino,C.Nombre_Ciudad
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
								JOIN TODOX2LUCAS.Ciudades C ON (V.Cod_Ciudad_Destino = C.Cod_Ciudad)
	WHERE V.Fecha_Llegada BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY V.Cod_Ciudad_Destino, C.Nombre_Ciudad
	ORDER BY 1 DESC
END
GO

/* ------------ Top 5 de los destinos con aeronaves más vacías ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronaves_Mas_Vacias(@fecha_inicio datetime, @fecha_fin datetime)
AS
BEGIN
	SELECT TOP 5 C.Nombre_Ciudad,COUNT(B.Cod_Butaca) AS 'CANT_BUTACAS'
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
								JOIN TODOX2LUCAS.Aeronaves A ON(A.Cod_Aeronave=V.Cod_Aeronave)
								JOIN TODOX2LUCAS.Butacas B ON(A.Cod_Aeronave=B.Cod_Aeronave AND P.Butaca_Asociada=B.Cod_Butaca)
								JOIN TODOX2LUCAS.Ciudades C ON (V.Cod_Ciudad_Destino = C.Cod_Ciudad)
	WHERE V.Fecha_Llegada BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY C.Nombre_Ciudad,B.Cod_Butaca,A.Cod_Aeronave
	ORDER BY 2 DESC

END
GO

/* ------------ Top 5 de los Clientes con más puntos acumulados a la fecha ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cliente_Mayoria_Puntos
AS
BEGIN
	SELECT TOP 5 Cant_Millas,Cliente_Apellido
	FROM TODOX2LUCAS.Clientes
	ORDER BY 1 DESC
END
GO

/* ------------ Top 5 de los destinos con pasajes cancelados ------------ */
CREATE PROCEDURE TODOX2LUCAS.Destinos_Mas_Cancelados(@fecha_inicio datetime, @fecha_fin datetime)
AS
BEGIN
	SELECT TOP 5 CIU.Nombre_Ciudad,COUNT(C.Cod_Pasaje)
	FROM TODOX2LUCAS.Cancelaciones C JOIN TODOX2LUCAS.Pasajes P ON (C.Cod_Pasaje=P.Cod_Pasaje)
									JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
									JOIN TODOX2LUCAS.Ciudades CIU ON (V.Cod_Ciudad_Destino=CIU.Cod_Ciudad)
	WHERE V.Fecha_Llegada BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY CIU.Nombre_Ciudad
	ORDER BY 2 DESC

END
GO

/* ------------ Top 5 de las aeronaves con mayor cantidad de días fuera de servicio ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronave_Mayoria_Fuera_Servicio(@fecha_inicio datetime, @fecha_fin datetime)
AS
BEGIN
	SELECT TOP 5 A.Cod_Aeronave,(DATEDIFF(DAY,E.Fecha_Reinicio_Servicio,E.Fecha_Fuera_Servicio)) AS 'DIAS FUERA DE SERVICIO'
	FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Estados_Aeronaves E ON(A.Cod_Aeronave=E.Cod_Aeronave)
	WHERE E.Fecha_Fuera_Servicio BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY A.Cod_Aeronave, E.Fecha_Reinicio_Servicio,E.Fecha_Fuera_Servicio
	ORDER BY 2 DESC							
END
GO

/* ------------ FILTROS PARA ABM AERONAVES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Aeronaves(@matricula nvarchar(255),@codAeronave int,@fabricante nvarchar(255), @servicio nvarchar(255))
AS
BEGIN
	SELECT A.Cod_Aeronave as  'CODIGO AERONAVE',A.Matricula AS 'MATRICULA',A.Modelo AS 'MODELO',A.Cantidad_Butacas AS 'CANTIDAD DE BUTACAS',A.Kgs_Disponibles AS 'CANTIDAD DE KILOGRAMOS',F.Nombre_Fabricante AS 'NOMBRE FABRICANTE',T.Descripcion_Servicio AS 'SERVICIO'
	FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Fabricantes F ON(A.Cod_Fabricante=F.Cod_Fabricante)
								JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(T.Cod_Tipo_Servicio=A.Cod_Tipo_Servicio)
	WHERE A.Matricula = @matricula OR
			A.Cod_Aeronave = @codAeronave OR
			f.Nombre_Fabricante = @fabricante OR
			t.Descripcion_Servicio = @servicio
END
GO
/* ------------ FILTROS PARA ABM ROL ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Roles(@rol nvarchar(255))
AS
BEGIN
	SELECT Cod_Rol AS 'CODIGO ROL',Nombre_Rol AS 'NOMBRE ROL', Estado_Rol AS 'ESTADO ROL'
	FROM TODOX2LUCAS.Roles
	WHERE Nombre_Rol = @rol
END
GO
/* ------------ FILTROS PARA ABM CIUDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Ciudades(@nombre nvarchar(255))
AS
BEGIN
	SELECT Cod_Ciudad AS 'CODIGO CIUDAD',Nombre_Ciudad AS 'NOMBRE CIUDAD',Estado_Ciudad AS 'ESTADO CIUDAD'
	FROM TODOX2LUCAS.Ciudades
	WHERE Nombre_Ciudad = @nombre
END
GO
/* ------------ FILTROS PARA ABM RUTAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Rutas(@codRuta numeric(18),@origen nvarchar(255),@destino nvarchar(255),@servicio nvarchar(255))
AS
BEGIN
	SELECT r.Cod_Ruta AS 'CODIGO RUTA',c1.Nombre_Ciudad AS 'CIUDAD SALIDA',c2.Nombre_Ciudad AS 'CIUDAD ARRIBO',r.Precio_Base_Kg AS 'PRECIO BASE KILOGRAMOS',r.Precio_Base_Pasaje AS 'PRECIO BASE PASAJE'
	FROM TODOX2LUCAS.RutasAereas R JOIN TODOX2LUCAS.Ciudades C1 ON(C1.Cod_Ciudad = R.Cod_Ciudad_Origen)
									JOIN TODOX2LUCAS.Ciudades C2 ON (C2.Cod_Ciudad = R.Cod_Ciudad_Destino)
									JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(R.Cod_Tipo_Servicio =T.Cod_Tipo_Servicio)
	WHERE R.Cod_Ruta = @codRuta OR C1.Nombre_Ciudad = @origen OR C2.Nombre_Ciudad = @destino OR  t.Descripcion_Servicio = @servicio
END
GO

/***************************************  TRIGGERS ***********************************************/
-- TRIGGER QUE ACTUALIZA EL ATRIBUTO DE LA TABLA CLIENTES(CANT_MILLAS) ANTE UN INSERT EN LA TABLA DE PASAJES--
GO
CREATE TRIGGER TODOX2LUCAS.Sumar_Millas_Pasajes
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

CREATE TRIGGER TODOX2LUCAS.Sumar_Millas_Paquetes
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

CREATE TRIGGER TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones
ON TODOX2LUCAS.Cancelaciones
AFTER INSERT
AS
BEGIN
	DECLARE @codDevolucion int, @codPasaje numeric(18),@codEncomiendas numeric(18);
	DECLARE cursor_cancelar CURSOR FOR	
	SELECT I.Codigo_Devolucion,I.Cod_Pasaje,I.Cod_Encomiendas
	FROM inserted I
	
	OPEN cursor_cancelar
	FETCH NEXT FROM cursor_cancelar INTO @codDevolucion,@codPasaje,@codEncomiendas
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF (@codPasaje) IS NULL 
		BEGIN
			DECLARE @millasEncomienda int,@Nro_Dni_Encomienda numeric(18),@apellido_Encomienda nvarchar(255),@precio_Encomienda numeric(18,2);
			SELECT @Nro_Dni_Encomienda = Nro_Dni,@apellido_Encomienda=Cliente_Apellido,@precio_Encomienda = Precio_Encomienda
			FROM TODOX2LUCAS.Encomiendas
			WHERE Cod_Encomiendas = @codEncomiendas

			SET @millasEncomienda = FLOOR((@precio_Encomienda/10));
			
			UPDATE TODOX2LUCAS.Clientes
			SET	Cant_Millas = Cant_Millas - @millasEncomienda
			WHERE Nro_Dni = @Nro_Dni_Encomienda AND Cliente_Apellido = @apellido_Encomienda
		END
		IF (@codEncomiendas) IS NULL
		BEGIN
			DECLARE @millasPasaje int,@Nro_Dni_Pasaje numeric(18),@apellido_Pasaje nvarchar(255),@precio_Pasaje numeric(18,2);
			SELECT @Nro_Dni_Pasaje = Nro_Dni , @apellido_Pasaje = Cliente_Apellido , @precio_Pasaje = Pasaje_Precio
			FROM TODOX2LUCAS.Pasajes
			WHERE Cod_Pasaje = @codPasaje

			SET @millasPasaje = FLOOR((@precio_Pasaje/10));
			
			UPDATE TODOX2LUCAS.Clientes
			SET	Cant_Millas = Cant_Millas - @millasPasaje
			WHERE Nro_Dni = @Nro_Dni_Pasaje AND Cliente_Apellido = @apellido_Pasaje
			
		END
		FETCH NEXT FROM cursor_cancelar INTO @codDevolucion,@codPasaje,@codEncomiendas
	END
	CLOSE cursor_cancelar
	DEALLOCATE cursor_cancelar

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
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificación Rol'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Rol'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Ciudad'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificación Ciudad'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Ciudad'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Aeronave'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificación Aeronave'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Aeronave'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Alta Ruta'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Modificación Ruta'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Baja Ruta'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Canje Millas'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Compra Pasajes'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Compra Encomiendas'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Consulta Millas'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Devolución'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Generación Viaje'
EXEC TODOX2LUCAS.Agregar_Funcionalidad 'Listado Estadístico'
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
/* ------------ SET DE USUSARIOS PARA EL TP (EL ABM DE USUARIO NO SE DEBE IMPLEMENTAR) ------------ */
DECLARE @clave nvarchar(255);
SET @clave = HASHBYTES('SHA2_256','w23e');
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol,Estado_Usuario)
VALUES('Lucas',@clave,2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol,Estado_Usuario)
VALUES('Eduardo',@clave,2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol,Estado_Usuario)
VALUES('Pepe',@clave,2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol,Estado_Usuario)
VALUES('Roman',@clave,2,1)
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol,Estado_Usuario)
VALUES('Messi',@clave,2,1)
GO


--DATOS INICIALES PARA LA TABLA ROL POR FUNCIONALIDAD--

EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Rol'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificación Rol'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Rol'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Registro de Usuario'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Ciudad'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificación Ciudad'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Ciudad'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Ruta'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificación Ruta'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Ruta'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Alta Aeronave'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Modificación Aeronave'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Baja Aeronave'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Generación Viaje'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Registro Llegada Destino'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Compra Pasajes'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Compra Encomiendas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Compra Pasajes'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Compra Encomiendas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Devolución'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Consulta Millas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Cliente','Canje Millas'
EXEC TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad 'Administrador','Listado Estadístico'
GO
--MIGRACION CLIENTES--
INSERT INTO TODOX2LUCAS.Clientes(Nro_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Direccion, Cliente_Telefono, Cliente_Mail, Cliente_Fecha_Nacimiento, Cant_Millas)
SELECT DISTINCT Cli_Dni, Cli_Nombre, Cli_Apellido, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, 0 
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

--MIGRACION TABLA BUTACAS--
INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca,Estado_Butaca)
SELECT DISTINCT A.Cod_Aeronave,Butaca_Nro,Butaca_Tipo, Butaca_Piso,1
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Aeronaves A ON (A.Matricula = M.Aeronave_Matricula)
WHERE Butaca_Piso!=0 AND Butaca_Tipo !='0'
ORDER BY A.Cod_Aeronave,Butaca_Nro

GO
EXEC TODOX2LUCAS.Cargar_Butacas
GO
--MIGRACION TABLA RUTASAEREAS--
EXEC TODOX2LUCAS.Migrar_Rutas_Aereas

GO
--MIGRACION TABLA VIAJES

INSERT INTO TODOX2LUCAS.Viajes(Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Aeronave,Fecha_Salida,Fecha_Llegada,Fecha_Llegada_Estimada)
SELECT DISTINCT r.Cod_Ruta,c1.Cod_Ciudad,c2.Cod_Ciudad,a.Cod_Aeronave,m.FechaSalida,NULL,m.Fecha_LLegada_Estimada
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Ciudades c1 ON(m.Ruta_Ciudad_Origen=c1.Nombre_Ciudad)
							JOIN TODOX2LUCAS.Ciudades c2 ON(m.Ruta_Ciudad_Destino=c2.Nombre_Ciudad)
							JOIN TODOX2LUCAS.RutasAereas r ON (c1.Cod_Ciudad = r.Cod_Ciudad_Origen AND c2.Cod_Ciudad=r.Cod_Ciudad_Destino) 
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula = a.Matricula)

GO
--MIGRACION TABLA CANJES--

--MIGRACION TABLA ENCOMIENDAS--
--tiene q dar 135.658
INSERT INTO TODOX2LUCAS.Encomiendas(Cod_Encomiendas,Precio_Encomienda,Kgs_A_Enviar,Fecha_Compra,Cod_Viaje,Nro_Dni,Cliente_Apellido)
SELECT DISTINCT M.Paquete_Codigo,M.Paquete_Precio,M.Paquete_KG,M.Paquete_FechaCompra,v.Cod_Viaje,C.Nro_Dni,c.Cliente_Apellido
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Clientes C ON(C.Nro_Dni = M.Cli_Dni AND c.Cliente_Apellido=m.Cli_Apellido)
							JOIN TODOX2LUCAS.Ciudades co ON (co.Nombre_Ciudad=m.Ruta_Ciudad_Origen)
							JOIN TODOX2LUCAS.Ciudades cd ON (cd.Nombre_Ciudad=Ruta_Ciudad_Destino)
							JOIN TODOX2LUCAS.RutasAereas r ON (co.Cod_Ciudad=r.Cod_Ciudad_Origen AND cd.Cod_Ciudad=r.Cod_Ciudad_Destino)
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula=a.Matricula)
							JOIN TODOX2LUCAS.Viajes v ON(v.Cod_Ruta =r.Cod_Ruta AND v.Cod_Aeronave=a.Cod_Aeronave AND v.Fecha_Salida=m.FechaSalida  AND v.Fecha_Llegada_Estimada=m.Fecha_LLegada_Estimada)
							
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
							JOIN TODOX2LUCAS.Viajes v ON(v.Cod_Ruta =r.Cod_Ruta AND v.Cod_Aeronave=a.Cod_Aeronave AND v.Fecha_Salida=m.FechaSalida AND v.Fecha_Llegada_Estimada=m.Fecha_LLegada_Estimada)
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


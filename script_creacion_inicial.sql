USE GD2C2015
GO
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'TODOX2LUCAS')
BEGIN
	EXEC ('CREATE SCHEMA TODOX2LUCAS AUTHORIZATION gd')
END
GO 
/**************************************************  DROP TRABLES  ***************************************************/
IF OBJECT_ID('TODOX2LUCAS.CancelacionesPasajes') IS NOT NULL
DROP TABLE TODOX2LUCAS.CancelacionesPasajes;
IF OBJECT_ID('TODOX2LUCAS.CancelacionesPaquetes') IS NOT NULL
DROP TABLE TODOX2LUCAS.CancelacionesPaquetes;
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
IF OBJECT_ID('TODOX2LUCAS.Modelo_Aeronave') IS NOT NULL
DROP TABLE TODOX2LUCAS.Modelo_Aeronave;
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
IF OBJECT_ID('TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones_Paquetes') IS NOT NULL
DROP TRIGGER TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones_Paquetes;
IF OBJECT_ID('TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones_Pasajes') IS NOT NULL
DROP TRIGGER TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones_Pasajes;
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
IF OBJECT_ID('TODOX2LUCAS.Filtrar_Rutas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Filtrar_Rutas;
IF OBJECT_ID('TODOX2LUCAS.GetCiudades') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCiudades;
IF OBJECT_ID('TODOX2LUCAS.GetCiudad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCiudad;
IF OBJECT_ID('TODOX2LUCAS.GetFabricante') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetFabricante;
IF OBJECT_ID('TODOX2LUCAS.GetFabricantes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetFabricantes;
IF OBJECT_ID('TODOX2LUCAS.Get_Funcionalidad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Funcionalidad;
IF OBJECT_ID('TODOX2LUCAS.Get_Funcionalidades') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Funcionalidades;
IF OBJECT_ID('TODOX2LUCAS.Get_Producto') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Producto;
IF OBJECT_ID('TODOX2LUCAS.Get_Productos') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Productos;
IF OBJECT_ID('TODOX2LUCAS.GetRol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetRol;
IF OBJECT_ID('TODOX2LUCAS.Get_Roles') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Roles;
IF OBJECT_ID('TODOX2LUCAS.GetUsuario') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetUsuario;
IF OBJECT_ID('TODOX2LUCAS.Get_Usuarios') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Usuarios;
IF OBJECT_ID('TODOX2LUCAS.GetAuditoriaLogin') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetAuditoriaLogin;
IF OBJECT_ID('TODOX2LUCAS.Get_AuditoriasLogin') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_AuditoriasLogin;
IF OBJECT_ID('TODOX2LUCAS.GetRolPorFuncionalidad') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetRolPorFuncionalidad;
IF OBJECT_ID('TODOX2LUCAS.Get_RolPorFuncionalidades') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_RolPorFuncionalidades;
IF OBJECT_ID('TODOX2LUCAS.GetCliente') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCliente;
IF OBJECT_ID('TODOX2LUCAS.Get_Clientes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Clientes;
IF OBJECT_ID('TODOX2LUCAS.GetTarjeta') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetTarjeta;
IF OBJECT_ID('TODOX2LUCAS.Get_Tarjetas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Tarjetas;
IF OBJECT_ID('TODOX2LUCAS.GetTipoServicio') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetTipoServicio;
IF OBJECT_ID('TODOX2LUCAS.GetServicios') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetServicios;
IF OBJECT_ID('TODOX2LUCAS.GetAeronave') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetAeronave;
IF OBJECT_ID('TODOX2LUCAS.Get_Aeronaves') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Aeronaves;
IF OBJECT_ID('TODOX2LUCAS.GetEstadoAeronave') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetEstadoAeronave;
IF OBJECT_ID('TODOX2LUCAS.Get_EstadosAeronaves') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_EstadosAeronaves;
IF OBJECT_ID('TODOX2LUCAS.GetButaca') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetButaca;
IF OBJECT_ID('TODOX2LUCAS.Get_Butacas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Butacas;
IF OBJECT_ID('TODOX2LUCAS.Get_Rutas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Rutas;
IF OBJECT_ID('TODOX2LUCAS.GetRuta') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetRuta;
IF OBJECT_ID('TODOX2LUCAS.GetViaje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetViaje;
IF OBJECT_ID('TODOX2LUCAS.Get_Viajes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Viajes;
IF OBJECT_ID('TODOX2LUCAS.GetCanje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCanje;
IF OBJECT_ID('TODOX2LUCAS.Get_Canjes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Canjes;
IF OBJECT_ID('TODOX2LUCAS.GetEncomienda') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetEncomienda;
IF OBJECT_ID('TODOX2LUCAS.Get_Encomiendas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Encomiendas;
IF OBJECT_ID('TODOX2LUCAS.GetPasaje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetPasaje;
IF OBJECT_ID('TODOX2LUCAS.Get_Pasajes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Pasajes;
IF OBJECT_ID('TODOX2LUCAS.GetTransaccionPasaje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetTransaccionPasaje;
IF OBJECT_ID('TODOX2LUCAS.Get_TransaccionesPasajes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_TransaccionesPasajes;
IF OBJECT_ID('TODOX2LUCAS.GetTransaccionPaquete') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetTransaccionPaquete;
IF OBJECT_ID('TODOX2LUCAS.Get_TransacionesPaquetes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_TransacionesPaquetes;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Aeronave') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Aeronave;
IF OBJECT_ID('TODOX2LUCAS.Quitar_Funcionalidad_A_Rol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Quitar_Funcionalidad_A_Rol;
IF OBJECT_ID('TODOX2LUCAS.Get_Funcionalidades_De_Rol') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Funcionalidades_De_Rol;
IF OBJECT_ID('TODOX2LUCAS.GetCancelacionPasaje') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCancelacionPasaje;
IF OBJECT_ID('TODOX2LUCAS.Get_CancelacionesPasajes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_CancelacionesPasajes;
IF OBJECT_ID('TODOX2LUCAS.GetCancelacionPaquete') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetCancelacionPaquete;
IF OBJECT_ID('TODOX2LUCAS.Get_CancelacionesPaquetes') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_CancelacionesPaquetes;
IF OBJECT_ID('TODOX2LUCAS.Kilogramos_Libres_Aeronave') IS NOT NULL
DROP FUNCTION TODOX2LUCAS.Kilogramos_Libres_Aeronave;
IF OBJECT_ID('TODOX2LUCAS.Butacas_Libres_Aeronave') IS NOT NULL
DROP FUNCTION TODOX2LUCAS.Butacas_Libres_Aeronave;
IF OBJECT_ID('TODOX2LUCAS.Butacas_Libres') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Butacas_Libres;
IF OBJECT_ID('TODOX2LUCAS.Aeronaves_Segun_Ruta') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Aeronaves_Segun_Ruta;
IF OBJECT_ID('TODOX2LUCAS.Listado_Consulta_Millas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Listado_Consulta_Millas;
IF OBJECT_ID('TODOX2LUCAS.Cancelar_Pasajes_Encomiendas') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Cancelar_Pasajes_Encomiendas;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Agregar_Butaca') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Agregar_Butaca;
IF OBJECT_ID('TODOX2LUCAS.Modificar_Quitar_Butaca') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Modificar_Quitar_Butaca ;
IF OBJECT_ID('TODOX2LUCAS.Get_Butacas_Por_Tipo') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Get_Butacas_Por_Tipo ;
IF OBJECT_ID('TODOX2LUCAS.GetModelo') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetModelo;
IF OBJECT_ID('TODOX2LUCAS.GetModelos') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.GetModelos;
IF OBJECT_ID('TODOX2LUCAS.Verificar_Cliente') IS NOT NULL
DROP PROCEDURE TODOX2LUCAS.Verificar_Cliente;
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
	Cod_Producto int PRIMARY KEY CLUSTERED IDENTITY,
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
	Numero_Tarjeta numeric(16) PRIMARY KEY ,
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
	Cod_Modelo int,
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
--CREACION TABLA MODELO--
CREATE TABLE TODOX2LUCAS.Modelo_Aeronave (
	Cod_Modelo int IDENTITY PRIMARY KEY,
	Descricpion_Modelo nvarchar(255)
)
;
--CREACION TABLA BUTACAS--
CREATE TABLE TODOX2LUCAS.Butacas ( 
	Cod_Aeronave int REFERENCES TODOX2LUCAS.Aeronaves(Cod_Aeronave),
	Cod_Butaca numeric(18),
	Pos_Butaca nvarchar(255),
	Piso_Butaca numeric(18),
	Estado_Butaca bit,
	PRIMARY KEY CLUSTERED(Cod_Aeronave,Cod_Butaca,Pos_Butaca)
)
; 
--CREACION TABLA RUTASAEREAS--
CREATE TABLE TODOX2LUCAS.RutasAereas ( 
	Cod_Ruta numeric(18) IDENTITY(65805158,1),
	Cod_Ruta_Maestra_Inconsistencia numeric(18),
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
	Cantidad_Comprada int,
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;
--CREACION TABLA ENCOMIENDAS--

CREATE TABLE TODOX2LUCAS.Encomiendas ( 
	Cod_Encomiendas numeric(18) PRIMARY KEY CLUSTERED IDENTITY(79291562,1),
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
	Cod_Pasaje numeric(18) PRIMARY KEY CLUSTERED IDENTITY(76163527,1),
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
	Numero_Compra int IDENTITY,
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
	Numero_Compra int IDENTITY,
	Cod_Encomiendas numeric(18) REFERENCES TODOX2LUCAS.Encomiendas (Cod_Encomiendas),
	Fecha_Transaccion datetime,
	Nro_Dni numeric(18),
	Cliente_Apellido nvarchar(255),
	Forma_De_Pago nvarchar(250),
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido),
	PRIMARY KEY CLUSTERED (Numero_Compra, Cod_Encomiendas)
)
;

--CREACION TABLA CANCELACIONES PASAJES-- 
CREATE TABLE TODOX2LUCAS.CancelacionesPasajes ( 
	Codigo_Devolucion int IDENTITY,
	Fecha_Devolucion datetime,
	Numero_Compra_Pasajes int ,
	Cod_Pasaje numeric(18) ,
	Motivo nvarchar(255),
	PRIMARY KEY CLUSTERED (Codigo_Devolucion, Cod_Pasaje),
	FOREIGN KEY (Numero_Compra_Pasajes,Cod_Pasaje) REFERENCES TODOX2LUCAS.TransaccionesPasajes (Numero_Compra,Cod_Pasaje),
)
;
--CREACION TABLA CANCELACIONES PAQUETES -- 
CREATE TABLE TODOX2LUCAS.CancelacionesPaquetes ( 
	Codigo_Devolucion int IDENTITY,
	Fecha_Devolucion datetime,
	Numero_Compra_Paquetes int ,
	Cod_Encomiendas numeric(18),
	Motivo nvarchar(255),
	PRIMARY KEY CLUSTERED (Codigo_Devolucion, Cod_Encomiendas),
	FOREIGN KEY (Numero_Compra_Paquetes,Cod_Encomiendas) REFERENCES TODOX2LUCAS.TransaccionesPaquetes (Numero_Compra,Cod_Encomiendas)
)
;

GO
/************************************************** PROCEDIMIENTOS Y TRIGGERS ***************************************************/
/* ------------ PROCEDIMIENTO PARA AGREGAR FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Agregar_Funcionalidad(@Funcionalidad nvarchar(255))
AS
BEGIN
	IF NOT EXISTS(SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Funcionalidades WHERE Nombre_Funcionalidad=@Funcionalidad)
	BEGIN
		INSERT INTO TODOX2LUCAS.Funcionalidades(Nombre_Funcionalidad) 
		VALUES(@Funcionalidad)
	END
	ELSE
	BEGIN
		print 'Ya existe la funcionalidad'
		RETURN -1;
	END
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
		RETURN -1;
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
		RETURN -1;
	END
END
; 
GO
/* ------------ PROCEDIMIENTO PARA QUITAR FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Quitar_Funcionalidad_A_Rol(@funcionalidad nvarchar(255), @codRol int)
AS
BEGIN
	DELETE FROM TODOX2LUCAS.Rol_Por_Funcionalidad 
	WHERE Cod_Rol = @codRol AND 
			Cod_Funcionalidad = (SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Funcionalidades WHERE Nombre_Funcionalidad = @funcionalidad)

END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR ROLES  ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Nombre_Rol(@rol nvarchar(255),@nuevoNombreRol nvarchar(255))
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM TODOX2LUCAS.Roles WHERE Nombre_Rol = @nuevoNombreRol)
	BEGIN
		UPDATE TODOX2LUCAS.Roles
		SET Nombre_Rol = @nuevoNombreRol
		WHERE Nombre_Rol=@rol
	END
	ELSE
	BEGIN
		PRINT 'El nombre de rol al que quiere modificar ya existe'
		RETURN -1;
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
			@codServicio  int, @codFabricante int, @fabricante nvarchar(255),@servicio nvarchar(255),@codModelo int;
	
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
		SET @codModelo = (SELECT Cod_Modelo FROM TODOX2LUCAS.Modelo_Aeronave WHERE Descricpion_Modelo = @modelo)
		
		INSERT INTO TODOX2LUCAS.Aeronaves(Matricula,Fecha_Alta,Cod_Fabricante,Cod_Modelo,Cod_Tipo_Servicio,Kgs_Disponibles)
		VALUES (@matricula,@fecha,@codFabricante,@codModelo,@codServicio,@kgs)
		
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

		INSERT INTO TODOX2LUCAS.RutasAereas(Cod_Ruta_Maestra_Inconsistencia,Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Tipo_Servicio,Precio_Base_Pasaje,Precio_Base_Kg,Estado_Ruta)
		VALUES (@codRuta,@codOrigen,@codDestino,@codServicio,@precioPasaje,@precioKg,1)
		
		FETCH NEXT FROM  cursor_rutas INTO @codRuta,@nombreOrigen,@nombreDestino,@servicio,@precioPasaje
	END
	CLOSE cursor_rutas
	DEALLOCATE cursor_rutas
	
END
GO

/* ------------ PROCEDIMIENTO DE LOGIN - SOLO PUEDEN UTILIZARLOS LOS ADMINISTRATIVOS ------------ */
/* ------------ ACTUALIZA INTENTOS DE LOGIN	------------ */
CREATE PROCEDURE TODOX2LUCAS.actualizarIntentos(@username nvarchar(255),@Cantidad int ) 
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

		INSERT INTO TODOX2LUCAS.Auditoria_Login(Usuario_Nombre,Estado,Numero_De_Intento)
		VALUES((SELECT Usuario_Nombre FROM TODOX2LUCAS.Usuarios WHERE Usuario_Nombre = @username),0,@IntentosActuales)

		IF (@IntentosActuales >= 3)
		BEGIN	
			UPDATE TODOX2LUCAS.Usuarios 
			SET Estado_Usuario = 0 
			WHERE Usuario_Nombre = @username
		END
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
		  Contraseña = CONVERT(nvarchar(255),@password)
	
	EXEC TODOX2LUCAS.actualizarIntentos @username,@Cantidad
	IF (SELECT Estado_Usuario FROM TODOX2LUCAS.Usuarios WHERE Usuario_Nombre = @username) = 1	
	BEGIN
		RETURN @Cantidad
	END
	ELSE
	BEGIN
		RETURN -1;
	END
END
DECLARE @clave nvarchar(255);
SET @clave = 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7';
exec TODOX2LUCAS.Validar_Login 'Eduardo',@clave

GO


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
		RETURN -1;
	END
END
GO

/* ------------ PROCEDIMIENTO PARA CANCELAR PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cancelar_Pasajes(@fecha datetime,@codAeronave int,@codRuta numeric(18),@motivo nvarchar(255))
AS
BEGIN
	INSERT INTO TODOX2LUCAS.CancelacionesPasajes(Fecha_Devolucion,Numero_Compra_Pasajes,Cod_Pasaje,Motivo)
	SELECT @fecha,t.Numero_Compra,p.Cod_Pasaje,@motivo
	FROM TODOX2LUCAS.Pasajes p JOIN TODOX2LUCAS.Viajes v ON (p.Cod_Viaje=v.Cod_Viaje)
								JOIN TODOX2LUCAS.TransaccionesPasajes t ON (T.Cod_Pasaje=P.Cod_Pasaje)
	WHERE (v.Cod_Aeronave = @codAeronave OR v.Cod_Ruta = @codRuta) AND v.Fecha_Salida > @fecha
END
GO

/* ------------ PROCEDIMIENTO PARA CANCELAR PAQUETES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cancelar_Paquetes(@fecha datetime,@codAeronave int,@codRuta numeric(18),@motivo nvarchar(255))
AS
BEGIN
	INSERT INTO TODOX2LUCAS.CancelacionesPaquetes(Fecha_Devolucion,Numero_Compra_Paquetes,Cod_Encomiendas,Motivo)
	SELECT @fecha,t.Numero_Compra,e.Cod_Encomiendas,@motivo
	FROM TODOX2LUCAS.Encomiendas e JOIN TODOX2LUCAS.Viajes v ON (e.Cod_Viaje=v.Cod_Viaje)
								JOIN TODOX2LUCAS.TransaccionesPaquetes t ON (T.Cod_Encomiendas=e.Cod_Encomiendas)
	WHERE (v.Cod_Aeronave = @codAeronave OR v.Cod_Ruta = @codRuta) AND v.Fecha_Salida > @fecha
END
GO
/* ------------ PROCEDIMIENTO PARA CANCELACIONES POR ADMINISTRADOR ------------ */
CREATE PROCEDURE TODOX2LUCAS.Cancelar_Pasajes_Encomiendas(@fechaDevolucion datetime,@numeroCompra int,@codigo numeric(18),@motivo nvarchar(255))
AS
BEGIN
	IF EXISTS (SELECT * FROM TODOX2LUCAS.TransaccionesPasajes T WHERE T.Numero_Compra =@numeroCompra AND T.Cod_Pasaje=@codigo)
	BEGIN
		INSERT INTO TODOX2LUCAS.CancelacionesPasajes(Cod_Pasaje,Fecha_Devolucion,Motivo,Numero_Compra_Pasajes)
		VALUES(@codigo,@fechaDevolucion,@motivo,@numeroCompra)
	END
	ELSE
	BEGIN
		IF EXISTS (SELECT * FROM TODOX2LUCAS.TransaccionesPaquetes T WHERE T.Numero_Compra =@numeroCompra AND T.Cod_Encomiendas=@codigo)
		BEGIN
			INSERT INTO TODOX2LUCAS.CancelacionesPaquetes(Cod_Encomiendas,Fecha_Devolucion,Motivo,Numero_Compra_Paquetes)
			VALUES(@codigo,@fechaDevolucion,@motivo,@numeroCompra)
		END
		ELSE
		BEGIN
			print 'Datos invalidos'
			return -1;
		END
	END
	
END
GO

/* ------------ PROCEDIMIENTO PARA DAR DE BAJA UNA RUTA AEREA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Ruta_Aerea(@codRuta numeric(18),@ciudadOrigen nvarchar(255),@ciudadDestino nvarchar(255),
												@motivo nvarchar(255))
AS
BEGIN
	DECLARE @codOrigen int,@codDestino int,@fecha datetime;
	SET @codOrigen = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadOrigen);
	SET @codDestino = (SELECT Cod_Ciudad FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad = @ciudadDestino);
	SET @fecha = getdate();
	
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.RutasAereas WHERE Cod_Ruta = @codRuta AND Cod_Ciudad_Origen = @codOrigen AND Cod_Ciudad_Destino = @codDestino AND Estado_Ruta = 0)
	BEGIN
		--El estado si esta en 1 esta activa, en 0 esta desactivada
		UPDATE TODOX2LUCAS.RutasAereas
		SET Estado_Ruta = 0
		WHERE Cod_Ruta = @codRuta AND Cod_Ciudad_Origen = @codOrigen AND Cod_Ciudad_Destino = @codDestino
			
		EXEC TODOX2LUCAS.Cancelar_Pasajes @fecha,NULL,@codRuta,@motivo
		EXEC TODOX2LUCAS.Cancelar_Paquetes @fecha,NULL,@codRuta,@motivo
	END 
	ELSE
	BEGIN
		print 'La ruta aerea ya se dio de baja'
		RETURN -1;
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

	IF NOT EXISTS (SELECT Cod_Viaje FROM TODOX2LUCAS.Viajes WHERE Cod_Ruta=@codRuta)
	BEGIN
		UPDATE TODOX2LUCAS.RutasAereas
		SET Cod_Ciudad_Origen = @codOrigen,
			Cod_Ciudad_Destino = @codDestino
		WHERE Cod_Ruta = @codRuta
	END
	ELSE
	BEGIN
		return -1;
	END
	
END
GO

/* ------------ PROCEDIMIENTO PARA MODIFICAR EL TIPO DE SERVICIO DADO POR LA RUTA AEREA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Servicio_Ruta_Aerea(@codRuta numeric(18),@servicio nvarchar(255))
AS
BEGIN
	DECLARE @codServicio int;
	SET @codServicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio=@servicio);

	IF NOT EXISTS (SELECT Cod_Viaje FROM TODOX2LUCAS.Viajes WHERE Cod_Ruta=@codRuta)
	BEGIN
		UPDATE TODOX2LUCAS.RutasAereas
		SET Cod_Tipo_Servicio = @codServicio
		WHERE Cod_Ruta = @codRuta
	END
	ELSE 
	BEGIN
		print 'La ruta tiene viajes asignados'
		return -1;
	END
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
	ELSE
	BEGIN
		return -1;
	END
	
END
GO
/* ------------ PROCEDIMIENTO QUE DEVUELVE UNA AERONAVE A SUPLANTAR  ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronave_Para_Reemplazar(@codAeronave int,@aeronaveSuplente int OUT)
AS
BEGIN
	DECLARE @fecha datetime,@codfabricante int ,@codServicio int,@modelo nvarchar(255),@fechaSalida datetime,@fechaLlegadaEstimada datetime,@codViaje int;
	SET @fecha = GETDATE();
	
	SELECT DISTINCT @codfabricante = a.Cod_Fabricante, @modelo = A.Cod_Modelo, @codServicio = a.Cod_Tipo_Servicio
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
			A1.Cod_Modelo =@modelo  AND
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

	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Estados_Aeronaves WHERE Cod_Aeronave = @codAeronave)
	BEGIN	
		INSERT INTO TODOX2LUCAS.Estados_Aeronaves (Cod_Aeronave,Vida_Util,Fecha_Baja_Definitiva)
		VALUES(@codAeronave,1,@fecha)
	END
	ELSE
	BEGIN
		PRINT 'La aeronave ya esta dada de baja'
		RETURN -1;
	END

	IF (@cancelaciones = 0)
	BEGIN
		DECLARE @aeronaveSuplente int;
		EXEC TODOX2LUCAS.Aeronave_Para_Reemplazar @codAeronave ,@aeronaveSuplente;
		
		IF (@aeronaveSuplente IS NOT NULL)
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

/* ------------ PROCEDMIENTO PARA DAR DE BAJA UNA AERONAVE POR FUERA DE SERVICIO ------------ */
CREATE PROCEDURE TODOX2LUCAS.Baja_Por_Fuera_De_Servicio(@codAeronave int,@cancelaciones bit,@fechaReinicio datetime)
AS
BEGIN
	DECLARE @fecha datetime,@motivo nvarchar(255);
	SET @fecha = GETDATE();
	SET @motivo = 'Baja por fuera de servicio';
	
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Estados_Aeronaves WHERE Cod_Aeronave = @codAeronave)
	BEGIN	
		INSERT INTO TODOX2LUCAS.Estados_Aeronaves (Cod_Aeronave,Fuera_De_Servicio,Fecha_Fuera_Servicio,Fecha_Reinicio_Servicio)
		VALUES(@codAeronave,1,@fecha,@fechaReinicio)
	END
	ELSE
	BEGIN
		PRINT 'La aeronave ya esta dada de baja'
		RETURN -1;
	END

	IF (@cancelaciones = 0)
	BEGIN
		DECLARE @aeronaveSuplente int;
		EXEC TODOX2LUCAS.Aeronave_Para_Reemplazar @codAeronave ,@aeronaveSuplente;
		
		IF (@aeronaveSuplente IS NOT NULL)
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
											@modelo nvarchar(255),@servicio nvarchar(255), @kgs_Disponibles numeric(18),
											@cantButacasPasillo int,@cantButacasVentanilla int)
AS
BEGIN
	DECLARE @cod_Fabricante int,@cod_Tipo_Servicio int,@codModelo int;
	SET @cod_Fabricante = (SELECT Cod_Fabricante FROM TODOX2LUCAS.Fabricantes WHERE Nombre_Fabricante=@fabricante);
	SET @cod_Tipo_Servicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio = @servicio);
	SET @codModelo = (SELECT Cod_Modelo FROM TODOX2LUCAS.Modelo_Aeronave WHERE Descricpion_Modelo = @modelo)
	
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Aeronaves WHERE Matricula = @matricula)
	BEGIN
		INSERT INTO TODOX2LUCAS.Aeronaves(Matricula,Fecha_Alta,Cod_Fabricante,Cod_Modelo,Cod_Tipo_Servicio,Kgs_Disponibles,Cantidad_Butacas )
		VALUES(@matricula,@fecha_Alta,@cod_Fabricante,@codModelo,@cod_Tipo_Servicio,@kgs_Disponibles,(@cantButacasPasillo + @cantButacasVentanilla))
	
		DECLARE @codAeronave int;
		SET @codAeronave = (SELECT DISTINCT @@IDENTITY FROM TODOX2LUCAS.Aeronaves);
		
		DECLARE @contador numeric(18);
		SET @contador = 0;
		WHILE (@cantButacasVentanilla != 0)
		BEGIN
			INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca,Estado_Butaca)
			VALUES(@codAeronave,@contador,'Ventanilla',1,1)
			
			SET @contador = @contador + 1;
			SET @cantButacasVentanilla = @cantButacasVentanilla - 1;
		END
		WHILE(@cantButacasPasillo != 0)	
			
		BEGIN
			INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca,Estado_Butaca)
			VALUES(@codAeronave,@contador,'Pasillo',1,1)
			
			SET @contador = @contador + 1;
			SET @cantButacasPasillo = @cantButacasPasillo - 1;
		END
	END
	ELSE
	BEGIN
		print 'La matricula ya existe'
		RETURN -1;
	END
END
GO
/* ------------ PROCEDIMIENTO PARA MODIFICAR UNA AERONAVE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Aeronave(@matricula nvarchar(255),@codAeronave int,@fabricante nvarchar(255),@modelo nvarchar(255),
												@servicio nvarchar(255),@rehabilitar bit,@kgs int)
AS
BEGIN
	IF NOT EXISTS (SELECT Matricula FROM TODOX2LUCAS.Aeronaves WHERE Matricula = @matricula)
	BEGIN
		UPDATE TODOX2LUCAS.Aeronaves 
		SET Matricula = @matricula 
		WHERE Cod_Aeronave = @codAeronave
	END
	ELSE
	BEGIN
			PRINT 'La matricula ingrsada ya existe'
			RETURN -1;
		END
	END
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Viajes WHERE Cod_Aeronave = @codAeronave AND Fecha_Salida > GETDATE() )
	BEGIN
		UPDATE TODOX2LUCAS.Aeronaves
		SET Cod_Fabricante = (SELECT Cod_Fabricante FROM TODOX2LUCAS.Fabricantes WHERE Nombre_Fabricante = @fabricante)	,
			Cod_Modelo = (SELECT Cod_Modelo FROM TODOX2LUCAS.Modelo_Aeronave WHERE Descricpion_Modelo= @modelo),
			Cod_Tipo_Servicio = (SELECT Cod_Tipo_Servicio FROM TODOX2LUCAS.Tipos_De_Servicios WHERE Descripcion_Servicio = @servicio),
			Kgs_Disponibles = Kgs_Disponibles + @kgs
		WHERE Cod_Aeronave = @codAeronave
	END
	ELSE
	BEGIN
		PRINT 'La aeronave tiene viajes asignados'
		RETURN -2;
	END

	IF (@rehabilitar = 1)
	BEGIN
		IF EXISTS (SELECT * FROM TODOX2LUCAS.Estados_Aeronaves WHERE Cod_Aeronave = @codAeronave AND Fuera_De_Servicio = 1)
		BEGIN
			DECLARE @fechaactual datetime;
			SET @fechaactual = GETDATE();
			IF (@fechaactual > (SELECT Fecha_Reinicio_Servicio FROM TODOX2LUCAS.Estados_Aeronaves WHERE Cod_Aeronave = @codAeronave))
			BEGIN
				DELETE FROM TODOX2LUCAS.Estados_Aeronaves WHERE Cod_Aeronave = @codAeronave
			END
			ELSE
			BEGIN 
				print 'Todavia la aeronave se encuentra fuera de servicio'
				RETURN -3;
			
		END
	END

	
END
GO 
/* ------------ PROCEDIMIENTO PARA AGREGAR BUTACA BUTACA------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Agregar_Butaca(@codAeronave int,@posButaca nvarchar(255))
AS
BEGIN
IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Viajes WHERE Cod_Aeronave = @codAeronave )
BEGIN
	UPDATE TODOX2LUCAS.Aeronaves
	SET Cantidad_Butacas = Cantidad_Butacas + 1
	WHERE Cod_Aeronave  = @codAeronave

	DECLARE @ultima_butaca numeric(18);
	SELECT TOP 1 @ultima_butaca = Cod_Butaca
	FROM TODOX2LUCAS.Butacas
	WHERE Cod_Aeronave = @codAeronave AND Pos_Butaca = @posButaca
	ORDER BY Cod_Butaca DESC

	INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Piso_Butaca,Pos_Butaca)
	VALUES(@codAeronave,(@ultima_butaca + 1),1,@posButaca)
END
ELSE
BEGIN
	print 'La aeronave ya tiene vuelos asignados'
	return -1;
END

END
GO 
/* ------------ PROCEDIMIENTO PARA AGREGAR BUTACA BUTACA------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Quitar_Butaca(@codAeronave int,@posButaca nvarchar(255))
AS
BEGIN
IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Viajes WHERE Cod_Aeronave = @codAeronave )
BEGIN

	UPDATE TODOX2LUCAS.Aeronaves
	SET Cantidad_Butacas = Cantidad_Butacas - 1
	WHERE Cod_Aeronave  = @codAeronave

	DECLARE @ultima_butaca numeric(18);
	SELECT TOP 1 @ultima_butaca = Cod_Butaca
	FROM TODOX2LUCAS.Butacas
	WHERE Cod_Aeronave = @codAeronave AND Pos_Butaca = @posButaca
	ORDER BY Cod_Butaca DESC

	DELETE FROM TODOX2LUCAS.Butacas 
	WHERE Cod_Butaca = @ultima_butaca AND Cod_Aeronave = @codAeronave AND Pos_Butaca = @posButaca
END
ELSE
BEGIN
	print 'La aeronave ya tiene vuelos asignados'
	return -1;
END

END
GO
/* ------------ PROCEDIMIENTO PARA OBTENER LAS CANTIDADES TOTALES DE LAS AERONAVES PASILLO - VENTANILLA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Butacas_Por_Tipo(@codAeronave int,@tipo nvarchar(255))
AS
BEGIN
	DECLARE @cantidad int;
	SELECT @cantidad = COUNT(*) 
	FROM TODOX2LUCAS.Butacas
	WHERE Cod_Aeronave = @codAeronave AND Pos_Butaca = @tipo

	RETURN @cantidad;
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
		RETURN -1;
	END
END
GO 
/* ------------ PROCEDIMIENTO QUE DEVUELVE LAS AERONAVES DISPONIBLES SEGUN UNA RUTA ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronaves_Segun_Ruta(@codRuta numeric(18),@origen int,@destino int)
AS
BEGIN
	SELECT A.*
	FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.RutasAereas R ON (R.Cod_Tipo_Servicio = A.Cod_Tipo_Servicio)
	WHERE A.Cod_Aeronave NOT IN (SELECT Cod_Aeronave FROM TODOX2LUCAS.Estados_Aeronaves) AND
			R.Cod_Ruta = @codRuta AND R.Cod_Ciudad_Origen = @origen AND R.Cod_Ciudad_Destino = @destino

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
				WHERE Matricula = @matricula AND V.Cod_Ciudad_Origen = @codOrigen AND V.Cod_Ciudad_Destino=@codDestino AND v.Fecha_Llegada IS NULL )
	BEGIN
		DECLARE @codAeronave int,@fechaSalida datetime,@codViaje int;
		SELECT @codViaje = v.Cod_Viaje,@codAeronave = a.Cod_Aeronave,@fechaSalida = v.Fecha_Salida
		FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Viajes V ON (A.Cod_Aeronave=V.Cod_Aeronave)
		WHERE a.Cod_Aeronave = (SELECT Cod_Aeronave FROM TODOX2LUCAS.Aeronaves WHERE Matricula = @matricula) AND
				 V.Cod_Ciudad_Origen = @codOrigen AND V.Cod_Ciudad_Destino=@codDestino AND v.Fecha_Llegada IS NULL 
				AND DATEDIFF(HOUR,@fechaLlegada,v.Fecha_Salida)<24
		
		IF (@fechaSalida < @fechaLlegada)
		BEGIN
			UPDATE TODOX2LUCAS.Viajes
			SET Fecha_Llegada = @fechaLlegada
			WHERE Cod_Viaje =@codViaje AND Cod_Aeronave =@codAeronave
		END
		ELSE 
		BEGIN
			print 'La fecha de llegada es menor a la fecha de salida'
			RETURN - 2;
		END
	END
	ELSE
	BEGIN
		print 'La aeronave no debia llegar al destino ingresado'
		RETURN -1;
	END
	
END
GO 

/* ------------ PROCEDIMIENTO PARA CANJES CON LAS MILLAS DE UN CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Canjear_Millas(@dni numeric(18),@cliente nvarchar(255),@producto nvarchar(255),@cantidad int)
AS
BEGIN
IF EXISTS(SELECT * FROM TODOX2LUCAS.Clientes WHERE Nro_Dni = @dni AND Cliente_Apellido = @cliente)
BEGIN
	IF ((SELECT Cantidad FROM TODOX2LUCAS.Productos p WHERE Descripcion_Producto = @producto) < @cantidad)
	BEGIN
		print 'No hay disponibilidad de stock'
		RETURN -2;
	END
	ELSE 
	BEGIN
		DECLARE @codProducto int, @precioMillas int;
		SELECT @codProducto = Cod_Producto, @precioMillas = PrecioEnMillas
		FROM TODOX2LUCAS.Productos 
		WHERE Descripcion_Producto = @producto
		IF ((SELECT Cant_Millas FROM TODOX2LUCAS.Clientes WHERE Nro_Dni=@dni AND Cliente_Apellido =@cliente) > (@precioMillas * @cantidad))
		BEGIN
			INSERT INTO TODOX2LUCAS.Canjes(Nro_Dni,Cliente_Apellido,Cod_Producto,Fecha,Cantidad_Comprada)
			VALUES (@dni,@cliente,@codProducto,GETDATE(),@cantidad)
		
			UPDATE TODOX2LUCAS.Clientes
			SET Cant_Millas = Cant_Millas - @precioMillas
			WHERE Nro_Dni = @dni AND Cliente_Apellido = @cliente

			UPDATE TODOX2LUCAS.Productos
			SET Cantidad = Cantidad - @cantidad
			WHERE Cod_Producto = @codProducto
		END
		ELSE
		BEGIN
			print 'No tiene la cantidad de millas necesarias para realizar el canje'
			RETURN -3;
		END
	END
END
ELSE
BEGIN
	PRINT 'El cliente ingresado no existe'
	RETURN -1;
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
/* ------------ FUNCION QUE RETORNA LA CANTIDAD DE KILOGRAMOS LIBRES EN UNA AERONAVE DADO UN VIAJE------------ */
CREATE FUNCTION TODOX2LUCAS.Kilogramos_Libres_Aeronave(@codViaje int)
RETURNS int
AS
BEGIN
	DECLARE @kilogramosLibres int,@kilogramosCancelados int;

	SELECT @kilogramosLibres =	(A.Kgs_Disponibles - SUM(E.Kgs_A_Enviar)) 
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
							JOIN TODOX2LUCAS.Encomiendas E ON (E.Cod_Viaje=V.Cod_Viaje)
	WHERE V.Cod_Viaje = @codViaje
	GROUP BY A.Cod_Aeronave,V.Cod_Viaje,A.Kgs_Disponibles

	SELECT @kilogramosCancelados = SUM(E.Kgs_A_Enviar)
	FROM TODOX2LUCAS.Encomiendas E JOIN TODOX2LUCAS.CancelacionesPaquetes CE ON (E.Cod_Encomiendas = CE.Cod_Encomiendas)
									JOIN TODOX2LUCAS.Viajes V ON (V.Cod_Viaje = E.Cod_Viaje)
	WHERE V.Cod_Viaje = @codViaje
	
	IF (@kilogramosCancelados IS NOT NULL)
	BEGIN
		SET @kilogramosLibres = @kilogramosLibres - @kilogramosCancelados;
	END
	
	RETURN @kilogramosLibres;
END
GO

/* ------------ FUNCION QUE RETORNA LA CANTIDAD DE BUTACAS LIBRES EN UNA AERONAVE DADO UN VIAJE------------ */
CREATE FUNCTION TODOX2LUCAS.Butacas_Libres_Aeronave(@codViaje int)
RETURNS int
AS
BEGIN
	DECLARE @butacasLibres int,@butacasCancelados int;
	
	SELECT @butacasLibres =	(A.Cantidad_Butacas - COUNT(B.Cod_Butaca)) 
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
							JOIN TODOX2LUCAS.Pasajes P ON (P.Cod_Viaje=V.Cod_Viaje)
							JOIN TODOX2LUCAS.Butacas B ON (B.Cod_Aeronave=A.Cod_Aeronave AND B.Cod_Butaca=P.Butaca_Asociada)
	WHERE V.Cod_Viaje = @codViaje
	GROUP BY A.Cod_Aeronave,V.Cod_Viaje,a.Cantidad_Butacas

	SELECT @butacasCancelados = COUNT(P.Butaca_Asociada)
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.CancelacionesPasajes CP ON (P.Cod_Pasaje = CP.Cod_Pasaje)
								JOIN TODOX2LUCAS.Viajes V ON(V.Cod_Viaje = P.Cod_Viaje)
	WHERE V.Cod_Viaje = @codViaje

	SET @butacasLibres = @butacasLibres - @butacasCancelados;
	
	RETURN @butacasLibres;
END
GO
/* ------------ PROCEDIMIENTO QUE RETORNA (LA TABLA BUTACAS) DE TODAS LAS BUTACA LIBRES DADO UN VIAJE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Butacas_Libres(@codViaje int)
AS
BEGIN
	SELECT B.Cod_Butaca,B.Pos_Butaca
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
							JOIN TODOX2LUCAS.Butacas B ON (B.Cod_Aeronave=A.Cod_Aeronave)
	WHERE V.Cod_Viaje = @codViaje
	EXCEPT
	SELECT B.Cod_Butaca,B.Pos_Butaca
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
							JOIN TODOX2LUCAS.Pasajes P ON (P.Cod_Viaje=V.Cod_Viaje)
							JOIN TODOX2LUCAS.Butacas B ON (B.Cod_Aeronave=A.Cod_Aeronave AND B.Cod_Butaca = P.Butaca_Asociada)
	WHERE V.Cod_Viaje = @codViaje
	UNION
	SELECT B.Cod_Butaca,B.Pos_Butaca
	FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.Aeronaves A ON (V.Cod_Aeronave=A.Cod_Aeronave)
							JOIN TODOX2LUCAS.Pasajes P ON (P.Cod_Viaje=V.Cod_Viaje)
							JOIN TODOX2LUCAS.Butacas B ON (B.Cod_Aeronave=A.Cod_Aeronave AND B.Cod_Butaca = P.Butaca_Asociada)
							JOIN TODOX2LUCAS.CancelacionesPasajes CP ON (CP.Cod_Pasaje = P.Cod_Pasaje)
	WHERE V.Cod_Viaje = @codViaje
	
END
GO

/* ------------ PROCEDIMIENTOS PARA COMPRAR PASAJES  ------------ */
--DROP PROCEDURE TODOX2LUCAS.Comprar_Pasajes
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

	SET @codPasaje = (SELECT DISTINCT @@IDENTITY FROM TODOX2LUCAS.Pasajes);
	
	DECLARE @PNR int,@ultimoDni numeric(18);
	SELECT DISTINCT TOP 1 @ultimoDni = Nro_Dni,@PNR = Numero_Compra FROM TODOX2LUCAS.TransaccionesPasajes ORDER BY Numero_Compra DESC

	IF (@nro_dni != @ultimoDni )
	BEGIN
		SET @PNR = @PNR + 1;
		SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPasajes ON
			INSERT INTO TODOX2LUCAS.TransaccionesPasajes(Numero_Compra,Nro_Dni,Cliente_Apellido,Cod_Pasaje,Fecha_Transaccion,Forma_De_Pago)
			VALUES (@PNR,@nro_dni,@apellido,@codPasaje,GETDATE(),@formaDePago)
		SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPasajes OFF
	END
	ELSE
	BEGIN
		SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPasajes ON
			INSERT INTO TODOX2LUCAS.TransaccionesPasajes(Numero_Compra,Nro_Dni,Cliente_Apellido,Cod_Pasaje,Fecha_Transaccion,Forma_De_Pago)
			VALUES (@PNR,@nro_dni,@apellido,@codPasaje,GETDATE(),@formaDePago)
		SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPasajes OFF

	END

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
	IF ((SELECT TODOX2LUCAS.Kilogramos_Libres_Aeronave(@codViaje)) > = @kgs_a_enviar)
	BEGIN
		SELECT  @fecha = Fecha_Salida , @precioBaseEncomienda = r.Precio_Base_Kg ,@precioServicio = t.Precio_Servicio
		FROM TODOX2LUCAS.Viajes V JOIN TODOX2LUCAS.RutasAereas R ON (V.Cod_Ruta=R.Cod_Ruta)
									JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(t.Cod_Tipo_Servicio=r.Cod_Tipo_Servicio)
		WHERE V.Cod_Viaje = @codViaje
	
		SET @precioEncomienda = (@precioBaseEncomienda * @precioServicio * @kgs_a_enviar)
	
		INSERT INTO TODOX2LUCAS.Encomiendas(Fecha_Compra,Cod_Viaje,Kgs_A_Enviar,Nro_Dni,Precio_Encomienda,Cliente_Apellido)
		VALUES(@fecha,@codViaje,@kgs_a_enviar,@nro_dni,@precioEncomienda,@apellido)
	
		SET @codEncomienda = (SELECT DISTINCT @@IDENTITY FROM TODOX2LUCAS.Encomiendas);
	
		DECLARE @PNR int,@ultimoDni numeric(18);
		SELECT DISTINCT TOP 1 @ultimoDni = Nro_Dni,@PNR = Numero_Compra FROM TODOX2LUCAS.TransaccionesPaquetes ORDER BY Numero_Compra DESC
	
		IF (@nro_dni = @ultimoDni)
		BEGIN
			SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPaquetes ON
			INSERT INTO TODOX2LUCAS.TransaccionesPaquetes(Numero_Compra,Nro_Dni,Cliente_Apellido,Cod_Encomiendas,Fecha_Transaccion,Forma_De_Pago)
			VALUES (@PNR,@nro_dni,@apellido,@codEncomienda,GETDATE(),@formaDePago)
			SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPaquetes OFF
		END
		ELSE
		BEGIN
			SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPaquetes ON
			INSERT INTO TODOX2LUCAS.TransaccionesPaquetes(Numero_Compra,Nro_Dni,Cliente_Apellido,Cod_Encomiendas,Fecha_Transaccion,Forma_De_Pago)
			VALUES ((@PNR + 1),@nro_dni,@apellido,@codEncomienda,GETDATE(),@formaDePago)
			SET IDENTITY_INSERT TODOX2LUCAS.TransaccionesPaquetes OFF
		END

		IF (@formaDePago = 'Tarjeta')
		BEGIN
			INSERT INTO TODOX2LUCAS.Tarjetas(Numero_Tarjeta,Cod_Seg,Fecha_Vencimiento,Tipo_Tarjeta,Nro_Dni,Cliente_Apellido)
			VALUES(@numero_tarjeta,@cod_seg,@fecha_vencimiento,@tipo_tarjeta,@nro_dni,@apellido)
		END
	END
	ELSE
	BEGIN
		print 'No hay disponibilidad para la cantidad de kilogramos ingresada'
		RETURN -1;
	END
END
GO 
/* ------------ PROCEDIMIENTOS PARA VERIFICAR EXISTENCIA DE UN CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Verificar_Cliente(@nro numeric(18),@apellido nvarchar(255))
AS
BEGIN
	IF EXISTS (SELECT * FROM TODOX2LUCAS.Clientes WHERE Nro_Dni = @nro AND Cliente_Apellido = @apellido)
	BEGIN
		RETURN -1; --EXISTE
	END
	ELSE
	BEGIN
		RETURN -2; --NOEXISTE
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
		RETURN -1;
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
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad LIKE '%' + @ciudad + '%')
	BEGIN
		INSERT INTO TODOX2LUCAS.Ciudades(Nombre_Ciudad,Estado_Ciudad)
		VALUES(@ciudad,1)
	END
	ELSE
	BEGIN
		print 'Ya existe la ciudad' 
		RETURN -1;
	END
END
GO
/* ------------ PROCEDIMIENTO PARA MODIFICAR UNA CIUDAD ------------ */
CREATE PROCEDURE TODOX2LUCAS.Modificar_Nombre_Ciudad(@ciudad nvarchar(255),@nuevoNombre nvarchar(255))
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM TODOX2LUCAS.Ciudades WHERE Nombre_Ciudad LIKE '%' + @nuevoNombre + '%')
	BEGIN
		UPDATE TODOX2LUCAS.Ciudades
		SET Nombre_Ciudad = @nuevoNombre
		WHERE Nombre_Ciudad = @ciudad
	END
	ELSE
	BEGIN
		print 'El nombre de la ciudad ingresado ya existe'
		RETURN -1;
	END
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
	IF EXISTS (SELECT * FROM TODOX2LUCAS.Clientes WHERE Nro_Dni=@dni AND Cliente_Apellido=@apellido)
	BEGIN
		DECLARE @millas int;
		SELECT @millas = Cant_Millas
		FROM TODOX2LUCAS.Clientes
		WHERE Nro_Dni = @dni AND Cliente_Apellido = @apellido
		RETURN @millas;
	END
	ELSE
	BEGIN
		PRINT 'El cliente ingresado no existe'
		RETURN -1;
	END
END
GO
/* ------------ PROCEDIMIENTOS PARA MOSTRAR LISTADO DETALLE MILLAS DE UN CLIENTE ------------ */
CREATE PROCEDURE TODOX2LUCAS.Listado_Consulta_Millas(@nroDni numeric(18),@apellido nvarchar(255))
AS
BEGIN
	select  C.Cliente_Apellido,C.Nro_Dni,P.Cod_Pasaje as 'Pasajes/Encomiendas/Canjes',FLOOR(p.Pasaje_Precio/10) as 'Millas Acumuladas'  
	from TODOX2LUCAS.TransaccionesPasajes TP JOIN TODOX2LUCAS.Clientes C ON (C.Cliente_Apellido=TP.Cliente_Apellido AND C.Nro_Dni=TP.Nro_Dni)
											JOIN  TODOX2LUCAS.Pasajes P ON (C.Cliente_Apellido = P.Cliente_Apellido AND C.Nro_Dni = P.Nro_Dni)
	WHERE C.Cliente_Apellido = @apellido AND C.Nro_Dni = @nroDni
	GROUP BY P.Cod_Pasaje,C.Cliente_Apellido,C.Nro_Dni,P.Pasaje_Precio	
	UNION ALL
	select  C.Cliente_Apellido,C.Nro_Dni,E.Cod_Encomiendas,FLOOR(e.Precio_Encomienda/10)
	from TODOX2LUCAS.Clientes C JOIN TODOX2LUCAS.Encomiendas E ON (E.Cliente_Apellido=C.Cliente_Apellido AND E.Nro_Dni = C.Nro_Dni)
								JOIN TODOX2LUCAS.TransaccionesPaquetes TE ON (TE.Cliente_Apellido=C.Cliente_Apellido AND C.Nro_Dni = TE.Nro_Dni)
	WHERE C.Cliente_Apellido = @apellido AND C.Nro_Dni = @nroDni
	GROUP BY E.Cod_Encomiendas,C.Cliente_Apellido,C.Nro_Dni,E.Precio_Encomienda
	UNION
	select  C.Cliente_Apellido,C.Nro_Dni,E.Cod_Encomiendas,(FLOOR(e.Precio_Encomienda/10) * -1)
	from TODOX2LUCAS.Clientes C JOIN TODOX2LUCAS.Encomiendas E ON (E.Cliente_Apellido=C.Cliente_Apellido AND E.Nro_Dni = C.Nro_Dni)
								JOIN TODOX2LUCAS.CancelacionesPaquetes CP ON (CP.Cod_Encomiendas=E.Cod_Encomiendas)
	WHERE C.Cliente_Apellido = @apellido AND C.Nro_Dni = @nroDni
	GROUP BY E.Cod_Encomiendas,C.Cliente_Apellido,C.Nro_Dni,E.Precio_Encomienda
	UNION
	select  C.Cliente_Apellido,C.Nro_Dni,P.Cod_Pasaje,(FLOOR(P.Pasaje_Precio/10) * -1)
	from TODOX2LUCAS.Clientes C JOIN TODOX2LUCAS.Pasajes P ON (P.Cliente_Apellido=C.Cliente_Apellido AND P.Nro_Dni = C.Nro_Dni)
								JOIN TODOX2LUCAS.CancelacionesPasajes CP ON (CP.Cod_Pasaje=P.Cod_Pasaje)
	WHERE C.Cliente_Apellido = @apellido AND C.Nro_Dni = @nroDni
	GROUP BY P.Cod_Pasaje,C.Cliente_Apellido,C.Nro_Dni,P.Pasaje_Precio
	UNION
	select  C.Cliente_Apellido,C.Nro_Dni,CA.Cod_Canje,(FLOOR(CA.Cantidad_Comprada * P.PrecioEnMillas) * -1)
	from TODOX2LUCAS.Clientes C JOIN TODOX2LUCAS.Canjes CA ON (CA.Cliente_Apellido=C.Cliente_Apellido AND CA.Nro_Dni = C.Nro_Dni)
								JOIN TODOX2LUCAS.Productos P ON (P.Cod_Producto = CA.Cod_Producto)
	WHERE C.Cliente_Apellido = @apellido AND C.Nro_Dni = @nroDni
	GROUP BY CA.Cod_Canje,C.Cliente_Apellido,C.Nro_Dni,CA.Cantidad_Comprada,P.PrecioEnMillas
END
GO 
----------------------------------------- GETTERS TABLAS DE TODOS SUS DATOS Y CON FILTRO POR PK------------------------------------------------
------------------------------------------------- TABLA CIUDADES ---------------------------------------------------------------
 /* ------------ PROCEDIMIENTOS GETTER TODOS LAS CIUDADES ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetCiudades
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Ciudades
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER TODOS LAS CIUDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetCiudad(@codCiudad int)
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Ciudades
	WHERE Cod_Ciudad = @codCiudad
END
GO
--------------------------------------------------- TABLA FABRICANTES ---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER FABRICANTE ------------ */
 CREATE PROCEDURE   TODOX2LUCAS.GetFabricante(@codFabricante int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Fabricantes
	WHERE Cod_Fabricante = @codFabricante
 END
 GO
 /* ------------ PROCEDIMIENTOS GETTER TODOS LOS FABRICANTES ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetFabricantes
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Fabricantes
 END
 GO

------------------------------------------------- TABLA FUNCIONALIDADES ---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Funcionalidad(@codFuncionalidad int)
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Funcionalidades
	WHERE Cod_Funcionalidad = @codFuncionalidad
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Funcionalidades
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Funcionalidades
END
GO
------------------------------------------------- TABLA PRODUCTOS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER PRODUCTOS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Producto(@codProducto int)
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Productos 
	WHERE Cod_Producto = @codProducto
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LOS PRODUCTOS ------------ */ 
CREATE PROCEDURE TODOX2LUCAS.Get_Productos
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Productos 
END
GO
------------------------------------------------- TABLA ROLES---------------------------------------------------------------
 /* ------------ PROCEDIMIENTOS GETTER ROL ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetRol(@codRol int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Roles
	WHERE Cod_Rol = @codRol
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER TODOS LOS ROLES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Roles
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Roles 
END
GO
------------------------------------------------- TABLA USUARIOS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER USUARIO ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetUsuario(@usrname nvarchar(255))
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Usuarios
	WHERE Usuario_Nombre = @usrname	
 END
 GO

/* ------------ PROCEDIMIENTOS GETTER TODOS LOS USUARIOS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Usuarios
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Usuarios
END
GO
------------------------------------------------- TABLA AUDITORIA LOGIN---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER AUDITORIA LOGIN ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetAuditoriaLogin(@codAuditoria int)
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Auditoria_Login
	WHERE Cod_Auditoria = @codAuditoria
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS AUDITORIAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_AuditoriasLogin
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Auditoria_Login
END
GO
------------------------------------------------- TABLA MODELO AERONAVE---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER MODELO AERONAVE ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetModelo(@codModelo int)
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Modelo_Aeronave
	WHERE Cod_Modelo = @codModelo
END
GO
CREATE PROCEDURE TODOX2LUCAS.GetModelos
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Modelo_Aeronave
END
GO
------------------------------------------------- TABLA ROL POR FUNCIONALIDAD---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER ROL FUNCIONALIDAD ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetRolPorFuncionalidad(@codRol int,@codFuncionalidad int)
AS
BEGIN 
	SELECT *
	FROM TODOX2LUCAS.Rol_Por_Funcionalidad
	WHERE Cod_Rol = @codRol AND Cod_Funcionalidad = @codFuncionalidad
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LOS ROLES POR FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_RolPorFuncionalidades
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Rol_Por_Funcionalidad
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LOS ROLES POR FUNCIONALIDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Funcionalidades_De_Rol(@codRol int)
AS
BEGIN 
	SELECT f.*
	FROM TODOX2LUCAS.Rol_Por_Funcionalidad R JOIN TODOX2LUCAS.Funcionalidades F ON (R.Cod_Funcionalidad = f.Cod_Funcionalidad)
	WHERE Cod_Rol = @codRol 
END
GO
------------------------------------------------- TABLA CLIENTES ---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER CLIENTE ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetCliente(@dni numeric(18),@apellido nvarchar(255))
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Clientes
	WHERE Nro_Dni = @dni AND Cliente_Apellido = @apellido
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER TODOS LOS CLIENTES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Clientes
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Clientes
END
GO
------------------------------------------------- TABLA TARJETAS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER TARJETAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetTarjeta(@numTarjeta numeric(16))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Tarjetas 
	WHERE Numero_Tarjeta = @numTarjeta
END
GO

/* ------------ PROCEDIMIENTOS GETTER TODAS LAS TARJETAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Tarjetas
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Tarjetas
END
GO
------------------------------------------------- TABLA TIPOS DE SERVICIOS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER TIPO SERVICIO ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetTipoServicio(@codServicio int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Tipos_De_Servicios
	WHERE Cod_Tipo_Servicio = @codServicio
 END
 GO
 /* ------------ PROCEDIMIENTOS GETTER TODOS LOS SERVICIOS ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetServicios
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Tipos_De_Servicios
 END
 GO

------------------------------------------------- TABLA AERONAVES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER AERONAVE ------------ */
 CREATE PROCEDURE  TODOX2LUCAS.GetAeronave(@codAeronave int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Aeronaves 
	WHERE Cod_Aeronave = @codAeronave
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS AERONAVES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Aeronaves
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Aeronaves 
END
GO
------------------------------------------------- TABLA ESTADOS AERONAVES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER ESTADOS AERONAVES ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetEstadoAeronave(@codEstado int,@codAeronave int)
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Estados_Aeronaves
	WHERE Cod_Estado = @codEstado AND Cod_Aeronave = @codAeronave
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODOS LOS AERONAVES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_EstadosAeronaves
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Estados_Aeronaves
END
GO
------------------------------------------------- TABLA BUTACAS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER BUTACAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetButaca(@codButaca numeric(18),@codAeronave int)
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Butacas 
	WHERE Cod_Butaca = @codButaca AND Cod_Aeronave = @codAeronave
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS BUTACAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Butacas
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Butacas
END
GO
------------------------------------------------- TABLA RUTASAEREAS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER RUTA ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetRuta(@codRuta numeric(18),@ciudadOrigen int,@ciudadDestino int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.RutasAereas 
	WHERE Cod_Ruta = @codRuta AND Cod_Ciudad_Origen = @ciudadOrigen AND Cod_Ciudad_Destino = @ciudadDestino
 END
 GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS RUTAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Rutas
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.RutasAereas
END
GO
------------------------------------------------- TABLA VIAJES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER VIAJE ------------ */
 CREATE PROCEDURE TODOX2LUCAS.GetViaje(@codViaje int)
 AS
 BEGIN
	SELECT *
	FROM TODOX2LUCAS.Viajes
	WHERE Cod_Viaje = @codViaje
 END
 GO

/* ------------ PROCEDIMIENTOS GETTER TODOS LOS VIAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Viajes
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Viajes
END
GO
------------------------------------------------- TABLA CANJES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER CANJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetCanje(@codCanje int)
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Canjes
	WHERE Cod_Canje = @codCanje
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODOS LOS CANJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Canjes
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Canjes
END
GO
------------------------------------------------- TABLA ENCOMIENDAS---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER ENCOMIENDAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetEncomienda(@codEncomiendas numeric(18))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Encomiendas
	WHERE Cod_Encomiendas = @codEncomiendas
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS ENCOMIENAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Encomiendas
AS
BEGIN
	SELECT * 
	FROM TODOX2LUCAS.Encomiendas
END
GO
------------------------------------------------- TABLA PASAJES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetPasaje(@codPasaje numeric(18))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Pasajes
	WHERE Cod_Pasaje = @codPasaje
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODOS LOS PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_Pasajes
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Encomiendas
END
GO
------------------------------------------------- TABLA TRANSACCIONES PASAJES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER TRANSACCIONES PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetTransaccionPasaje(@numeroCompra int,@codPasaje numeric(18))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.TransaccionesPasajes
	WHERE Numero_Compra = @numeroCompra AND Cod_Pasaje = @codPasaje
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS TRANSACCIONES PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_TransaccionesPasajes
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.TransaccionesPasajes
END
GO
------------------------------------------------- TABLA TRANSACCIONES PAQUETES---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER TRANSACCIONES PAQUETES ------------ */
CREATE PROCEDURE TODOX2LUCAS.GetTransaccionPaquete(@numeroCompra int,@codEncomienda numeric(18))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.TransaccionesPaquetes
	WHERE Numero_Compra = @numeroCompra AND Cod_Encomiendas = @codEncomienda
END
GO

/* ------------ PROCEDIMIENTOS GETTER TODAS LAS TRANSACCIONES PAQUETES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_TransacionesPaquetes
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.TransaccionesPaquetes
END
GO
------------------------------------------------- TABLAS CANCELACIONES ---------------------------------------------------------------
/* ------------ PROCEDIMIENTOS GETTER CANCELACIONES PASAJE------------ */
CREATE PROCEDURE TODOX2LUCAS.GetCancelacionPasaje(@codDevolucion int,@codPasaje numeric(18))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.CancelacionesPasajes
	WHERE Codigo_Devolucion = @codDevolucion AND Cod_Pasaje = @codPasaje 
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS CANCELACIONES PASAJES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_CancelacionesPasajes
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.CancelacionesPasajes
END
GO
/* ------------ PROCEDIMIENTOS GETTER CANCELACIONES PAQUETE------------ */
CREATE PROCEDURE TODOX2LUCAS.GetCancelacionPaquete(@codDevolucion int,@codEncomienda numeric(18))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.CancelacionesPaquetes
	WHERE Codigo_Devolucion = @codDevolucion AND Cod_Encomiendas = @codEncomienda
END
GO
/* ------------ PROCEDIMIENTOS GETTER TODAS LAS CANCELACIONES PAQUETES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Get_CancelacionesPaquetes
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.CancelacionesPaquetes
END
GO
/* ------------ PROCEDIMIENTOS PARA LOS LISTADOS ESTADISTICOS ------------ */
/* ------------ Top 5 de los destinos con más pasajes comprados ------------ */
CREATE PROCEDURE TODOX2LUCAS.Pasajes_Mas_Comprados(@fecha_inicio datetime, @fecha_fin datetime)
AS
BEGIN
	SELECT TOP 5  COUNT(V.Cod_Ciudad_Destino) as 'Cantidad Pasajes',V.Cod_Ciudad_Destino as 'Codigo Ciudad',C.Nombre_Ciudad as 'Nombre Ciudad'
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
								JOIN TODOX2LUCAS.Ciudades C ON (V.Cod_Ciudad_Destino = C.Cod_Ciudad)
	WHERE V.Fecha_Salida BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY V.Cod_Ciudad_Destino, C.Nombre_Ciudad
	ORDER BY 1 DESC
	
END
GO

/* ------------ Top 5 de los destinos con aeronaves más vacías ------------ */
CREATE PROCEDURE TODOX2LUCAS.Aeronaves_Mas_Vacias(@fecha_inicio datetime, @fecha_fin datetime)
AS
BEGIN
	SELECT TOP 5 C.Nombre_Ciudad,COUNT(B.Cod_Butaca) AS 'CANT_BUTACAS_VACIAS'
	FROM TODOX2LUCAS.Pasajes P JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
								JOIN TODOX2LUCAS.Aeronaves A ON(A.Cod_Aeronave=V.Cod_Aeronave)
								JOIN TODOX2LUCAS.Butacas B ON(A.Cod_Aeronave=B.Cod_Aeronave AND P.Butaca_Asociada=B.Cod_Butaca)
								JOIN TODOX2LUCAS.Ciudades C ON (V.Cod_Ciudad_Destino = C.Cod_Ciudad)
	WHERE V.Fecha_Salida BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY c.Nombre_Ciudad
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
	SELECT DISTINCT TOP 5 CIU.Nombre_Ciudad,COUNT(CP.Cod_Pasaje) as 'CANT_CANCELACIONES'
	FROM TODOX2LUCAS.CancelacionesPasajes CP JOIN TODOX2LUCAS.Pasajes P ON (CP.Cod_Pasaje=P.Cod_Pasaje)
									JOIN TODOX2LUCAS.Viajes V ON (P.Cod_Viaje=V.Cod_Viaje)
									JOIN TODOX2LUCAS.Ciudades CIU ON (V.Cod_Ciudad_Destino=CIU.Cod_Ciudad)
	WHERE V.Fecha_Salida BETWEEN @fecha_inicio AND @fecha_fin
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
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Aeronaves(@matricula nvarchar(255) = null,@codAeronave int = null,@fabricante nvarchar(255) = NULL, @servicio nvarchar(255) = NULL)
AS
BEGIN
	SELECT A.*
	FROM TODOX2LUCAS.Aeronaves A JOIN TODOX2LUCAS.Fabricantes F ON(A.Cod_Fabricante=F.Cod_Fabricante)
								JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(T.Cod_Tipo_Servicio=A.Cod_Tipo_Servicio)
	WHERE (A.Matricula LIKE '%' + @matricula + '%' OR @matricula IS NULL) AND
			(f.Nombre_Fabricante = @fabricante OR @fabricante IS NULL) AND
			(t.Descripcion_Servicio = @servicio OR @servicio IS NULL) AND 
			(A.Cod_Aeronave = @codAeronave  OR @codAeronave IS NULL) 
END
GO

/* ------------ FILTROS PARA ABM ROL ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Roles(@rol nvarchar(255))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Roles
	WHERE Nombre_Rol LIKE '%' + @rol + '%'
END
GO
/* ------------ FILTROS PARA ABM CIUDADES ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Ciudades(@nombre nvarchar(255))
AS
BEGIN
	SELECT *
	FROM TODOX2LUCAS.Ciudades
	WHERE Nombre_Ciudad LIKE '%' + @nombre + '%'
END
GO
/* ------------ FILTROS PARA ABM RUTAS ------------ */
CREATE PROCEDURE TODOX2LUCAS.Filtrar_Rutas(@codRuta numeric(18) = NULL ,@origen nvarchar(255) = NULL,@destino nvarchar(255) = NULL,@servicio nvarchar(255) = NULL)
AS
BEGIN
	SELECT r.*
	FROM TODOX2LUCAS.RutasAereas R JOIN TODOX2LUCAS.Ciudades C1 ON(C1.Cod_Ciudad = R.Cod_Ciudad_Origen)
									JOIN TODOX2LUCAS.Ciudades C2 ON (C2.Cod_Ciudad = R.Cod_Ciudad_Destino)
									JOIN TODOX2LUCAS.Tipos_De_Servicios T ON(R.Cod_Tipo_Servicio =T.Cod_Tipo_Servicio)
	WHERE (R.Cod_Ruta = @codRuta OR @codRuta IS NULL )AND 
			(t.Descripcion_Servicio = @servicio OR @servicio IS NULL) AND 
			(C1.Nombre_Ciudad = @origen OR @origen IS NULL)AND 
			(C2.Nombre_Ciudad = @destino OR @destino IS NULL)
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

CREATE TRIGGER TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones_Paquetes
ON TODOX2LUCAS.CancelacionesPaquetes
AFTER INSERT
AS
BEGIN
	DECLARE @codDevolucion int,@codEncomiendas numeric(18);
	DECLARE cursor_cancelar CURSOR FOR	
	SELECT I.Codigo_Devolucion,I.Cod_Encomiendas
	FROM inserted I
	
	OPEN cursor_cancelar
	FETCH NEXT FROM cursor_cancelar INTO @codDevolucion,@codEncomiendas
	WHILE @@FETCH_STATUS = 0
	BEGIN
			DECLARE @millasEncomienda int,@Nro_Dni_Encomienda numeric(18),@apellido_Encomienda nvarchar(255),@precio_Encomienda numeric(18,2);
			
			SELECT @Nro_Dni_Encomienda = Nro_Dni,@apellido_Encomienda=Cliente_Apellido,@precio_Encomienda = Precio_Encomienda
			FROM TODOX2LUCAS.Encomiendas
			WHERE Cod_Encomiendas = @codEncomiendas

			SET @millasEncomienda = FLOOR((@precio_Encomienda/10));
			
			UPDATE TODOX2LUCAS.Clientes
			SET	Cant_Millas = Cant_Millas - @millasEncomienda
			WHERE Nro_Dni = @Nro_Dni_Encomienda AND Cliente_Apellido = @apellido_Encomienda
	
			FETCH NEXT FROM cursor_cancelar INTO @codDevolucion,@codEncomiendas
	END
	CLOSE cursor_cancelar
	DEALLOCATE cursor_cancelar

END
GO

CREATE TRIGGER TODOX2LUCAS.Restar_Millas_Ante_Cancelaciones_Pasajes
ON TODOX2LUCAS.CancelacionesPasajes
AFTER INSERT
AS
BEGIN
	DECLARE @codDevolucion int, @codPasaje numeric(18);
	DECLARE cursor_cancelar CURSOR FOR	
	SELECT I.Codigo_Devolucion,I.Cod_Pasaje
	FROM inserted I
	
	OPEN cursor_cancelar
	FETCH NEXT FROM cursor_cancelar INTO @codDevolucion,@codPasaje
	WHILE @@FETCH_STATUS = 0
	BEGIN
			DECLARE @millasPasaje int,@Nro_Dni_Pasaje numeric(18),@apellido_Pasaje nvarchar(255),@precio_Pasaje numeric(18,2);
			SELECT @Nro_Dni_Pasaje = Nro_Dni , @apellido_Pasaje = Cliente_Apellido , @precio_Pasaje = Pasaje_Precio
			FROM TODOX2LUCAS.Pasajes
			WHERE Cod_Pasaje = @codPasaje

			SET @millasPasaje = FLOOR((@precio_Pasaje/10));
			
			UPDATE TODOX2LUCAS.Clientes
			SET	Cant_Millas = Cant_Millas - @millasPasaje
			WHERE Nro_Dni = @Nro_Dni_Pasaje AND Cliente_Apellido = @apellido_Pasaje			

			FETCH NEXT FROM cursor_cancelar INTO @codDevolucion,@codPasaje
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
INSERT INTO TODOX2LUCAS.Productos(Descripcion_Producto,PrecioEnMillas,Cantidad)
VALUES('Licuadora',1500,60)
INSERT INTO TODOX2LUCAS.Productos(Descripcion_Producto,PrecioEnMillas,Cantidad)
VALUES('TV Led HD',10000,10)
INSERT INTO TODOX2LUCAS.Productos(Descripcion_Producto,PrecioEnMillas,Cantidad)
VALUES('Cafetera',2000,50)
INSERT INTO TODOX2LUCAS.Productos(Descripcion_Producto,PrecioEnMillas,Cantidad)
VALUES('Tablet',5000,100)
GO

--DATOS INICIALES PARA LA TABLA DE ROLES--

EXEC TODOX2LUCAS.Agregar_Rol 'Cliente'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador General'

GO
--DATOS INICIALES PARA LA TABLA USUARIOS--
/* ------------ SET DE USUSARIOS PARA EL TP (EL ABM DE USUARIO NO SE DEBE IMPLEMENTAR) ------------ */
DECLARE @clave nvarchar(255);
SET @clave = 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7';
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

EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Primera Clase' , 1.7
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Ejecutivo', 1.5
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Turista', 1.1

GO
--MIGRACION TABLA MODELOS--
INSERT INTO TODOX2LUCAS.Modelo_Aeronave(Descricpion_Modelo)
SELECT DISTINCT Aeronave_Modelo
FROM gd_esquema.Maestra
GO
--MIGRACION TABLA AERONAVES--
EXEC TODOX2LUCAS.Migrar_Aeronaves

GO

--MIGRACION TABLA BUTACAS--
INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca,Estado_Butaca)
SELECT DISTINCT A.Cod_Aeronave,Butaca_Nro,Butaca_Tipo, Butaca_Piso,1
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Aeronaves A ON (A.Matricula = M.Aeronave_Matricula)
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

--MIGRACION TABLA ENCOMIENDAS--
SET IDENTITY_INSERT TODOX2LUCAS.Encomiendas ON
INSERT INTO TODOX2LUCAS.Encomiendas(Cod_Encomiendas,Precio_Encomienda,Kgs_A_Enviar,Fecha_Compra,Cod_Viaje,Nro_Dni,Cliente_Apellido)
SELECT DISTINCT M.Paquete_Codigo,M.Paquete_Precio,M.Paquete_KG,M.Paquete_FechaCompra,v.Cod_Viaje,C.Nro_Dni,c.Cliente_Apellido
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Clientes C ON(C.Nro_Dni = M.Cli_Dni AND c.Cliente_Apellido=m.Cli_Apellido)
							JOIN TODOX2LUCAS.Ciudades co ON (co.Nombre_Ciudad=m.Ruta_Ciudad_Origen)
							JOIN TODOX2LUCAS.Ciudades cd ON (cd.Nombre_Ciudad=Ruta_Ciudad_Destino)
							JOIN TODOX2LUCAS.RutasAereas r ON (co.Cod_Ciudad=r.Cod_Ciudad_Origen AND cd.Cod_Ciudad=r.Cod_Ciudad_Destino)
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula=a.Matricula)
							JOIN TODOX2LUCAS.Viajes v ON(v.Cod_Ruta =r.Cod_Ruta AND v.Cod_Aeronave=a.Cod_Aeronave AND v.Fecha_Salida=m.FechaSalida  AND v.Fecha_Llegada_Estimada=m.Fecha_LLegada_Estimada)
							
WHERE M.Paquete_Codigo != 0
SET IDENTITY_INSERT TODOX2LUCAS.Encomiendas OFF
GO 
--MIGRACION TABLA PASAJES--
SET IDENTITY_INSERT TODOX2LUCAS.Pasajes ON
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
SET IDENTITY_INSERT TODOX2LUCAS.Pasajes OFF
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



select * from TODOX2LUCAS.Clientes

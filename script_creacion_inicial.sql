/************************************************** PROCEDIMIENTOS Y TRIGGERS ***************************************************/
--PROCEDIMIENTO PARA AGREGAR FUNCIONALIDADES--
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
--PROCEDIMIENTO PARA AGREGAR ROLES--
CREATE PROCEDURE TODOX2LUCAS.Agregar_Rol(@rol nvarchar(255))
AS
BEGIN
	INSERT INTO TODOX2LUCAS.Roles(Nombre_Rol,Estado_Rol)
	VALUES (@rol,1)
END
;
GO
--PROCEDIMIENTO QUE AGREGA LAS FUNCIONALIDADES A UN ROL DETERMINADO --
CREATE PROCEDURE TODOX2LUCAS.Agregar_Rol_Por_Funcionalidad(@rol nvarchar(255),@funcionalidad nvarchar(255))
AS
BEGIN
	DECLARE @codRol int,@codFuncionalidad int;
	SET @codFuncionalidad = (SELECT Cod_Funcionalidad FROM TODOX2LUCAS.Funcionalidades WHERE Nombre_Funcionalidad = @funcionalidad)
	SET @codRol = (SELECT Cod_Rol FROM TODOX2LUCAS.Roles WHERE Nombre_Rol = @rol)
	INSERT INTO TODOX2LUCAS.Rol_Por_Funcionalidad(Cod_Rol,Cod_Funcionalidad)
	VALUES (@codRol,@codFuncionalidad)
END
;
GO
--PROCEDIMIENTO PARA AGREGAR LOS TIPOS DE SERVICIOS --
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
--PROCEDIMIENTO QUE MIGRA LOS DATOS DE LA TABLA MAESTRA A LA TABLA DE AERONAVES CON CURSOR--
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
--PROCEDIMIENTO QUE MIGRA LOS DATOS DE LA TABLA MAESTRA A LA TABLA DE RUTAS AEREAS CON CURSOR--
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
	Descripcion_Producto nvarchar(255)
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
	Cod_Rol int REFERENCES TODOX2LUCAS.Roles (Cod_Rol)
)
;
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
	Kgs_Disponibles numeric(18),
	
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
	Cantidad int,
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
--	Numero_Compra int,
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
	Codigo_Devolucion int,
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
/***************************************  TRIGGERS ***********************************************/
-- TRIGGER QUE ACTUALIZA EL ATRIBUTO DE LA TABLA CLIENTES(CANT_MILLAS) ANTE UN INSERT EN LA TABLA DE PASAJES--
go
CREATE TRIGGER Sumar_Millas
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

/***************************************  MIGRACIONES DE DATOS ***********************************************/

--MIGRACINON TABLA CIUDADES--
INSERT INTO TODOX2LUCAS.Ciudades(Nombre_Ciudad,Estado_Ciudad)
SELECT DISTINCT Ruta_Ciudad_Destino, 1
FROM gd_esquema.Maestra
UNION
SELECT DISTINCT Ruta_Ciudad_Origen, 1
FROM gd_esquema.Maestra
;

--MIGRACION TABLA FABRICANTES--
INSERT INTO TODOX2LUCAS.Fabricantes(Nombre_Fabricante)
SELECT DISTINCT Aeronave_Fabricante FROM gd_esquema.Maestra
;

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

--DATOS INICIALES PARA LA TABLA DE PRODUCTOS--



--DATOS INICIALES PARA LA TABLA DE ROLES--

EXEC TODOX2LUCAS.Agregar_Rol 'Cliente'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador General'


--DATOS INICIALES PARA LA TABLA USUARIOS--
DECLARE @clave nvarchar(255);
SET @clave = HASHBYTES('SHA2_256','w23e');
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol)
SELECT DISTINCT CONVERT(nvarchar(255),Cli_Dni) + Cli_Apellido, @clave, 1
FROM gd_esquema.Maestra



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

--MIGRACION CLIENTES--
INSERT INTO TODOX2LUCAS.Clientes(Nro_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Direccion, Cliente_Telefono, Cliente_Mail, Cliente_Fecha_Nacimiento, Cant_Millas, Usuario_Nombre)
SELECT DISTINCT Cli_Dni, Cli_Nombre, Cli_Apellido, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, 0 , CONVERT(nvarchar(255),Cli_Dni) + Cli_Apellido
FROM gd_esquema.Maestra  


--DATOS INICIALES TABLA TARJETAS--




--MIGRACION TABLA TIPOS DE SERVICIOS--

EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Primera Clase' , 2000
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Ejecutivo', 1000
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Turista', 500


--MIGRACION TABLA AERONAVES--
EXEC TODOX2LUCAS.Migrar_Aeronaves


--MIGRACION TABLA ESTADOS AERONAVES--

--esta tabla no necesita de migracion tendra que ir actualizandose a medida que en la aplicacion lo utilicen

--MIGRACION TABLA BUTACAS--
INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca)
SELECT DISTINCT A.Cod_Aeronave,Butaca_Nro,Butaca_Tipo, Butaca_Piso,1
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Aeronaves A ON (A.Matricula = M.Aeronave_Matricula)
WHERE Butaca_Piso!=0 AND Butaca_Tipo !='0'
ORDER BY A.Cod_Aeronave,Butaca_Nro


--MIGRACION TABLA RUTASAEREAS--
EXEC TODOX2LUCAS.Migrar_Rutas_Aereas


--MIGRACION TABLA VIAJES

INSERT INTO TODOX2LUCAS.Viajes(Cod_Ruta,Cod_Ciudad_Origen,Cod_Ciudad_Destino,Cod_Aeronave,Fecha_Salida,Fecha_Llegada,Fecha_Llegada_Estimada)
SELECT DISTINCT r.Cod_Ruta,c1.Cod_Ciudad,c2.Cod_Ciudad,a.Cod_Aeronave,m.FechaSalida,m.FechaLLegada,m.Fecha_LLegada_Estimada
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Ciudades c1 ON(m.Ruta_Ciudad_Origen=c1.Nombre_Ciudad)
							JOIN TODOX2LUCAS.Ciudades c2 ON(m.Ruta_Ciudad_Destino=c2.Nombre_Ciudad)
							JOIN TODOX2LUCAS.RutasAereas r ON (c1.Cod_Ciudad = r.Cod_Ciudad_Origen AND c2.Cod_Ciudad=r.Cod_Ciudad_Destino) 
							JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula = a.Matricula)


--MIGRACION TABLA CANJES--

--MIGRACION TABLA ENCOMIENDAS--
--tiene q dar 135.658

INSERT INTO TODOX2LUCAS.Encomiendas(Cod_Encomiendas,Precio_Encomienda,Kgs_A_Enviar,Fecha_Compra,Nro_Dni,Cliente_Apellido)
SELECT DISTINCT M.Paquete_Codigo,M.Paquete_Precio,M.Paquete_KG,M.Paquete_FechaCompra,C.Nro_Dni,c.Cliente_Apellido
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Clientes C ON(C.Nro_Dni = M.Cli_Dni AND c.Cliente_Apellido=m.Cli_Apellido)
WHERE M.Paquete_Codigo != 0


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




--MIGRACION TABLA TRANSACCIONES PASAJES--
INSERT INTO TODOX2LUCAS.TransaccionesPasajes(Cod_Pasaje,Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
SELECT DISTINCT p.Cod_Pasaje,m.Pasaje_FechaCompra,c.Nro_Dni,c.Cliente_Apellido,'Efectivo'
FROM TODOX2LUCAS.Pasajes p JOIN TODOX2LUCAS.Clientes c ON (p.Nro_Dni=c.Nro_Dni AND p.Cliente_Apellido=c.Cliente_Apellido)
							JOIN gd_esquema.Maestra m ON (m.Pasaje_Codigo=p.Cod_Pasaje)
							

--MIGRACION TABLA TRANSACCIONES PAQUETES--
INSERT INTO TODOX2LUCAS.TransaccionesPaquetes(Cod_Encomiendas,Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
SELECT DISTINCT e.Cod_Encomiendas,m.Paquete_FechaCompra,c.Nro_Dni,c.Cliente_Apellido,'Efectivo'
FROM TODOX2LUCAS.Encomiendas e JOIN TODOX2LUCAS.Clientes c ON (e.Nro_Dni=c.Nro_Dni AND e.Cliente_Apellido=c.Cliente_Apellido)
							JOIN gd_esquema.Maestra m ON (m.Paquete_Codigo=e.Cod_Encomiendas)


--MIGRACION TABLA CANCELACIONES--

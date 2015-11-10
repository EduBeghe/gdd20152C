--CREACION TABLA CIUDADES--
CREATE TABLE TODOX2LUCAS.Ciudades ( 
	Cod_Ciudad int PRIMARY KEY IDENTITY,
	Nombre_Ciudad nvarchar(255),
	Estado_Ciudad bit
)
;

--MIGRACINON TABLA CIUDADES--
INSERT INTO TODOX2LUCAS.Ciudades(Nombre_Ciudad,Estado_Ciudad)
SELECT DISTINCT Ruta_Ciudad_Destino, 1
FROM gd_esquema.Maestra
UNION
SELECT DISTINCT Ruta_Ciudad_Origen, 1
FROM gd_esquema.Maestra
;


--CREACION TABLA FABRICANTES--
CREATE TABLE TODOX2LUCAS.Fabricantes ( 
	Cod_Fabricante int PRIMARY KEY IDENTITY,
	Nombre_Fabricante nvarchar(255)
)
;
--MIGRACION TABLA FABRICANTES--
INSERT INTO TODOX2LUCAS.Fabricantes(Nombre_Fabricante)
SELECT DISTINCT Aeronave_Fabricante FROM gd_esquema.Maestra
;


--CREACION TABLA FUNCIONALIDADES--
CREATE TABLE TODOX2LUCAS.Funcionalidades ( 
	Cod_Funcionalidad int PRIMARY KEY IDENTITY,
	Nombre_Funcionalidad nvarchar(255)
)
;

--DATOS INICIALES PARA LA TABLA FUNCIONALIDADES--
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
	END
END
;

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

--CREACION TABLA PRODUCTOS--
CREATE TABLE TODOX2LUCAS.Productos ( 
	Cod_Producto int PRIMARY KEY CLUSTERED,
	Descripcion_Producto nvarchar(255)
)
;
--DATOS INICIALES PARA LA TABLA DE PRODUCTOS--


--CREACION TABLA ROLES--
CREATE TABLE TODOX2LUCAS.Roles ( 
	Cod_Rol int PRIMARY KEY CLUSTERED IDENTITY,
	Nombre_Rol nvarchar(255),
	Estado_Rol bit
)
;
--DATOS INICIALES PARA LA TABLA DE ROLES--

CREATE PROCEDURE TODOX2LUCAS.Agregar_Rol(@rol nvarchar(255))
AS
BEGIN
	INSERT INTO TODOX2LUCAS.Roles(Nombre_Rol,Estado_Rol)
	VALUES (@rol,1)
END
;

EXEC TODOX2LUCAS.Agregar_Rol 'Cliente'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador'
EXEC TODOX2LUCAS.Agregar_Rol 'Administrador General'


--CREACION TABLA USUARIOS--
CREATE TABLE TODOX2LUCAS.Usuarios ( 
	Usuario_Nombre nvarchar(255) PRIMARY KEY CLUSTERED,
	Contraseña nvarchar(255) NOT NULL,
	Cod_Rol int REFERENCES TODOX2LUCAS.Roles (Cod_Rol)
)
;
--DATOS INICIALES PARA LA TABLA USUARIOS--
INSERT INTO TODOX2LUCAS.Usuarios(Usuario_Nombre,Contraseña,Cod_Rol)
SELECT DISTINCT CONVERT(nvarchar(255),Cli_Dni) + Cli_Apellido, HASHBYTES('SHA2_256','w23e'), 1
FROM gd_esquema.Maestra


--CREACION TABLA ROL POR FUNCIONALIDAD--
CREATE TABLE TODOX2LUCAS.Rol_Por_Funcionalidad ( 
	Cod_Rol int REFERENCES TODOX2LUCAS.Roles (Cod_Rol),
	Cod_Funcionalidad int REFERENCES TODOX2LUCAS.Funcionalidades (Cod_Funcionalidad),
	PRIMARY KEY CLUSTERED (Cod_Rol, Cod_Funcionalidad)
)
;

--DATOS INICIALES PARA LA TABLA ROL POR FUNCIONALIDAD--
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


--CREACION TABLA CLIENTES
CREATE TABLE TODOX2LUCAS.Clientes ( 
	Nro_Dni numeric(18) ,
	Cliente_Nombre nvarchar(255),
	Cliente_Apellido nvarchar(255),
	Cliente_Direccion nvarchar(255),
	Cliente_Telefono numeric(18),
	Cliente_Mail nvarchar(255),
	Cliente_Fecha_Nacimiento datetime,
	Cant_Millas smallint,
	Usuario_Nombre nvarchar(255) REFERENCES TODOX2LUCAS.Usuarios (Usuario_Nombre),
	PRIMARY KEY CLUSTERED(Nro_Dni,Cliente_Apellido)
)
;

--MIGRACION CLIENTES--
INSERT INTO TODOX2LUCAS.Clientes(Nro_Dni, Cliente_Nombre, Cliente_Apellido, Cliente_Direccion, Cliente_Telefono, Cliente_Mail, Cliente_Fecha_Nacimiento, Cant_Millas, Usuario_Nombre)
SELECT DISTINCT Cli_Dni, Cli_Nombre, Cli_Apellido, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, 0 , CONVERT(nvarchar(255),Cli_Dni) + Cli_Apellido
FROM gd_esquema.Maestra  

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

--DATOS INICIALES TABLA TARJETAS--



--CREACION TABLA TIPOS DE SERVICIOS--
CREATE TABLE TODOX2LUCAS.Tipos_De_Servicios ( 
	Cod_Tipo_Servicio int PRIMARY KEY IDENTITY,
	Descripcion_Servicio nvarchar(255),
	Precio_Servicio int
)
;

--MIGRACION TABLA TIPOS DE SERVICIOS--
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
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Primera Clase' , 2000
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Ejecutivo', 1000
EXEC TODOX2LUCAS.Agregar_Tipo_De_Servicio 'Turista', 500

--CREACION TABLA TRANSACCIONES--
CREATE TABLE TODOX2LUCAS.Transacciones ( 
	Numero_Compra int PRIMARY KEY IDENTITY,
	Fecha_Transaccion datetime,
	Nro_Dni numeric(18),
	Cliente_Apellido nvarchar(255),
	Forma_De_Pago nvarchar(250),
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;

--MIGRACION TABLA TANSACCIONES--
INSERT INTO TODOX2LUCAS.Transacciones(Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
SELECT DISTINCT GETDATE(),c.Nro_Dni,c.Cliente_Apellido,'Efectivo',Pasaje_Codigo
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Clientes c ON (m.Cli_Dni=c.Nro_Dni)
WHERE  Pasaje_Codigo != 0 
UNION
INSERT INTO TODOX2LUCAS.Transacciones(Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
SELECT DISTINCT GETDATE(),c.Nro_Dni,c.Cliente_Apellido,'Efectivo',Paquete_Codigo
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Clientes c ON (m.Cli_Dni=c.Nro_Dni)
WHERE Paquete_Codigo != 0 




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
--MIGRACION TABLA AERONAVES--
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

EXEC TODOX2LUCAS.Migrar_Aeronaves

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

--MIGRACION TABLA ESTADOS AERONAVES--

--esta tabla no necesita de migracion tendra que ir actualizandose a medida que en la aplicacion lo utilicen

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
--MIGRACION TABLA BUTACAS--
INSERT INTO TODOX2LUCAS.Butacas(Cod_Aeronave,Cod_Butaca,Pos_Butaca,Piso_Butaca)
SELECT DISTINCT A.Cod_Aeronave,Butaca_Nro,Butaca_Tipo, Butaca_Piso
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Aeronaves A ON (A.Matricula = M.Aeronave_Matricula)
WHERE Butaca_Piso!=0 AND Butaca_Tipo !='0'
ORDER BY A.Cod_Aeronave,Butaca_Nro

--CREACION TABLA RUTASAEREAS--
CREATE TABLE TODOX2LUCAS.RutasAereas ( 
	Cod_Ruta numeric(18) IDENTITY(65805158,1) PRIMARY KEY CLUSTERED,
	Cod_Ciudad_Origen int REFERENCES TODOX2LUCAS.Ciudades (Cod_Ciudad),
	Cod_Ciudad_Destino int REFERENCES TODOX2LUCAS.Ciudades (Cod_Ciudad),
	Cod_Tipo_Servicio int REFERENCES TODOX2LUCAS.Tipos_De_Servicios (Cod_Tipo_Servicio),
	Precio_Base_Pasaje numeric(18,2),
	Precio_Base_Kg numeric(18,2),
	Estado_Ruta bit
)
;

--MIGRACION TABLA RUTASAEREAS--
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
EXEC TODOX2LUCAS.Migrar_Rutas_Aereas


--CREACION TABLA VIAJES-- 
CREATE TABLE TODOX2LUCAS.Viajes ( 
	Cod_Viaje int PRIMARY KEY IDENTITY,
	Cod_Ruta numeric(18) REFERENCES TODOX2LUCAS.RutasAereas (Cod_Ruta),
	Cod_Aeronave int REFERENCES TODOX2LUCAS.Aeronaves (Cod_Aeronave),
	Fecha_Salida datetime,
	Fecha_Llegada datetime,
	Fecha_Llegada_Estimada datetime,
	Aeropuerto_Salida nvarchar(255),
	Aeropuerto_Llegada nvarchar(255)
)
;
--MIGRACION TABLA VIAJES

INSERT INTO TODOX2LUCAS.Viajes(Cod_Ruta,Cod_Aeronave,Fecha_Salida,Fecha_Llegada,Fecha_Llegada_Estimada)
SELECT DISTINCT r.Cod_Ruta,a.Cod_Aeronave,m.FechaSalida,m.FechaLLegada,m.Fecha_LLegada_Estimada
FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.RutasAereas r ON (m.Ruta_Codigo= r.Cod_Ruta) 
								JOIN TODOX2LUCAS.Aeronaves a ON (m.Aeronave_Matricula = a.Matricula)

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
--MIGRACION TABLA CANJES--

--CREACION TABLA ENCOMIENDAS--
CREATE TABLE TODOX2LUCAS.Encomiendas ( 
	Cod_Encomiendas numeric(18) PRIMARY KEY CLUSTERED,
	Precio_Encomienda numeric(18,2),
	Kgs_A_Enviar numeric(18),
	Fecha_Compra datetime,
	Numero_Compra int,
	Nro_Dni numeric(18) ,
	Cliente_Apellido nvarchar(255) ,
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;

--MIGRACION TABLA ENCOMIENDAS--
INSERT INTO TODOX2LUCAS.Encomiendas(Cod_Encomiendas,Precio_Encomienda,Kgs_A_Enviar,Fecha_Compra,Nro_Dni,Cliente_Apellido)
SELECT DISTINCT Paquete_Codigo,Paquete_Precio,Paquete_KG,Paquete_FechaCompra,C.Nro_Dni,c.Cliente_Apellido
FROM gd_esquema.Maestra M JOIN TODOX2LUCAS.Clientes C ON(C.Nro_Dni = M.Cli_Dni)
							JOIN TODOX2LUCAS.Transacciones t ()
WHERE Paquete_Codigo != 0

SELECT * FROM TODOX2LUCAS.Encomiendas
--CREACION TABLA PASAJES--
CREATE TABLE TODOX2LUCAS.Pasajes ( 
	Cod_Pasaje numeric(18) PRIMARY KEY CLUSTERED,
	Fecha_Viaje datetime,
	Cod_Viaje int REFERENCES TODOX2LUCAS.Viajes (Cod_Viaje),
	Butaca_Asociada int,
	Numero_Compra int REFERENCES TODOX2LUCAS.Transacciones (Numero_Compra),
	Nro_Dni numeric(18) ,
	Pasaje_Precio numeric(18,2),
	Cliente_Apellido nvarchar(255),
	FOREIGN KEY (Nro_Dni,Cliente_Apellido) REFERENCES TODOX2LUCAS.Clientes (Nro_Dni,Cliente_Apellido)
)
;
--MIGRACION TABLA PASAJES--
drop procedure TODOX2LUCAS.Migrar_Pasajes
CREATE PROCEDURE TODOX2LUCAS.Migrar_Pasajes
AS
BEGIN
	DECLARE @codPasaje numeric(18),@fecha datetime,@codViaje int,
			@butaca int,@dni numeric(18),@precio numeric(18,2),@codRuta numeric(18),@apellido nvarchar(255),
			@codAeronave int, @fechaSalida datetime,@fechaLlegada datetime, @numeroCompra int;
	
	DECLARE pasaje_cursor CURSOR FOR 
	SELECT Pasaje_Codigo,Pasaje_FechaCompra,Pasaje_Precio,Nro_Dni,Ruta_Codigo,Butaca_Nro,Cli_Apellido,FechaSalida,FechaLLegada
	FROM gd_esquema.Maestra m JOIN TODOX2LUCAS.Clientes c ON(m.Cli_Dni =c.Nro_Dni)
	WHERE Pasaje_Codigo !=0
	
	OPEN pasaje_cursor
	FETCH NEXT FROM pasaje_cursor INTO @codPasaje,@fecha,@precio,@dni,@codRuta,@butaca,@apellido,@fechaSalida,@fechaLlegada
	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		SET @codViaje = (SELECT Cod_Viaje FROM TODOX2LUCAS.Viajes v 
										WHERE Cod_Ruta =@codRuta  AND v.Fecha_Salida =@fechaSalida AND v.Fecha_Llegada = @fechaLlegada);
		
		INSERT INTO TODOX2LUCAS.Transacciones(Fecha_Transaccion,Nro_Dni,Cliente_Apellido,Forma_De_Pago)
		VALUES (GETDATE(),@dni,@apellido,'Efectivo')

		SET @numeroCompra = (SELECT DISTINCT @@IDENTITY FROM TODOX2LUCAS.Transacciones );

		INSERT INTO TODOX2LUCAS.Pasajes(Cod_Pasaje,Fecha_Viaje,Cod_Viaje,Butaca_Asociada,Numero_Compra,Nro_Dni,Pasaje_Precio,Cliente_Apellido)
		VALUES (@codPasaje,@fecha,@codViaje,@butaca,@numeroCompra,@dni,@precio,@apellido)
		
		FETCH NEXT FROM pasaje_cursor INTO @codPasaje,@fecha,@precio,@dni,@codRuta,@butaca,@apellido,@fechaSalida,@fechaLlegada	
	END
	CLOSE pasaje_cursor
	DEALLOCATE pasaje_cursor
END	
; 

EXEC TODOX2LUCAS.Migrar_Pasajes;
SELECT * FROM TODOX2LUCAS.Pasajes
SELECT * FROM TODOX2LUCAS.Transacciones
delete from TODOX2LUCAS.Pasajes
DELETE FROM TODOX2LUCAS.Transacciones

CREATE TRIGGER Sumar_Millas
ON TODOX2LUCAS.Pasajes 
AFTER INSERT
AS
BEGIN
	DECLARE @pasaje numeric(18),@millas smallint,@precio numeric(18,2);
	SELECT  @pasaje =  Cod_Pasaje, @precio = PasajePrecio
	FROM inserted i 
	
	SET @millas = @millas + (@precio/10)

	INSERT INTO TODOX2LUCAS.Clientes(Cant_Millas)
	VALUES(@millas)
END

--CREACION TABLA CANCELACIONES-- 
CREATE TABLE TODOX2LUCAS.Cancelaciones ( 
	Codigo_Devolucion int,
	Fecha_Devolucion datetime,
	Numero_Compra int REFERENCES TODOX2LUCAS.Transacciones (Numero_Compra),
	Cod_Pasaje numeric(18) NOT NULL REFERENCES TODOX2LUCAS.Pasajes (Cod_Pasaje),
	Motivo nvarchar(255),
	Cod_Encomiendas numeric(18) NOT NULL REFERENCES TODOX2LUCAS.Encomiendas (Cod_Encomiendas),
	PRIMARY KEY CLUSTERED (Codigo_Devolucion, Cod_Pasaje, Cod_Encomiendas)
)
;
--MIGRACION TABLA CANCELACIONES--

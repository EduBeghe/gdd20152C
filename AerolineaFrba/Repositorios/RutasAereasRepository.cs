using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class RutaAereaRepository {

		public void darDeAlta(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Alta_Ruta_Aerea", 
			rutaAerea.origen.idCiudad,
			rutaAerea.destino.idCiudad,
			rutaAerea.servicio.idTipoServicio,
			rutaAerea.precioXKg,
			rutaAerea.precioXPasaje
			);
		}

		// Ingresa una ruta aerea ? 
		public void modificarCiudaes(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Ciudades_Ruta_Aereas", 
			rutaAerea.idRutaAerea,
			rutaAerea.origen.idCiudad,
			rutaAerea.destino.idCiudad
			);				
		}

		public void modificarTipoServicio(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Servicio_Ruta_Aerea", 
			rutaAerea.idRutaAerea,
			rutaAerea.servicio.idTipoServicio
			);				
		}

		public void modificarPrecio(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Precios_Ruta_Aerea", 
			rutaAerea.idRutaAerea,
			rutaAerea.precioXKg,
			rutaAerea.precioXPasaje
			);				
		}

		// El motivo no lo tengo en ningun lado asi que deberia ingresar como param.
		public void darDeBaja(  RutaAerea rutaAerea )
		{
			Adapter.executeProcedure("Baja_Ruta_Aerea", 
			rutaAerea.origen.idCiudad,
			rutaAerea.destino.idCiudad,
			rutaAerea.servicio.idTipoServicio,
			rutaAerea.precioXKg,
			rutaAerea.precioXPasaje
			// motivo?
			);				
		}

	}
}
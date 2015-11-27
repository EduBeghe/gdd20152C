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
			rutaAerea.origen.Cod_Ciudad,
			rutaAerea.destino.Cod_Ciudad,
			rutaAerea.servicio.Cod_Tipo_Servicio,
			rutaAerea.Precio_Base_Kg,
			rutaAerea.Precio_Base_Pasaje
			);
		}

		// Ingresa una ruta aerea ? 
		public void modificarCiudaes(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Ciudades_Ruta_Aereas", 
			rutaAerea.Cod_Ruta,
			rutaAerea.origen.Cod_Ciudad,
			rutaAerea.destino.Cod_Ciudad
			);				
		}

		public void modificarTipoServicio(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Servicio_Ruta_Aerea", 
			rutaAerea.Cod_Ruta,
			rutaAerea.servicio.Cod_Tipo_Servicio
			);				
		}

		public void modificarPrecio(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Precios_Ruta_Aerea", 
			rutaAerea.Cod_Ruta,
			rutaAerea.Precio_Base_Kg,
			rutaAerea.Precio_Base_Pasaje
			);				
		}

		// El motivo no lo tengo en ningun lado asi que deberia ingresar como param.
		public void darDeBaja(  RutaAerea rutaAerea )
		{
			Adapter.executeProcedure("Baja_Ruta_Aerea", 
			rutaAerea.origen.Cod_Ciudad,
			rutaAerea.destino.Cod_Ciudad,
			rutaAerea.servicio.Cod_Tipo_Servicio,
			rutaAerea.Precio_Base_Kg,
			rutaAerea.Precio_Base_Pasaje
			// motivo? ( entra por la form ? )
			);				
		}

	}
}
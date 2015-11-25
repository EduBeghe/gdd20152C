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
			rutaAerea.origen,
			rutaAerea.destino,
			rutaAerea.servicio,
			rutaAerea.precioXKg,
			rutaAerea.precioXPasaje,
			);
		}

		public void modificar(  RutaAerea rutaAerea )
		{
			//DBAdapter.executeProcedure("XXXXX", cliente.idCliente);				
		}

		public void darDeBaja(  RutaAerea rutaAerea )
		{
			//Adapter.executeProcedure("XXXX", cliente.idCliente);				
		}

	}
}
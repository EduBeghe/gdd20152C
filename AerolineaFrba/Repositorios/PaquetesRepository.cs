using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Domain;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Repositories {

	class EncomiendasRepository {

		public void cancelarPaquete(  Encomienda encomienda )
		{
			DBAdapter.executeProcedure("Cancelar_Paquetes",
				//Fecha actual,
				encomienda.viaje.aeronave.Cod_Aeronave,
				encomienda.viaje.rutaAerea.Cod_Ruta
				// motivo ( sale de la form ?)
			);
		}

	}
}
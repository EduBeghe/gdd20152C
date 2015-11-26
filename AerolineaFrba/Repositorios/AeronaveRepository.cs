using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class AeronaveRepository {

		public void darDeBajaXVidaUtil( Aeronave aeronave ) 
		{
			Adapter.executeProcedure("Baja_Por_Vida_Util", 
			aeronave.idAeronave,
			// @cancelaciones bit
			);
		}

		public void darDeBajaXProblemasTecnicos( Aeronave aeronave )
		{
			//Adapter.executeProcedure("XXXX", 
			//aeronave.idAeronave
			//);	
		}

		public void darDeAlta( Aeronave aeronave )
		{
			Adapter.executeProcedure("Alta_Aeronave", 
			aeronave.matricula,
			aeronave.fechaDeAlta,
			aeronave.fabricante,
			aeronave.modelo,
			aeronave.servicio.idTipoServicio, // ( no esta en la clase MIRAR! )
			aeronave.capacidadEncomiendas 
			);
		}



	}
}
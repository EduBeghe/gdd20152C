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
			aeronave.Cod_Aeronave,
			// @cancelaciones bit
			);
		}

		public void darDeBajaXProblemasTecnicos( Aeronave aeronave, DateTime fechaReinicio )
		{
			Adapter.executeProcedure("Baja_Por_Fuera_De_Servicio", 
			aeronave.Cod_Aeronave,
			// @cancelaciones bit 
			fechaReinicio
			);	
		}

		public void darDeAlta( Aeronave aeronave )
		{
			Adapter.executeProcedure("Alta_Aeronave", 
			aeronave.Matricula,
			aeronave.Fecha_Alta,
			aeronave.fabricante,
			aeronave.Modelo,
			aeronave.Servicio,
			aeronave.Kgs_Disponibles	
			);
		}

		public List<Aeronave> parseAeronaves ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Aeronave parse(DataRow dr)
        {
       		return new Aeronave( 
       			Convert.ToInt32(dr["Cod_Aeronave"]),
       			Convert.ToInt32(dr["Matricula"]),
       			Convert.ToDateTime(dr["Fecha_Alta"]),
       			new FabricantesRepository().getFabricante( Convert.ToInt32(dr["Cod_Fabricante"]) ),
       			dr["Modelo"] as string,
       			new TipoServicioRepository().getTipoServicio( Convert.ToInt32(["Cod_Tipo_Servicio"])),
       			Convert.ToInt32(dr["Kgs_Disponibles"]),
       			Convert.ToInt32(dr["Cantidad_Butacas"])
			);
        }



	}
}
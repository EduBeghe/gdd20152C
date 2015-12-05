using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Domain;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Repositories {

	class AeronaveRepository {

		public void darDeBajaXVidaUtil( Aeronave aeronave ) 
		{
			DBAdapter.executeProcedure("Baja_Por_Vida_Util", 
			aeronave.Cod_Aeronave
			// @cancelaciones bit
			);
		}

		public void darDeBajaXProblemasTecnicos( Aeronave aeronave, DateTime fechaReinicio )
		{
			DBAdapter.executeProcedure("Baja_Por_Fuera_De_Servicio", 
			aeronave.Cod_Aeronave,
			// @cancelaciones bit 
			fechaReinicio
			// fecha actual ?
			);	
		}

		public Aeronave getAeronave( int idAeronave )
		{
			return parse ( DBAdapter.retrieveDataTable("GetAeronave", idAeronave ).Rows[0]);
		}

		public List<Aeronave> findAeronave( string matricula, int codigo, Fabricante fabricante, TipoServicio servicio  )
		{
			return parseAeronaves( DBAdapter.retrieveDataTable("GetAeronave",
			matricula,
			codigo,
			fabricante.Nombre_Fabricante,
			servicio.Descripcion_Servicio
			);	
		}

		public void darDeAlta( Aeronave aeronave )
		{
			DBAdapter.executeProcedure("Alta_Aeronave", 
			aeronave.Matricula,
			aeronave.Fecha_Alta,
			aeronave.fabricante.Nombre_Fabricante,
			aeronave.Modelo,
			aeronave.servicio.Descripcion_Servicio,
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
       			new TipoServicioRepository().getTipoServicio( Convert.ToInt32(dr["Cod_Tipo_Servicio"])),
       			Convert.ToInt32(dr["Kgs_Disponibles"]),
       			Convert.ToInt32(dr["Cantidad_Butacas"])
			);
        }



	}
}
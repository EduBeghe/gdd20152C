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
			aeronave.Cod_Aeronave,
			false // MODIFICAR, DEBERIA SE ALGO EN LA FORM
			);
		}

		public void darDeBajaXProblemasTecnicos( Aeronave aeronave, Boolean cancelaciones , DateTime fechaReinicio )
		{
			DBAdapter.executeProcedure("Baja_Por_Fuera_De_Servicio", 
			aeronave.Cod_Aeronave,
			cancelaciones,
			fechaReinicio
			);	
		}

		public Aeronave getAeronave( int idAeronave )
		{
			return parse ( DBAdapter.retrieveDataTable("GetAeronave", idAeronave ).Rows[0]);
		}

		public List<Aeronave> findAeronave( string matricula, int? codigo, Fabricante fabricante, TipoServicio servicio  )
		{
			return parseAeronaves( DBAdapter.retrieveDataTable("Filtrar_Aeronaves",
			matricula,
			codigo,
			fabricante.Nombre_Fabricante,
			servicio.Descripcion_Servicio
			));	
		}

		public int darDeAlta(string Matricula, DateTime Fecha_Alta,  Fabricante fabricante, string Modelo, TipoServicio servicio, int Kgs_Disponibles, int butacasPasillo, int butacasVentanilla )
		{
			return DBAdapter.executeProcedureWithReturnValue("Alta_Aeronave", 
			Matricula,
			Fecha_Alta,
			fabricante.Nombre_Fabricante,
			Modelo,
			servicio.Descripcion_Servicio,
			Kgs_Disponibles,
			butacasPasillo,
			butacasVentanilla
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
       			dr["Matricula"] as string,
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
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

		public int darDeBajaXVidaUtil( Aeronave aeronave, Boolean cancelaciones ) 
		{
			var retorno = DBAdapter.executeProcedureWithReturnValue("Baja_Por_Vida_Util", 
			aeronave.Cod_Aeronave,
			cancelaciones
			);
            return retorno;
		}

		public int modificarAeronave( string matricula, int codAeronave, Fabricante fabricante, Modelo modelo, TipoServicio servicio, Boolean rehabilitar, int kgs ) 
		{
			var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Aeronave", 
            matricula,
			codAeronave,
			fabricante.Nombre_Fabricante,
			modelo.Descricpion_Modelo,
			servicio.Descripcion_Servicio,
			rehabilitar,
            kgs
			);
            return retorno;
		}

        public List<Aeronave> getAeronaveByRuta(int codRuta, int origen, int destino)
        {
            return parseAeronaves(DBAdapter.retrieveDataTable("Aeronaves_Segun_Ruta", codRuta, origen, destino));
        }

		public int darDeBajaXProblemasTecnicos( Aeronave aeronave, Boolean cancelaciones , DateTime fechaReinicio )
		{
			var retorno = DBAdapter.executeProcedureWithReturnValue("Baja_Por_Fuera_De_Servicio", 
			aeronave.Cod_Aeronave,
			cancelaciones,
			fechaReinicio
			);
            return retorno;
		}

		public Aeronave getAeronave( int idAeronave )
		{
			return parse ( DBAdapter.retrieveDataTable("GetAeronave", idAeronave ).Rows[0]);

		}

        public List<Aeronave> getAeronaves()
        { 
            return parseAeronaves( DBAdapter.retrieveDataTable( "Get_Aeronaves" ));
        }

		public List<Aeronave> findAeronave( string matricula, int? codigo, Fabricante fabricante, TipoServicio servicio )
		{
			return parseAeronaves( DBAdapter.retrieveDataTable("Filtrar_Aeronaves",
			matricula,
			codigo,
			fabricante.Nombre_Fabricante,
			servicio.Descripcion_Servicio
			));	
		}

		public int darDeAlta(string Matricula, DateTime Fecha_Alta,  Fabricante fabricante, Modelo Modelo, TipoServicio servicio, int Kgs_Disponibles, int butacasPasillo, int butacasVentanilla )
		{
			return DBAdapter.executeProcedureWithReturnValue("Alta_Aeronave", 
			Matricula,
			Fecha_Alta,
			fabricante.Nombre_Fabricante,
			Modelo.Descricpion_Modelo,
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
       			new ModeloRepository().getModelo( Convert.ToInt32( dr["Cod_Modelo"]) ),
       			new TipoServicioRepository().getTipoServicio( Convert.ToInt32(dr["Cod_Tipo_Servicio"])),
       			Convert.ToInt32(dr["Kgs_Disponibles"]),
       			Convert.ToInt32(dr["Cantidad_Butacas"])
			);
        }



	}
}
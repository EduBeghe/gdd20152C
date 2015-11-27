using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	
	class Estadísticos {

		public void destinosConMasPasajes( DateTime fechaInicio, DateTime fechaFin ) 
		{
			return parsePasajes ( 
			DBAdapter.retrieveDataTable("Pasajes_Mas_Comprados", 
			fechaInicio,
			fechaFin )
			);
		}

		public void destinosConMasAeronavesVacias( DateTime fechaInicio, DateTime fechaFin )
		{
			return parseAeronaves ( 
			DBAdapter.retrieveDataTable("Aeronaves_Mas_Vacias", 
			fechaInicio,
			fechaFin )
			);	
		}

		public void clientesConMasPuntos()
		{
			return parseClientes (
			DBAdapter.executeProcedure( "Cliente_Mayoria_Puntos" );
		}

		public void destinosConMasPasajesCancelados(  DateTime fechaInicio, DateTime fechaFin )
		{
			DBAdapter.executeProcedure("Destinos_Mas_Cancelados", 
			fechaInicio,
			fechaFin	
			);
		}

		public void aeronavesConMasDiasFueraDeServicio(  DateTime fechaInicio, DateTime fechaFin )
		{
			DBAdapter.executeProcedure("Aeronave_Mayoria_Fuera_Servicio", 
			fechaInicio,
			fechaFin	
			);
		}



	}
}
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
			Adapter.executeProcedure("Pasajes_Mas_Comprados", 
			fechaInicio,
			fechaFin
			);
		}

		public void destinosConMasAeronavesVacias( DateTime fechaInicio, DateTime fechaFin )
		{
			Adapter.executeProcedure("Aeronaves_Mas_Vacias", 
			fechaInicio,
			fechaFin
			);	
		}

		public void clientesConMasPuntos()
		{
			Adapter.executeProcedure("Cliente_Mayoria_Puntos", );
		}

		public void destinosConMasPasajesCancelados(  DateTime fechaInicio, DateTime fechaFin )
		{
			Adapter.executeProcedure("Destinos_Mas_Cancelados", 
			fechaInicio,
			fechaFin	
			);
		}

		public void aeronavesConMasDiasFueraDeServicio(  DateTime fechaInicio, DateTime fechaFin )
		{
			Adapter.executeProcedure("Aeronave_Mayoria_Fuera_Servicio", 
			fechaInicio,
			fechaFin	
			);
		}

	}
}
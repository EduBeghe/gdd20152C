using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class ViajesRepository {

		public void generarViaje( Viaje viaje )
		{
			Adapter.executeProcedure("Generar_Viaje", 
			viaje.rutaAerea.idRutaAerea,
			viaje.aeronave.idAeronave,
			viaje.fechaSalida,
			viaje.fechaLlegadaEstimada
			);
		}

		// Verificar parametros
		public void getViajesDisponibles( DateTime fechaSalida, Ciudad origen, Ciudad destino )
		{
			Adapter.executeProcedure( "Mostrar_Viajes_Disponibles",
			fechaSalida, 
			origen.idCiudad, 
			destino.idCiudad
			);
		}



	}
}
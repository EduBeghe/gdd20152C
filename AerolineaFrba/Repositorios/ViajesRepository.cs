using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class ViajesRepository {

		// Ingresa un viaje o los datos sueltos ?
		public void generarViaje( Viaje viaje )
		{
			DBAdapter.executeProcedure("Generar_Viaje", 
			viaje.rutaAerea.idRutaAerea,
			viaje.aeronave.idAeronave,
			viaje.fechaSalida,
			viaje.fechaLlegadaEstimada
			);
		}

		// Verificar parametros
		public void getViajesDisponibles( DateTime fechaSalida, Ciudad origen, Ciudad destino )
		{
			return parseViajes( 
			DBAdapter.retrieveDataTable("Mostrar_Viajes_Disponibles",
			fechaSalida, 
			origen.idCiudad, 
			destino.idCiudad )
			);
		}

		public List<Viaje> parseViajes ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Viaje parse(DataRow dr)
        {
       		return new Viaje( Convert.ToInt32(dr["Cod_Viaje"] ),
			dr["Fecha_Salida"] as DateTime,
			dr["Fecha_Llegada"] as DateTime,
			dr["Fecha_Llegada_Estimada"] as DateTime,
			new AeronaveRepository.getAeronave( Convert.ToInt32(dr["Cod_Aeronave"]) ),
			// Mirar parametros necesario para getRuta Aerea 
			new RutaAereaRepository.getRuta( Convert.ToInt32(dr["Cod_Ruta"]) )
			);
        }



	}
}
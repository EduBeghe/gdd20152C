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
			viaje.rutaAerea.Cod_Viaje,
			viaje.aeronave.Cod_Aeronave,
			viaje.Fecha_Salida,
			viaje.Fecha_Llegada_Estimada
			);
		}		

		// Verificar parametros
		public void getViajesDisponibles( DateTime fechaSalida, Ciudad origen, Ciudad destino )
		{
			return parseViajes( 
			DBAdapter.retrieveDataTable("Mostrar_Viajes_Disponibles",
			fechaSalida, 
			origen.Cod_Ciudad, 
			destino.Cod_Ciudad )
			);
		}

		public List<Viaje> parseViajes ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Viaje parse(DataRow dr)
        {
        	// Verificar parametros de gets
       		return new Viaje( 
       		Convert.ToInt32(dr["Cod_Viaje"] ),
       		new RutasAereasRepository().getRuta( Convert.ToInt32(dr["Cod_Ruta"] ) ),
       		new AeronaveRepository().getAeronave( Convert.ToInt32(dr["Cod_Aeronave"])),
			Convert.ToDateTime(dr["Fecha_Salida"]),
			Convert.ToDateTime(dr["Fecha_Llegada"]),
			Convert.ToDateTime(dr["Fecha_Llegada_Estimada"]),
			);
        }



	}
}
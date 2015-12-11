using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;
using System.Data;


namespace AerolineaFrba.Repositories {

	class ViajesRepository {

		
		public int generarViaje( RutaAerea ruta, Aeronave aeronave, DateTime fechaSalida, DateTime llegadaEstimada )
		{
			return DBAdapter.executeProcedureWithReturnValue("Generar_Viaje", 
			ruta.Cod_Ruta,
			aeronave.Cod_Aeronave,
            fechaSalida,
            llegadaEstimada
			);
		}		

		// Verificar parametros
		public List<Viaje> getViajesDisponibles( DateTime fechaSalida, Ciudad origen, Ciudad destino )
		{
			return parseViajes( 
			DBAdapter.retrieveDataTable("Mostrar_Viajes_Disponibles",
			fechaSalida, 
			origen.Cod_Ciudad, 
			destino.Cod_Ciudad )
			);
		}

		public Viaje getViaje( int idViaje )
		{
			return parse ( DBAdapter.retrieveDataTable("GetViaje", idViaje ).Rows[0]);
		}


		public List<Viaje> parseViajes ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Viaje parse(DataRow dr)
        {
        	// Verificar parametros de gets
            string a = dr["Fecha_Llegada"].ToString() ;
            if ( a != "")
            {
                return new Viaje(
                Convert.ToInt32(dr["Cod_Viaje"]),
                new RutaAereaRepository().getRuta(Convert.ToInt32(dr["Cod_Ruta"]),
                    new CiudadRepository().getCiudad(Convert.ToInt32(dr["Cod_Ciudad_Origen"])),
                    new CiudadRepository().getCiudad(Convert.ToInt32(dr["Cod_Ciudad_Destino"]))
                    ),
                new AeronaveRepository().getAeronave(Convert.ToInt32(dr["Cod_Aeronave"])),
                Convert.ToDateTime(dr["Fecha_Salida"]),
                Convert.ToDateTime(dr["Fecha_Llegada"]),
                Convert.ToDateTime(dr["Fecha_Llegada_Estimada"])
                );
            }
            else
            {
                return new Viaje(
               Convert.ToInt32(dr["Cod_Viaje"]),
               new RutaAereaRepository().getRuta(Convert.ToInt32(dr["Cod_Ruta"]),
                   new CiudadRepository().getCiudad(Convert.ToInt32(dr["Cod_Ciudad_Origen"])),
                   new CiudadRepository().getCiudad(Convert.ToInt32(dr["Cod_Ciudad_Destino"]))
                   ),
               new AeronaveRepository().getAeronave(Convert.ToInt32(dr["Cod_Aeronave"])),
               Convert.ToDateTime(dr["Fecha_Salida"]),
               null,
               Convert.ToDateTime(dr["Fecha_Llegada_Estimada"])
               );
            }
        }



	}
}
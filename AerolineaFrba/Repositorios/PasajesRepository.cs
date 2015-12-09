using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;
using System.Data;


namespace AerolineaFrba.Repositories {

	class PasajesRepository {

		public void comprarPasajes( int butaca, int codViaje, string apellido, int dni, string formaPago, int tarjeta, int codSeg, DateTime vencimiento, string tipoTarjeta )
		{
			DBAdapter.executeProcedure("Comprar_Pasajes",
				butaca, 
				codViaje, 
				apellido, 
				dni, 
				formaPago, 
				tarjeta, 
				codSeg, 
				vencimiento,
				tipoTarjeta
			);
		}

		public void cancelarPasaje( Pasaje pasaje, DateTime fecha, string motivo )
		{
			DBAdapter.executeProcedure("Cancelar_Pasajes",
				fecha,
				pasaje.viaje.aeronave.Cod_Aeronave,
				pasaje.viaje.rutaAerea.Cod_Ruta,
				motivo
			);
		}

		
		public List<Pasaje> parsePasajes ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Pasaje parse(DataRow dr)
        {
       		return new Pasaje( 
       		Convert.ToInt32(dr["Cod_Pasaje"] ),
       		Convert.ToDateTime(dr["Fecha_Viaje"]),
       		new ViajesRepository().getViaje( Convert.ToInt32(dr["Cod_Viaje"])),
       		Convert.ToInt32(dr["Butaca_Asociada"]),
       		new ClientesRepository().getCliente( Convert.ToInt32(dr["Nro_Dni"]), dr["Cliente_Apellido"] as string ),
       		Convert.ToInt32(dr["Pasaje_Precio"])
 			);
        }

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using AerolineaFrba.Repositories;
using System.Data;


namespace AerolineaFrba.Repositories {

	
	class Estadísticos {

		public List<Ciudad> destinosConMasPasajes( DateTime fechaInicio, DateTime fechaFin ) 
		{
            
			return new CiudadRepository().parseCiudades ( 
			DBAdapter.retrieveDataTable("Pasajes_Mas_Comprados", 
			fechaInicio,
			fechaFin )
			);
		}

		public List<Ciudad> destinosConMasAeronavesVacias( DateTime fechaInicio, DateTime fechaFin )
		{
			return new CiudadRepository().parseCiudades ( 
			DBAdapter.retrieveDataTable("Aeronaves_Mas_Vacias", 
			fechaInicio,
			fechaFin )
			);	
		}

		public List<Cliente> clientesConMasPuntos()
		{
			return new ClientesRepository().parseClientes (
			DBAdapter.retrieveDataTable( "Cliente_Mayoria_Puntos" )
            );
		}

		public List<Ciudad> destinosConMasPasajesCancelados(  DateTime fechaInicio, DateTime fechaFin )
		{
			return new CiudadRepository().parseCiudades (
			DBAdapter.retrieveDataTable("Destinos_Mas_Cancelados", 
			fechaInicio,
			fechaFin )
			);
		}

		public List<Aeronave> aeronavesConMasDiasFueraDeServicio(  DateTime fechaInicio, DateTime fechaFin )
		{
			return new AeronaveRepository().parseAeronaves(
            DBAdapter.retrieveDataTable("Aeronave_Mayoria_Fuera_Servicio", 
			fechaInicio,
			fechaFin )
			);
		}



	}
}
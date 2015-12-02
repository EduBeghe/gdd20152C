using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Domain;
using AerolineaFrba.Repositories;


namespace AerolineaFrba.Repositories {

	class RutaAereaRepository {

		public void darDeAlta(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Alta_Ruta_Aerea", 
			rutaAerea.origen.Cod_Ciudad,
			rutaAerea.destino.Cod_Ciudad,
			rutaAerea.servicio.Cod_Tipo_Servicio,
			rutaAerea.Precio_Base_Kg,
			rutaAerea.Precio_Base_Pasaje
			);
		}

		public RutaAerea getRuta( int idRuta, Ciudad origen, Ciudad destino )
		{
			return parse ( DBAdapter.retrieveDataTable("GetRuta", idRuta, origen, destino ).Rows[0]);
		}

		public List<RutaAerea> findRuta( )
		{
			//return parseRutas( DBAdapter.retrieveDataTable( "FindRuta" ).Rows[0]);
            return new List<RutaAerea>();
		}

		// Ingresa una ruta aerea ? 
		public void modificarCiudades(  RutaAerea rutaAerea, Ciudad origen, Ciudad destino )
		{
			DBAdapter.executeProcedure("Modificar_Ciudades_Ruta_Aereas", 
			rutaAerea.Cod_Ruta,
			origen.Nombre_Ciudad,
			destino.Nombre_Ciudad
			);				
		}

		public void modificarTipoServicio(  RutaAerea rutaAerea, TipoServicio servicio )
		{
			DBAdapter.executeProcedure("Modificar_Servicio_Ruta_Aerea", 
			rutaAerea.Cod_Ruta,
			servicio.Descripcion_Servicio
			);				
		}

		public void modificarPrecio(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Modificar_Precios_Ruta_Aerea", 
			rutaAerea.Cod_Ruta,
			rutaAerea.Precio_Base_Kg,
			rutaAerea.Precio_Base_Pasaje
			);				
		}

		// El motivo no lo tengo en ningun lado asi que deberia ingresar como param.
		public void darDeBaja(  RutaAerea rutaAerea )
		{
			DBAdapter.executeProcedure("Baja_Ruta_Aerea", 
			rutaAerea.origen.Cod_Ciudad,
			rutaAerea.destino.Cod_Ciudad,
			rutaAerea.servicio.Cod_Tipo_Servicio,
			rutaAerea.Precio_Base_Kg,
			rutaAerea.Precio_Base_Pasaje
			// motivo? ( entra por la form ? )
			);				
		}

		public List<RutaAerea> parseRutas ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}



		public RutaAerea parse(DataRow dr)
        {
       		return new RutaAerea( 
       			Convert.ToInt32(dr["Cod_Ruta"]),
       			new CiudadRepository().getCiudad( Convert.ToInt32(dr["Cod_Ciudad_Origen"]) ),
       			new CiudadRepository().getCiudad( Convert.ToInt32(dr["Cod_Ciudad_Destino"]) ),
                new TipoServicioRepository().getTipoServicio( Convert.ToInt32(dr["Cod_Tipo_Servicio"])),
       			Convert.ToInt32( dr["Precio_Base_Pasaje"]),
       			Convert.ToInt32( dr["Precio_Base_Kg"]),
       			( bool ) dr["Estado_Ruta"] 
			);
        }



	}
}
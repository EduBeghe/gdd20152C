using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Repositories;


namespace AerolineaFrba.Repositories {

	class RutaAereaRepository {

		public int darDeAlta( Ciudad origen,Ciudad destino, TipoServicio servicio, int Precio_Base_Kg,int Precio_Base_Pasaje )
		{
			return DBAdapter.executeProcedureWithReturnValue("Alta_Ruta_Aerea", 
			origen.Nombre_Ciudad,
			destino.Nombre_Ciudad,
			servicio.Descripcion_Servicio,
			Precio_Base_Kg,
			Precio_Base_Pasaje
			);

		}

		public RutaAerea getRuta( int idRuta, Ciudad origen, Ciudad destino )
		{
			return parse ( DBAdapter.retrieveDataTable("GetRuta", idRuta, origen, destino ).Rows[0]);
		}

		public List<RutaAerea> findRuta(  int? codigo, Ciudad origen, Ciudad destino, TipoServicio servicio  )
		{
			return parseRutas( DBAdapter.retrieveDataTable("Filtrar_Rutas",
			codigo,
			origen.Nombre_Ciudad,
			destino.Nombre_Ciudad,
			servicio.Descripcion_Servicio
			));	
		}

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

		public void modificarPrecio(  RutaAerea rutaAerea, int precioKg, int precioPasaje )
		{
			DBAdapter.executeProcedure("Modificar_Precios_Ruta_Aerea", 
			rutaAerea.Cod_Ruta,
			precioKg,
			precioPasaje
			);				
		}

		// El motivo no lo tengo en ningun lado asi que deberia ingresar como param.
		public void darDeBaja(  RutaAerea rutaAerea, string motivo )
		{
			DBAdapter.executeProcedure("Baja_Ruta_Aerea", 
            rutaAerea.Cod_Ruta,
			rutaAerea.origen.Nombre_Ciudad,
			rutaAerea.destino.Nombre_Ciudad,
			motivo
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
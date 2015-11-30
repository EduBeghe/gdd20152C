using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class RolesRepository {

		public void agregarRol( Rol rol )
		{
			DBAdapter.executeProcedure("Agregar_Rol", rol.Nombre_Rol );
		}

		// Esto deberia estar aca ? 
		// o Rol tiene una lista de funcionabilidades como atributos y ya esta
		public void relacionRolFuncionabilidad()
		{
			//DBAdapter.executeProcedure("XXXXX", cliente.idCliente);				
		}

		public void modificarNombre( Rol rol )
		{
			DBAdapter.executeProcedure("Modificar_Nombre_Rol", rol.Nombre_Rol);
		}

		public List<Rol> findRol( )
		{
			return parseRoles( DBAdapter.retrieveDataTable( "FindRol" ).Rows[0]);
		}

		public void modificarEstado( Rol rol )
		{
			DBAdapter.executeProcedure("Modificar_Estado_Rol", 
			rol.Nombre_Rol,
			rol.Estado_Rol
			);
		}


		public void darDeBaja( Rol rol )
		{
			Adapter.executeProcedure("Baja_Rol", rol.Nombre_Rol );				
		}

		public List<Rol> parseRoles ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Rol parse(DataRow dr)
        {
       		// return new Aeronave( 
       			// Convert.ToInt32(dr["Cod_Aeronave"]),
       			// Convert.ToInt32(dr["Matricula"]),
       			// Convert.ToDateTime(dr["Fecha_Alta"]),
       			// new FabricantesRepository().getFabricante( Convert.ToInt32(dr["Cod_Fabricante"]) ),
       			// dr["Modelo"] as string,
       			// new TipoServicioRepository().getTipoServicio( Convert.ToInt32(["Cod_Tipo_Servicio"])),
       			// Convert.ToInt32(dr["Kgs_Disponibles"]),
       			// Convert.ToInt32(dr["Cantidad_Butacas"])
			);
        }


	}
}
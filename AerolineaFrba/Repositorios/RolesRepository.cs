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

		public List<Rol> findRol(  string nombre  )
		{
			return parseRoles( DBAdapter.retrieveDataTable("Filtrar_Roles", nombre ));	
		}

		public Rol getRol( int idRol )
		{
			return parse ( DBAdapter.retrieveDataTable("GetRol", idRol ).Rows[0]);
		}

		public List<Rol> getRoles()
		{
			return parseRoles( DBAdapter.retrieveDataTable( "Get_Roles" ));
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
			DBAdapter.executeProcedure("Baja_Rol", rol.Nombre_Rol );				
		}

		public List<Rol> parseRoles ( DataTable dataTable )
		{
			return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
		}

		public Rol parse(DataRow dr)
        {
        	return new Rol(
        		Convert.ToInt32(dr["Cod_Rol"]),
        		dr["Nombre_Rol"] as string,
        		( bool ) dr["Estado_Rol"],
        		// new RolesRepository().getRol()
        		new List<Funcionalidades>()// CORREGIR! donde sale esta lista ?
       		);
        }


	}
}
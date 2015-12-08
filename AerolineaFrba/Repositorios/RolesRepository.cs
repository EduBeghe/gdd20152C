using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;


namespace AerolineaFrba.Repositories {

	class RolesRepository {

		public int agregarRol( string rol )
		{
			var retorno = DBAdapter.executeProcedureWithReturnValue("Agregar_Rol", rol );
            return retorno;
		}

		public void relacionRolFuncionabilidad(String nombreRol,Funcionalidades funcionalidad)
		{
			DBAdapter.executeProcedure("Agregar_Rol_Por_Funcionalidad", nombreRol,funcionalidad.Nombre_Funcionalidad);				
		}

        public void quitarFuncionabilidad( int codRol, Funcionalidades funcionalidad)
        {
            DBAdapter.executeProcedure("Quitar_Funcionalidad_A_Rol", funcionalidad.Nombre_Funcionalidad, codRol) ;
        }

		public void modificarNombre( Rol rol, string nombre )
		{
			DBAdapter.executeProcedure("Modificar_Nombre_Rol", rol.Nombre_Rol, nombre );
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


		public void modificarEstado( Rol rol, Boolean estado )
		{
			DBAdapter.executeProcedure("Modificar_Estado_Rol", 
			rol.Nombre_Rol,
			estado
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
                new FuncionalidadRepository().getFuncionalidadesByRol( Convert.ToInt32(dr["Cod_Rol"]) )
       		);
        }

    }
}
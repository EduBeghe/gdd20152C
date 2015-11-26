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
			DBAdapter.executeProcedure("Agregar_Rol", rol.nombre );
		}

		// Esto deberia estar aca ? 
		// o Rol tiene una lista de funcionabilidades como atributos y ya esta
		public void relacionRolFuncionabilidad()
		{
			//DBAdapter.executeProcedure("XXXXX", cliente.idCliente);				
		}

		public void modificarNombre( Rol rol )
		{
			DBAdapter.executeProcedure("Agregar_Rol", rol.nombre );
		}

		public void modificarEstado( Rol rol )
		{
			DBAdapter.executeProcedure("Modificar_Estado_Rol", 
				rol.nombre,
				rol.estado
				);
		}

		public void darDeBaja( Rol rol )
		{
			Adapter.executeProcedure("Baja_Rol", rol.nombre );				
		}

	}
}
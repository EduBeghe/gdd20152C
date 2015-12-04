using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Repositories;

namespace AerolineaFrba.Repositories {

	class UsuarioRepository {

		public int ValidarLogin( string usuario, string pass )
		{
			return DBAdapter.executeProcedureWithReturnValue("Validar_Login", usuario, pass );

		}

        public Usuario getUsuario( string username )
        {
            return parse(DBAdapter.retrieveDataTable("GetUsuario", username ).Rows[0]);
        }


		public void iniciarSesion(string userName) {
            CLC_SessionManager.currentUser = getUsuario( userName ) ;
        }

        public Usuario parse(DataRow dr)
        {
       		return new Usuario(
       			dr["Usuario_Nombre"] as string, 
       			dr["Contraseña"] as string, 
       			new RolesRepository().getRol( Convert.ToInt32( dr["Cod_Rol"] ) ),
                Convert.ToInt32( dr["Intentos_Login"] ),
                ( bool ) dr["Estado_Usuario"]
			);
        }

	}
}
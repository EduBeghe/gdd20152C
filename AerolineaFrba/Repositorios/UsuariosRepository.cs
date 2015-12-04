using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AerolineaFrba.Domain;
using AerolineaFrba.Utils;
using System.Data;
using AerolineaFrba.Repositories;
using System.Windows.Forms;

namespace AerolineaFrba.Repositories {

	class UsuarioRepository {

		public int ValidarLogin( string usuario, string pass )
		{
			var cantUsuarios = DBAdapter.executeProcedureWithReturnValue("Validar_Login", usuario, new Encription().encryptToSHA256( pass ) );
            return cantUsuarios;
		}

        public Usuario getUsuario( string username )
        {
            return parse(DBAdapter.retrieveDataTable("GetUsuario", username).Rows[0]);
        }


		public void iniciarSesion(string userName) {
            //CLC_SessionManager.currentUser = getUsuario( userName ) ;
            var usr = getUsuario(userName);
            if ( usr != null ) CLC_SessionManager.setCurrentUser( usr );
            else MessageBox.Show("usr es null");
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
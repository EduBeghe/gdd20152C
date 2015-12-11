using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using AerolineaFrba.Domain;
using AerolineaFrba.Domain.Excepciones;
using System.Windows.Forms;

namespace AerolineaFrba.Utils
{
    public static class CLC_SessionManager
    {
        private static Usuario _administrador;
        public static Usuario currentUser { get { if (_administrador == null) throw new NoOpenSessionException(); else  return _administrador; } set { _administrador = value; } }
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GD2C2015"].ConnectionString;      
        // public static bool esAdministrador = false;

        public static void setCurrentUser(Usuario u)
        {
            currentUser = u;
        }

        public static void closeSession()
        {
            currentUser = null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using AerolineaFrba.Domain;
// using AerolineaFrba.Domain.Exceptions;
using AerolineaFrba.UI;
using System.Windows.Forms;

namespace AerolineaFrba.Utils
{
    class CLC_SessionManager
    {
        private static Administrador _administrador;
        public static Administrador currentUser { get { if (_administrador == null) throw new NoSessionIsOpenException(); else  return _administrador;  } set { _administrador = value; } }
        public static string connectionString = ConfigurationManager.ConnectionStrings["GD2C2015"].ConnectionString;      
        // public static bool esAdministrador = false;
        
        public static DateTime getFecha() {
            return DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["fechaSistema"]);
        }

        public static void setCurrentUser(Administrador u) {
            currentUser = u;
        }

        public static void closeSession()
        {
            currentUser = null;
        }

    }
}

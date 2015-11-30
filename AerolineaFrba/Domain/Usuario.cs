using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Usuario
    {
        public string Usuario_Nombre { get; set; }
        public string Contraseña { get; set; }
        public Rol rol { get; set; }
        public int Intentos_Login { get; set; }
        public bool Estado_Usuario { get; set; }

        public Usuario( string Usuario_Nombre, string Contraseña, Rol rol, int Intentos_Login, bool Estado_Usuario )
        {
            this.Usuario_Nombre = Usuario_Nombre;
            this.Contraseña = Contraseña;
            this.rol = rol;
            this.Intentos_Login = Intentos_Login;
            this.Estado_Usuario = Estado_Usuario;     
        }

    }
}

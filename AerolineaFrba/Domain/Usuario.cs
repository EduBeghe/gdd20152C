using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public Rol rol { get; set; }

        public Usuario( int idUsuario, string nombre, Rol rol )
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.rol = rol;
        }
    }
}

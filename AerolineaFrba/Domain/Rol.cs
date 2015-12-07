using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Domain;

namespace AerolineaFrba.Domain
{
        
    public class Rol
    {
        public int Cod_Rol { get; set; } 
        public string Nombre_Rol { get; set; }
        public bool Estado_Rol { get; set; }
        public List<Funcionalidades> funcionalidades { get; set; }
        
        public Rol( int Cod_Rol, string Nombre_Rol, bool Estado_Rol, List<Funcionalidades> funcionalidades )
        {
            this.Cod_Rol = Cod_Rol;
            this.Nombre_Rol = Nombre_Rol;
            this.Estado_Rol = Estado_Rol;
            this.funcionalidades = funcionalidades;
        }

        public static Rol Copy(Rol r)
        {
            return new Rol( r.Cod_Rol, r.Nombre_Rol, r.Estado_Rol, r.funcionalidades );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombreYApellido { get; set; }
        public int dni { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int millasAcumuladas { get; set; }

        public Cliente( int idCliente, string nombreYApellido, int dni, string direccion, int telefono, string email, DateTime fechaNacimiento, int millasAcumuladas )
        {
            this.idCliente = idCliente;
            this.nombreYApellido = nombreYApellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.millasAcumuladas = millasAcumuladas;
        }
    }
}

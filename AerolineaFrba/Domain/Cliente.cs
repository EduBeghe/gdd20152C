using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Cliente
    {
        public int Nro_Dni { get; set; }
        public string Cliente_Nombre { get; set; }
        public string Cliente_Apellido { get; set; }
        public string Cliente_Direccion { get; set; }
        public int Cliente_Telefono { get; set; }
        public string Cliente_Mail { get; set; }
        public DateTime Cliente_Fecha_Nacimiento { get; set; }
        public int Cant_Millas { get; set; }

        public Cliente( int Nro_Dni, string Cliente_Nombre, string Cliente_Apellido, string Cliente_Direccion, int Cliente_Telefono, string Cliente_Mail, DateTime Cliente_Fecha_Nacimiento, int Cant_Millas )
        {
            this.Nro_Dni = Nro_Dni;
            this.Cliente_Nombre = Cliente_Nombre;
            this.Cliente_Apellido = Cliente_Apellido;
            this.Cliente_Direccion = Cliente_Direccion;
            this.Cliente_Telefono = Cliente_Telefono;
            this.Cliente_Mail = Cliente_Mail;
            this.Cliente_Fecha_Nacimiento = Cliente_Fecha_Nacimiento;
            this.Cant_Millas = Cant_Millas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class Aeronave
    {
        public int idAeronave { get; set; }
        // fuera de servicio
        public int capacidadEncomiendas { get; set; }
        public EstadoAeronave estadoAeronave { get; set; }
        public Fabricante fabricante { get; set; }
        public DateTime fechaDeAlta { get; set; }
        public int numeroAeronave { get; set; }
        public string modelo { get; set; }
        public int matricula { get; set; }
        // Servicio ? 

        public Aeronave(int IdAeronave, int capacidadEncomiendas, EstadoAeronave estadoAeronave, Fabricante fabricante, DateTime fechaDeAlta, int numeroAeronave, string modelo, int matricula)
        {
            // Servicio
            this.IdAeronave = IdAeronave;
            this.capacidadEncomiendas = capacidadEncomiendas;
            this.estadoAeronave = estadoAeronave;
            this.fabricante = fabricante;
            this.fechaDeAlta = fechaDeAlta;
            this.numeroAeronave = numeroAeronave;
            this.modelo = modelo;
          	this.matricula = matricula;

        }

    }
}


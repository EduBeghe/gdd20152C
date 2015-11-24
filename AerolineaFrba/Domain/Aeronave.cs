using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class Aeronave
    {
        public int aeronaveId { get; set; }
        public int capacidadEncomiendas { get; set; }
        public Estado estado { get; set; }
        public Fabricante fabricante { get; set; }
        public DateTime fechaDeAlta { get; set; }
        public int numeroAeronave { get; set; }
        public string modelo { get; set; }
        public int matricula { get; set; }

        public Aeronave(int aeronaveId, int capacidadEncomiendas, Estado estado, Fabricante fabricante, DateTime fechaDeAlta, int numeroAeronave, string modelo, int matricula)
        {
            this.aeronaveId = aeronaveId;
            this.capacidadEncomiendas = capacidadEncomiendas;
            this.estado = estado;
            this.fabricante = fabricante;
            this.fechaDeAlta = fechaDeAlta;
            this.numeroAeronave = numeroAeronave;
            this.modelo = modelo;
          	this.matricula = matricula;

        }

    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
    public class Aeronave
    {
        public int Cod_Aeronave { get; set; }
        public int Matricula { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public Fabricante fabricante { get; set; }
        public string Modelo { get; set; }
        public TipoServicio servicio { get; set; }
        public int Kgs_Disponibles { get; set; }
        public int Cantidad_Butacas { get; set; }
        // public EstadoAeronave estadoAeronave { get; set; }

        public Aeronave(int Cod_Aeronave, int Matricula, DateTime Fecha_Alta,  Fabricante fabricante, string Modelo, TipoServicio servicio, int Kgs_Disponibles, int Cantidad_Butacas )
        {
            // Servicio
            this.Cod_Aeronave = Cod_Aeronave;
          	this.Matricula = Matricula;
            this.Fecha_Alta = Fecha_Alta;
            this.fabricante = fabricante;
            this.Modelo = Modelo;
            this.servicio = servicio;
            this.Kgs_Disponibles = Kgs_Disponibles;
            this.Cantidad_Butacas = Cantidad_Butacas;
        }

    }
}


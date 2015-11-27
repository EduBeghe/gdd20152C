using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Butaca
    {

        public int Cod_Butaca { get; set; }
        public Aeronave aeronave { get; set; }
        public string Pos_Butaca { get; set; }
        public int Piso_Butaca { get; set; }
        public bool Estado_Butaca { get; set; }

        public Butaca( int Cod_Butaca, Aeronave aeronave, string Pos_Butaca, int Piso_Butaca, bool Estado_Butaca )
        {
            this.Cod_Butaca = Cod_Butaca;
            this.aeronave = aeronave;
        	this.Pos_Butaca = Pos_Butaca;
            this.Piso_Butaca = Piso_Butaca;
            this.Estado_Butaca = Estado_Butaca;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain
{
        
    public class Funcionalidades
    {
        public int idFuncionabildiad { get; set; }
        public string detalleFuncionabilidad { get; set; }

        public Funcionalidades( int idFuncionabildiad, string detalleFuncionabilidad )
        {
            this.idFuncionabildiad = idFuncionabildiad;
            this.detalleFuncionabilidad = detalleFuncionabilidad;
        }
    }
}

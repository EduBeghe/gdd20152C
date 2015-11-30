using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Domain.Excepciones
{
    class NoOpenSessionException : Exception
    {
        public NoOpenSessionException() { }
    }
}

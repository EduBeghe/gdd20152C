using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.Utils;

namespace AerolineaFrba.Repositories
{
    class DevolucionRepository
    {
       public int devolverCompra( int numeroCompra ,int codigo ,String motivo, int tipo ){
            return DBAdapter.executeProcedureWithReturnValue("Cancelar_Pasajes_Encomiendas", 
                numeroCompra,codigo,motivo, tipo );
         } //fechaDevolucion ,@numeroCompra int,@codigo numeric(18),@motivo nvarchar(255))
    }
}

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
       public int devolverCompra(DateTime fechaDevolucion,int numeroCompra ,int codigo ,String motivo){
            return DBAdapter.executeProcedureWithReturnValue("Cancelar_Pasajes_Encomiendas", 
                fechaDevolucion,numeroCompra,codigo,motivo);
         } //fechaDevolucion ,@numeroCompra int,@codigo numeric(18),@motivo nvarchar(255))
    }
}

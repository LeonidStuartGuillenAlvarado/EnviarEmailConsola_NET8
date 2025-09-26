using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Pagos
{
    public interface PMetodoPago
    {
        void ProcesarPago(decimal monto);
    }
}

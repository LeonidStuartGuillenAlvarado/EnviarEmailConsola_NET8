using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailConsolaApp.Pagos
{
    public class PTransferencia : PMetodoPago
    {
        public void ProcesarPago(decimal monto) 
        {
            Console.WriteLine($"Procesando {monto:C} con transferencia bancaria...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailConsolaApp.Pagos
{
    public class PTarjetaCredito : PMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando {monto:C} con tarjeta de crédito...");
        }
    }
}

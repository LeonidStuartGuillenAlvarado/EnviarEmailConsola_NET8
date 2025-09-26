using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailConsolaApp.Pagos
{
    public class ProcesadorPagos
    {
        public void Procesar(decimal monto, PMetodoPago metodoPago)
        {
            metodoPago.ProcesarPago(monto);
            Console.WriteLine("Factura pagada");
        }
    }
}

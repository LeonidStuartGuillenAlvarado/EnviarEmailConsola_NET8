//PPaypal.cs

namespace EmailConsolaApp.Pagos
{
    public class PPaypal : PMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"\nProcesando {monto:C} con Pypal...");
        }
    }
}

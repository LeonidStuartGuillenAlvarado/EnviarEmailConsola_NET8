//PTarjetaCredito.cs

namespace EmailConsolaApp.Pagos
{
    public class PTarjetaCredito : PMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"\nProcesando {monto:C} con tarjeta de crédito...");
        }
    }
}

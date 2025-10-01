//ProcesadorPagos.cs

namespace EmailConsolaApp.Pagos
{
    public class ProcesadorPagos
    {
        public void Procesar(decimal monto, PMetodoPago metodoPago)
        {
            metodoPago.ProcesarPago(monto);
            Console.WriteLine("\nFactura pagada");
        }
    }
}

//PTransferencia.cs

namespace EmailConsolaApp.Pagos
{
    public class PTransferencia : PMetodoPago
    {
        public void ProcesarPago(decimal monto) 
        {
            Console.WriteLine($"\nProcesando {monto:C} con transferencia bancaria...");
        }
    }
}

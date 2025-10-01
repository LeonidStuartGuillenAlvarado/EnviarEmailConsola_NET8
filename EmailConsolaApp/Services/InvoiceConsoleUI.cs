//InvoiceConsoleUI
//aplicamos el princio de SRP, :p
using EmailConsolaApp.Models;
using EmailConsolaApp.Pagos;

namespace EmailConsolaApp.Services
{
    public class InvoiceConsoleUI
    {
        public Invoice SolicitarDatosFactura()
        {
            Console.WriteLine("\n========= DATOS DE LA FACTURA =========");
            int customerId;
            while (true)
            {
                Console.WriteLine("Ingrese el ID del cliente: ");
                if (int.TryParse(Console.ReadLine(), out customerId)) break;
                Console.WriteLine("ID invalido, intente de nuevo");
            }

            Console.WriteLine("Ingrese el nombre del cliente: ");
            string? customerName = Console.ReadLine();

            double amount;
            while (true)
            {
                Console.WriteLine("Ingrese el monto de la factura: ");
                if (double.TryParse(Console.ReadLine(), out amount)) break;
                Console.WriteLine("Monto inválido, intente de nuevo.");
            }

            // Usamos InvoiceBuilder para crear la instancia 
            var builder = new InvoiceBuilder();
            return builder.CrearFactura(customerId, customerName, amount);
        }
        public PMetodoPago ElegirMetodoPago(Invoice invoice)
        {
            //preguntar metodo de pago
            Console.WriteLine("\n========= MÉTODO DE PAGO =========");
            Console.WriteLine("1. Tarjeta de crédito");
            Console.WriteLine("2. Transferencia bancaria");
            Console.WriteLine("3. PayPal");
            Console.Write("Ingrese una opción (1, 2 o 3): ");

            while (true)
            {
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1": invoice.metodoPago = "Tarjeta de crédito"; return new PTarjetaCredito();
                    case "2": invoice.metodoPago = "Transferencia"; return new PTransferencia();
                    case "3": invoice.metodoPago = "PayPal"; return new PPaypal();
                    default: Console.WriteLine("Método de pago invalido");break;
                }
            }
        }
        public string? SolicitarCorreo()
        {
            Console.WriteLine("\n========= CORREO =========");
            Console.WriteLine("Ingrese el correo del cliente: ");
            return Console.ReadLine();
        }
    }
}

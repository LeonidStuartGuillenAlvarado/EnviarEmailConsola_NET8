//program.cs
//aplicamos los princios SRP, DIP, OCP
using EmailConsolaApp.Models;
using EmailConsolaApp.Services;
using EmailConsolaApp.Pagos;

namespace EmailConsolaApp
{
    class Program
    {
        static void Main()
        {
            //interfaz de user, consola
            var consola = new InvoiceConsoleUI();

            //paso 1: solicitar datos de la factura
            Invoice invoice = consola.SolicitarDatosFactura();

            //paso 2: elegir método de pago
            PMetodoPago metodoPago = consola.ElegirMetodoPago(invoice);

            //paso 3: procesar el pago (OCP)
            var procesador = new ProcesadorPagos();
            procesador.Procesar((decimal)invoice.Amount, metodoPago);

            //paso 4: calcular, guardar e imprimir factura (SRP, DIP)
            var Calcular = new InvoiceCalcular();
            var Guardar = new InvoiceGuardarArchivo();
            var Imprmir = new InvoicePrint();
            var Servicio = new InvoiceServicios(Calcular, Guardar, Imprmir);
            Servicio.ProcessInvoices(invoice);

            //paso 5: sollicitar correo y enviar factura
            string?correoDestino = consola.SolicitarCorreo();
            if (!string.IsNullOrWhiteSpace(correoDestino))
            {
                //aqui debes ingresar tu correo electronico y contraseña de aplicaciones (busca un tutorial de youtube en mi readmi)
                var emailSender = new InvoiceCorreo("aritansun@gmail.com", "opxw nxms isgx nrfz");
                emailSender.SendInvoice(invoice, correoDestino);
            }
            else
            {
                Console.WriteLine("Correo inválido. No se envió la factura.");
            }
        }
    }
}
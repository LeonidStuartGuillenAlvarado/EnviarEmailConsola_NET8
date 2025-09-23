
using EmailConsolaApp.Models;
using EmailConsolaApp.Services;

//ingreso de datos desde consola
int customerId;
while (true)
{
    Console.WriteLine("Ingrese el ID del cliente: ");
    if (int.TryParse(Console.ReadLine(), out customerId)) break;
    Console.WriteLine("ID invalido, intente de nuevo");
}

Console.WriteLine("Ingrese el nombre del cliente: ");
string customerName = Console.ReadLine();

double amount;
while (true)
{
    Console.WriteLine("Ingrese el monto de la factura: ");
    if (double.TryParse(Console.ReadLine(), out amount)) break;
    Console.WriteLine("Monto inválido, intente de nuevo.");
}

//id y fecha automatica
var invoice = new Invoice
{
    CustomerId = customerId,
    CustomerName = customerName,
    Amount = amount
};

//procesar fac
var Calcular = new InvoiceCalcular();
var Guardar = new InvoiceGuardarArchivo();
var Print = new InvoicePrint();

var Servicio = new InvoiceServicios(Calcular, Guardar, Print);
Servicio.ProcessInvoices(invoice);

//uso de email :p
Console.WriteLine("Ingrese el correo del cliente: ");
string? EmailDestino = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(EmailDestino))
{
    var emailSender = new InvoiceCorreo("aritansun@gmail.com", "opxw nxms isgx nrfz");
    emailSender.SendInvoice(invoice, EmailDestino);
}
else
{
    Console.WriteLine("Correo inválido. No se envió la factura.");
}
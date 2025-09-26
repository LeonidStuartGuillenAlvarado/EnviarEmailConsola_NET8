
using EmailConsolaApp.Models;
using EmailConsolaApp.Services;
using EmailConsolaApp.Pagos;

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

//preguntar metodo de pago
Console.WriteLine("\nSeleccione un método de pago: ");
Console.WriteLine("1. Tarjeta de crédito");
Console.WriteLine("2. Transferencia bancaria");
Console.WriteLine("3. PayPal");
Console.WriteLine(":");
PMetodoPago metodoPago = null;

switch (Console.ReadLine())
{ 
    case "1": metodoPago = new PTarjetaCredito(); invoice.metodoPago = "Tarjeta de crédito"; break;
    case "2": metodoPago = new PTransferencia(); invoice.metodoPago = "Transferencia"; break;
    case "3": metodoPago = new PPaypal(); invoice.metodoPago = "PayPal"; break;
    default: Console.WriteLine("Método de pago invalido");
    return;
}
//procesar pago
var procesador = new ProcesadorPagos();
procesador.Procesar((decimal)invoice.Amount, metodoPago);

var Servicio = new InvoiceServicios(Calcular, Guardar, Print);
Servicio.ProcessInvoices(invoice);

//uso de email :p
Console.WriteLine("Ingrese el correo del cliente: ");
string? EmailDestino = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(EmailDestino))
{
    //aqui debes ingresar tu correo electronico y contraseña de aplicaciones (busca un tutorial de youtube en mi readmi)
    var emailSender = new InvoiceCorreo("correo", "contraseña");
    emailSender.SendInvoice(invoice, EmailDestino);
}
else
{
    Console.WriteLine("Correo inválido. No se envió la factura.");
}
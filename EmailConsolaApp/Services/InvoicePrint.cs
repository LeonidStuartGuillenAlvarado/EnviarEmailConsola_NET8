//InvoicePrint.cs
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public class InvoicePrint
    {
        public void Print(Invoice invoice, double total)
        {
            Console.WriteLine("\n========= RESUMEN =========");
            Console.WriteLine(
                $"\nFactura #{invoice.Id}" +
                $"\nCliente: {invoice.CustomerName}" +
                $"\nID:{invoice.CustomerId}" +
                $"\nFecha de emosión: {invoice.IssueDate:g} " +
                $"\nMonto total: {invoice.Amount}" +
                $"\nTotal con IVA: {total}");
        }
    }
}

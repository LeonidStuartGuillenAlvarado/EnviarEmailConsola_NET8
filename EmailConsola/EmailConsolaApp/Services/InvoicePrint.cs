using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public class InvoicePrint
    {
        public void Print(Invoice invoice, double total)
        {
            Console.WriteLine($"Factura #{invoice.Id}" +
                $"Cliente: {invoice.CustomerName} - (ID:{invoice.CustomerId})" +
                $"Fecha de emosión: {invoice.IssueDate:g} - Monto total: {invoice.Amount}" +
                $"Total con IVA: {total}");
        }
    }
}

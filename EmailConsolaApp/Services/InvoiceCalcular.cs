//InvoiceCalcular.cs
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public class InvoiceCalcular
    {
        public double CalcularTasaTotal(Invoice invoice)
        {
            return invoice.Amount * 1.21;
        }
    }
}

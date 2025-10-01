//InvoiceGuardar.cs
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public interface InvoiceGuardar
    {
        void Save(Invoice invoice, double total);
    }
}

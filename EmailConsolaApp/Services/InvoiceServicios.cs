//InvoiceServicios.cs
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public class InvoiceServicios
    {
        private readonly InvoiceCalcular _calculare;
        private readonly InvoiceGuardar _guardare;
        private readonly InvoicePrint _imprimire;

        public InvoiceServicios(InvoiceCalcular calculare, InvoiceGuardar guardare, InvoicePrint imprimire) 
        {
            _calculare = calculare;
            _guardare = guardare;
            _imprimire = imprimire;
        }
        public void ProcessInvoices(Invoice invoice)
        {
            double total = _calculare.CalcularTasaTotal(invoice);
            _guardare.Save(invoice, total);
            _imprimire.Print(invoice, total);
        }
    }
}

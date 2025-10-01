//InvoiceBuilder.cs
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public class InvoiceBuilder
    {
        public Invoice CrearFactura(int customerId, string customerName, double amount)
        {
            // Validación
            if (customerId <= 0)
                throw new ArgumentException("ID del cliente no puede ser menor o igual a 0");

            if (string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentException("Nombre del cliente no puede estar vacío");

            if (amount <= 0)
                throw new ArgumentException("Monto debe ser mayor que 0");

            return new Invoice
            {
                CustomerId = customerId,
                CustomerName = customerName,
                Amount = amount
            };
        }
    }
}

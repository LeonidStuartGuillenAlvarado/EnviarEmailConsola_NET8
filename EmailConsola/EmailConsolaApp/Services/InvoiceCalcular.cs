using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

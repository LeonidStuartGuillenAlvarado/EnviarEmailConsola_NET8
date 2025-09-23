using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailConsolaApp.Models;

namespace EmailConsolaApp.Services
{
    public class InvoiceGuardarArchivo : InvoiceGuardar
    {
        private const string Archivo = "factura.txt";

        public void Save(Invoice invoice, double total)
        {
            string line = $"ID: {invoice.Id}\n ID CLIENTE: {invoice.CustomerId}" +
                $"\n CLIENTE: {invoice.CustomerName}\n MONTO: {invoice.Amount}\n IVA: {total}" +
                $"\n FECHA DE EMISIÓN: {invoice.IssueDate:g}";
            if (!File.Exists(Archivo) || !File.ReadAllLines(Archivo).Contains(line))
            {
                //el metodo de abajo hace que se forme un historial de facturas gracias a "appendalltext"
                //File.AppendAllText(Archivo, line + Environment.NewLine);

                //esto hace que cada vez que el programa sea ejecutado no exista un historial previo
                File.WriteAllText(Archivo, line + Environment.NewLine);
                Console.WriteLine("Factura Guardada");
            }
            else
            {
                Console.WriteLine("Factura ya existe");
            }
        }
    }
}

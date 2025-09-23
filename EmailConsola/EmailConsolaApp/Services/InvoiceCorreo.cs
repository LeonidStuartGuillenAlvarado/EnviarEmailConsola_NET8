using EmailConsolaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailConsolaApp.Services
{
    public class InvoiceCorreo
    {
        private readonly string _smtpServer = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private readonly string _fromEmail;
        private readonly string _password;

        public InvoiceCorreo(string fromEmail, string password)
        {
            _fromEmail = fromEmail;
            _password = password;
        }

        public void SendInvoice(Invoice invoice, string toEmail)
        {
            string archivo = "factura.txt";

            if (!File.Exists(archivo)) 
            {
                Console.WriteLine("no existe el archivo p causa");
                return;
            }

            MailMessage mail = new MailMessage(_fromEmail, toEmail);
            mail.Subject = $"Factura #{invoice.Id}";
            mail.Body = $"Hola {invoice.CustomerName}, adjuntamos su factura #{invoice.Id}";
            mail.Attachments.Add(new Attachment(archivo));

            SmtpClient client = new SmtpClient(_smtpServer, _smtpPort)
            {
                Credentials = new NetworkCredential(_fromEmail, _password),
                EnableSsl = true
            };

            try
            {
                client.Send(mail);
                Console.WriteLine("Factura enviada por email correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
    }

}

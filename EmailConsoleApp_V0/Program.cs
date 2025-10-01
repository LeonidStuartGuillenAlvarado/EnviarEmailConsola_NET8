using System;
using System.Security.Cryptography.X509Certificates;

namespace EmailConsoleAPP_V0
{
    class PromanPO
    {
        public int id { get; set; }
        public int clienteId { get; set; }
        public string name { get; set; }
        public double monto { get; set; }
        public string email { get; set; }
        public string metodopago { get; set; }

        

        public double calcular()
        {
            return monto * 1.21;
        }
        public void clienteDatos()
        {
            id = 1;
            clienteId = 1;
            name = "Leo";
            monto = 500;
            email = "Leo@gmail.com";
            metodopago = "Yape";
        }

        public void imprimir()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Cliente ID: " + clienteId);
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Monto: $" + monto);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Método de pago: " + metodopago);
            Console.WriteLine("Monto con IVA (21%): $" + calcular());

        }
        static void Main()
        {
            PromanPO pedido = new PromanPO();
            pedido.clienteDatos();
            pedido.imprimir();
        }

    }
}
//Invoice.cs
namespace EmailConsolaApp.Models
{
    public class Invoice
    {
        private static int _nextId = 1;
        public Invoice()
        {
            Id = _nextId++;
            IssueDate = DateTime.Now;
        }
        public int Id {get; set;}
        public int CustomerId {get; set;}
        public string CustomerName {get; set;}
        public double Amount { get; set; }
        public DateTime IssueDate { get; set; }
        public string metodoPago { get; set; }

    }
}

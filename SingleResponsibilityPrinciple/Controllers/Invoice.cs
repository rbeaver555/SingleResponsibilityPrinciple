public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string Requester { get; set; }
        public string RequesterEmail { get; set; }
        public bool IsActive { get; set; }
    }
public class Invoice
        {
            public int InvoiceNumber { get; set; }
            public decimal InvoiceAmount { get; set; }
            public string Requester { get; set; }
            public string RequesterEmail { get; set; }
            public bool IsActive { get; set; }

                public bool SendEmailNotificationForInvoice(Invoice invoice)
            {
                //send an email notification
                //try
                //{
                    //SMTPService service = new SMTPService()
                    //{
                    //    FromEmail = "noreply@srp.com",
                    //    Subject = "Your new invoice has been entered!",
                    //    Body = "Invoice Number 23243 has been....."
                    //};
                    //service.SendEmail();
                //}
                //catch(Exception ex)
                //{
                //    LogError(ex);
                //}

                return true;
            }
        }
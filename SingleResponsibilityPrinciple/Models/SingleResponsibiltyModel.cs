using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Models
{

    

    /// <summary>
    /// TODO: Find a home for this class. Ask yourself what does it actually do? What is it's purpose?
    /// Where should it live so multiple controllers can use it?
    /// </summary>
    public class InvoiceModel
    {
        public int InvoiceNumber { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string Requester { get; set; }
        public string RequesterEmail { get; set; }
        public bool IsActive { get; set; }
    }
    // this should be a model that lives with the other models
    
    



    public class SMTPService
    {
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool SendEmail()
        {
            //logic to send email here

            return true;
            // this should be 1. a model and 2. where all of the other email SMTP logic should live?
        }
    }
}

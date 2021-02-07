using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Controllers
{
    public class InvoiceController : Controller
    {
        public List<Invoice> _dbContext = new List<Invoice>();

        
        public IActionResult Index()
        {
            //try
            //{ 
                //return _dbContext.Where(invoice.IsActive);
            //}
            //catch(Exception ex)
            //{
            //    LogError(ex);
            //}

            //return _dbContext.Where(invoice.IsActive);
            return View();
        }

        public IActionResult AddInvoice(Invoice invoice)
        {
            //_dbContext.Add(invoice);
            //return _dbContext.Where(invoice.IsActive);

            //try
            //{ 
                //_dbContext.Add(invoice);
                //return _dbContext.Where(invoice.IsActive);
            //}
            //catch(Exception ex)
            //{
            //    LogError(ex);
            //}
            return View();
        }

        public IActionResult DeleteInvoice(Invoice invoice)
        {
            //try
            //{ 
                //_dbContext.Remove(invoice);
                //return _dbContext.Where(invoice.IsActive);
            //}
            //catch(Exception ex)
            //{
            //    LogError(ex);
            //}
            return View();
        }

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

        private void LogError()
        { 
            //log error here
        }

        public class Invoice
        {
            public int InvoiceNumber { get; set; }
            public decimal InvoiceAmount { get; set; }
            public string Requester { get; set; }
            public string RequesterEmail { get; set; }
            public bool IsActive { get; set; }
        }

    }
}

using SingleResponsibilityPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Helpers
{
    public class EmailHelper
    {
        public bool SendEmailNotificationForInvoice(Invoice invoice)
        {
            try
            {
                SMTPService service = new SMTPService()
                {
                    FromEmail = "noreply@srp.com",
                    Subject = "Your new invoice has been entered!",
                    Body = "Invoice Number 23243 has been....."
                };
                service.SendEmail();
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex);
                return false;
            }

            return true;
        }       
    }   
}

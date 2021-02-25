

using SingleResponsibilityPrinciple;

namespace EmailHelpers
{
    public class sendEmail
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
                LogError(ex);
                return false;
            }

            return true;
        }
    }
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
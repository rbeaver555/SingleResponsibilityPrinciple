using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Helpers
{
    public class SMTPService
    {
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool SendEmail()
        {
            //logic to send email here

            return true;
        }
    }
}

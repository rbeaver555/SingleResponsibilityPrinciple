using SingleResponsibilityPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Business
{
    public class CalculateSalesTax
    {

        public decimal CalculateTotalTaxOnInvoices(IEnumerable<Invoice> invoices)
        {
            decimal totalTax = 0;

            foreach(Invoice inv in invoices)
            {
                totalTax += inv.InvoiceAmount * .08M;
            }

            return totalTax;
        }

    }
}

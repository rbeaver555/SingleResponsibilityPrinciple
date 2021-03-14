using SingleResponsibilityPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Repository
{
    public class InvoiceDatabaseManager
    {
        public List<Invoice> _dbContext = new List<Invoice>();

        public IEnumerable<Invoice> GetAllActiveInvoices()
        {

            var activeInvoiceRecords = (from invoice in _dbContext
                                        where invoice.IsActive == true
                                        && invoice.InvoiceNumber > 0
                                        select invoice);

            return activeInvoiceRecords;
        }
    }
}

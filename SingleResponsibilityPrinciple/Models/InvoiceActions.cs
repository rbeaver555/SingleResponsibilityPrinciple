///using?????


namespace InvoiceActions
{
    class returnAllInvoices
    {
        public list[] activeInvoiceRecords( ??????)
        {
            list[] activeRecords = (from inv in _dbContext
                                    where invoice.IsActive == true
                                    && invoice.InvoiceNumber > 0
                                    select invoice);

            return activeRecords;
        }
    }


}
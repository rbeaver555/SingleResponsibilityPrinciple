using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceActions;
using InvoiceDefinition;

namespace SingleResponsibilityPrinciple.Controllers
{
    public class InvoiceController : Controller
    {
        public List<Invoice> _dbContext = new List<Invoice>();


        /// <summary>
        /// TODO: If the controller is an orchestrator, should it have the database logic within it? Is it doing more than one thing?
        /// If it is, where would you put the database logic, and how would the controller intract with it?
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            try
            {
                return (View(InvoiceActions.returnAllInvoices.activeInvoiceRecords(_dbContext)));
            }
            catch (Exception ex)
            {
                LogError(ex);
                return View();
            }
        }
        // the Index method seems way too busy. This should be a much more simple "show all method" this "IsActive" should be in the view?



        // all of the above needs to live somewhere else this controller is way too busy

        /// <summary>
        /// TODO: We have a small method here that loops over the exception and inner exceptions, throwing them to the console.
        /// What's it's real purpose? If my controller's job is to be an orchestrator does this belong here? If not here, where?
        /// Does this function do more than it should?
        /// </summary>
        /// <param name="exceptionToLog"></param>
        private void LogError(Exception exceptionToLog)
        {
            var currentException = exceptionToLog;

            while (currentException != null)
            {
                System.Diagnostics.Debug.WriteLine(currentException.Message);
                System.Diagnostics.Debug.WriteLine(currentException.StackTrace);

                currentException = currentException.InnerException;
            }
        }
        // should this be a Partial? this log error should like in it's own file which can be shared or as part of an Error collection

        /// <summary>
        /// TODO: Find a home for this class. Ask yourself what does it actually do? What is it's purpose?
        /// Where should it live so multiple controllers can use it?
        /// </summary>

        // this should be a model that lives with the other models
        /// <summary>
        /// TODO: Does this class do just one thing well? Should it live in the controller? If not the controller than where?
        /// </summary>

    }
}
}

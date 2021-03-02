using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Helpers;


namespace SingleResponsibilityPrinciple.Controllers
{


    public class InvoiceController : Controller
    {


        public static List<InvoiceModel> _dbContext = new  List<InvoiceModel>();
        /// <summary>
        /// TODO: If the controller is an orchestrator, should it have the database logic within it? Is it doing more than one thing?
        /// If it is, where would you put the database logic, and how would the controller interact with it?
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            try
            {
                var activeInvoiceRecords = (from invoice in _dbContext
                                            where invoice.IsActive == true
                                            && invoice.InvoiceNumber > 0
                                            select invoice);

                return View(activeInvoiceRecords);
            }
            catch (Exception ex)
            {
                LogError(ex);

                return View();
            }
        }

    }
}

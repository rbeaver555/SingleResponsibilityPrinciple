using Microsoft.AspNetCore.Mvc;
using SingleResponsibilityPrinciple.Helpers;
using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Controllers
{
    public class InvoiceController : Controller
    {
       
        /// <summary>
        /// TODO: If the controller is an orchestrator, should it have the database logic within it? Is it doing more than one thing?
        /// If it is, where would you put the database logic, and how would the controller intract with it?
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            try
            {
                InvoiceDatabaseManager invoiceDBManager = new InvoiceDatabaseManager();
                var activeInvoiceRecords = invoiceDBManager.GetAllActiveInvoices();

                return View(activeInvoiceRecords);
            }
            catch (Exception ex)
            {
                LogErrorHelper.LogError(ex); 

                return View();
            }            
        }                     
    }   
}

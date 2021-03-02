using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Helpers
{
    public class Helper
    {
        /// <summary>
        /// TODO: We have a small method here that loops over the exception and inner exceptions, throwing them to the console.
        /// What's it's real purpose? If my controller's job is to be an orchestrator does this belong here? If not here, where?
        /// Does this function do more than it should?
        /// </summary>
        /// <param name="exceptionToLog"></param>
        public static void LogError(Exception exceptionToLog)
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

    }
}

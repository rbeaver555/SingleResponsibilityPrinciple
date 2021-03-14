using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Helpers
{
    public class LogErrorHelper
    {
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
    }
}

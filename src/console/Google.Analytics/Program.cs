using System;
//using System.Collections.Generic;
using Google.Analytics.Analytics.Business;
using Google.Analytics.Business;
using Google.Analytics.Infrastructure;

namespace Google.Analytics
{
    class Program
    {
        //private static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                ConsoleConfigurations.Initialize(args);

                ExecuteMethodsByConfig();
            }
            catch (Exception ex)
            {
                //Logger.ErrorException(ex);
            }
        }

        private static void ExecuteMethodsByConfig()
        {
            if (ConsoleConfigurations.EnableDefaultMethods)
            {
                GoogleAnalytics.GetAndFill();
                BillingAnalytics.GetAndFill();
            }

            if (ConsoleConfigurations.EnableUserActivity)
            {
                UserActivityAnalytics.GetAndFill();
            }
        }

        private static bool IsDebug()
        {
#if DEBUG
            return true;
#else
            return false;
#endif
        }
    }
}
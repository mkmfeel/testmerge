using System;
using System.Collections.Generic;
using Moedelo.Google.Analytics.Business;
using Moedelo.Google.Analytics.Infrastructure;
using Moedelo.Infrastructure.Logging;
using Moedelo.MailServiceApi.Client;
using Moedelo.MailServiceApi.DataTransferObjects;

namespace Moedelo.Google.Analytics
{
    class Program
    {
        private static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                ConsoleConfigurations.Initialize(args);

                ExecuteMethodsByConfig();
            }
            catch (Exception ex)
            {
                using (var client = new MailApiClient())
                {
                    var adresses = IsDebug()
                        ? new List<string> { "yariktestip@mail.ru" }
                        : new List<string> {"d.vtorov@moedelo.org", "prohorov@moedelo.org", "lomov@moedelo.org"};
                    client.SendAsync(new EmailDto
                    {
                        Addresses = adresses,
                        Body = ex.Message,
                        IsBodyHtml = false,
                        Subject = "Google.Analytics console failed"
                    }).ConfigureAwait(false);
                }

                Logger.ErrorException(ex);
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
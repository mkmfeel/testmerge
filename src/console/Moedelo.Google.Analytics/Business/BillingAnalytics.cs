using Moedelo.Google.Analytics.Domain;
using Moedelo.Google.Analytics.Infrastructure;
using Moedelo.Infrastructure.Logging;

namespace Moedelo.Google.Analytics.Business
{
    public static class BillingAnalytics
    {
        static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        static readonly Dao Dao = new Dao();

        internal static void GetAndFill()
        {
            Logger.Info(string.Format("Start Billing! By date: {0}.", ConsoleConfigurations.DateRequest));

            var billings = Dao.GetBillingAnalyticsFromRpt();
            Dao.SaveBillingAnalytics(billings);

            Logger.Info(string.Format("Finish success Billing! By date: {0}.", ConsoleConfigurations.DateRequest));
        }
    }
}
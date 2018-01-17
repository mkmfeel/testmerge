using Google.Analytics.Analytics.Domain;
using Google.Analytics.Analytics.Infrastructure;

namespace Google.Analytics.Analytics.Business
{
    public static class BillingAnalytics
    {
        //static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        static readonly Dao Dao = new Dao();

        internal static void GetAndFill()
        {
            //Logger.Info(string.Format("Start Billing! By date: {0}.", ConsoleConfigurations.DateRequest));

            var billings = Dao.GetBillingAnalyticsFromRpt();
            Dao.SaveBillingAnalytics(billings);

            //Logger.Info(string.Format("Finish success Billing! By date: {0}.", ConsoleConfigurations.DateRequest));
        }
    }
}
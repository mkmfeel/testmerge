using Google.Analytics.Analytics.Client;
using Google.Analytics.Analytics.Domain;
using Google.Analytics.Analytics.Infrastructure;
using Google.Analytics.Mapping;
using Google.Analytics.Model.Ga.Dimensions;

namespace Google.Analytics.Analytics.Business
{
    public static class GoogleAnalytics
    {
        //static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        static readonly Mapper Mapper = new Mapper();
        static readonly Dao Dao = new Dao();

        internal static void GetAndFill()
        {
            var dateRequest = ConsoleConfigurations.DateRequest;

            //Logger.Info(string.Format("Start GA! By date: {0}.", dateRequest));

            PerformAnalyticsOne();
            PerformAnalyticsTwo();
            PerformAnalyticsThree();
            PerformAnalyticsFour();

            //Logger.Info(string.Format("Finish success GA! By date: {0}.", dateRequest));
        }

        private static void PerformAnalyticsOne()
        {
            var analyticsOne = AnalyticsClient<DimensionsOne>.GetData();
            var bufferDicClients = Mapper.MapOne(analyticsOne);
            Dao.SaveAnalyticsOne(bufferDicClients);
        }

        private static void PerformAnalyticsTwo()
        {
            var analyticsTwo = AnalyticsClient<DimensionsTwo>.GetData();
            var fctSessions = Mapper.MapTwo(analyticsTwo);
            Dao.SaveAnalyticsTwo(fctSessions);
        }

        private static void PerformAnalyticsThree()
        {
            var analyticsThree = AnalyticsClient<DimensionsThree>.GetData();
            var fctSessionChannels = Mapper.MapThree(analyticsThree);
            Dao.SaveAnalyticsThree(fctSessionChannels);
        }

        private static void PerformAnalyticsFour()
        {
            var analyticsFour = AnalyticsClient<DimensionsFour>.GetData();
            var fctSessionHitses = Mapper.MapFour(analyticsFour);
            Dao.SaveAnalyticsFour(fctSessionHitses);
        }
    }
}
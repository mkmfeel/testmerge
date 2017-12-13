using System;
using System.Collections.Generic;
using System.Configuration;
using Google.Apis.Analytics.v3;
using Moedelo.Google.Analytics.Infrastructure;
using Moedelo.Google.Analytics.Model.Ga.Dimensions;

namespace Moedelo.Google.Analytics.Client
{
    public static class AnalyticsClient<T> where T : DimensionsBase
    {
        private const int MaxResultsInRequest = 10000;

        private static readonly string Dimensions;
        private static readonly string Metrics;
        private static readonly string Filters;
        private static readonly string Sort;
        private static List<IList<string>> Rows = new List<IList<string>>();

        static AnalyticsClient()
        {
            var instance = (DimensionsBase)Activator.CreateInstance(typeof(T));
            Dimensions = instance.GetDimension();
            Metrics = instance.GetMetrics();
            Filters = instance.GetFilters();
            Sort = instance.GetSort();
        }

        internal static IList<IList<string>> GetData()
        {
            var initializer = GaInitializerFactory.CreateGaInitializer();

            using (var service = new AnalyticsService(initializer))
            {
                var totalCount = MaxResultsInRequest;
                for (var indx = 1; indx < totalCount; )
                {
                    var rows = GetPartion(service, ref indx, ref totalCount);
                    Rows.AddRange(rows);
                }

                return Rows;
            }
        }

        private static IEnumerable<IList<string>> GetPartion(AnalyticsService service, ref int indx, ref int totalCount)
        {
            var response = CreateRequest(service, indx).Execute();
            var totalResults = response.TotalResults;

            if (!totalResults.HasValue)
            {
                throw new Exception("TotalResults is null in Google Analytics response.");
            }

            totalCount = totalResults.Value;
            if (indx < totalCount)
            {
                indx += MaxResultsInRequest;
            }

            var rows = response.Rows;
            if (rows == null)
            {
                throw new Exception("Rows not found in Google Analytics response.");
            }

            return rows;
        }

        private static DataResource.GaResource.GetRequest CreateRequest(AnalyticsService service, int indx)
        {
            var analyticId = GetAnalitycsId();
            var dateRequest = GetDateRequest();

            var request = service.Data.Ga.Get(analyticId, dateRequest, dateRequest, Metrics);
            request.StartIndex = indx;
            request.Dimensions = Dimensions;
            request.MaxResults = MaxResultsInRequest;
            request.Filters = Filters;
            request.Sort = Sort;

            return request;
        }

        private static string GetAnalitycsId()
        {
            return ConsoleConfigurations.EnableUserActivity 
                ? ConfigurationManager.AppSettings["UserActivityAnalyticId"]
                : ConfigurationManager.AppSettings["AccountAnalyticId"];
        }

        private static string GetDateRequest()
        {
            int daysBefore = ConsoleConfigurations.DaysBefore;
            const string dateFormat = "yyyy-MM-dd";
            return ConsoleConfigurations.DateRequest.AddDays(daysBefore).ToString(dateFormat);
        }
    }
}
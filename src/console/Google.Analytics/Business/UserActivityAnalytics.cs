using System;
using System.Collections.Generic;
using Google.Analytics.Additions;
using Google.Analytics.Analytics.Client;
using Google.Analytics.Analytics.Domain;
using Google.Analytics.Infrastructure;
using Google.Analytics.Mapping;
using Google.Analytics.Model.Ga.Dimensions.UserActivity;

namespace Google.Analytics.Business
{
    /// <summary>Забор данных по поведению пользователя</summary>
    public static class UserActivityAnalytics
    {
        //private static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        private static readonly Dao DataAccess = new Dao();

        internal static void GetAndFill()
        {
            var dateRequest = ConsoleConfigurations.DateRequest;

            var infoString = $"Start GA UserActivity! By date: {dateRequest}.";
            //Logger.Info(infoString);
            Console.WriteLine(infoString);

            ProccessReportWithPages();
            ProccessReportWithConvertions();
            ProccessReportWithUserId();
            ProccessReportWithCompanyId();
            ProccessReportWithAccountRegDate();
            ProccessReportWithProduct();
            ProccessReportWithTariff();
            ProccessReportWithEmployees();
            ProccessReportWithPaymentDate();
            ProccessReportWithSessionType();

            //Logger.Info($"Finish success GA UserActivity! By date: {dateRequest}.");
        }

        private static void ProccessReportWithPages()
        {
            //Logger.Info("Start GA ProccessReportWithPages");

            var reportWithPages = AnalyticsClient<DimensionsReportWithPages>.GetData();
            var mappedReportWithPages = UserActivityMapper.MapReportiWithPageses(reportWithPages);
            SaveReport(mappedReportWithPages);

            //Logger.Info($"End GA ProccessReportWithPages: count={mappedReportWithPages.Count}.");
        }

        private static void ProccessReportWithConvertions()
        {
            //Logger.Info("Start GA ProccessReportWithConvertions");

            var reportWithConvertions = AnalyticsClient<DimensionsReportWithConversions>.GetData();
            var mappedReportWithConvertions = UserActivityMapper.MapReportWithConversions(reportWithConvertions);
            SaveReport(mappedReportWithConvertions);

            //Logger.Info($"End GA ProccessReportWithConvertions: count={reportWithConvertions.Count}.");
        }

        private static void ProccessReportWithUserId()
        {
            //Logger.Info("Start GA ProccessReportWithUserId");

            var reportWithUserId = AnalyticsClient<DimensionsReportWithUserId>.GetData();
            var mappedReportWithUserId = UserActivityMapper.MapReportWithUserId(reportWithUserId);
            SaveReport(mappedReportWithUserId);

            //Logger.Info($"End GA ProccessReportWithUserId: count={mappedReportWithUserId.Count}.");
        }

        private static void ProccessReportWithCompanyId()
        {
            //Logger.Info("Start GA ProccessReportWithCompanyId");

            var reportWithCompanyId = AnalyticsClient<DimensionsReportWithCompanyId>.GetData();
            var mappedReportWithCompanyId = UserActivityMapper.MapReportWithCompaynyId(reportWithCompanyId);
            SaveReport(mappedReportWithCompanyId);

            //Logger.Info($"End GA ProccessReportWithCompanyId: count={mappedReportWithCompanyId.Count}.");
        }

        private static void ProccessReportWithAccountRegDate()
        {
            //Logger.Info("Start GA ProccessReportWithAccountRegDate");

            var reportWithAccountRegDate = AnalyticsClient<DimensionsReportWithAccountRegDate>.GetData();
            var mappedReportWithAccountRegDate = UserActivityMapper.MapReportWithAccountRegDate(reportWithAccountRegDate);
            SaveReport(mappedReportWithAccountRegDate);

            //Logger.Info($"End GA ProccessReportWithAccountRegDate: count={mappedReportWithAccountRegDate.Count}.");
        }

        private static void ProccessReportWithProduct()
        {
            //Logger.Info("Start GA ProccessReportWithProduct");

            var reportWithProduct = AnalyticsClient<DimensionsReportWithProduct>.GetData();
            var mappedReportWithProduct = UserActivityMapper.MapReportWithProduct(reportWithProduct);
            SaveReport(mappedReportWithProduct);

            //Logger.Info($"End GA ProccessReportWithProduct: count={mappedReportWithProduct.Count}.");
        }

        private static void ProccessReportWithTariff()
        {
            //Logger.Info("Start GA ProccessReportWithTariff");

            var reportWithTariff = AnalyticsClient<DimensionsReportWithTariff>.GetData();
            var mappedReportWithTariff = UserActivityMapper.MapReportWithTariff(reportWithTariff);
            SaveReport(mappedReportWithTariff);

            //Logger.Info($"End GA ProccessReportWithTariff: count={mappedReportWithTariff.Count}.");
        }

        private static void ProccessReportWithEmployees()
        {
            //Logger.Info("Start GA ProccessReportWithEmployees");

            var reportWithEmployees = AnalyticsClient<DimensionsReportWithEmployees>.GetData();
            var mappedReportWithEmployees = UserActivityMapper.MapReportWithEmployees(reportWithEmployees);
            SaveReport(mappedReportWithEmployees);

            //Logger.Info($"End GA ProccessReportWithEmployees: count={mappedReportWithEmployees.Count}.");
        }

        private static void ProccessReportWithPaymentDate()
        {
            //Logger.Info("Start GA ProccessReportWithPaymentDate");

            var reportWithPaymentDate = AnalyticsClient<DimensionsReportWithPaymentDate>.GetData();
            var mappedReportWithPaymentDate = UserActivityMapper.MapReportWithPaymentDate(reportWithPaymentDate);
            SaveReport(mappedReportWithPaymentDate);

            //Logger.Info($"End GA ProccessReportWithPaymentDate: count={mappedReportWithPaymentDate.Count}.");
        }

        private static void ProccessReportWithSessionType()
        {
            string infoStringStart = "Start GA ProccessReportWithSessionType";
            //Logger.Info(infoStringStart);
            Console.WriteLine(infoStringStart);

            var reportWithSessionType = AnalyticsClient<DimensionsReportWithSessionType>.GetData();
            var mappedReportWithSessionType = UserActivityMapper.MapReportWithSessionType(reportWithSessionType);
            SaveReport(mappedReportWithSessionType);

            string infoStringEnd = $"End GA ProccessReportWithSessionType: count={mappedReportWithSessionType.Count}.";
            //Logger.Info(infoStringEnd);
            Console.WriteLine(infoStringEnd);
        }

        private static void SaveReport<T>(List<T> data) where T:class
        {
            if (data == null)
            {
                //Logger.Info($"Null data for saving {typeof(T).Name}");
                return;
            }

            DataAccess.SaveUserActvity(data);

#if DEBUG
            var fileSaver = new ResultDataFileSaver<T>();
            fileSaver.SaveDataToFile(data);
#endif
        }
    }
}
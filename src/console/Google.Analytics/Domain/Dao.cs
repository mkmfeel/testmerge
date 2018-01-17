using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Resources;
using Google.Analytics.Model.BillingAnalytics;
using Google.Analytics.Model.Ga.Entity;

namespace Google.Analytics.Analytics.Domain
{
    internal class Dao
    {
        //private readonly IDbConnectionFactory gaConnectionFactory = new GaDbFactory();      // new LocalTestConnectionFactory(); для профилирования ошибок в запросах
        //readonly IDbConnectionFactory billingConnectionFactory = new BillingDbFactory();
        //readonly IDbConnectionFactory rptConnectionFactory = new RptDbFactory();

        internal void SaveAnalyticsOne(List<BufferDicClient> bufferDicClients)
        {
            //using (var connection = gaConnectionFactory.CreateConnection())
            //{
            //    connection.ExecuteQuery(SqlRecources.InsertBufferDicClient, bufferDicClients);
            //}
        }

        internal void SaveAnalyticsTwo(List<BufferFctSession> bufferDicClients)
        {
            //using (var connection = gaConnectionFactory.CreateConnection())
            //{
            //    connection.ExecuteQuery(SqlRecources.InsertBufferFctSession, bufferDicClients);
            //}
        }

        public void SaveAnalyticsThree(List<BufferFctSessionChannel> bufferDicClients)
        {
            //using (var connection = gaConnectionFactory.CreateConnection())
            //{
            //    connection.ExecuteQuery(SqlRecources.InsertBufferFctSessionChannel, bufferDicClients);
            //}
        }

        public void SaveAnalyticsFour(List<BufferFctSessionHits> bufferDicClients)
        {
            //using (var connection = gaConnectionFactory.CreateConnection())
            //{
            //    connection.ExecuteQuery(SqlRecources.InsertBufferFctSessionHits, bufferDicClients);
            //}
        }

        public List<BufferFctBilling> GetBillingAnalyticsFromRpt()
        {
            //using (var connection = rptConnectionFactory.CreateConnection())
            //{
            //    return connection.ExecuteStoredProcedureFor<BufferFctBilling>("integration.GetBillingAnalyticsToGa", new
            //    {
            //        regStart = ConsoleConfigurations.DateRequest.AddMonths(-3),
            //        regEnd = ConsoleConfigurations.DateRequest
            //    }, 600).ToList();
            //}
            return new List<BufferFctBilling>();
        }

        public void SaveBillingAnalytics(List<BufferFctBilling> bufferFctBillings)
        {
            //using (var connection = billingConnectionFactory.CreateConnection())
            //{
            //    connection.ExecuteQuery("truncate table DWH_BUFFER_BILLING.dbo.BUFFER_FCT_BILLING;", null);
            //    connection.ExecuteQuery(SqlRecources.InsertBufferFctBilling, bufferFctBillings);
            //}
        }

        public void SaveUserActvity<T>(List<T> userActivityToSave)
        {
            const int batchCount = 1000;
            var rm = new ResourceManager(".Google.Analytics.Domain.Sql.SqlRecources", GetType().Assembly);
            string reportName = typeof (T).Name;

            string infoString = $"Try save {reportName}";
            //Logger.Info(infoString);
            Console.WriteLine(infoString);

            string sqlQuery = rm.GetString($"Insert{reportName}");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //using (var connection = gaConnectionFactory.CreateConnection())
            //{
            //    for (int skipCount = 0; skipCount < userActivityToSave.Count; skipCount += batchCount)
            //    {
            //        var tempList = userActivityToSave.Skip(skipCount).Take(batchCount);
            //        connection.ExecuteQuery(sqlQuery, tempList);
            //    }
            //}

            stopwatch.Stop();
            infoString = $"Saving {reportName} time elapsed {stopwatch.Elapsed}";
            //Logger.Info(infoString);
            Console.WriteLine(infoString);
        }
    }
}
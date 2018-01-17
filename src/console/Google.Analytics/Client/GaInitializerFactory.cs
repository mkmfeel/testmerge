using System;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;

namespace Google.Analytics.Analytics.Client
{
    public static class GaInitializerFactory
    {
        //static readonly ILogger Logger = LoggerManager.GetCurrentClassLogger();

        private const string ClientId = "108493017696-b1pkohril2urdl0kit2artuv3433h0b7@developer.gserviceaccount.com";

        public static BaseClientService.Initializer CreateGaInitializer()
        {
            string[] scopes =
            {
                AnalyticsService.Scope.Analytics,
                AnalyticsService.Scope.AnalyticsManageUsers
            };

            var certificate = GetX509Certificate2();

            var initializer = new ServiceAccountCredential.Initializer(ClientId)
            {
                Scopes = scopes,
                User = "mdanalytic@gmail.com"
            }.FromCertificate(certificate);

            var credential = new ServiceAccountCredential(initializer);

            return new BaseClientService.Initializer
            {
                ApplicationName = "Analytics of Moe Delo",
                HttpClientInitializer = credential
            };
        }

        private static X509Certificate2 GetX509Certificate2()
        {
            var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            var collection = store.Certificates;
            return collection.Find(X509FindType.FindBySerialNumber, "6A884892B3DE3174", false)[0];
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            //finally
            //{
            //    store.Close();
            //}
        }
    }
}
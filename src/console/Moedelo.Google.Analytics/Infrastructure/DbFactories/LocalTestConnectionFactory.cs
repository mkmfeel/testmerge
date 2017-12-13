using System.Data;
using System.Data.SqlClient;
using Moedelo.Infrastructure.Query;
using Moedelo.Settings;

namespace Moedelo.Google.Analytics.Infrastructure.DbFactories
{
    public class LocalTestConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var rptConnectionString = SettingsHelper.Instance.GetSetting("ConnectionString");
            return new SqlConnection(rptConnectionString);
        }
    }
}
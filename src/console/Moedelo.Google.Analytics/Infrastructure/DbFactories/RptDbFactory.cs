using System.Data;
using System.Data.SqlClient;
using Moedelo.Infrastructure.Query;
using Moedelo.Settings;

namespace Moedelo.Google.Analytics.Infrastructure.DbFactories
{
    public class RptDbFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var rptConnectionString = SettingsHelper.Instance.GetSetting("ReadOnlyConnectionString");
            return new SqlConnection(rptConnectionString);
        }
    }
}
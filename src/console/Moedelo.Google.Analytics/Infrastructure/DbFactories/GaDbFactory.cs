using System.Data;
using System.Data.SqlClient;
using Moedelo.Infrastructure.Query;
using Moedelo.Settings;

namespace Moedelo.Google.Analytics.Infrastructure.DbFactories
{
    public class GaDbFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(SettingsHelper.Instance.GetSetting("ConnectionStringGa"));
        }
    }
}
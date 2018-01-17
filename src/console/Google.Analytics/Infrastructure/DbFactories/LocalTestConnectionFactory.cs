using System.Data;
using System.Data.SqlClient;

namespace Google.Analytics.Infrastructure.DbFactories
{
    public class LocalTestConnectionFactory //: IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var rptConnectionString = "ConnectionString";//SettingsHelper.Instance.GetSetting("ConnectionString");
            return new SqlConnection(rptConnectionString);
        }
    }
}
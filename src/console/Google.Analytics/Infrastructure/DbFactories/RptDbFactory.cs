using System.Data;
using System.Data.SqlClient;

namespace Google.Analytics.Infrastructure.DbFactories
{
    public class RptDbFactory //: IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var rptConnectionString = "ReadOnlyConnectionString";//SettingsHelper.Instance.GetSetting("ReadOnlyConnectionString");
            return new SqlConnection(rptConnectionString);
        }
    }
}
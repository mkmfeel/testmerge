using System.Data;
using System.Data.SqlClient;

namespace Google.Analytics.Infrastructure.DbFactories
{
    public class BillingDbFactory// : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection("ConnectionStringBilling");
            //return new SqlConnection(SettingsHelper.Instance.GetSetting("ConnectionStringBilling"));
        }
    }
}
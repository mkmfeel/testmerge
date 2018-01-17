using System.Data;
using System.Data.SqlClient;

namespace Google.Analytics.Infrastructure.DbFactories
{
    public class GaDbFactory// : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection("ConnectionStringGa");
            //return new SqlConnection(SettingsHelper.Instance.GetSetting("ConnectionStringGa"));
        }
    }
}
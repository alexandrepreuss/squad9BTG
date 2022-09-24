using Squad9.Client.API.Infra.Contracts;
using System.Data;
using System.Data.SqlClient;

namespace Squad9.Client.API.Infra.Factories
{
    public class DBConnectionFactory : IDBConnectionFactory
    {

        public IDbConnection Create()
        {
            return new SqlConnection("Server=squad9db.cluster-cvpksv55zfzp.us-east-1.rds.amazonaws.com;User ID=admin;Password=squad9DB;Database=squad9db");
        }

    }
}

using Squad9.Client.API.Entities;
using Squad9.Client.API.Infra.Contracts;
using Squad9.Client.API.Infra.Repositories.Contracts;
using System.Data.SqlClient;

namespace Squad9.Client.API.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IDBConnectionFactory _dBConnectionFactory;

        public ClientRepository(IDBConnectionFactory connectionFactory)
        {
            _dBConnectionFactory = connectionFactory;
        }
        public ClientEntities GetDividas(Guid cliente)
        {
            return new ClientEntities();
        }

         ClientEntities IClientRepository.GetClient(Guid cliente)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "<your_server.database.windows.net>";
            builder.UserID = "<your_username>";
            builder.Password = "<your_password>";
            builder.InitialCatalog = "<your_database>";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();

                String sql = "SELECT * FROM db.Cliete Where Id= @Id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    return new ClientEntities();



                }
            }
        }
    }
}

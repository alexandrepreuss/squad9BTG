using Squad9.Client.API.Entities;
using Squad9.Client.API.Infra.Contracts;
using Squad9.Client.API.Infra.Repositories.Contracts;
using System.Data.SqlClient;

namespace Squad9.Client.API.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IDBConnectionFactory _dBConnectionFactory;

        
    }
}

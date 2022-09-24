using Squad9.Client.API.Entities;
using Squad9.Client.API.Infra.Contracts;
using Squad9.Client.API.Infra.Repositories.Contracts;

namespace Squad9.Client.API.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IDBConnectionFactory _dBConnectionFactory;

        public ClientRepository(IDBConnectionFactory connectionFactory)
        {
            _dBConnectionFactory = connectionFactory;
        }
        public IEnumerable<ClientEntities> GetDividas(Guid cliente)
        {
            var sql = $"SELECT * FROM Cliente WHERE CPF = $Cpf ";
            using (var cn =  _dBConnectionFactory.Create())
            {
                cn.CreateCommand().ExecuteReader();
            }
        }
    }
}

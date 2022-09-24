using System.Data;

namespace Squad9.Client.API.Infra.Contracts
{
    public interface IDBConnectionFactory
    {
        IDbConnection Create();
    }
}

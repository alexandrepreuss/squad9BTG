using Squad9.Client.API.Entities;

namespace Squad9.Client.API.Infra.Repositories.Contracts
{
    public interface IClientRepository
    {
        IEnumerable<ClientEntities> GetDividas(Guid cliente);
    }
}

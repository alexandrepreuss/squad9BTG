using Squad9.Client.API.Entities;

namespace Squad9.Client.API.Application.Contracts
{
    public interface IClientAplication
    {
        IEnumerable<ClientEntities> GetDividasById(Guid cliente);
    }
}

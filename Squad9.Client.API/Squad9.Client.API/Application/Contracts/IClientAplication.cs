using Squad9.Client.API.Entities;

namespace Squad9.Client.API.Application.Contracts
{
    public interface IClientAplication
    {
        ClientEntities GetDividasById(Guid cliente);
    }
}

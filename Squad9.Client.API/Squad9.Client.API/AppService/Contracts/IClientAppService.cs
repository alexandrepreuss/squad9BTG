using Squad9.Client.API.Entities;

namespace Squad9.Client.API.AppService.Contracts
{
    public interface IClientAppService
    {
        ClientEntities GetDividas(Guid client);
    }
}

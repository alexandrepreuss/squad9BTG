using Squad9.Client.API.Application;
using Squad9.Client.API.Application.Contracts;
using Squad9.Client.API.AppService.Contracts;
using Squad9.Client.API.Entities;

namespace Squad9.Client.API.AppService
{
    public class ClientAppService : IClientAppService
    {
        private IClientAplication _dividaApplication;
        
        public ClientEntities GetDividas(Guid dadosClient)
        {
            return _dividaApplication.GetDividasById(dadosClient);
        }
    }
}

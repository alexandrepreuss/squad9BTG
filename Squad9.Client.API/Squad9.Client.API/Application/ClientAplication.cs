using Squad9.Client.API.Application.Contracts;
using Squad9.Client.API.Entities;
using Squad9.Client.API.Infra.Repositories.Contracts;

namespace Squad9.Client.API.Application
{
    public class ClientAplication : IClientAplication
    {
        private IClientRepository _clientRepository;
        
        public IEnumerable<ClientEntities> GetDividasById(Guid cliente)
        {
            return _clientRepository.GetDividas(cliente);
        }
    }
}

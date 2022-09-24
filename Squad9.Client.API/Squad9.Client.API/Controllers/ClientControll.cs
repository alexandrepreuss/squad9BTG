using Microsoft.AspNetCore.Mvc;
using Squad9.Client.API.AppService.Contracts;
using Squad9.Client.API.Entities;

namespace Squad9.Client.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientControll : ControllerBase
    {
        public IClientAppService _clientAppService;

        [HttpGet(Name = "Pega Dividas")]
        public IEnumerable<ClientEntities> Get(Guid client)
        {
            return _clientAppService.GetDividas(client);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Squad9.Dividas;

namespace Squad9.Entidade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntidadeController : ControllerBase
    {
        private readonly ILogger<EntidadeController> _logger;

        public EntidadeController(ILogger<EntidadeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Pega Lista de Entidades")]
        public List<EntidadeEntitie> GetList()
        {
            return new List<EntidadeEntitie>();
        }
    }
}
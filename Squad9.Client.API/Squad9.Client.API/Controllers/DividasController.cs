using Microsoft.AspNetCore.Mvc;
using Squad9.Client.API.AppService.Contracts;
using Squad9.Client.API.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Squad9.Client.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DividasController : ControllerBase
    {
        private IDividaAppService _dividaAppService;

        // GET: api/<DividasController>
        [HttpGet]
        public List<DadosDividasEntities> Get()
        {
            return _dividaAppService.GetDividasList();
        }

        // GET api/<DividasController>/5
        [HttpGet("{id}")]
        public DadosDividasEntities Get(int id)
        {
            return _dividaAppService.GetDividaById(id);
        }

        // POST api/<DividasController>
        [HttpPost]
        public Task<string> Post([FromBody] AcordoFinanceiraEntities acordo)
        {
            var result = _dividaAppService.CreateAcordo(acordo);
            return result;
        }

        // PUT api/<DividasController>/5
        [HttpGet("{id}")]
        public void Get(int id, [FromBody] string value)
        {
        }
    }
}

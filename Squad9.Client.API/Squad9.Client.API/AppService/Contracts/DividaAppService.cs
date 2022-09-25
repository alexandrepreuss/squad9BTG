using Squad9.Client.API.Entities;

namespace Squad9.Client.API.AppService.Contracts
{
    public class DividaAppService : IDividaAppService
    {
        public Task<string> CreateAcordo(AcordoFinanceiraEntities acordo)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateRespostaAcordo(AcordoFinanceiraEntities acordo)
        {
            throw new NotImplementedException();
        }

        public DadosDividasEntities GetDividaById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<DadosDividasEntities> GetDividasList()
        {
            throw new NotImplementedException();
        }
    }
}

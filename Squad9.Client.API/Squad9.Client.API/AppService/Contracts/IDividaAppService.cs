using Squad9.Client.API.Entities;

namespace Squad9.Client.API.AppService.Contracts
{
    public interface IDividaAppService
    {
        List<DadosDividasEntities> GetDividasList();

        DadosDividasEntities GetDividaById(int Id);

        Task<string> CreateAcordo(AcordoFinanceiraEntities acordo);

        Task<string> CreateRespostaAcordo(AcordoFinanceiraEntities acordo);
    }
}

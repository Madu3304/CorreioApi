using CorreioApi.Integracao.Response;
using Refit;

namespace CorreioApi.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}json")]
        Task<ApiResponse<ViaCep_Response>> ObterDadosViaCepp(string cep);
    }
}



using CorreioApi.Integracao.Response;

namespace CorreioApi.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {

        Task<ViaCep_Response> ObterDadosViaCep(string cep);

    }
}

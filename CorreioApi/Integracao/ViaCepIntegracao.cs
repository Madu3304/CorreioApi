using CorreioApi.Integracao.Refit;
using CorreioApi.Integracao.Response;
using CorreioApi.Integracao.Interfaces;

namespace CorreioApi.Integracao
{
    public class ViaCepIntegracao
    {
        //injecao de dependencia 
        public readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;

        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }

        public async Task<ViaCep_Response> ObterDadosViaCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCepp(cep);

            if(responseData == null && responseData.IsSuccessStatusCode)
            {

                return responseData.Content;
            }

            return null;
        }
    }
}

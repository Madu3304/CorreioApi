using CorreioApi.Integracao;
using CorreioApi.Integracao.Interfaces;
using CorreioApi.Integracao.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorreioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cep_Controller : ControllerBase
    {

        private readonly IViaCepIntegracao _viaCepIntegracao;

        public Cep_Controller(IViaCepIntegracao viaCepIntegracao)
        {
            _viaCepIntegracao = viaCepIntegracao;
        }


        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCep_Response>> ListarDadosEndereco(string cep)
        {
            var responseData = await _viaCepIntegracao.ObterDadosViaCep(cep);
            
            if(responseData == null)
            {
                return BadRequest("CEP não localizado");
            }

            return Ok(responseData);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MsBairro.Dtos;
using MsBairro.Services.Interfaces;

namespace MsBairro.Controllers
{
    public class BairroController : Controller
    {
        private readonly IServiceBairro _serviceBairro;
        public BairroController(IServiceBairro serviceBairro)
        {
            _serviceBairro = serviceBairro;
        }
        [HttpPost("/api/AdicionarBairro")]
        public async Task<IActionResult> AdicionarBairro([FromBody] BairroDto bairroDto)
        {
            try
            {
                var result = await this._serviceBairro.AddBairro(bairroDto);

                if (!result) return BadRequest("Ocorreu um erro interno ao adicionar o bairro.");

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

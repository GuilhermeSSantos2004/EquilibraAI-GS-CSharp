using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaTrabalhoApi.Controllers
{
    [ApiController]
    [Route("api/v1/foco")]
    public class FocoController : ControllerBase
    {
        private readonly IFocoService _service;

        public FocoController(IFocoService service)
        {
            _service = service;
        }

        [HttpPost("iniciar")]
        public async Task<IActionResult> Iniciar([FromBody] string usuarioId)
        {
            var sessao = await _service.IniciarAsync(usuarioId);
            return Created("", sessao);
        }

        [HttpPost("finalizar")]
        public async Task<IActionResult> Finalizar([FromBody] string usuarioId)
        {
            await _service.FinalizarAsync(usuarioId);
            return NoContent();
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> Ciclos(string usuarioId)
        {
            var ciclos = await _service.ListarConcluidosAsync(usuarioId);
            return Ok(ciclos);
        }
    }
}

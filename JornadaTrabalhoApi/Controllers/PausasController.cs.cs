using JornadaTrabalhoApi.Models;
using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaTrabalhoApi.Controllers
{
    [ApiController]
    [Route("api/v1/pausas")]
    public class PausasController : ControllerBase
    {
        private readonly IPausaService _service;

        public PausasController(IPausaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Registrar([FromBody] Pausa pausa)
        {
            var criado = await _service.RegistrarAsync(pausa);
            return Created("", criado);
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> Listar(string usuarioId)
        {
            var pausas = await _service.ListarPorUsuarioAsync(usuarioId);
            return Ok(pausas);
        }
    }
}

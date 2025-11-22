using JornadaTrabalhoApi.Models;
using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaTrabalhoApi.Controllers
{
    [ApiController]
    [Route("api/v1/humor")]
    public class HumorController : ControllerBase
    {
        private readonly IHumorService _service;

        public HumorController(IHumorService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Registrar([FromBody] HumorRegistro registro)
        {
            var result = await _service.RegistrarAsync(registro);
            return Created("", result);
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> Historico(string usuarioId)
        {
            var registros = await _service.ListarPorUsuarioAsync(usuarioId);
            return Ok(registros);
        }
    }
}

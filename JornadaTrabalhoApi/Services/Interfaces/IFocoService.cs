using JornadaTrabalhoApi.Models;

namespace JornadaTrabalhoApi.Services.Interfaces
{
    public interface IFocoService
    {
        Task<FocoSessao> IniciarAsync(string usuarioId);
        Task FinalizarAsync(string usuarioId);
        Task<IEnumerable<FocoSessao>> ListarConcluidosAsync(string usuarioId);
    }
}

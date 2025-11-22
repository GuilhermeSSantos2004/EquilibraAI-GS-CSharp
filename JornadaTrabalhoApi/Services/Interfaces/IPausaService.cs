using JornadaTrabalhoApi.Models;

namespace JornadaTrabalhoApi.Services.Interfaces
{
    public interface IPausaService
    {
        Task<Pausa> RegistrarAsync(Pausa pausa);
        Task<IEnumerable<Pausa>> ListarPorUsuarioAsync(string usuarioId);
    }
}

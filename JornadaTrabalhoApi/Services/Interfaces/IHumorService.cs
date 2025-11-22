using JornadaTrabalhoApi.Models;

namespace JornadaTrabalhoApi.Services.Interfaces
{
    public interface IHumorService
    {
        Task<HumorRegistro> RegistrarAsync(HumorRegistro humor);
        Task<IEnumerable<HumorRegistro>> ListarPorUsuarioAsync(string usuarioId);
    }
}

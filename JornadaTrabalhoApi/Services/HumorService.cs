using JornadaTrabalhoApi.Data;
using JornadaTrabalhoApi.Models;
using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JornadaTrabalhoApi.Services
{
    public class HumorService : IHumorService
    {
        private readonly JornadaContext _context;

        public HumorService(JornadaContext context)
        {
            _context = context;
        }

        public async Task<HumorRegistro> RegistrarAsync(HumorRegistro humor)
        {
            humor.Id = Guid.NewGuid();
            humor.DataRegistro = DateTime.UtcNow;

            _context.Humores.Add(humor);
            await _context.SaveChangesAsync();
            return humor;
        }

        public async Task<IEnumerable<HumorRegistro>> ListarPorUsuarioAsync(string usuarioId)
        {
            return await _context.Humores
                .Where(h => h.UsuarioId == usuarioId)
                .OrderByDescending(h => h.DataRegistro)
                .ToListAsync();
        }
    }
}

using JornadaTrabalhoApi.Data;
using JornadaTrabalhoApi.Models;
using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JornadaTrabalhoApi.Services
{
    public class PausaService : IPausaService
    {
        private readonly JornadaContext _context;

        public PausaService(JornadaContext context)
        {
            _context = context;
        }

        public async Task<Pausa> RegistrarAsync(Pausa pausa)
        {
            pausa.Id = Guid.NewGuid();
            pausa.Inicio = DateTime.UtcNow;

            _context.Pausas.Add(pausa);
            await _context.SaveChangesAsync();
            return pausa;
        }

        public async Task<IEnumerable<Pausa>> ListarPorUsuarioAsync(string usuarioId)
        {
            return await _context.Pausas
                .Where(p => p.UsuarioId == usuarioId)
                .OrderByDescending(p => p.Inicio)
                .ToListAsync();
        }
    }
}

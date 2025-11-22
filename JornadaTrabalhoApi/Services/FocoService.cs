using JornadaTrabalhoApi.Data;
using JornadaTrabalhoApi.Models;
using JornadaTrabalhoApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JornadaTrabalhoApi.Services
{
    public class FocoService : IFocoService
    {
        private readonly JornadaContext _context;

        public FocoService(JornadaContext context)
        {
            _context = context;
        }

        public async Task<FocoSessao> IniciarAsync(string usuarioId)
        {
            var sessao = new FocoSessao
            {
                UsuarioId = usuarioId,
                Inicio = DateTime.UtcNow,
                Concluida = false
            };

            _context.Focos.Add(sessao);
            await _context.SaveChangesAsync();
            return sessao;
        }

        public async Task FinalizarAsync(string usuarioId)
        {
            var sessao = await _context.Focos
                .Where(f => f.UsuarioId == usuarioId && !f.Concluida)
                .OrderByDescending(f => f.Inicio)
                .FirstOrDefaultAsync();

            if (sessao == null)
                throw new Exception("Nenhuma sessão de foco em andamento.");

            sessao.Fim = DateTime.UtcNow;
            sessao.Concluida = true;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FocoSessao>> ListarConcluidosAsync(string usuarioId)
        {
            return await _context.Focos
                .Where(f => f.UsuarioId == usuarioId && f.Concluida)
                .OrderByDescending(f => f.Inicio)
                .ToListAsync();
        }
    }
}

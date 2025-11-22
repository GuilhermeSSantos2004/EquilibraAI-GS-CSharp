using JornadaTrabalhoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JornadaTrabalhoApi.Data
{
    public class JornadaContext : DbContext
    {
        public JornadaContext(DbContextOptions<JornadaContext> options) : base(options)
        {
        }

        // 👇 ADICIONA ISSO AQUI
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                    "Host=db.vjnpannrribdfoxewiyd.supabase.co;Port=5432;Database=postgres;Username=postgres;Password=hxdtoWLuReZzlRlQ"
                );
            }
        }

        public DbSet<Pausa> Pausas { get; set; } = default!;
        public DbSet<HumorRegistro> Humores { get; set; } = default!;
        public DbSet<FocoSessao> Focos { get; set; } = default!;
    }
}

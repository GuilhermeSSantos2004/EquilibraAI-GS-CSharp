using System;

namespace JornadaTrabalhoApi.Models
{
    public class FocoSessao
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UsuarioId { get; set; } = default!;
        public DateTime Inicio { get; set; } = DateTime.UtcNow;
        public DateTime? Fim { get; set; }
        public bool Concluida { get; set; } = false;
    }
}

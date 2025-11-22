namespace JornadaTrabalhoApi.Models
{
    public class Pausa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UsuarioId { get; set; } = default!;
        public DateTime Inicio { get; set; } = DateTime.UtcNow;
        public DateTime? Fim { get; set; }
        public string? Tipo { get; set; }         
        public string? Observacao { get; set; }
    }
}

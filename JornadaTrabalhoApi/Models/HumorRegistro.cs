namespace JornadaTrabalhoApi.Models
{
    public class HumorRegistro
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UsuarioId { get; set; } = default!;
        public DateTime DataRegistro { get; set; } = DateTime.UtcNow;
        public string Humor { get; set; } = default!;   
        public string? Observacao { get; set; }
    }

}
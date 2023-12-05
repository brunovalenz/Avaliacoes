namespace Avaliacoes.App.Models
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public string? Avaliacao2 { get; set; }
        public DateTime? DataAvaliacao { get; set; }
        public int IdMidia { get; set; }
        public string? Midia { get; set; }

    }
}

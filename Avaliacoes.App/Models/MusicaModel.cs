namespace Avaliacoes.App.Models
{
    public class MusicaModel
    {
        public int Id { get; set; }
        public string? Artista { get; set; }
        public int? Duracao { get; set; }
        public int IdMidia { get; set; }
        public string? Titulo { get; set; }
        public int? AnoLancamento { get; set; }
        public string? Descricao { get; set; }
        public string? Classificacao { get; set; }
    }
}

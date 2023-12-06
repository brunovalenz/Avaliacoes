namespace Avaliacoes.App.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string? Autor { get; set; }
        public int? TotalPag { get; set; }
        public int IdMidia { get; set; }
        public string? Titulo { get; set; }
        public int? AnoLancamento { get; set; }
        public string? Descricao { get; set; }
        public string? Classificacao { get; set; }

    }
}

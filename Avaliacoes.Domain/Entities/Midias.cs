using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Midias : BaseEntity<int>
    {
        public Midias()
        {

        }

        public Midias(int id, string titulo, int? anoLancamento, string? descricao, string? classificacao) : base(id)
        {
            Titulo = titulo;
            AnoLancamento = anoLancamento;
            Descricao = descricao;
            Classificacao = classificacao;
        }

        public string? Titulo { get; set; }
        public int? AnoLancamento { get; set; }
        public string? Descricao { get; set; }
        public string? Classificacao { get; set; }

    }
}
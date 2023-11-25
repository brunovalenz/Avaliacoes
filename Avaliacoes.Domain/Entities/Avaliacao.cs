using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Avaliacao : BaseEntity<int>
    {
        public Avaliacao()
        {

        }

        public Avaliacao(int id, Midias? midia, float? nota, string? avaliacao, DateTime? dataAvaliacao) : base(id)
        {
            Midia = midia;
            Nota = nota;
            Avaliacao2 = avaliacao;
            DataAvaliacao = dataAvaliacao;
        }

        public Midias? Midia { get; set; }
        public float? Nota { get; set; }
        public string? Avaliacao2 { get; set; }
        public DateTime? DataAvaliacao { get; set; }
    }
}
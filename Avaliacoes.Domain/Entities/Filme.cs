using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Filme : BaseEntity<int>
    {
        public Filme()
        {

        }

        public Filme(int id, Midia? midia, string? diretor, int? duracao) : base(id)
        {
            Midia = midia;
            Diretor = diretor;
            Duracao = duracao;
        }

        public Midia? Midia { get; set; }
        public string? Diretor { get; set; }
        public int? Duracao { get; set; }
    }
}
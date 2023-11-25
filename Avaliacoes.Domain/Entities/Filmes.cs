using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Filmes : BaseEntity<int>
    {
        public Filmes()
        {

        }

        public Filmes(int id, Midias? midia, String? diretor, int? duracao) : base(id)
        {
            Midia = midia;
            Diretor = diretor;
            Duracao = duracao;
        }

        public Midias? Midia { get; set; }
        public string? Diretor { get; set; }
        public int? Duracao { get; set; }
    }
}
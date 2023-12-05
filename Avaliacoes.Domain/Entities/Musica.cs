using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Musica : BaseEntity<int>
    {
        public Musica()
        {

        }

        public Musica(int id, Midia? midia, string? artista, int? duracao) : base(id)
        {
            Midia = midia;
            Artista = artista;
            Duracao = duracao;
        }

        public Midia? Midia { get; set; }
        public string? Artista { get; set; }
        public int? Duracao { get; set; }
    }
}
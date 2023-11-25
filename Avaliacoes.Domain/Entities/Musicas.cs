using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Musicas : BaseEntity<int>
    {
        public Musicas()
        {

        }

        public Musicas(int id, Midias? midia, string? artista, int? duracao) : base(id)
        {
            Midia = midia;
            Artista = artista;
            Duracao = duracao;
        }

        public Midias? Midia { get; set; }
        public string? Artista { get; set; }
        public int? Duracao { get; set; }
    }
}
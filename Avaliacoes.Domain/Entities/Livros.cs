using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Livros : BaseEntity<int>
    {
        public Livros()
        {

        }

        public Livros(int id, Midias? midia, string? autor, int? totalPag) : base(id)
        {
            Midia = midia;
            Autor = autor;
            TotalPag = totalPag;
        }

        public Midias? Midia { get; set; }
        public string? Autor { get; set; }
        public int? TotalPag { get; set; }
    }
}
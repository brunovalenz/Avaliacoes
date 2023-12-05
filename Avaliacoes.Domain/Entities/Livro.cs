using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Livro : BaseEntity<int>
    {
        public Livro()
        {

        }

        public Livro(int id, Midia? midia, string? autor, int? totalPag) : base(id)
        {
            Midia = midia;
            Autor = autor;
            TotalPag = totalPag;
        }

        public Midia? Midia { get; set; }
        public string? Autor { get; set; }
        public int? TotalPag { get; set; }
    }
}
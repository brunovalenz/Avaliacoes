using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Series : BaseEntity<int>
    {
        public Series()
        {

        }

        public Series(int id, Midias? midia, string? diretor, int? qntEps) : base(id)
        {
            Midia = midia;
            Diretor = diretor;
            QntEps = qntEps;
        }

        public Midias? Midia { get; set; }
        public string? Diretor { get; set; }
        public int? QntEps { get; set; }
    }
}
using Avaliacoes.Domain.Base;

namespace Avaliacoes.Domain.Entities
{
    public class Serie : BaseEntity<int>
    {
        public Serie()
        {

        }

        public Serie(int id, Midia? midia, string? diretor, int? qntEps) : base(id)
        {
            Midia = midia;
            Diretor = diretor;
            QntEps = qntEps;
        }

        public Midia? Midia { get; set; }
        public string? Diretor { get; set; }
        public int? QntEps { get; set; }
    }
}
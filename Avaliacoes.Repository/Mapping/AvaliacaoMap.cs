using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");

            builder.HasKey(prop => prop.Id);

            builder.HasKey(prop => prop.Midia);

            builder.HasKey(prop => prop.Nota);

            builder.Property(prop => prop.Avaliacao2);

            builder.Property(prop => prop.DataAvaliacao);
        }
    }
}

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

            builder.Property(prop => prop.Nota);

            builder.Property(prop => prop.Avaliacao2)
                .HasColumnType("text");

            builder.Property(prop => prop.DataAvaliacao)
                .HasDefaultValue(DateTime.Now);

            builder.HasOne(prop => prop.Midia);

        }
    }
}
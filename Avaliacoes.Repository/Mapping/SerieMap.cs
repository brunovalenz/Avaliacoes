using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class SerieMap : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            builder.ToTable("Serie");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Diretor)
                .HasColumnType("varchar(127)");

            builder.Property(prop => prop.QntEps);

            builder.HasOne(prop => prop.Midia);
        }
    }
}
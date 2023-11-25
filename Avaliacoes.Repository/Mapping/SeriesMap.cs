using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class SeriesMap : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.ToTable("Series");

            builder.HasKey(prop => prop.Id);

            builder.HasKey(prop => prop.Midia);

            builder.Property(prop => prop.Diretor)
                .HasColumnType("varchar(127)");

            builder.Property(prop => prop.QntEps);
        }
    }
}

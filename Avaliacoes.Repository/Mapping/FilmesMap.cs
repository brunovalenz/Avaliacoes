using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class FilmesMap : IEntityTypeConfiguration<Filmes>
    {
        public void Configure(EntityTypeBuilder<Filmes> builder)
        {
            builder.ToTable("Filmes");

            builder.HasKey(prop => prop.Id);

            builder.HasKey(prop => prop.Midia);

            builder.Property(prop => prop.Diretor)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Duracao);
        }
    }
}

using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class MusicasMap : IEntityTypeConfiguration<Musicas>
    {
        public void Configure(EntityTypeBuilder<Musicas> builder)
        {
            builder.ToTable("Musicas");

            builder.HasKey(prop => prop.Id);

            builder.HasKey(prop => prop.Midia);

            builder.Property(prop => prop.Artista)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Duracao);
        }
    }
}

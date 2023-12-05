using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class MusicaMap : IEntityTypeConfiguration<Musica>
    {
        public void Configure(EntityTypeBuilder<Musica> builder)
        {
            builder.ToTable("Musica");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Artista)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Duracao);

            builder.HasOne(prop => prop.Midia);
        }
    }
}
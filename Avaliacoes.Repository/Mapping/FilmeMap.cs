using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Diretor)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Duracao);

            builder.HasOne(prop => prop.Midia);
        }
    }
}
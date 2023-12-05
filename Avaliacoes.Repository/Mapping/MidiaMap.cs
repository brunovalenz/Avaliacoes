using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class MidiaMap : IEntityTypeConfiguration<Midia>
    {
        public void Configure(EntityTypeBuilder<Midia> builder)
        {
            builder.ToTable("Midia");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .HasColumnType("varchar(200)");

            builder.Property(prop => prop.AnoLancamento);

            builder.Property(prop => prop.Descricao)
                .HasColumnType("text");

            builder.Property(prop => prop.Classificacao)
                .HasColumnType("varchar(20)");
        }
    }
}
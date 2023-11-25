using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class MidiasMap : IEntityTypeConfiguration<Midias>
    {
        public void Configure(EntityTypeBuilder<Midias> builder)
        {
            builder.ToTable("Midias");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.AnoLancamento);

            builder.Property(prop => prop.Descricao);

            builder.Property(prop => prop.Classificacao)
                .HasColumnType("varchar(15)");
        }
    }
}

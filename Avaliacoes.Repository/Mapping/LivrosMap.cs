using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class LivrosMap : IEntityTypeConfiguration<Livros>
    {
        public void Configure(EntityTypeBuilder<Livros> builder)
        {
            builder.ToTable("Livros");

            builder.HasKey(prop => prop.Id);

            builder.HasKey(prop => prop.Midia);

            builder.Property(prop => prop.Autor)
                .HasColumnType("varchar(127)");

            builder.Property(prop => prop.TotalPag);
        }
    }
}

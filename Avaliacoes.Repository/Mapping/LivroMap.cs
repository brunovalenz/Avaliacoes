using Avaliacoes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacoes.Repository.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Autor)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.TotalPag);

            builder.HasOne(prop => prop.Midia);
        }
    }
}
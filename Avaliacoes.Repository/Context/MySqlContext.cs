using Avaliacoes.Domain.Entities;
using Avaliacoes.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace Avaliacoes.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Midia>? Midia { get; set; }
        public DbSet<Filme>? Filme { get; set; }
        public DbSet<Musica>? Musica { get; set; }
        public DbSet<Livro>? Livro { get; set; }
        public DbSet<Serie>? Serie { get; set; }
        public DbSet<Avaliacao>? Avaliacao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Midia>(new MidiaMap().Configure);
            modelBuilder.Entity<Filme>(new FilmeMap().Configure);
            modelBuilder.Entity<Musica>(new MusicaMap().Configure);
            modelBuilder.Entity<Livro>(new LivroMap().Configure);
            modelBuilder.Entity<Serie>(new SerieMap().Configure);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);

        }
    }
}
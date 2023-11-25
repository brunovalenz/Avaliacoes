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

        public DbSet<Midias>? Midias { get; set; }
        public DbSet<Filmes>? Filmes { get; set; }
        public DbSet<Musicas>? Musicas { get; set; }
        public DbSet<Livros>? Livros { get; set; }
        public DbSet<Series>? Series { get; set; }
        public DbSet<Avaliacao>? Avaliacao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Midias>(new MidiasMap().Configure);
            modelBuilder.Entity<Filmes>(new FilmesMap().Configure);
            modelBuilder.Entity<Musicas>(new MusicasMap().Configure);
            modelBuilder.Entity<Livros>(new LivrosMap().Configure);
            modelBuilder.Entity<Series>(new SeriesMap().Configure);
            modelBuilder.Entity<Avaliacao>(new AvaliacaoMap().Configure);
        }
    }
}

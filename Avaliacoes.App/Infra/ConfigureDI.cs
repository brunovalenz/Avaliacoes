using AutoMapper;
using Avaliacoes.App.Cadastros;
using Avaliacoes.App.Models;
using Avaliacoes.App.Outros;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Repository.Context;
using Avaliacoes.Repository.Repository;
using Avaliacoes.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Avaliacoes.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Midias>, BaseRepository<Midias>>();
            Services.AddScoped<IBaseRepository<Filmes>, BaseRepository<Filmes>>();
            Services.AddScoped<IBaseRepository<Musicas>, BaseRepository<Musicas>>();
            Services.AddScoped<IBaseRepository<Livros>, BaseRepository<Livros>>();
            Services.AddScoped<IBaseRepository<Series>, BaseRepository<Series>>();
            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();

            // Services
            Services.AddScoped<IBaseService<Midias>, BaseService<Midias>>();
            Services.AddScoped<IBaseService<Filmes>, BaseService<Filmes>>();
            Services.AddScoped<IBaseService<Musicas>, BaseService<Musicas>>();
            Services.AddScoped<IBaseService<Livros>, BaseService<Livros>>();
            Services.AddScoped<IBaseService<Series>, BaseService<Series>>();
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();

            // Formulários
            Services.AddTransient<NovaAvaliacao, NovaAvaliacao>();
            Services.AddTransient<CadastroFilmes, CadastroFilmes>();
            Services.AddTransient<CadastroMusicas, CadastroMusicas>();
            Services.AddTransient<CadastroLivros, CadastroLivros>();
            Services.AddTransient<CadastroSeries, CadastroSeries>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Midias, MidiasModel>();
                config.CreateMap<Filmes, FilmesModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.Midias, d => d.MapFrom(x => x.Midia!.Id));
                config.CreateMap<Musicas, MusicasModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.Midias, d => d.MapFrom(x => x.Midia!.Id));
                config.CreateMap<Livros, LivrosModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.Midias, d => d.MapFrom(x => x.Midia!.Id));
                config.CreateMap<Series, SeriesModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.Midias, d => d.MapFrom(x => x.Midia!.Id));

                config.CreateMap<Avaliacao, AvaliacaoModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.Midias, d => d.MapFrom(x => x.Midia!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}

using AutoMapper;
using Avaliacoes.App.Cadastros;
using Avaliacoes.App.Models;
//using Avaliacoes.App.Outros;
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
                var strCon = File.ReadAllText("../../../Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Midia>, BaseRepository<Midia>>();
            Services.AddScoped<IBaseRepository<Filme>, BaseRepository<Filme>>();
            Services.AddScoped<IBaseRepository<Musica>, BaseRepository<Musica>>();
            Services.AddScoped<IBaseRepository<Livro>, BaseRepository<Livro>>();
            Services.AddScoped<IBaseRepository<Serie>, BaseRepository<Serie>>();
            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();

            // Services
            Services.AddScoped<IBaseService<Midia>, BaseService<Midia>>();
            Services.AddScoped<IBaseService<Filme>, BaseService<Filme>>();
            Services.AddScoped<IBaseService<Musica>, BaseService<Musica>>();
            Services.AddScoped<IBaseService<Livro>, BaseService<Livro>>();
            Services.AddScoped<IBaseService<Serie>, BaseService<Serie>>();
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();

            // Formulários
            Services.AddTransient<CadastroFilme, CadastroFilme>();
            Services.AddTransient<CadastroMusica, CadastroMusica>();
            Services.AddTransient<CadastroLivro, CadastroLivro>();
            Services.AddTransient<CadastroSerie, CadastroSerie>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Midia, MidiaModel>();

                config.CreateMap<Filme, FilmeModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id));

                config.CreateMap<Musica, MusicaModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id));

                config.CreateMap<Livro, LivroModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id));

                config.CreateMap<Serie, SerieModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id));

                config.CreateMap<Avaliacao, AvaliacaoModel>()
                    .ForMember(d => d.Midia, d => d.MapFrom(x => $"{x.Midia!.Titulo}/{x.Midia!.AnoLancamento}/{x.Midia!.Descricao}/{x.Midia!.Classificacao}"))
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
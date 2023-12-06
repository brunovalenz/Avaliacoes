using AutoMapper;
using Avaliacoes.App.Cadastros;
using Avaliacoes.App.Models;
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
            Services.AddTransient<FormPrincipal, FormPrincipal>();

            Services.AddTransient<CadastroFilme, CadastroFilme>();
            Services.AddTransient<CadastroMusica, CadastroMusica>();
            Services.AddTransient<CadastroLivro, CadastroLivro>();
            Services.AddTransient<CadastroSerie, CadastroSerie>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Midia, MidiaModel>();

                config.CreateMap<Filme, FilmeModel>()
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id))
                    .ForMember(d => d.Titulo, d => d.MapFrom(x => x.Midia!.Titulo))
                    .ForMember(d => d.AnoLancamento, d => d.MapFrom(x => x.Midia!.AnoLancamento))
                    .ForMember(d => d.Descricao, d => d.MapFrom(x => x.Midia!.Descricao))
                    .ForMember(d => d.Classificacao, d => d.MapFrom(x => x.Midia!.Classificacao));

                config.CreateMap<Musica, MusicaModel>()
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id))
                    .ForMember(d => d.Titulo, d => d.MapFrom(x => x.Midia!.Titulo))
                    .ForMember(d => d.AnoLancamento, d => d.MapFrom(x => x.Midia!.AnoLancamento))
                    .ForMember(d => d.Descricao, d => d.MapFrom(x => x.Midia!.Descricao))
                    .ForMember(d => d.Classificacao, d => d.MapFrom(x => x.Midia!.Classificacao));

                config.CreateMap<Livro, LivroModel>()
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id))
                    .ForMember(d => d.Titulo, d => d.MapFrom(x => x.Midia!.Titulo))
                    .ForMember(d => d.AnoLancamento, d => d.MapFrom(x => x.Midia!.AnoLancamento))
                    .ForMember(d => d.Descricao, d => d.MapFrom(x => x.Midia!.Descricao))
                    .ForMember(d => d.Classificacao, d => d.MapFrom(x => x.Midia!.Classificacao));

                config.CreateMap<Serie, SerieModel>()
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id))
                    .ForMember(d => d.Titulo, d => d.MapFrom(x => x.Midia!.Titulo))
                    .ForMember(d => d.AnoLancamento, d => d.MapFrom(x => x.Midia!.AnoLancamento))
                    .ForMember(d => d.Descricao, d => d.MapFrom(x => x.Midia!.Descricao))
                    .ForMember(d => d.Classificacao, d => d.MapFrom(x => x.Midia!.Classificacao));

                config.CreateMap<Avaliacao, AvaliacaoModel>()
                    .ForMember(d => d.Titulo, d => d.MapFrom(x => x.Midia!.Titulo))
                    .ForMember(d => d.IdMidia, d => d.MapFrom(x => x.Midia!.Id));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
﻿using System.Text.Json;
using AutoMapper;
using Avaliacoes.Domain.Base;
using Avaliacoes.Repository.Context;
using Avaliacoes.Repository.Repository;
using Avaliacoes.Service.Services;
using Avaliacoes.Domain.Base;
using Avaliacoes.Domain.Entities;
using Avaliacoes.Repository.Context;
using Avaliacoes.Repository.Repository;
using Avaliacoes.Service.Services;
using Avaliacoes.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Avaliacoes.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;


        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "1122";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Usuario, Usuario>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario()
        {
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Murilo",
                Login = "MuriloVarges",
                Email = "murilo@mail.com",
                Senha = "123",
                DataCadastro = DateTime.Now,
                DataLogin = DateTime.Now
            };

            var result = _userService?.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}

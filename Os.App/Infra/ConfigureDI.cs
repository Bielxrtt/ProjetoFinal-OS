using AutoMapper;
using IFSPStore.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Os.Domain.Base;
using Os.Domain.Entities;
using Os.Repository.Context;

using System;
using System.IO;

// Alias para evitar conflito com "Service" do .NET
using ServiceEntity = Os.Domain.Entities.Services;

namespace Os.App.Infra
{
    public class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            // Configuração do banco
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);

            services = new ServiceCollection();

            services.AddDbContext<OsContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(strCon);
            });

            #region Repositories
            services.AddScoped<IBaseRepository<Client>, BaseRepository<Client>>();
            services.AddScoped<IBaseRepository<Device>, BaseRepository<Device>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<ServiceEntity>, BaseRepository<ServiceEntity>>();
            services.AddScoped<IBaseRepository<ServiceOrder>, BaseRepository<ServiceOrder>>();
            services.AddScoped<IBaseRepository<Status>, BaseRepository<Status>>();
            services.AddScoped<IBaseRepository<UserSystem>, BaseRepository<UserSystem>>();
            #endregion

            #region Services
            // Nenhum serviço registrado por enquanto (não há classes concretas)
            #endregion

            #region AutoMapper
            services.AddSingleton(
                new MapperConfiguration(cfg =>
                {
                    // Adicione mapeamentos aqui se necessário
                },
                NullLoggerFactory.Instance).CreateMapper()
            );
            #endregion

            serviceProvider = services.BuildServiceProvider();
        }
    }
}

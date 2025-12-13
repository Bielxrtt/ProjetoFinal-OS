using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Os.App.Others;
using Os.Domain.Base;
using Os.Domain.Entities;
using Os.Repository.Context;
using Os.Repository.Repository;
using Os.Service.Service;
using System;
using System.IO;
using ServiceEntity = Os.Domain.Entities.Services;

namespace Os.App.Infra
{
    public class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {

            string dbConfigFile = @"C:\Os\DbConfig.txt";

            if (!File.Exists(dbConfigFile))
            {
                dbConfigFile = "Config/DBConfig.txt";
            }

            if (!File.Exists(dbConfigFile))
            {
                throw new FileNotFoundException($"O arquivo de configuração do banco não foi encontrado em: {Path.GetFullPath(dbConfigFile)}. Crie a pasta C:\\Os\\ e coloque o arquivo DbConfig.txt lá.");
            }

            var strCon = File.ReadAllText(dbConfigFile);

            services = new ServiceCollection();


            services.AddDbContext<OsContext>(options =>
            {
                options.LogTo(Console.WriteLine);

                options.UseMySQL(strCon);
            });



            #region Repositories

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));


            services.AddScoped<IBaseRepository<Client>, BaseRepository<Client>>();
            services.AddScoped<IBaseRepository<Device>, BaseRepository<Device>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<ServiceEntity>, BaseRepository<ServiceEntity>>();
            services.AddScoped<IBaseRepository<ServiceOrder>, BaseRepository<ServiceOrder>>();
            services.AddScoped<IBaseRepository<Status>, BaseRepository<Status>>();
            services.AddScoped<IBaseRepository<UserSystem>, BaseRepository<UserSystem>>();
            #endregion

            #region Services

            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            #endregion

            #region Forms
            services.AddTransient<Login, Login>();
            #endregion

            #region AutoMapper
            services.AddSingleton(
                new MapperConfiguration(cfg =>
                {

                },
                NullLoggerFactory.Instance).CreateMapper()
            );
            #endregion


            serviceProvider = services.BuildServiceProvider();
        }
    }
}
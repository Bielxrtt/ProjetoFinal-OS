using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Os.App.Others;
using Os.App.Register;
using Os.App.ViewModel;
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
            // 1. Configuração do Banco de Dados
            string dbConfigFile = @"C:\Os\DbConfig.txt";

            if (!File.Exists(dbConfigFile))
            {
                dbConfigFile = "Config/DBConfig.txt";
            }

            if (!File.Exists(dbConfigFile))
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "DBConfig.txt");
                if (File.Exists(path)) dbConfigFile = path;
            }

            var strCon = File.Exists(dbConfigFile) ? File.ReadAllText(dbConfigFile) : "Server=localhost;Database=Os;Uid=root;Pwd=;";

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
            services.AddTransient<Login>();
            services.AddTransient<UserSystemForm>();
            services.AddTransient<ClientForm>();
            services.AddTransient<DeviceForm>();
            services.AddTransient<ProductForm>();
            services.AddTransient<ServiceForm>();
            services.AddTransient<StatusForm>();
            services.AddTransient<Os.App.Register.ServiceForm>();
            #endregion

            #region AutoMapper Configuração Explícita
            // Definindo a configuração separadamente para evitar erro de construtor
            var mapperConfig = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<UserSystem, UserSystemViewModel>().ReverseMap();
                cfg.CreateMap<Client, ClientViewModel>().ReverseMap();
                cfg.CreateMap<Product, ProductViewModel>().ReverseMap();
                cfg.CreateMap<ServiceEntity, ServicesViewModel>().ReverseMap();
                cfg.CreateMap<Status, StatusViewModel>().ReverseMap();

                cfg.CreateMap<Device, DeviceViewModel>()
                   .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Client.Name));
                cfg.CreateMap<DeviceViewModel, Device>();

                cfg.CreateMap<ServiceOrder, ServiceOrderViewModel>().ReverseMap();
            });

            // Cria o IMapper a partir da configuração
            IMapper mapper = mapperConfig.CreateMapper();

            // Registra o IMapper no sistema
            services.AddSingleton(mapper);
            #endregion

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
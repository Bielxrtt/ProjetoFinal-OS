using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Os.Domain.Entities;
using Os.Domain.Enum;
using Os.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Os.Test
{
    [TestClass]
    public sealed class TestRepository
    {
        [TestMethod]
        public void TestServiceOrder()
        {
            var op = new DbContextOptionsBuilder<OsContext>();
            op.UseMySQL("server=localhost;database=Os_Testes;uid=root;pwd=");

            using (var context = new OsContext(op.Options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Console.WriteLine("Connected and Database Recreated!");
                var statusAberto = new Status
                {
                    Name = "Aberto",
                    Description = "OS Iniciada",
                    StartDate = DateTime.Now,
                    FinishDate = DateTime.Now.AddDays(1)
                };

                var statusFechado = new Status
                {
                    Name = "Fechado",
                    Description = "OS Finalizada",
                    StartDate = DateTime.Now,
                    FinishDate = DateTime.Now.AddDays(5)
                };

                context.Statuses.Add(statusAberto);
                context.Statuses.Add(statusFechado);
                context.SaveChanges();
                var userAdmin = new UserSystem
                {
                    Password = "123",
                    AcessLevel = "Admin",
                    Status = statusAberto,
                    ServiceOrders = new List<ServiceOrder>(),
                    Services = new List<Services>()
                };

                context.UserSystems.Add(userAdmin);
                context.SaveChanges();
                var client = new Client
                {
                    Name = "Gabriel Silva",
                    Phone = "11999998888",
                    Email = "gabriel@email.com",
                    Adress = "Rua Teste, 123",
                    Register_Date = DateTime.Now,
                    IdDevice = null,
                    ServiceOrders = new List<Services>()
                };

                context.Clients.Add(client);
                context.SaveChanges();
                var device = new Device
                {
                    Model = "iPhone 13",
                    IMEI = "111222333",
                    Type = "Smartphone",
                    TypeBrand = TypeBrand.Apple,
                    ServiceOrders = new List<Services>(),
                    Client = client
                };

                context.Devices.Add(device);
                context.SaveChanges();
                client.Device = device;
                context.Clients.Update(client);
                context.SaveChanges();

                Console.WriteLine("Dependencies Insert done!");

                var os1 = new ServiceOrder
                {
                    Price = 150.00M,
                    Note = "Troca de Tela",
                    Status = statusAberto,
                    User = userAdmin,
                    Client = client,
                    Device = device,
                    Services = new List<ServiceOrder_has_Service>(),
                    Products = new List<Products_has_ServiceOrder>()
                };

                var os2 = new ServiceOrder
                {
                    Price = 300.00M,
                    Note = "Reparo Placa",
                    Status = statusFechado,
                    User = userAdmin,
                    Client = client,
                    Device = device,
                    Services = new List<ServiceOrder_has_Service>(),
                    Products = new List<Products_has_ServiceOrder>()
                };

                context.ServiceOrders.Add(os1);
                context.ServiceOrders.Add(os2);
                context.SaveChanges();

                Console.WriteLine("ServiceOrder Insert done!");

                var jsonOptions = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                var orders = context.ServiceOrders
                                    .Include(o => o.Client)
                                    .Include(o => o.Device)
                                    .Include(o => o.Status);

                foreach (var order in orders)
                {
                    Console.WriteLine(JsonSerializer.Serialize(order, jsonOptions));
                }

                Console.WriteLine("List Done!");
            }
        }
    }
}
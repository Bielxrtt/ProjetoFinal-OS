using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Os.Domain.Entities;
using Os.Domain.Enum;
using Os.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Os.Test
{
    [TestClass]
    public class IntegrationTest
    {
        
        private const string ConnectionString = "server=localhost;database=Os_Testes;uid=root;pwd=";

        [TestInitialize]
        public void Setup()
        {
            try
            {
                using (var context = GetRealContext())
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"Erro ao conectar no MySQL: {ex.Message}. Verifique se o serviço está rodando.");
            }
        }

        private OsContext GetRealContext()
        {
            var options = new DbContextOptionsBuilder<OsContext>()
                .UseMySQL(ConnectionString)
                .LogTo(Console.WriteLine)
                .Options;

            return new OsContext(options);
        }

        [TestMethod]
        public void Deve_Salvar_No_Banco_MySQL_Real()
        {
            
            var status = new Status { Name = "Aberto" };
            var user = new UserSystem { Password = "123", AcessLevel = "Admin", Status = status };

            
            var device = new Device
            {
                Model = "Galaxy S23",
                IMEI = "123456789REAL",
                Type = "Smartphone",
                TypeBrand = TypeBrand.Samsung,
                Id_Client = 0
            };

            var client = new Client
            {
                Name = "Cliente Real MySQL",
                Phone = "1199999999",
                Email = "real@teste.com",
                Adress = "Rua do Banco de Dados, 100",
                Register_Date = DateTime.Now,
                Device = device
            };

            device.Client = client; 

            var serviceOrder = new ServiceOrder
            {
                Price = 500.00M,
                Note = "Teste de Integração",
                Status = status,
                User = user,
                Client = client,
                Device = device,
                Services = new List<ServiceOrder_has_Service>(),
                Products = new List<Products_has_ServiceOrder>()
            };

            
            using (var context = GetRealContext())
            {
                context.ServiceOrders.Add(serviceOrder);
                context.SaveChanges();
            }

            
            using (var context = GetRealContext())
            {
                var ordemSalva = context.ServiceOrders
                    .Include(o => o.Client)
                    .Include(o => o.Device)
                    .Include(o => o.Status)
                    .FirstOrDefault();

                Assert.IsNotNull(ordemSalva, "A ordem não foi salva.");
                Assert.AreEqual("Cliente Real MySQL", ordemSalva.Client.Name);
                Assert.AreEqual("Galaxy S23", ordemSalva.Device.Model);
                Assert.IsTrue(ordemSalva.Id > 0);
            }
        }
    }
}
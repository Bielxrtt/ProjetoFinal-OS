using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Os.Domain.Entities;
using Os.Repository.Context;  
using System;
using System.Linq;
using System.Collections.Generic;

namespace Os.Test
{
    [TestClass]
    public class ClientRepositoryTest
    {
        private OsContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<OsContext>().UseInMemoryDatabase(databaseName: "OsTestDB").Options;

            return new OsContext(options);
        }

        [TestMethod]
        public void Deve_Inserir_Cliente_Com_Sucesso()
        {
            // Arrange
            var context = GetInMemoryContext();

            var client = new Client
            {
                Id_Client = 1,
                Name = "Gabriel",
                Phone = "18981636059",
                Email = "gmontresol@gmail.com",
                Adress = "Rua A, 123",
                Register_Date = DateTime.Now,

                IdDevice = 1,
                Device = null, 
               
            };

            // Act
            context.Clients.Add(client);
            context.SaveChanges();

            // Assert
            var salvo = context.Clients.FirstOrDefault(x => x.Id_Client == 1);

            Assert.IsNotNull(salvo);
            Assert.AreEqual("Gabriel", salvo.Name);
            Assert.AreEqual("18981636059", salvo.Phone);
            Assert.AreEqual("gmontresol@gmail.com", salvo.Email);
        }
    }
}

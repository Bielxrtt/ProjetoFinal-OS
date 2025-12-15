using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Os.Repository.Context
{
    // Esta classe serve APENAS para os comandos Add-Migration e Update-Database
    public class OsContextFactory : IDesignTimeDbContextFactory<OsContext>
    {
        public OsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OsContext>();

            // Coloque aqui a mesma string de conexão do seu arquivo DbConfig.txt
            // Isso garante que o Migration saiba onde conectar
            var connectionString = "Server=localhost;Port=3306;Database=Os;Uid=root;Pwd=";

            // Define o provedor (MySQL)
            optionsBuilder.UseMySQL(connectionString);

            return new OsContext(optionsBuilder.Options);
        }
    }
}
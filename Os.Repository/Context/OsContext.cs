using Microsoft.EntityFrameworkCore;
using Os.Domain.Entities;
using Os.Repository.Mapping;

namespace Os.Repository.Context
{
    public class OsContext : DbContext
    {
        public OsContext(DbContextOptions<OsContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<Products_has_ServiceOrder> Products_Has_ServiceOrders { get; set; }
        public DbSet<ServiceOrder_has_Service> ServiceOrder_Has_ServicesOrders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<UserSystem> UserSystems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new DeviceMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ServicesMap());
            modelBuilder.ApplyConfiguration(new ServiceOrderMap());
            modelBuilder.ApplyConfiguration(new Products_has_ServiceOrderMap());
            modelBuilder.ApplyConfiguration(new ServiceOrder_has_ServiceMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new UserSystemMap());
        }
    }
}
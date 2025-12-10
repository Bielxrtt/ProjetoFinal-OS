using Microsoft.EntityFrameworkCore;
using Os.Domain.Entities;
using Os.Repository.Mapping;

namespace Os.Repository.Context
{
    public class OsContext : DbContext
    {
        public OsContext(DbContextOptions<OsContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=Os;user=root;password=");
            }
        }

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

            modelBuilder.Entity<Client>(new ClientMap().Configure);
            modelBuilder.Entity<Device>(new DeviceMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<Services>(new ServicesMap().Configure);
            modelBuilder.Entity<ServiceOrder>(new ServiceOrderMap().Configure);
           
            modelBuilder.Entity<Products_has_ServiceOrder>(new Products_has_ServiceOrderMap().Configure);
            modelBuilder.Entity<ServiceOrder_has_Service>(new ServiceOrder_has_ServiceMap().Configure);
            modelBuilder.Entity<Status>(new StatusMap().Configure);
            modelBuilder.Entity<UserSystem>(new UserSystemMap());

        }
    }
}

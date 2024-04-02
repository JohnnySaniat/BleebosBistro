using Microsoft.EntityFrameworkCore;
using BleebosBistro.Models;

namespace BleebosBistro
{
    public class BleebosBistroDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BleebosBistroDbContext(DbContextOptions<BleebosBistroDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[] {
                new User { Uid = "1", Username = "user1", Password = "password1", AuthenticationStatus = true },
                new User { Uid = "2", Username = "user2", Password = "password2", AuthenticationStatus = true },
            });

            modelBuilder.Entity<Order>().HasData(new Order[]
            {
                new Order { OrderId = "1001", IsOpen = true, CustomerName = "John Doe", PhoneNumber = 1234567890, Email = "john@example.com", IsOnline = true, Uid = "1", Subtotal = 2000, Tip = 300, Total = 2300, Date = DateTime.Now },
                new Order { OrderId = "1002", IsOpen = false, CustomerName = "Jane Smith", PhoneNumber = 9876543210, Email = "jane@example.com", IsOnline = false, Uid = "2", Subtotal = 1500, Tip = 200, Total = 1700, Date = DateTime.Now.AddDays(-1) }
            });

            modelBuilder.Entity<Item>().HasData(new Item[]
            {
                new Item { ItemId = "101", Name = "Pizza", Price = 100, Uid = "1" },
                new Item { ItemId = "102", Name = "Wings", Price = 150, Uid = "1" },
                new Item { ItemId = "103", Name = "Salad", Price = 50, Uid = "2" }
            });
        }
    }
}
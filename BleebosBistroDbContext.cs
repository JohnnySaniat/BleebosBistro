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
        new User { Id = 1, Uid = "WFKkg9zIyfT36VTlUrxbLXhknJV2", Username = 200201, IsColleague = "Yes", Image = "https://avatarfiles.alphacoders.com/113/113469.jpg" },
        new User { Id = 2, Uid = "WFKkg9zIyfT36VTlUrxbLXhknJV3", Username = 200202, IsColleague = "No", Image = "https://imagedelivery.net/9sCnq8t6WEGNay0RAQNdvQ/UUID-cl9g4rv6p4471q8nfruthlmio/public" }
    });

            modelBuilder.Entity<Order>().HasData(new Order[]
            {
        new Order { Id = 1001, IsClosed = true, FirstName = "Darbin", LastName = "Glowbone", Email = "gertyherdy@example.com", Subtotal = 2000, Tip = 300, Total = 2300, Date = DateTime.Now, Image = "https://i.ibb.co/kqvY0KX/Bleebos-Bistro-Order2.png", PaymentType = "Credit", },
        new Order { Id = 1002, IsClosed = false, FirstName = "Phil", LastName = "Doctor", Email = "goober@example.com", Subtotal = 1500, Tip = 200, Total = 1700, Date = DateTime.Now.AddDays(-1) , Image = "https://i.ibb.co/kqvY0KX/Bleebos-Bistro-Order2.png", PaymentType = "Cash",}
            });

            modelBuilder.Entity<Item>().HasData(new Item[]
            {
        new Item { Id = 101, Name = "Shrugbo", Price = 100, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTULR06hbIXK3efBfwg0eJon8_z9CcU7srRmQqL-gRglQ&s", Description = "Sauced up Shrugbo with Grumberries", ItemType = "Whams"},
        new Item { Id = 102, Name = "Trenboodoo", Price = 150 , Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrh1BIMheVzZsb7AUHvPlGo9QTSKdSvLPLFw&s", Description = "Glazed Trenboodoo with Fizz", ItemType = "Stump"},
        new Item { Id = 103, Name = "Salad", Price = 50, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8iROIB-DTfaO0Tzke6ErgcaBR6V10C3xfEw&s", Description = "Human Salad", ItemType = "Human Food"},
            });
        }
    }
}
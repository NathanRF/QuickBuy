using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.Valueables;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentOptionConfiguration());

            modelBuilder.Entity<PaymentOption>().HasData(
                new PaymentOption()
                {
                    Id = 1,
                    Name = "Payment Slip",
                    Description = "Payment Slip Payment Option"
                },
                new PaymentOption()
                {
                    Id = 2,
                    Name = "Credit Card",
                    Description = "Credit Card Payment Option"
                },
                new PaymentOption()
                {
                    Id = 3,
                    Name = "Deposit",
                    Description = "Bank Deposit Payment Option"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}

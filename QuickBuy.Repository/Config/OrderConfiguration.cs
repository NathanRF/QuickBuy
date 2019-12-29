using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder
                .Property(o => o.OrderDate)
                .IsRequired();
            builder
                .Property(o => o.ExpectedDeliveryDate)
                .IsRequired();
            builder
                .Property(o => o.ZipCode)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(o => o.City)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(o => o.State)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(o => o.CompleteAddress)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(o => o.AddressNumber)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}

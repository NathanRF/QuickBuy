using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Valueables;

namespace QuickBuy.Repository.Config
{
    public class PaymentOptionConfiguration : IEntityTypeConfiguration<PaymentOption>
    {
        public void Configure(EntityTypeBuilder<PaymentOption> builder)
        {
            builder.HasKey(p => p.Id);
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

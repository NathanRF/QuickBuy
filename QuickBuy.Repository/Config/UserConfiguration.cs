using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            builder
                .Property(user => user.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(user => user.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");
            builder
                .Property(user => user.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");
            builder
                .Property(user => user.Password)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .HasMany(user => user.Orders)
                .WithOne(o => o.User);
        }
    }
}

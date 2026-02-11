using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Infrastructure.Data.Entities;

public sealed class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        builder.ToTable("cart_items");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ProductId).IsRequired().HasMaxLength(100);
        builder.Property(x => x.ProductNameSnapshot).IsRequired().HasMaxLength(200);
        builder.Property(x => x.UnitPrice).HasPrecision(18, 2);
        builder.Property(x => x.Quantity).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}

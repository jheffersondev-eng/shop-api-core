using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Infrastructure.Data.Entities;

public sealed class OrderStatusHistoryConfiguration : IEntityTypeConfiguration<OrderStatusHistory>
{
    public void Configure(EntityTypeBuilder<OrderStatusHistory> builder)
    {
        builder.ToTable("order_status_history");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.ChangedAt).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}

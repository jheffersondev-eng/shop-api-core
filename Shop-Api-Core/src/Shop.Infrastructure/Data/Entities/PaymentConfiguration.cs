using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Infrastructure.Data.Entities;

public sealed class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("payments");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.PaymentMethod).IsRequired();
        builder.Property(x => x.PaymentProvider).IsRequired();
        builder.Property(x => x.Amount).HasPrecision(18, 2);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.TransactionId).HasMaxLength(100);
        builder.Property(x => x.CreatedAt).IsRequired();

        builder.HasMany(x => x.Events)
            .WithOne(x => x.Payment)
            .HasForeignKey(x => x.PaymentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

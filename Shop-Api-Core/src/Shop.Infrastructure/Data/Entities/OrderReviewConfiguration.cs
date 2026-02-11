using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Infrastructure.Data.Entities;

public sealed class OrderReviewConfiguration : IEntityTypeConfiguration<OrderReview>
{
    public void Configure(EntityTypeBuilder<OrderReview> builder)
    {
        builder.ToTable("order_reviews", table =>
            table.HasCheckConstraint("ck_order_reviews_rating", "\"Rating\" between 1 and 5"));
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Rating).IsRequired();
        builder.Property(x => x.Comment).HasMaxLength(1000);
        builder.Property(x => x.CreatedAt).IsRequired();

    }
}

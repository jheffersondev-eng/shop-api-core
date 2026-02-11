using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Infrastructure.Data.Entities;

public sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("reviews", table =>
            table.HasCheckConstraint("ck_reviews_rating", "\"Rating\" between 1 and 5"));
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ProductId).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Rating).IsRequired();
        builder.Property(x => x.Comment).HasMaxLength(1000);
        builder.Property(x => x.CreatedAt).IsRequired();

    }
}

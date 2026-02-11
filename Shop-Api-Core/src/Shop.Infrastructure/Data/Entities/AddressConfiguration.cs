using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Infrastructure.Data.Entities;

public sealed class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("addresses");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Type).IsRequired();
        builder.Property(x => x.Street).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Number).IsRequired().HasMaxLength(20);
        builder.Property(x => x.City).IsRequired().HasMaxLength(100);
        builder.Property(x => x.State).IsRequired().HasMaxLength(100);
        builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Country).IsRequired().HasMaxLength(100);
        builder.Property(x => x.CreatedAt).IsRequired();
    }
}

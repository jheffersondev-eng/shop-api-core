using Shop.Domain.Enums;

namespace Shop.Domain.Entities;

public sealed class Address
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public AddressType Type { get; set; }
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public Customer? Customer { get; set; }
}

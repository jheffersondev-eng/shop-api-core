using Shop.Domain.Enums;

namespace Shop.Domain.Entities;

public sealed class Cart
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public CartStatus Status { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public Customer? Customer { get; set; }
    public ICollection<CartItem> Items { get; set; } = new List<CartItem>();
}

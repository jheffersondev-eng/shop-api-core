using Shop.Domain.Enums;

namespace Shop.Domain.Entities;

public sealed class OrderStatusHistory
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public OrderStatus Status { get; set; }
    public DateTimeOffset ChangedAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public Order? Order { get; set; }
}

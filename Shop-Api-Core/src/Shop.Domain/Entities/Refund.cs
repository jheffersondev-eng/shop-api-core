using Shop.Domain.Enums;

namespace Shop.Domain.Entities;

public sealed class Refund
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid PaymentId { get; set; }
    public decimal Amount { get; set; }
    public string? Reason { get; set; }
    public RefundStatus Status { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public Order? Order { get; set; }
    public Payment? Payment { get; set; }
}

using Shop.Domain.Enums;

namespace Shop.Domain.Entities;

public sealed class Payment
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
    public decimal Amount { get; set; }
    public PaymentStatus Status { get; set; }
    public string? TransactionId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public Order? Order { get; set; }
    public ICollection<PaymentEvent> Events { get; set; } = new List<PaymentEvent>();
}

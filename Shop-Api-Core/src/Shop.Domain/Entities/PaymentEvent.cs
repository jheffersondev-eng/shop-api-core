namespace Shop.Domain.Entities;

public sealed class PaymentEvent
{
    public Guid Id { get; set; }
    public Guid PaymentId { get; set; }
    public string EventType { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }

    public Payment? Payment { get; set; }
}

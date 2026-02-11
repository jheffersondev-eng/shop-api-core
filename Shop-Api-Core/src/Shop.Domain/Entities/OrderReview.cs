namespace Shop.Domain.Entities;

public sealed class OrderReview
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public Order? Order { get; set; }
}

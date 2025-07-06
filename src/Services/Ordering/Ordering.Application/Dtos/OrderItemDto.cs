namespace Ordering.Application.Dtos;

public record OrderItemDto(
    Guid OrderId,
    Guid ProductId,
    int Quantity,
    decimal Price
)
{
    public OrderItemDto(OrderItem orderItem) : this(
        orderItem.OrderId.Value,
        orderItem.ProductId.Value,
        orderItem.Quantity,
        orderItem.Price)
    { }

};
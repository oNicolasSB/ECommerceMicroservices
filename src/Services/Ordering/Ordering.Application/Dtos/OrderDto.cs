using Ordering.Domain.Enums;

namespace Ordering.Application.Dtos;

public record OrderDto(
    Guid Id,
    Guid CustomerId,
    string OrderName,
    AddressDto ShippingAddress,
    AddressDto BillingAddress,
    PaymentDto Payment,
    OrderStatus Status,
    List<OrderItemDto> OrderItems
)
{
    public OrderDto(Order order) : this(
        order.Id.Value,
        order.CustomerId.Value,
        order.OrderName.Value,
        new AddressDto(order.ShippingAddress),
        new AddressDto(order.BillingAddress),
        new PaymentDto(order.Payment),
        order.Status,
        [.. order.OrderItems.Select(oi => new OrderItemDto(oi))])
    { }
}
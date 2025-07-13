namespace Ordering.Application.Extensions;

public static class OrderExtensions
{
    public static IEnumerable<OrderDto> ToOrderDtoList(this IEnumerable<Order> orders)
    {
        return orders.Select(order => new OrderDto(
            Id: order.Id.Value,
            CustomerId: order.CustomerId.Value,
            OrderName: order.OrderName.Value,
            ShippingAddress: new AddressDto(order.ShippingAddress.FirstName ?? string.Empty, order.ShippingAddress.LastName ?? string.Empty, order.ShippingAddress.EmailAddress!, order.ShippingAddress.AddressLine, order.ShippingAddress.Country ?? string.Empty, order.ShippingAddress.State ?? string.Empty, order.ShippingAddress.ZipCode ?? string.Empty),
            BillingAddress: new AddressDto(order.BillingAddress.FirstName ?? string.Empty, order.BillingAddress.LastName ?? string.Empty, order.BillingAddress.EmailAddress!, order.BillingAddress.AddressLine, order.BillingAddress.Country ?? string.Empty, order.BillingAddress.State ?? string.Empty, order.BillingAddress.ZipCode ?? string.Empty),
            Payment: new PaymentDto(order.Payment.CardName!, order.Payment.CardNumber, order.Payment.Expiration ?? string.Empty, order.Payment.CVV, order.Payment.PaymentMethod),
            Status: order.Status,
            OrderItems: order.OrderItems.Select(oi => new OrderItemDto(oi.OrderId.Value, oi.ProductId.Value, oi.Quantity, oi.Price)).ToList()
        ));
    }

    public static OrderDto ToOrderDto(this Order order)
    {
        return DtoFromOrder(order);
    }

    private static OrderDto DtoFromOrder(Order order)
    {
        return new OrderDto(
                    Id: order.Id.Value,
                    CustomerId: order.CustomerId.Value,
                    OrderName: order.OrderName.Value,
                    ShippingAddress: new AddressDto(order.ShippingAddress.FirstName ?? string.Empty, order.ShippingAddress.LastName ?? string.Empty, order.ShippingAddress.EmailAddress!, order.ShippingAddress.AddressLine, order.ShippingAddress.Country ?? string.Empty, order.ShippingAddress.State ?? string.Empty, order.ShippingAddress.ZipCode ?? string.Empty),
                    BillingAddress: new AddressDto(order.BillingAddress.FirstName ?? string.Empty, order.BillingAddress.LastName ?? string.Empty, order.BillingAddress.EmailAddress!, order.BillingAddress.AddressLine, order.BillingAddress.Country ?? string.Empty, order.BillingAddress.State ?? string.Empty, order.BillingAddress.ZipCode ?? string.Empty),
                    Payment: new PaymentDto(order.Payment.CardName!, order.Payment.CardNumber, order.Payment.Expiration ?? string.Empty, order.Payment.CVV, order.Payment.PaymentMethod),
                    Status: order.Status,
                    OrderItems: order.OrderItems.Select(oi => new OrderItemDto(oi.OrderId.Value, oi.ProductId.Value, oi.Quantity, oi.Price)).ToList()
                );
    }
}
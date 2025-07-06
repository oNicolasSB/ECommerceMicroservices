namespace Ordering.Application.Dtos;

public record PaymentDto(
    string CardName,
    string CardNumber,
    string? Expiration,
    string Cvv,
    int PaymentMethod
)
{
    public PaymentDto(Payment payment) : this(payment.CardName,
        payment.CardNumber,
        payment.Expiration,
        payment.CVV,
        payment.PaymentMethod)
    { }
};
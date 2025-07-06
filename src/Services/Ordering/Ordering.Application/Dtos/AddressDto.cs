namespace Ordering.Application.Dtos;

public record AddressDto(
    string? FirstName,
    string? LastName,
    string EmailAddress,
    string AddressLine,
    string? Country,
    string? State,
    string? ZipCode
)
{
    public AddressDto(Address address) : this(
        address.FirstName,
        address.LastName,
        address.EmailAddress,
        address.AddressLine,
        address.Country,
        address.State,
        address.ZipCode)
    { }
};
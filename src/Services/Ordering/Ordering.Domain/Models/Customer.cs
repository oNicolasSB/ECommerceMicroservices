namespace Ordering.Domain.Models;

public class Customer : Entity<CustomerId>
{
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;

    protected Customer() { }
    private Customer(CustomerId id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public static Customer Create(CustomerId id, string name, string email)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(email);

        // Customer customer = new()
        // {
        //     Id = id,
        //     Name = name,
        //     Email = email
        // };

        Customer customer = new(id, name, email);

        return customer;
    }

}

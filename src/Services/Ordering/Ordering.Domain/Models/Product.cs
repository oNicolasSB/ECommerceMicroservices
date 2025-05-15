namespace Ordering.Domain.Models;

public class Product : Entity<ProductId>
{
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    public static Product Create(ProductId id, string name, decimal price)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);

        Product product = new()
        {
            Id = id,
            Name = name,
            Price = price
        };

        return product;
    }
}

namespace Catalog.API.Models;

public class Product
{
    public Product() { }
    public Product(string name, List<string> category, string description, string imageFile, decimal price)
    {
        Name = name;
        Category = category;
        Description = description;
        ImageFile = imageFile;
        Price = price;
    }

    public void Update(string name, List<string> category, string description, string imageFile, decimal price)
    {
        Name = name;
        Category = category;
        Description = description;
        ImageFile = imageFile;
        Price = price;
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<string> Category { get; set; } = [];
    public string Description { get; set; } = string.Empty;
    public string ImageFile { get; set; } = string.Empty;
    public decimal Price { get; set; }
}

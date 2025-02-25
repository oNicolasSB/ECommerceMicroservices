using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct;


public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);
public class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create a product entity from command object
        Product product = new(command.Name, command.Category, command.Description, command.ImageFile, command.Price);

        //save to database

        //return CreateProductResult result 

        return new CreateProductResult(Guid.NewGuid());
    }
}

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler(IDocumentSession session) : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create a product entity from command object
        Product product = new(command.Name, command.Category, command.Description, command.ImageFile, command.Price);

        //save to database
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);
        //return CreateProductResult result 

        return new CreateProductResult(product.Id);
    }
}

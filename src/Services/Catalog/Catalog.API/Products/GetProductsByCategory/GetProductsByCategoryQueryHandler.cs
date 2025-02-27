
namespace Catalog.API.Products.GetProductsByCategory;


public record GetProductsByCategoryQuery(string Category) : IQuery<GetProductByCategoryResult>;
public record GetProductByCategoryResult(IEnumerable<Product> Products);
internal class GetProductsByCategoryQueryHandler(IDocumentSession session, ILogger<GetProductsByCategoryQueryHandler> logger)
    : IQueryHandler<GetProductsByCategoryQuery, GetProductByCategoryResult>
{
    public async Task<GetProductByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductsByCategoryQueryHandler.Handle called with {@Query}", query);

        var products = await session.Query<Product>().Where(p => p.Category.Contains(query.Category)).ToListAsync();

        return new GetProductByCategoryResult(products);
    }
}

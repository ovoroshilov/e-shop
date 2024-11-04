using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProducts;

internal sealed class GetProductsQueryHandler(IDocumentSession session, ILogger<GetProductsQueryHandler> logger)
    : IQueryHandler<GetProductsQuery, IEnumerable<ProductResponse>>
{
    public async Task<IEnumerable<ProductResponse>> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductsQueryHandler.Handle called with {@Query}");

        var products = await session.Query<Product>().ToListAsync(cancellationToken);

        return products.Adapt<IEnumerable<ProductResponse>>();
    }
}

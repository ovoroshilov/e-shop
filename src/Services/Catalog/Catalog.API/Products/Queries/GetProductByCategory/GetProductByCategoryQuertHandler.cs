using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProductByCategory;

internal sealed class GetProductByCategoryQuertHandler(IDocumentSession session, ILogger<GetProductByCategoryQuertHandler> logger)
    : IQueryHandler<GetProductByCategoryQuert, IEnumerable<ProductResponse>>
{
    public async Task<IEnumerable<ProductResponse>> Handle(GetProductByCategoryQuert query, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetProductByCategoryQuertHandler.Handle called with {@Query}");

        var products = await session.Query<Product>()
            .Where(p => p.Categories.Contains(query.Category))
            .ToListAsync(cancellationToken);

        return products.Adapt<IEnumerable<ProductResponse>>();
    }
}

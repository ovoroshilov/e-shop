using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProductByCategory;

public sealed record GetProductByCategoryQuert(string Category) : IQuery<IEnumerable<ProductResponse>>;

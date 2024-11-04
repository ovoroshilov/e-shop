using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProducts;

public sealed record GetProductsQuery : IQuery<IEnumerable<ProductResponse>>;

using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProductById;

public sealed record GetProductByIdQuery(Guid Id) : IQuery<ProductResponse>;

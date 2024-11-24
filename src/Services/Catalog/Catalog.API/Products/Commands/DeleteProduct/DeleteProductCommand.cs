using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.DeleteProduct;

public sealed record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResponse>;

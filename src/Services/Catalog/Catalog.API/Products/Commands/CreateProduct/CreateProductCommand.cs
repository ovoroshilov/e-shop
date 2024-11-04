using Catalog.API.Responses;
using Shared.CQRS;

namespace Catalog.API.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(string Name, List<string> Categories, string Description, string ImagePath, decimal Price)
    : ICommand<CreateProductResponse>;

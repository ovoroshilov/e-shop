using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.UpdateProduct;

public sealed record UpdateProductCommand(Guid UpdateProductId, string Name, List<string> Categories, string Description, string ImageFile, decimal Price)
    : ICommand<UpdateProductResponse>;



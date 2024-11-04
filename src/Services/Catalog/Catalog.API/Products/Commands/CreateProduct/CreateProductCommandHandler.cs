using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler(IDocumentSession session)
    : ICommandHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = command.Name,
            Categories = command.Categories,
            Description = command.Description,
            Price = command.Price,
            ImageFile = command.ImagePath
        };

        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        return new CreateProductResponse(product.Id);
    }
}

using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler(IDocumentSession session)
    : ICommandHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = command.Adapt<Product>();

        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        return new CreateProductResponse(product.Id);
    }
}

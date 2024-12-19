using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler(IDocumentSession session, ILogger<CreateProductCommandHandler> logger)
    : ICommandHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("CreateProductCommandHandler.Handle called with {@Command} parameter", command);
        var product = command.Adapt<Product>();

        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        return new CreateProductResponse(product.Id);
    }
}

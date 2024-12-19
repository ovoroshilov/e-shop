using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.DeleteProduct;

internal sealed class DeleteProductCommandHandler(IDocumentSession session, ILogger<DeleteProductCommandHandler> logger)
    : ICommandHandler<DeleteProductCommand, DeleteProductResponse>
{
    public async Task<DeleteProductResponse> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("DeleteProductCommandHandler.Handle called with {@Command}", command);

        session.Delete<Product>(command.Id);
        await session.SaveChangesAsync(cancellationToken);

        return new DeleteProductResponse(true);
    }
}
using Catalog.API.Models;
using Catalog.API.Responses;

namespace Catalog.API.Products.Commands.UpdateProduct;

internal sealed class UpdateProductCommandHandler(IDocumentSession session, ILogger<UpdateProductCommandHandler> logger)
    : ICommandHandler<UpdateProductCommand, UpdateProductResponse>
{
    public async Task<UpdateProductResponse> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        logger.LogInformation("UpdateProductCommandHandler.Handle called with {@Query}");

        var product = await session.LoadAsync<Product>(command.UpdateProductId, cancellationToken);

        if (product is null)
        {
            throw new ProductNotFoundException(command.UpdateProductId);
        }

        product.Name = command.Name;
        product.Description = command.Description;
        product.ImageFile = command.ImageFile;
        product.Categories = command.Categories;
        product.Price = command.Price;
        
        session.Update(product);
        await session.SaveChangesAsync(cancellationToken);

        return new UpdateProductResponse(true);
    }
}


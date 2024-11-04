using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProductById;

public sealed class GetProductByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id}", async (Guid id, ISender sender) =>
        {
            var query = new GetProductByIdQuery(id);

            var response = await sender.Send(query);

            return Results.Ok(response);
        })
        .WithName("GetProductById")
        .Produces<ProductResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Product by id")
        .WithDescription("Get Product by id");
    }
}

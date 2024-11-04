
using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProducts;

public sealed class GetProductsEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", async (ISender sender) =>
        {
            var query = new GetProductsQuery();

            var response = await sender.Send(query);

            return Results.Ok(response);
        })
        .WithName("GetProducts")
        .Produces<IEnumerable<ProductResponse>>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get Products")
        .WithDescription("Get Products");
    }
}

using Catalog.API.Responses;

namespace Catalog.API.Products.Queries.GetProductByCategory;

public sealed class GetProductByCategoryEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/category/{category}", async (string category, ISender sender) =>
        {
            var query = new GetProductByCategoryQuert(category);

            var response = await sender.Send(query);

            return Results.Ok(response);
        })
      .WithName("GetProductByCategory")
      .Produces<IEnumerable<ProductResponse>>(StatusCodes.Status200OK)
      .ProducesProblem(StatusCodes.Status400BadRequest)
      .WithSummary("Get Product by category")
      .WithDescription("Get Product by category");
    }
}

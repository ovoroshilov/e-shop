namespace Catalog.API.Models;

public sealed class Product
{
    public Guid Id { get; init; }

    public string Name { get; init; } = default!;

    public List<string> Categories { get; init; } = [];

    public string Description { get; init; } = default!;

    public string ImageFile { get; init; } = default!;

    public decimal Price { get; init; }
}
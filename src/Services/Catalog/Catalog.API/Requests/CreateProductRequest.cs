namespace Catalog.API.Requests;

public sealed record CreateProductRequest(string Name, List<string> Categories, string Description, string ImageFile, decimal Price);

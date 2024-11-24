namespace Catalog.API.Requests;

public sealed record UpdateProductRequest(Guid UpdateProductId, string Name, List<string> Categories, string Description, string ImageFile, decimal Price);
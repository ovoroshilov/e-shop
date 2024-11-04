namespace Catalog.API.Responses;

public sealed record ProductResponse(Guid Id, string Name, string Description, List<string> Categories, decimal Price);

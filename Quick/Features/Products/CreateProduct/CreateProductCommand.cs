using MediatR;

namespace Quick.Features.Products;

public record CreateProductCommand(string Name, decimal Price) : IRequest<CreateProductResponse>;

public record CreateProductResponse(int Id, string Name, decimal Price);

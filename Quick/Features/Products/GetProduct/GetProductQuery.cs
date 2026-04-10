using MediatR;

namespace Quick.Features.Products;

public record GetProductQuery(int Id) : IRequest<GetProductResponse?>;

public record GetProductResponse(int Id, string Name, decimal Price);

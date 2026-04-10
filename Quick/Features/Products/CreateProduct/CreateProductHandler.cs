using MediatR;

namespace Quick.Features.Products;

public class CreateProductHandler(ProductStore store)
    : IRequestHandler<CreateProductCommand, CreateProductResponse>
{
    public Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = store.Add(request.Name, request.Price);
        return Task.FromResult(new CreateProductResponse(product.Id, product.Name, product.Price));
    }
}

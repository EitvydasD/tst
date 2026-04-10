using MediatR;

namespace Quick.Features.Products;

public class GetProductHandler(ProductStore store)
    : IRequestHandler<GetProductQuery, GetProductResponse?>
{
    public Task<GetProductResponse?> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var product = store.GetById(request.Id);
        var response = product is null
            ? null
            : new GetProductResponse(product.Id, product.Name, product.Price);
        return Task.FromResult(response);
    }
}

using MediatR;

namespace Quick.Features.Products;

public static class GetProductEndpoint
{
    public static IEndpointRouteBuilder MapGetProduct(this IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id:int}", async (int id, ISender sender) =>
        {
            var result = await sender.Send(new GetProductQuery(id));
            return result is null ? Results.NotFound() : Results.Ok(result);
        })
        .WithName("GetProduct");

        return app;
    }
}

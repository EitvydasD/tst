using MediatR;

namespace Quick.Features.Products;

public static class CreateProductEndpoint
{
    public static IEndpointRouteBuilder MapCreateProduct(this IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductCommand command, IMediator mediatr) =>
        {
            var result = await mediatr.Send(command);
            return Results.Created($"/products/{result.Id}", result);
        })
        .WithName("CreateProduct");

        return app;
    }
}

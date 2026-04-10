namespace Quick.Features.Products;

public record Product(int Id, string Name, decimal Price);

public class ProductStore
{
    private int _nextId;
    private readonly Dictionary<int, Product> _products = [];

    public Product Add(string name, decimal price)
    {
        var id = ++_nextId;
        var product = new Product(id, name, price);
        _products[id] = product;
        return product;
    }

    public Product? GetById(int id) =>
        _products.TryGetValue(id, out var product) ? product : null;
}

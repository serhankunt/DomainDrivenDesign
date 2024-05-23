namespace DomainDrivenDesign.Domain.Products;

public interface IProductRepository
{
    Task CreateAsync(CreateProductDto request, CancellationToken cancellationToken);
    Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);
}

using Catalog.Core.Entities;

namespace Catalog.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<Product> GetProductByName(string name);
        Task<Product> GetProductByBrand(string name);
        Task<Product> CreatePoduct(Product name);
        Task<bool> UpdatePoduct(Product name);
        Task<bool> DeletePoduct(string id);


    }
}

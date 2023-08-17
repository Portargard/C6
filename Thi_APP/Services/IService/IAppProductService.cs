using Thi_Data.Data;

namespace Thi_APP.Services.IService
{
    public interface IAppProductService
    {
        Task<Product> AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task DeleteProduct(Guid id);
        Task<Product> GetProductById(Guid id);
        Task UpdateProduct(Product product);
    }
}

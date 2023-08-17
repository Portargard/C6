using Thi_Data.Data;

namespace Thi_API.Services.IServices
{
    public interface IProductService
    {
        public bool Add(Product product);
        public bool Update(Product product);
        public bool Delete(Guid product);
        public List<Product> GetAll();
        public Product GetById(Guid id);
    }
}

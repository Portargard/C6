using Thi_API.Services.IServices;
using Thi_Data.Data;
using Thi_Data.Repositories;

namespace Thi_API.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public bool Add(Product product)
        {
            try
            {
                product.Id = Guid.NewGuid();
                if (_productRepository.Add(product))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                if (_productRepository.Delete(id))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetAllById(id);
        }

        public bool Update(Product product)
        {
            try
            {
                if (_productRepository.Update(product))
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

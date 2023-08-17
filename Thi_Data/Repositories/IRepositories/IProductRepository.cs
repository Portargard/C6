using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thi_Data.Data;

namespace Thi_Data.Repositories.IRepositories
{
    public interface IProductRepository
    {
        public bool Add(Product product);
        public bool Update(Product product);
        public bool Delete(Guid id);
        public List<Product> GetAll();
        public Product GetAllById(Guid id);
    }
}

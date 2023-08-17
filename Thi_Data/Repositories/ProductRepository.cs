using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thi_Data.Data;
using Thi_Data.Repositories.IRepositories;

namespace Thi_Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ThiDbC6 _db;
        public ProductRepository()
        {
            _db = new ThiDbC6();
        }
        public bool Add(Product product)
        {
            try
            {
                product.Id = Guid.NewGuid();
                _db.Products.Add(product);
                _db.SaveChanges();
                return true;
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
                var sp = _db.Products.ToList().FirstOrDefault(c => c.Id == id);
                if (sp != null)
                {
                    _db.Products.Remove(sp);
                    _db.SaveChanges();
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
            return _db.Products.ToList();
        }

        public Product GetAllById(Guid id)
        {
            return _db.Products.ToList().FirstOrDefault(c=>c.Id==id);
        }

        public bool Update(Product product)
        {
            try
            {
                var sp = _db.Products.ToList().FirstOrDefault(c => c.Id == product.Id);
                if ( sp!= null)
                {
                    sp.Name = product.Name;
                    sp.Price = product.Price;
                    sp.Qty = product.Qty;
                    _db.Products.Update(sp);
                    _db.SaveChanges();
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

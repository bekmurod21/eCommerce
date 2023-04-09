using eCommerce.DAL.IRepositories;
using eCommerce.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllAsync(Predicate<Product> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> GetAsync(Predicate<Product> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> InsertAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

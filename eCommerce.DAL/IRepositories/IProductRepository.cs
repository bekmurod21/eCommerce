using eCommerce.Domain.Entities.Products;
using eCommerce.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.IRepositories
{
    public interface IProductRepository
    {
        ValueTask<Product> InsertAsync(Product product);
        ValueTask<Product> UpdateAsync(Product product);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<Product> GetAsync(Predicate<Product> predicate = null);
        IQueryable<Product> GetAllAsync(Predicate<Product> predicate = null);
    }
}

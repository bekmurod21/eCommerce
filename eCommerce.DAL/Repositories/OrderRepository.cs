using eCommerce.DAL.IRepositories;
using eCommerce.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> GetAllAsync(Predicate<Order> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Order> GetAsync(Predicate<Order> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Order> InsertAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Order> UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

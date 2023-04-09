using eCommerce.Domain.Entities.Orders;
using eCommerce.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.IRepositories
{
    public interface IOrderRepository
    {
        ValueTask<Order> InsertAsync(Order order);
        ValueTask<Order> UpdateAsync(Order order);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<Order> GetAsync(Predicate<Order> predicate = null);
        IQueryable<Order> GetAllAsync(Predicate<Order> predicate = null);
    }
}

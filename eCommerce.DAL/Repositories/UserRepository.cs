using eCommerce.DAL.IRepositories;
using eCommerce.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public ValueTask<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAllAsync(Predicate<User> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> GetAsync(Predicate<User> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> InsertAsync(User user)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}

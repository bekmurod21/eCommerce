using eCommerce.DAL.Contexts;
using eCommerce.DAL.IRepositories;
using eCommerce.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();
        public async ValueTask<bool> DeleteAsync(long id)
        {
            User entity = await appDbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
            if (entity is null)
            {
                return false;
            }
            this.appDbContext.Remove(entity);
            await this.appDbContext.SaveChangesAsync();
            return true;
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

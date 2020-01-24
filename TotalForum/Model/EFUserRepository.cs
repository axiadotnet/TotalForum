using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public class EFUserRepository : IUserRepository
    {
        public IQueryable<User> AllUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<User> InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

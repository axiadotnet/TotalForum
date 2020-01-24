using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public interface IUserRepository
    {
        IQueryable<User> AllUser { get; set; }

        Task<User> InsertUser(User user);
        Task<bool> DeleteUser(int id);
        Task<User> UpdateUser(User user);
        Task<IEnumerable<User>> GetAllUser();
        Task<IEnumerable<User>> GetUsersByName(string name);
    }
}

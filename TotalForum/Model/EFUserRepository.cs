using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public class EFUserRepository : IUserRepository
    {
        public EFContext Ctx { get; set; }
        public IQueryable<User> AllUser { get; set; }
        public EFUserRepository(EFContext ctx)
        {
            this.Ctx = ctx;
            AllUser = ctx.User;
        }

        public Task<List<User>> GetAllUser()
        {
            return AllUser.ToListAsync();
        }
        public Task<User> GetUserByID(int id)
        {
            return AllUser.Where(user => user.Id == id).FirstOrDefaultAsync();
        }
        public Task<List<User>> GetUsersByName(string name)
        {
            return AllUser.Where(user => user.UserName.Contains(name)).ToListAsync();
        }

        public async Task<User> InsertUser(User user)
        {
            await Ctx.AddAsync<User>(user);
            Ctx.SaveChanges();
            return user;
        }
        public async Task<User> UpdateUser(User user)
        {
            Ctx.Update<User>(user);
            await Ctx.SaveChangesAsync();
            return user;
        }
        public async Task<bool> DeleteUser(int id)
        {
            var user = await GetUserByID(id);
            Ctx.Remove<User>(user);
            return await Ctx.SaveChangesAsync()>0;
        }
        
    }
}

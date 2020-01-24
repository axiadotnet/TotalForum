using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }
        public IPostRepository PostRepository { get; set; }

        //Post
        Task<User> InsertUser(User user);
        Task<bool> DeleteUser(int id);
        Task<User> UpdateUser(User user);
        Task<IEnumerable<User>> GetAllUser();
        Task<IEnumerable<User>> SearchUserByName(string name);
        

        //User
        Task<Post> InsertPost(Post post);
        Task<bool> DeletePost(int id);
        Task<Post> UpdatePost(Post post);
        Task<IEnumerable<Post>> GetAllPost();
        Task<IEnumerable<Post>> SearchPostByUserId(int id);
        
    }
}

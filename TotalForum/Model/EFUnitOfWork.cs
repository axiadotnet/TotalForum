using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }
        public IPostRepository PostRepository { get; set; }

        public EFUnitOfWork(IUserRepository userRepository, IPostRepository postRepository)
        {
            UserRepository = userRepository;
            PostRepository = postRepository;
        }

        public Task<bool> DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetAllPost()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Post> InsertUser(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

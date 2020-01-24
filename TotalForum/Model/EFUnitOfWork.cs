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

        public Task<IEnumerable<Post>> GetAllPost()
        {
            return PostRepository.GetAllPost();
        }

        public Task<Post> InsertPost(Post post)
        {
            return PostRepository.InsertPost(post);
        }

        public Task<Post> UpdatePost(Post post)
        {
            return PostRepository.UpdatePost(post);
        }

        public Task<bool> DeletePost(int id)
        {
            return PostRepository.DeletePost(id);
        }

        public Task<IEnumerable<Post>> GetPostByUserId(int id)
        {
            return PostRepository.GetPostByUserId(id);
        }

       
        public Task<IEnumerable<User>> GetAllUser()
        {
            return UserRepository.GetAllUser();
        }

        public Task<User> InsertUser(User user)
        {
            return UserRepository.InsertUser(user);
        }

        public Task<User> UpdateUser(User user)
        {
            return UserRepository.UpdateUser(user);
        }

        public async Task<bool> DeleteUser(int id)
        {
            // var areDeletedPosts = await PostRepository.DeletePostsByUserId(id);
            //if (areDeletedPosts)
            //{
            //    return await UserRepository.DeleteUser(id);
            //}
            //else
            //{
            //    return false;
            //}     

            return (await PostRepository.DeletePostsByUserId(id) ?
                    await UserRepository.DeleteUser(id) : false);
        }

        public Task<IEnumerable<User>> GetUsersByName(string name) 
        {
            return UserRepository.GetUsersByName(name);
        }
    }
}

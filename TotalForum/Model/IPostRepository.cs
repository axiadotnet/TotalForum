using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public interface IPostRepository
    {
        IQueryable<Post> AllPost { get; set; }
        Task<Post> InsertPost(Post post);
        Task<bool> DeletePost(int id);
        Task<Post> UpdatePost(Post post);
        Task<List<Post>> GetAllPost();

        Task<bool> DeletePostsByUserId(int userId);
        Task<List<Post>> GetPostsByUserId(int id);

    }
}

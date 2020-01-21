using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public interface IPostRepository
    {
        IEnumerable<Post> AllPost { get; set; }

        Task<Post> InsertUser(Post post);
        Task<bool> DeletePost(int id);
        Task<Post> UpdatePost(Post post);
        Task<IEnumerable<Post>> GetAllPost();
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public class EFPostRepository : IPostRepository
    {
        public IQueryable<Post> AllPost { get; set; }
        public EFContext Ctx { get; set; }
        public EFPostRepository(EFContext ctx)
        {
            this.Ctx = ctx;
            AllPost = ctx.Post;
        }

        public Task<List<Post>> GetAllPost()
        {
            return AllPost.ToListAsync();
        }
        public Task<List<Post>> GetPostsByUserId(int userId)
        {
            return AllPost.Where(p => p.Id == userId).ToListAsync();
        }
        public Task<Post> GetPostById(int id)
        {
            return AllPost.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Post> InsertPost(Post post)
        {
            Ctx.Add<Post>(post);
            await Ctx.SaveChangesAsync();
            return post;
        }
        public async Task<Post> UpdatePost(Post post)
        {
            Ctx.Update<Post>(post);
            await Ctx.SaveChangesAsync();
            return post;
        }
        public async Task<bool> DeletePost(int id)
        {

            var post = await GetPostById(id);
            Ctx.Remove(post);
            return await Ctx.SaveChangesAsync()> 0;
        }

        public async Task<bool> DeletePostsByUserId(int userId)
        {

            var posts = await GetPostsByUserId(userId);
            foreach (var item in posts)
            {
                Ctx.Remove(item);
            }     
            return await Ctx.SaveChangesAsync() > 0;
        }


        

        
    }
}

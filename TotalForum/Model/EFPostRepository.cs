﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public class EFPostRepository : IPostRepository
    {
        public IQueryable<Post> AllPost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<bool> DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetAllPost()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetPostByUserId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> InsertPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
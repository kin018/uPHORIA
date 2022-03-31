using System;
using System.Collections.Generic;
using System.Linq;
using uPhoriaClientAPI.Data;
using uPhoriaClientAPI.Interfaces;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Services
{
    public class PostService : IPostService
    {
        private readonly DataContext _context;

        public PostService(DataContext context)
        {
            _context = context;
        }
        public void CreatePost(Post post)
        {
            if (post == null) 
            {
                throw new ArgumentNullException(nameof(post));
            }

            _context.Posts.Add(post);
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public Post GetPostByID(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.postId == id); //postID is equal to the id passed in
        }

        public bool Savechanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}

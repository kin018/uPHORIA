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
            throw new System.NotImplementedException();
        }

        public IEnumerable<Post> GetAllPosts()
        {
           return _context.Posts.ToList();
        }

        public Post GetPostByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Savechanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}

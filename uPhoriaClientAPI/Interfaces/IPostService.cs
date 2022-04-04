using System.Collections.Generic;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Interfaces
{
    public interface IPostService
    {
        bool Savechanges();
        IEnumerable<Post> GetAllPosts();
        Post GetPostByID(int id);
        void CreatePost(Post post);
    }
}

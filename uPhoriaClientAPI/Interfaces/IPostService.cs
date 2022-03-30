using System.Collections.Generic;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Interfaces
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        Post GetPostByID(int id);
    }
}

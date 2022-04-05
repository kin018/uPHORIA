using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.DTOs.PostDTO
{
    public class GetPostDTO
    {
        public int postId { get; set; }

        public string username { get; set; }

        public string text { get; set; }
    }
}

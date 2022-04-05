using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.DTOs.PostDTO
{
    public class GetPostDTO
    {
        [Required]
        public int postId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string text { get; set; }
    }
}

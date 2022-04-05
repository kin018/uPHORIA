using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.DTOs.PostDTO
{
    public class GetUserPostDTO
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int postId { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string text { get; set; }

        
        
    }
}

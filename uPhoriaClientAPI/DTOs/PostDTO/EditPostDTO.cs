using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.DTOs.PostDTO
{
    public class EditPostDTO
    {
        [Required]
        public int postId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string text { get; set; }
    }
}

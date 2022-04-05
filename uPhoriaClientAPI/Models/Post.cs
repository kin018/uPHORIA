using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int postId { get; set; }

        [Required]
        public string text { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public User User { get; set; }
    }
}

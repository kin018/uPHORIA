using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.Models
{
    public class Post
    {
        [Key]
        [Required] //cannot be null if required key is present
        public int postId { get; set; }

        [Required]
        [MaxLength(250)]
        public string text { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public User User { get; set; }
    }
}

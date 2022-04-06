using System.ComponentModel.DataAnnotations;

namespace uPhoriaClientAPI.DTOs.PostDTO
{
    public class GetUserPostDTO
    {
        public int UserId { get; set; }

        public int postId { get; set; }//

        public string username { get; set; }
        
        public string text { get; set; }//

        
        
    }
}

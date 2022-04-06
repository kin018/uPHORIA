using Microsoft.AspNetCore.Mvc;
using uPhoriaClientAPI.Interfaces;

namespace uPhoriaClientAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]    
    public class PostsController : ControllerBase
    {
        public PostsController(IPostService postrepository)
        {

        }
    
    }
}

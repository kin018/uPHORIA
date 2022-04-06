using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using uPhoriaClientAPI.Interfaces;

namespace uPhoriaClientAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]    
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postrepository;
        private readonly IMapper _mapper;

        public PostsController(IPostService postrepository, IMapper mapper)
        {
            _postrepository = postrepository;
            _mapper = mapper;
        }
    
    }
}

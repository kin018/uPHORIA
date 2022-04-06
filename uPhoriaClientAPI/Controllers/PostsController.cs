using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using uPhoriaClientAPI.DTOs.PostDTO;
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

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<GetPostDTO>> GetAllPosts()
        {
            Console.WriteLine("--> ...Getting Posts... <--");
            var postItems = _postrepository.GetAllPosts();
            return Ok(postItems);

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using uPhoriaClientAPI.DTOs.PostDTO;
using uPhoriaClientAPI.Interfaces;

namespace uPhoriaClientAPI.Controllers
{
    //"api/[controller]"
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
            return Ok(_mapper.Map<IEnumerable<GetPostDTO>>(postItems)); //mapped to GetPostDTO from the collection of model-->postItems

        }


        [HttpGet("{id}", Name = "GetPostById")]
        public ActionResult<GetPostDTO> GetPostByID(int id)
        {
            var postItem = _postrepository.GetPostByID(id);
            if (postItem != null)
            {
                return Ok(_mapper.Map<GetPostDTO>(postItem));
            }
            return NotFound();
        }
    }
}

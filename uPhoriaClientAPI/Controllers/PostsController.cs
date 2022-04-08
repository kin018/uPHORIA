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
            return Ok(_mapper.Map<IEnumerable<GetPostDTO>>(postItems)); //mapped to GetPostDTO from the collection of model-->postItems

        }


        //        [HttpGet("{id}", Name = "GetPlatformById")]
        //        public ActionResult<PlatformReadDto> GetPlatformById(int id)
        //        {
        //            var platformItem = _postrepository.GetPlatformById(id);
        //            if (platformItem != null)
        //            {
        //                return Ok(_mapper.Map<PlatformReadDto>(platformItem));
        //            }

        //            return NotFound();

    }
}

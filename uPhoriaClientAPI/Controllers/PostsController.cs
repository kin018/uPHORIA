using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using uPhoriaClientAPI.DTOs.PostDTO;
using uPhoriaClientAPI.Interfaces;
using uPhoriaClientAPI.Models;

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
            return Ok(_mapper.Map<IEnumerable<GetPostDTO>>(postItems)); //mapped to GetPostDTO from the collection of model--> postItems

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

        [HttpPost]
        public ActionResult<GetPostDTO> CreatePost(CreatePostDTO createPostDTO)
        {
            var postModel = _mapper.Map<Post>(createPostDTO);
            _postrepository.CreatePost(postModel);
            _postrepository.Savechanges();

            var getPostDTO = _mapper.Map<GetPostDTO>(postModel);//

            return CreatedAtRoute(nameof(GetPostByID), new { PostId = getPostDTO.postId }, getPostDTO); //CreatedAtRoute
        }


        //[HttpDelete("{id}")] //DELETE api/commands/{id}
        //public ActionResult DeleteCommand(int id)
        //{
        //    var commandModelFromRepo = _repository.GetCommmandById(id);
        //    if (commandModelFromRepo == null)
        //    {
        //        return NotFound();
        //    }
        //    _repository.DeleteCommand(commandModelFromRepo);
        //    _repository.SaveChanges();

        //    return NoContent();

        //}
    }
}

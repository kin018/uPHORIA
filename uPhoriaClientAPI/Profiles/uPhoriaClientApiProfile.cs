using AutoMapper;
using uPhoriaClientAPI.DTOs.PostDTO;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Profiles
{
    public class uPhoriaClientApiProfile : Profile
    {
        public uPhoriaClientApiProfile()
        {
            //Source --> Target
            CreateMap<Post, GetUserPostDTO>();
            CreateMap<Post, GetPostDTO>();
            CreateMap<GetPostDTO, Post>();
            CreateMap<CreatePostDTO, Post>();
        }
    }
}

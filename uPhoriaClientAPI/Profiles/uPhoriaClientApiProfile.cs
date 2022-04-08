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
            CreateMap<Post, GetPostDTO>();
            CreateMap<Post, GetUserPostDTO>();            
            CreateMap<GetPostDTO, Post>();
            CreateMap<CreatePostDTO, Post>();
        }
    }
}

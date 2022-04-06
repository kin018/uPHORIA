using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using uPhoriaClientAPI.Interfaces;
using uPhoriaClientAPI.Models;

namespace uPhoriaClientAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userrepository;
        private readonly IMapper _mapper;

        public UsersController(IUserService userrepository, IMapper mapper)
        {
            _userrepository = userrepository;
            _mapper = mapper;
        }
    }
}

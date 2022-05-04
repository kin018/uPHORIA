using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("---> Inbound Test<---");

            return Ok("Inbound test from Users Controller");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwtAspNetCoreWebApi.Models;
using JwtAspNetCoreWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userservice;
        public UserController(IUserService userService)
        {
            _userservice = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterModel model)
        {
            var result = await _userservice.RegisterAsync(model);
            return Ok(result);
        }


    }
}

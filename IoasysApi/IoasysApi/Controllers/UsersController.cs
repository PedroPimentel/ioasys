using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoasysApi.Services.User;
using IoasysApi.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IoasysApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    //[Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("auth/sign_in")]
        //[AllowAnonymous]
        public IActionResult SignIn([FromBody] UserViewModel userViewModel)
        {
            var user = _userService.SignIn(userViewModel);

            if (!user.authenticated)
                return Unauthorized();

            return new OkObjectResult(new { message = "200 OK", user });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoasysApi.Services.Enterprise;
using IoasysApi.Services.Type;
using IoasysApi.Services.User;
using IoasysApi.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IoasysApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class EnterprisesController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IEnterpriseService _enterpriseService;
        private readonly ITypeService _typeService;

        public EnterprisesController(IUserService userService, IEnterpriseService enterpriseService, ITypeService typeService)
        {
            _userService = userService;
            _enterpriseService = enterpriseService;
            _typeService = typeService;
        }
        [HttpGet]
        public IActionResult GetByTypeAndName([FromBody] UserViewModel userViewModel, int enterprise_types, string name)
        {
            var authenticated = _userService.SignIn(userViewModel).authenticated;

            if (authenticated)
            {
                var enterprise = _enterpriseService.GetByTypeAndName(enterprise_types, name);

                if (enterprise != null)
                    return new OkObjectResult(new { message = "200 OK", enterprise });

                return NoContent();
            }

            return Unauthorized();
        }

        [HttpGet("{enterpriseId}")]
        public IActionResult GetById([FromBody] UserViewModel userViewModel, int enterpriseId)
        {
            var authenticated = _userService.SignIn(userViewModel).authenticated;

            if (authenticated)
            {
                var enterprise = _enterpriseService.GetById(enterpriseId);

                if (enterprise != null)
                    return new OkObjectResult(new { message = "200 OK", enterprise });

                return NoContent();
            }

            return Unauthorized();
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll([FromBody] UserViewModel userViewModel)
        {
            var authenticated = _userService.SignIn(userViewModel).authenticated;

            if (authenticated)
            {
                var enterprises = _enterpriseService.GetAll();
                return new OkObjectResult(new { message = "200 OK", enterprises });
            }

            return Unauthorized();
        }

        [HttpGet]
        [Route("getEnterpriseTypes")]
        public IActionResult GetEnterpriseTypes([FromBody] UserViewModel userViewModel)
        {
            var authenticated = _userService.SignIn(userViewModel).authenticated;

            if (authenticated)
            {
                var enterpriseTypes = _typeService.GetAll();
                return new OkObjectResult(new { message = "200 OK", enterpriseTypes });
            }

            return Unauthorized();
        }

        [HttpGet]
        [Route("getByTypeId/{typeId}")]
        public IActionResult GetByTypeId([FromBody] UserViewModel userViewModel, int typeId)
        {
            var authenticated = _userService.SignIn(userViewModel).authenticated;

            if (authenticated)
            {
                var enterprises = _enterpriseService.GetByTypeId(typeId);
                return new OkObjectResult(new { message = "200 OK", enterprises });
            }

            return Unauthorized();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagement.Models;
using UserManagement.Services;
using UserManagement.Utils;

namespace UserManagement.Controllers
{
    [Route("v1/api/roles")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        private readonly IRoleRepository _roleRepository;
        private readonly ILogger _logger;

        Response response = new Response();

        public RolesController(ILogger<RolesController> logger, IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            var roles = _roleRepository.GetAllRoles();

            response.error = false;
            response.data = roles;
            response.message = "All roles";

            return Ok(response);
        }

        [HttpGet]
        [Route("{roleId}")]
        public IActionResult GetRoleById(int roleId)
        {
            var roles = _roleRepository.GetRoleById(roleId);

            response.error = false;
            response.data = roles;
            response.message = "Role with Role ID " + roleId;

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateRole(Role roleItem)
        {
            var rolItem = _roleRepository.CreateRole(roleItem);

            response.error = false;
            response.data = rolItem;
            response.message = "Role with name " + roleItem.RoleName + " was successfull y created.";


            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateRole(int id, Role roleItem)
        {
            var rolItem = _roleRepository.EditRole(id, roleItem);

            if (rolItem == null)
            {
                response.error = true;
                response.data = rolItem;
                response.message = "Role with id " + id + " does not exist";

                return NotFound(response);
            }

            response.error = false;
            response.data = rolItem;
            response.message = "Role with name " + roleItem.RoleName + " was successfull y updated.";


            return Ok(response);
        }

    }


}

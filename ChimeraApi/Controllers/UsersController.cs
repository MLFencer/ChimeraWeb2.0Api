using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChimeraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateUser()
        {
            return Ok();
        }

    }
}

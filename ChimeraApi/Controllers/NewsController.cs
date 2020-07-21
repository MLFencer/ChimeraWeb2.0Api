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
    public class NewsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLatest()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateNewArticle()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateArticle()
        {
            return Ok();
        }
    }
}

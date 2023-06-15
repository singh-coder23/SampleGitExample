﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleGitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            string str = "Success Test-1";
            string test = "MyTest";
            return Ok(str);
        }
    }
}

using Microsoft.AspNetCore.Http;
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
            string str = "Success";
            return Ok(str);
        }
    }
}

using ApiVersioningDemo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestApiVersioningController : MainController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("This is the VERSION 1 endpoint!");
        }
    }
}

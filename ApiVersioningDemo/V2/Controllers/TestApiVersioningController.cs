using ApiVersioningDemo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TestApiVersioningController : MainController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("This is the VERSION 2 endpoint!");
        }
    }
}

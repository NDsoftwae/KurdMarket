using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KurdMarket.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        [HttpGet]
        public IActionResult get() => Ok("This service is running through CI/CD from github to Azure machine....");
    }
}

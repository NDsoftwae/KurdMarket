using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KurdMarket.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        [HttpGet]
        public IActionResult get() => Ok("CI/CD from GitHub to Azure Machine Completed.and this service is running successfully....");
    }
}

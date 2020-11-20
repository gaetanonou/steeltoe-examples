using Foo.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Foo.Api.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class SayController : Controller
    {
        private readonly IBarService barService;
        public SayController(IBarService barService)
        {
            this.barService = barService;
        }
        
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello from Foo!");
        }

        [HttpGet]
        public async Task<IActionResult> HelloToBar()
        {
            return Ok(await barService.Hello());
        }
    }
}

using Foo.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace Foo.Api.Controllers
{
    public class HelloController : Controller
    {
        private readonly IBarService barService;
        public HelloController(IBarService barService)
        {
            this.barService = barService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello from Foo!");
        }

        [HttpGet]
        public async Task<IActionResult> FromBar()
        {
            return Ok(await barService.Hello());
        }
    }
}

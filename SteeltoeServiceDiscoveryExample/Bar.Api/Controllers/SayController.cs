using Bar.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bar.Api.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class SayController : Controller
    {
        private readonly IFooService fooService;

        public SayController(IFooService fooService)
        {
            this.fooService = fooService;
        }

        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello from Bar!");
        }


        [HttpGet]
        public async Task<IActionResult> HelloToFoo()
        {
            return Ok(await fooService.Hello());
        }
    }
}

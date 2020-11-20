using Bar.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bar.Api.Controllers
{
    public class HelloController : Controller
    {
        private readonly IFooService fooService;

        public HelloController(IFooService fooService)
        {
            this.fooService = fooService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello from Bar!");
        }


        [HttpGet]
        public async Task<IActionResult> FromFoo()
        {
            return Ok(await fooService.Hello());
        }
    }
}

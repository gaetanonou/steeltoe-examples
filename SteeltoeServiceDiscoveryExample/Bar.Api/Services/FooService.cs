using Bar.Api.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bar.Api.Services
{
    public class FooService : IFooService
    {
        private HttpClient httpClient;
        public FooService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<string> Hello()
        {
            return await httpClient.GetStringAsync("say/hello");
        }
    }
}

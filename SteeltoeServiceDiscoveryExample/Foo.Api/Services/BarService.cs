using Foo.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Foo.Api.Services
{
    public class BarService : IBarService
    {
        private HttpClient httpClient;
        public BarService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<string> Hello()
        {
            return await httpClient.GetStringAsync("say/hello");
        }
    }
}

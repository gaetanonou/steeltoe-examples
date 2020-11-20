using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo.Api.Services.Interfaces
{
    public interface IBarService
    {
        Task<string> Hello();
    }
}

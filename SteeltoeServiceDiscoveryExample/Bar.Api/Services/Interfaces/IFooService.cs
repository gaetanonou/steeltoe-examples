using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar.Api.Services.Interfaces
{
    public interface IFooService
    {
        Task<string> Hello();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Ports
{
    public record GetCopyInfoDtoRequest
    {
        //I could remove this Dto because he hold just one attibute. But I let as a Dto to show how to use it.
        public bool IsAvailable { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Ports
{
    public interface ICopyServicePort
    {
        Task<GetCopyInfoDtoRequest> GetCopyInfo(Guid BookId, CancellationToken cancellationToken);
    }
}

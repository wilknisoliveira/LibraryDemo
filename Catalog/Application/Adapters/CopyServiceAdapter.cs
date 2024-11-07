using Catalog.Domain;
using Shared.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Adapter
{
    internal class CopyServiceAdapter : ICopyServicePort
    {
        public async Task<GetCopyInfoDtoRequest> GetCopyInfo(Guid BookId, CancellationToken cancellationToken)
        {
            //Get Copy from repository
            Copy copy = new(new BookId());

            var copyDto = new GetCopyInfoDtoRequest()
            {
                IsAvailable = false
            };

            return copyDto;
        }
    }
}

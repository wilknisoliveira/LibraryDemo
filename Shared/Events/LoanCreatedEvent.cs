using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Events
{
    public record LoanCreatedEvent : INotification
    {
        public Guid CopyId { get; set; }

        public LoanCreatedEvent(Guid copyId)
        {
            CopyId = copyId;
        }
    }
}

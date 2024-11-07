using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lending.Domain
{
    internal class Loan
    {
        protected Guid Id { get; private set; }
        protected DateTimeOffset CreatedAt { get; private set; }
        protected DateTimeOffset UpdatedAt { get; private set; }
        protected Guid CopyId { get; private set; }
        protected DateTimeOffset ExpectedReturnDate { get; private set; }
        protected DateTimeOffset ReturnedAt { get; private set; }
        protected Guid UserId { get; private set; }

        public Loan(Guid copyId, Guid userId)
        {
            CopyId = copyId;
            ExpectedReturnDate = DateTimeOffset.Now.AddDays(30);
            UserId = userId;

            Id = Guid.NewGuid();
            CreatedAt = DateTimeOffset.Now;
            UpdatedAt = DateTimeOffset.Now;
        }

        public void Return()
        {
            ReturnedAt = DateTimeOffset.Now;
        }
    }
}

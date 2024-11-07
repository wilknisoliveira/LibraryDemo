using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain
{
    internal class Copy
    {
        protected Guid Id { get; private set; }
        protected DateTimeOffset CreatedAt { get; private set; }
        protected DateTimeOffset UpdatedAt { get; private set; }
        [Required]
        protected BookId BookId { get; private set; }
        protected bool IsAvailable { get; private set; }

        public Copy(BookId bookId)
        {
            BookId = bookId;
            IsAvailable = true;

            Id = Guid.NewGuid();
            CreatedAt = DateTimeOffset.Now;
            UpdatedAt = DateTimeOffset.Now;
        }
    }
}

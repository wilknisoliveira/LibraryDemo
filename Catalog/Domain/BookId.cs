using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain
{
    internal record BookId
    {
        [Required]
        protected Guid Id { get; private set; }

        public BookId()
        {
            this.Id = Guid.NewGuid();
        }

        public BookId(Guid id)
        {
            Id = id;
        }
    }
}

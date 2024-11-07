using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain
{
    internal class Book
    {
        protected BookId Id { get; private set; }
        protected DateTimeOffset CreatedAt { get; private set; }
        protected DateTimeOffset UpdatedAt { get; private set; }
        [Required]
        protected string Title { get; private set; }
        [Required]
        protected string Isbn { get; private set; }

        public Book(string title, string isbn)
        {
            Title = title;
            Isbn = isbn;

            Id = new BookId();
            CreatedAt = DateTimeOffset.Now;
            UpdatedAt = DateTimeOffset.Now;
        }
    }
}

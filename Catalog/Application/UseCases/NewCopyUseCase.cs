using Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.UseCases
{
    internal class NewCopyUseCase : INewCopyUseCase
    {
        public void Execute(Guid bookId)
        {
            //Validate if the book is registered

            BookId bookIdObject = new(bookId);

            Copy copy = new(bookIdObject);

            //Save the copy
        }
    }
}

using Catalog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.UseCases
{
    internal class NewBookUseCase : INewBookUseCase
    {
        public void Execute(string isbn)
        {
            //Search by bookInformation by Isbn
            var title = "Title example";

            Book book = new(title, isbn);

            //Save the book on repository
        }
    }
}

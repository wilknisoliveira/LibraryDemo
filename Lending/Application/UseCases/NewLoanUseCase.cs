using Lending.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lending.Application.UseCases
{
    internal class NewLoanUseCase : INewLoanUseCase
    {
        public void Execute(Guid copyId, Guid userId)
        {
            //Search for Copy info

            Loan loan = new(copyId, userId);

            //Save loan on repository

            //Call event
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lending.Application.UseCases
{
    public interface INewLoanUseCase
    {
        void Execute(Guid CopyId, Guid userId);
    }
}

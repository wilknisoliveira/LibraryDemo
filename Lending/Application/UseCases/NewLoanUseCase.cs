using Lending.Domain;
using MediatR;
using Shared.Events;

namespace Lending.Application.UseCases
{
    internal class NewLoanUseCase : INewLoanUseCase
    {
        private readonly IMediator _mediator;

        public NewLoanUseCase(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Execute(Guid copyId, Guid userId)
        {
            //Search for Copy info. THIS IS IMPORTANT

            Loan loan = new(copyId, userId);

            //Save loan on repository

            //Call event
            await _mediator.Publish(new LoanCreatedEvent(copyId));
        }
    }
}

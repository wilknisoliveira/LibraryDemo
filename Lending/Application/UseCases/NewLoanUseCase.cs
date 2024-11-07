using Lending.Domain;
using MediatR;
using Shared.Events;
using Shared.Ports;

namespace Lending.Application.UseCases
{
    internal class NewLoanUseCase : INewLoanUseCase
    {
        private readonly IMediator _mediator;
        private readonly ICopyServicePort _bookServiceShared;

        public NewLoanUseCase(IMediator mediator, ICopyServicePort bookServiceShared)
        {
            _mediator = mediator;
            _bookServiceShared = bookServiceShared;
        }

        public async Task Execute(Guid copyId, Guid userId, CancellationToken cancellationToken)
        {
            //Get info from another Component
            GetCopyInfoDtoRequest copyInfo = await _bookServiceShared.GetCopyInfo(copyId, cancellationToken);

            if (!copyInfo.IsAvailable)
            {
                throw new Exception("The copy isn't available");
            }


            Loan loan = new(copyId, userId);

            //Save loan on repository

            //Call event
            await _mediator.Publish(new LoanCreatedEvent(copyId));
        }
    }
}

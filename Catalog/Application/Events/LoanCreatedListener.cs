using Catalog.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using Shared.Events;

namespace Catalog.Application.Events
{
    public class LoanCreatedListener : INotificationHandler<LoanCreatedEvent>
    {
        private readonly ILogger<LoanCreatedListener> _logger;

        public LoanCreatedListener(ILogger<LoanCreatedListener> logger)
        {
            _logger = logger;
        }

        public Task Handle(LoanCreatedEvent notification, CancellationToken cancellationToken)
        {
            var message = $"Make copy unavailable. Loan created with id {notification.CopyId}";
            _logger.LogInformation(message);

            //Get the Copy from repository
            Copy copy = new(new BookId());

            copy.Unavailable();

            return Task.CompletedTask;
        }
    }
}

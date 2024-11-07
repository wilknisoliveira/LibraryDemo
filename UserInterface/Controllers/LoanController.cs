using Lending.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace UserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly INewLoanUseCase _newLoanUseCase;

        public LoanController(INewLoanUseCase newLoanUseCase)
        {
            _newLoanUseCase = newLoanUseCase;
        }

        [HttpPost("{copyId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateLoan([FromRoute] Guid copyId, CancellationToken cancellationToken = default)
        {
            //GetUserId
            Guid userId = Guid.NewGuid();

            await _newLoanUseCase.Execute(copyId, userId, cancellationToken);

            return Ok();
        }
    }
}

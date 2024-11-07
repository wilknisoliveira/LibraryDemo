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
        public IActionResult CreateLoan([FromRoute] Guid copyId)
        {
            //GetUserId
            Guid userId = Guid.NewGuid();

            _newLoanUseCase.Execute(copyId, userId);

            return Ok();
        }
    }
}

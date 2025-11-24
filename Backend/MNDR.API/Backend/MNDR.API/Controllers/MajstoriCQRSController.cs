using MediatR;
using Microsoft.AspNetCore.Mvc;
using MNDR.API.Models.CQRS.Commands;

namespace MNDR.API.Controllers
{
    [ApiController]
    [Route("api/cqrs/[controller]")]
    public class MajstoriCQRSController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MajstoriCQRSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("dodaj-ocjenu")]
        public async Task<IActionResult> DodajOcjenu([FromBody] DodajOcjenuCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ocjena dodana preko CQRS!");
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Mvc;
using MNDR.API.Application.Features.Notifikacije.Commands;
using MNDR.API.Application.Features.Notifikacije.Queries;

namespace MNDR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotifikacijeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotifikacijeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("korisnik/{korisnikId}")]
        public async Task<IActionResult> DohvatiNotifikacije(int korisnikId, [FromQuery] bool samoNeprocitane = false)
        {
            var query = new DohvatiNotifikacijeKorisnikaQuery(korisnikId, samoNeprocitane);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> KreirajNotifikaciju([FromBody] KreirajNotifikacijuCommand command)
        {
            var notifikacijaId = await _mediator.Send(command);
            return Ok(new { NotifikacijaId = notifikacijaId });
        }

        [HttpPut("{id}/procitano")]
        public async Task<IActionResult> OznaciProcitanom(int id)
        {
            var command = new OznaciNotifikacijuProcitanomCommand(id);
            await _mediator.Send(command);
            return Ok();
        }
    }
}

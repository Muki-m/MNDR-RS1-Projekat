using MediatR;

namespace MNDR.API.Application.Features.Notifikacije.Commands
{
    public record OznaciNotifikacijuProcitanomCommand(int NotifikacijaID) : IRequest;
}

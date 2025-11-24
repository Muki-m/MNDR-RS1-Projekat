using MediatR;

namespace MNDR.API.Application.Features.Majstori.Commands
{
    public record DodajOcjenuCommand(int MajstorId, decimal Ocjena) : IRequest;
}

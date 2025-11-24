using MediatR;

namespace MNDR.API.Models.CQRS.Commands
{
    public record DodajOcjenuCommand(int MajstorId, decimal Ocjena) : IRequest;
}

using MediatR;

namespace MNDR.API.Application.Features.Notifikacije.Commands
{
    public record KreirajNotifikacijuCommand(
        int KorisnikID,
        string TipNotifikacije,
        string Sadrzaj
    ) : IRequest<int>;
}

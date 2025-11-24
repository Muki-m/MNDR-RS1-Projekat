using MediatR;
using MNDR.API.Core.Entities;

namespace MNDR.API.Application.Features.Notifikacije.Queries
{
    public record DohvatiNotifikacijeKorisnikaQuery(
        int KorisnikID, 
        bool SamoNeprocitane = false
    ) : IRequest<System.Collections.Generic.List<Notifikacija>>;
}

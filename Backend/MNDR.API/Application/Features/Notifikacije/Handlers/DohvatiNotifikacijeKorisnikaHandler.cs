using MediatR;
using Microsoft.EntityFrameworkCore;
using MNDR.API.Core.Entities;
using MNDR.API.Application.Features.Notifikacije.Queries;
using MNDR.API.Infrastructure.Data;

namespace MNDR.API.Application.Features.Notifikacije.Handlers
{
    public class DohvatiNotifikacijeKorisnikaHandler : IRequestHandler<DohvatiNotifikacijeKorisnikaQuery, System.Collections.Generic.List<Notifikacija>>
    {
        private readonly ApplicationDbContext _context;

        public DohvatiNotifikacijeKorisnikaHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<System.Collections.Generic.List<Notifikacija>> Handle(DohvatiNotifikacijeKorisnikaQuery request, System.Threading.CancellationToken cancellationToken)
        {
            var query = _context.Notifikacije
                .Where(n => n.KorisnikID == request.KorisnikID);

            if (request.SamoNeprocitane)
            {
                query = query.Where(n => !n.Procitano);
            }

            return await query
                .OrderByDescending(n => n.DatumSlanja)
                .ToListAsync();
        }
    }
}

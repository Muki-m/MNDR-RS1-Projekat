using MediatR;
using MNDR.API.Core.Entities;
using MNDR.API.Application.Features.Notifikacije.Commands;
using MNDR.API.Infrastructure.Data;

namespace MNDR.API.Application.Features.Notifikacije.Handlers
{
    public class KreirajNotifikacijuHandler : IRequestHandler<KreirajNotifikacijuCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public KreirajNotifikacijuHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(KreirajNotifikacijuCommand request, System.Threading.CancellationToken cancellationToken)
        {
            var notifikacija = new Notifikacija
            {
                KorisnikID = request.KorisnikID,
                TipNotifikacije = request.TipNotifikacije,
                Sadrzaj = request.Sadrzaj
            };

            _context.Notifikacije.Add(notifikacija);
            await _context.SaveChangesAsync();

            return notifikacija.NotifikacijaID;
        }
    }
}

using MediatR;
using MNDR.API.Application.Features.Notifikacije.Commands;
using MNDR.API.Infrastructure.Data;

namespace MNDR.API.Application.Features.Notifikacije.Handlers
{
    public class OznaciNotifikacijuProcitanomHandler : IRequestHandler<OznaciNotifikacijuProcitanomCommand>
    {
        private readonly ApplicationDbContext _context;

        public OznaciNotifikacijuProcitanomHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(OznaciNotifikacijuProcitanomCommand request, System.Threading.CancellationToken cancellationToken)
        {
            var notifikacija = await _context.Notifikacije.FindAsync(request.NotifikacijaID);
            if (notifikacija != null)
            {
                notifikacija.Procitano = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}

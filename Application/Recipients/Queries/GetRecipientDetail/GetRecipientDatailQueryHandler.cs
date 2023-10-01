using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Providers.Queries.GetProviderDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Recipients.Queries.GetRecipientDetail
{
    public class GetRecipientDatailQueryHandler : IRequestHandler<GetRecipientDatailQuery, RecipientDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetRecipientDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<RecipientDatailVm> Handle(GetRecipientDatailQuery request, CancellationToken cancellationToken)
        {
            var recipient = _context.Recipients.Where(p => p.Id == request.Id && p.IsActive == 1);
            if (recipient != null)
            {
                var recipientVm = await recipient
                    .AsNoTracking().ProjectTo<RecipientDatailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return recipientVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class GetOffersByPersonPerformerQueryHandler : IRequestHandler<GetOffersByPersonPerformerQuery, OffersByPersonPerformerVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetOffersByPersonPerformerQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<OffersByPersonPerformerVm> Handle(GetOffersByPersonPerformerQuery request, CancellationToken cancellationToken)
        {
            var offersQuery = _context.Offers
                .Where(x => x.PerformerId == request.PersonPerformerId && x.IsActive == true);
                
            var offers = await offersQuery
                .AsNoTracking().ProjectTo<OffersByPersonPerformerDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new OffersByPersonPerformerVm() { Offers = offers };
        }
    }
}

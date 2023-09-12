using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class GetOffersQueryHandler : IRequestHandler<GetOffersQuery, OffersVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetOffersQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<OffersVm> Handle(GetOffersQuery request, CancellationToken cancellationToken)
        {
            var offersQuery = _context.Offers.Where(x => x.IsActive == true);

            if (request.PerformerId != null)
            {
                offersQuery = offersQuery.Where(x => x.PerformerId == request.PerformerId);

            }
            if (request.IsAvailable != null)
            {
                offersQuery = offersQuery.Where(x => x.IsAvailable == request.IsAvailable);
            }
            if (request.ProviderId != null)
            {
                offersQuery = offersQuery.Where(x => x.Performer.ProviderId == request.ProviderId);

            }
            if (!string.IsNullOrEmpty(request.ProviderName))
            {
                offersQuery = offersQuery.Where(x => x.Performer.Provider.Name.StartsWith(request.ProviderName));
            }
            if (!string.IsNullOrEmpty(request.ProductName))
            {
                offersQuery = offersQuery.Where(x => x.Product.Name.StartsWith(request.ProductName));
            }
            if (request.StartOfServiceFrom != null)
            {
                offersQuery = offersQuery.Where(x => x.StartOfService >= request.StartOfServiceFrom);

            }
            if (request.StartOfServiceTo != null)
            {
                offersQuery = offersQuery.Where(x => x.StartOfService <= request.StartOfServiceTo);

            }
            if (request.IsAnyServiceAvailableFrom != null)
            {
                offersQuery = offersQuery.Where(x => (x.StartOfService <= request.IsAnyServiceAvailableTo
                    || x.EndOfService <= request.IsAnyServiceAvailableTo) && x.IsAvailable);
            }
            if (request.IsAnyServiceAvailableTo!= null) 
            {
                offersQuery = offersQuery.Where(x => (x.StartOfService >= request.IsAnyServiceAvailableFrom
                    || x.EndOfService >= request.IsAnyServiceAvailableFrom) && x.IsAvailable);
            }

            var offers = await offersQuery
                .AsNoTracking().ProjectTo<OffersDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new OffersVm() { Offers = offers };
        }
    }
}

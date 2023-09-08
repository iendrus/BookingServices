using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Offers.Queries.GetOfferDetail
{
    public class GetOfferDatailQueryHandler : IRequestHandler<GetOfferDatailQuery, OfferDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetOfferDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<OfferDatailVm> Handle(GetOfferDatailQuery request, CancellationToken cancellationToken)
        {
            var offer = _context.Offers
                .Where(p => p.Id == request.Id && p.IsActive == true)
                .Include(p => p.Performer)
                .Include(p => p.Product);
            if (offer == null)
            {
                throw new IsNullException();
            }
            var offerVm = await offer
                .AsNoTracking().ProjectTo<OfferDatailVm>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
            return offerVm;
        }
    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Bookings.Queries.GetBookings
{
    public class GetBookingsQueryHandler : IRequestHandler<GetBookingsQuery, BookingsVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetBookingsQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<BookingsVm> Handle(GetBookingsQuery request, CancellationToken cancellationToken)
        {
            var bookingsQuery = _context.Bookings.Where(x => x.IsActive == 1);

            if (request.PerformerId != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.PerformerId == request.PerformerId);
            }

            if(request.ProviderId != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.Performer.ProviderId == request.ProviderId);
            }

            if (request.ProductId != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.ProductId == request.ProductId);
            }

            if (request.RecipientId != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.RecipientId == request.RecipientId);
            }

            if (!string.IsNullOrEmpty(request.RecipientEmailAddress))
            {
                var email = Email.For(request.RecipientEmailAddress);
                bookingsQuery = bookingsQuery
                    .Where(x => x.Recipient.Email.UserName == email.UserName && x.Recipient.Email.DomainName ==
                email.DomainName);
            }

            if (!string.IsNullOrEmpty(request.RecipientPhoneNumber))
            {
                bookingsQuery = bookingsQuery.Where(x => x.Recipient.Phone.Equals(request.RecipientPhoneNumber));
            }

            if (!string.IsNullOrEmpty(request.ProviderName))
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.Performer.Provider.Name.StartsWith(request.ProviderName));
            }

            if (!string.IsNullOrEmpty(request.ProductName))
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.Product.Name.StartsWith(request.ProductName));
            }

            if (request.State != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.State == request.State);
            }

            if (request.StartOfServiceFrom != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.StartOfService >= request.StartOfServiceFrom);
            }

            if (request.StartOfServiceTo != null)
            {
                bookingsQuery = bookingsQuery.Where(x => x.Offer.StartOfService <= request.StartOfServiceTo);
            }

            var bookings = await bookingsQuery
                .AsNoTracking().ProjectTo<BookingsDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new BookingsVm() { Bookings = bookings };
        }
    }
}

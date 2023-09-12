using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;
        public CreateBookingCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper, IDateTime dateTime)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
            _dateTime = dateTime;
        }
        public async Task<int> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers
               .FirstOrDefaultAsync(x => x.IsAvailable && x.IsActive && 
               x.Id == request.OfferId && x.EndOfService > _dateTime.Now);
            if (offer == null) 
            {
                throw new IsNullException("Oferta jest niedostępna lub upłynął jej czas realizacji.");
            }
            bool isAnyBookingForOffer = await _context.Bookings.AnyAsync(x => x.OfferId == request.OfferId && (int)x.State < 2 && x.IsActive);
            if (isAnyBookingForOffer || !offer.IsAvailable) 
            {
                throw new TimeRangeUnavalaibleException();
            }

            var booking = _mapper.Map<Booking>(request);
            booking.Cost = offer.Cost;
            _context.Bookings.Add(booking);
            offer.IsAvailable = false;
            await _context.SaveChangesAsync(cancellationToken);
            return booking.Id;
        }
    }
}

using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MediatR;


namespace BookingServices.Application.Bookings.Commands.UpdateBooking
{
    public class UpdateBookingCommandHandler : IRequestHandler<UpdateBookingCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateBookingCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = await _context.Bookings
                .Where(x => x.Id == request.Id && x.IsActive == 1).FirstOrDefaultAsync(cancellationToken);
            
            if (booking == null)
            {
                throw new IsNullException();
            }

            if (!IsPossibleToChangeState(booking.State, request.State))
            {
                throw new Exception("Zmiana statusu niedozwolona.");
            }

            _mapper.Map(request, booking);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }


        public bool IsPossibleToChangeState(BookingState currentState, BookingState targetState)
        {
            
            if (currentState == targetState)
            {
                return true;
            }
            bool isPossible = false;
            switch (currentState)
            {
                case BookingState.Submitted:
                    switch (targetState)
                    {
                        case BookingState.Confirmed:
                        case BookingState.Rejected: 
                            isPossible = true;
                            break;
                    }
                    break;
                case BookingState.Confirmed:
                    switch (targetState)
                    {
                        case BookingState.Rejected:
                        case BookingState.Finished:
                            isPossible = true;
                            break;
                    }
                    break;
                case BookingState.Rejected:
                    switch (targetState)
                    {
                        case BookingState.Confirmed:
                            isPossible = true;
                            break;
                    }
                    break;
                case BookingState.Finished:
                    switch (targetState)
                    {
                        case BookingState.Confirmed:
                            isPossible = true;
                            break;
                    }
                    break;
            }
            return isPossible;
        }

    }
}

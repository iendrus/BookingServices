using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


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
                .Where(x => x.Id == request.Id && x.IsActive == true).FirstOrDefaultAsync(cancellationToken);
            
            if (booking == null)
            {
                throw new IsNullException();
            }

            if (!IsPossibleToChangeState((int)booking.State, request.State))
            {
                throw new Exception("Zmiana statusu niedozwolona.");
            }

            _mapper.Map(request, booking);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }


        public bool IsPossibleToChangeState(int currentState, int targetState)
        {
            
            if (currentState == targetState)
            {
                return true;
            }
            bool isPossible = false;
            switch (currentState)
            {
                case 0:
                    switch (targetState)
                    {
                        case 1:
                        case 2: // Submited => Confirmed, Rejected
                            isPossible = true;
                            break;
                    }
                    break;
                case 1:
                    switch (targetState)
                    {
                        case 2:
                        case 3:  // Confirmed => Rejected, Finished
                            isPossible = true;
                            break;
                    }
                    break;
                case 2:
                    switch (targetState)
                    {
                        case 1: // Rejected => Confirmed
                            isPossible = true;
                            break;
                    }
                    break;
                case 3:
                    switch (targetState)
                    {
                        case 1: // Finished => Confirmed
                            isPossible = true;
                            break;
                    }
                    break;
            }
            return isPossible;
        }

    }
}

using MediatR;


namespace BookingServices.Application.Bookings.Commands.DeleteBooking
{
    public class DeleteBookingCommand : IRequest
    {
        public int Id { get; set; }

    }
}

using FluentValidation;


namespace BookingServices.Application.Bookings.Commands.UpdateBooking
{
    public class UpdateBookingCommandValidator : AbstractValidator<UpdateBookingCommand>
    {
        public UpdateBookingCommandValidator()
        {
        }
    }
}

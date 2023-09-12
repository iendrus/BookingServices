using FluentValidation;


namespace BookingServices.Application.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommandValidator : AbstractValidator<CreateBookingCommand>
    {
        public CreateBookingCommandValidator()
        {
            RuleFor(x => x.RecipientId)
                .NotEmpty()
                .WithMessage("Pole 'RecipientId' nie może być puste");
            RuleFor(x => x.OfferId)
                .NotEmpty()
                .WithMessage("Pole 'OfferId' nie może być puste");
        }
    }
}

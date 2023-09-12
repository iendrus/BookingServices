using BookingServices.Application.Common.Interfaces;
using FluentValidation;


namespace BookingServices.Application.Offers.Commands.CreateOffer
{
    public class CreateOfferCommandValidator : AbstractValidator<CreateOfferCommand>
    {
        private readonly IDateTime _dateTime;
        public CreateOfferCommandValidator(IDateTime dateTime)
        {
            _dateTime = dateTime;
            RuleFor(x => x.ProductId)
                .NotEmpty()
                .WithMessage("Pole ProductId nie może być puste.");
            RuleFor(x => x.PerformerId)
                .NotEmpty()
                .WithMessage("Pole PerformerId nie może być puste.");
            RuleFor(x => x.StartOfService)
                .NotEmpty()
                .WithMessage("Pole StartOfService nie może być puste.")
                .GreaterThanOrEqualTo(x => _dateTime.Now)
                .WithMessage("Czas rozpoczęcia nie może być wcześniejszy ani równy aktualnemu.");
            RuleFor(x => x.EndOfService)
            .NotEmpty()
                .WithMessage("Pole EndOfService nie może być puste.")
                .GreaterThanOrEqualTo(x => x.StartOfService)
                .WithMessage("Czas zakończenia nie może być wcześniejszy ani równy czasowi rozpoczęcia.");
            RuleFor(x => x.Cost)
                .NotEmpty().GreaterThanOrEqualTo(x => 0)
                .WithMessage("Koszt usługi nie może być mniejszy niż zero.");
        }
    }
}

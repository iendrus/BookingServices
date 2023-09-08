using FluentValidation.Validators;
using FluentValidation;


namespace BookingServices.Application.Offers.Commands.UpdateOffer
{
    public class UpdateOfferCommandValidator : AbstractValidator<UpdateOfferCommand>
    {
        public UpdateOfferCommandValidator()
        {
            {
                RuleFor(x => x.FirstName)
                    .NotEmpty()
                        .WithMessage("Imię jest wymagane.")
                    .MaximumLength(60)
                    .MinimumLength(2)
                        .WithMessage("Długość imienia musi zawierać się w przedziale 2 - 60 znaków.");
                RuleFor(x => x.LastName)
                    .NotEmpty()
                        .WithMessage("Nazwisko jest wymagane.")
                    .MaximumLength(60)
                    .MinimumLength(2)
                        .WithMessage("Długość nazwiska musi zawierać się w przedziale 2 - 60 znaków.");
                RuleFor(x => x.EmailAddress)
                    .NotEmpty()
                        .WithMessage("Adres e-mail jest wymagany.")
                    .EmailAddress(EmailValidationMode.Net4xRegex)
                        .WithMessage("Podano nieprawidłowy adres e-mail.");
                RuleFor(x => x.ProviderId).NotEmpty()
                    .WithMessage("Pole ProviderId jest wymagane.");
            }
        }
    }
}

using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.Providers.Commands.CreateProvider
{
    public class CreateProviderCommandValidator : AbstractValidator<CreateProviderCommand>
    {
        public CreateProviderCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("Nazwa jest wymagana.")
                .MaximumLength(120)
                .MinimumLength(3)
                    .WithMessage("Długość nazwy musi zawierać się w przedziale 3 - 120 znaków.");
            RuleFor(x => x.EmailAddress)
                .NotEmpty()
                    .WithMessage("Adres e-mail jest wymagany.")
                .EmailAddress(EmailValidationMode.Net4xRegex)
                    .WithMessage("Podano nieprawidłowy adres e-mail.");
        }
    }
}

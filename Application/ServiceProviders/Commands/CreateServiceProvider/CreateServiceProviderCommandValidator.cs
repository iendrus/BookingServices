using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider
{
    public class CreateServiceProviderCommandValidator : AbstractValidator<CreateServiceProviderCommand>
    {
        public CreateServiceProviderCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("Nazwa jest wymagana.")
                .MaximumLength(120)
                .MinimumLength(3)
                    .WithMessage("Długość nazwy musi sie zawierać w przedziale 3 - 120 znaków.");
            RuleFor(x => x.EmailAddress)
                .NotEmpty()
                    .WithMessage("Adres e-mail jest wymagany.")
                .EmailAddress(EmailValidationMode.Net4xRegex)
                    .WithMessage("Podano nieprawidłowy adres e-mail.");
            
        }
    }
}

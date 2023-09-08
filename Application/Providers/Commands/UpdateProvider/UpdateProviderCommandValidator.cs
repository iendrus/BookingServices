using BookingServices.Application.Providers.Commands.CreateProvider;
using FluentValidation.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Providers.Commands.UpdateProvider
{
    public class UpdateProviderCommandValidator : AbstractValidator<UpdateProviderCommand>
    {
        public UpdateProviderCommandValidator()
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

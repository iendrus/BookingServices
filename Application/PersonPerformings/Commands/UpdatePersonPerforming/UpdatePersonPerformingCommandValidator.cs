﻿using FluentValidation.Validators;
using FluentValidation;


namespace BookingServices.Application.PersonPerformings.Commands.UpdatePersonPerforming
{
    public class UpdatePersonPerformingCommandValidator : AbstractValidator<UpdatePersonPerformingCommand>
    {
        public UpdatePersonPerformingCommandValidator()
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
                RuleFor(x => x.ServiceProviderId).NotEmpty()
                    .WithMessage("Pole ServiceProviderId jest wymagane.");
            }
        }
    }
}

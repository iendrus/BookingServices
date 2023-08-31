using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.ServiceProductPersonPerformings.Commands.CreateServiceProductPersonPerforming
{
    public class CreateServiceProductPersonPerformingCommandValidator : AbstractValidator<CreateServiceProductPersonPerformingCommand>
    {
        public CreateServiceProductPersonPerformingCommandValidator()
        {
            RuleFor(x => x.ServiceProductId)
                    .NotEmpty()
                    .WithMessage("Pole jest wymagane wymagane.");
            RuleFor(x => x.PersonPerformingId)
                    .NotEmpty()
                    .WithMessage("Pole jest wymagane wymagane.");
        }
    }
}

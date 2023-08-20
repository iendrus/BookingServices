using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.Industries.Commands.UpdateIndustry
{
    public class UpdateIndustryCommandValidator : AbstractValidator<UpdateIndustryCommand>
    {
        public UpdateIndustryCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("Nazwa jest wymagana.")
                .MaximumLength(120)
                .MinimumLength(3)
                    .WithMessage("Długość nazwy musi zawierać się w przedziale 3 - 120 znaków.");
        }
    }
}

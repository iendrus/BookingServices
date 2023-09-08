using BookingServices.Application.Providers.Commands.CreateProvider;
using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.Industries.Commands.CreateIndustry
{
    public class CreateIndustryCommandValidator : AbstractValidator<CreateIndustryCommand>
    {
        public CreateIndustryCommandValidator()
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

using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.ServiceProducts.Commands.CreateServiceProduct
{
    public class CreateServiceProductCommandValidator : AbstractValidator<CreateServiceProductCommand>
    {
        public CreateServiceProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("Nazwa jest wymagana.")
                .MaximumLength(255)
                .MinimumLength(3)
                    .WithMessage("Długość nazwy musi zawierać się w przedziale 3 - 255 znaków.");
        }
    }
}

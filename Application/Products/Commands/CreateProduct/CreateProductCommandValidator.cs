using BookingServices.Application.Providers.Commands.CreateProvider;
using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
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

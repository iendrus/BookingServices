using BookingServices.Application.Providers.Commands.CreateProvider;
using FluentValidation;
using FluentValidation.Validators;
using System;


namespace BookingServices.Application.ProductPerformers.Commands.CreateProductPerformer
{
    public class CreateProductPerformerCommandValidator : AbstractValidator<CreateProductPerformerCommand>
    {
        public CreateProductPerformerCommandValidator()
        {
            RuleFor(x => x.ProductId)
                    .NotEmpty()
                    .WithMessage("Pole jest wymagane wymagane.");
            RuleFor(x => x.PerformerId)
                    .NotEmpty()
                    .WithMessage("Pole jest wymagane wymagane.");
        }
    }
}

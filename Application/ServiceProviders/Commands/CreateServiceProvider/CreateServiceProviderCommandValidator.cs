using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider
{
    public class CreateServiceProviderCommandValidator : AbstractValidator<CreateServiceProviderCommand>
    {
        public CreateServiceProviderCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(120).MinimumLength(3);
        }
    }
}

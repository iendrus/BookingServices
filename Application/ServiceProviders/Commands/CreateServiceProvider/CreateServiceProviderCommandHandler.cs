using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider
{
    public class CreateServiceProviderCommandHandler : IRequestHandler<CreateServiceProviderCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        public CreateServiceProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }
        public async Task<int> Handle(CreateServiceProviderCommand request, CancellationToken cancellationToken)
        {
            ServiceProvider serviceProvider = new()
            {
                Email = new Domain.ValueObjects.Email() { DomainName = request.EmailDomainName, UserName = request.EmailUserName },
                ContactPerson = new Domain.ValueObjects.PersonName() { LastName = request.ContactLastName, FirstName = request.ContactFirstName}
            };

            _context.ServiceProviders.Add(serviceProvider);
            await _context.SaveChangesAsync(cancellationToken);
            return serviceProvider.Id;
        }
    }
}

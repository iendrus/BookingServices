using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider
{
    public class DeleteServiceProviderCommandHandler : IRequestHandler<DeleteServiceProviderCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeleteServiceProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }

        public async Task Handle(DeleteServiceProviderCommand request, CancellationToken cancellationToken)
        {
            var serviceProvider = await _context.ServiceProviders
               .Where(s => s.Id == request.Id && s.IsActive == true).FirstOrDefaultAsync(cancellationToken);

            if (serviceProvider != null)
            {
                serviceProvider.Address = new Address(
                    serviceProvider.Address.Street,
                    serviceProvider.Address.City,
                    serviceProvider.Address.ZipCode,
                    serviceProvider.Address.Number);
                serviceProvider.ContactPerson = new PersonName(serviceProvider.ContactPerson.FirstName, serviceProvider.ContactPerson.LastName);
                serviceProvider.Email = new Email(serviceProvider.Email.UserName, serviceProvider.Email.DomainName);

                _context.ServiceProviders.Remove(serviceProvider);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}

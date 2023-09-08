using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Providers.Commands.DeleteProvider
{
    public class DeleteProviderCommandHandler : IRequestHandler<DeleteProviderCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeleteProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }

        public async Task Handle(DeleteProviderCommand request, CancellationToken cancellationToken)
        {
            var provider = await _context.Providers
               .Where(s => s.Id == request.Id && s.IsActive == true).FirstOrDefaultAsync(cancellationToken);

            if (provider == null)
            {
                throw new IsNullException();
            }

            provider.Address = new Address(
                provider.Address.Street,
                provider.Address.City,
                provider.Address.ZipCode,
                provider.Address.Number);

            provider.ContactPerson = new PersonName(provider.ContactPerson.FirstName, provider.ContactPerson.LastName);
            provider.Email = new Email(provider.Email.UserName, provider.Email.DomainName);

            _context.Providers.Remove(provider);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;

        }
    }
}

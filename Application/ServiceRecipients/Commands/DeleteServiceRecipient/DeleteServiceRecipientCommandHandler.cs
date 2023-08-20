using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ServiceRecipients.Commands.DeleteServiceRecipient
{
    public class DeleteServiceRecipientCommandHandler : IRequestHandler<DeleteServiceRecipientCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeleteServiceRecipientCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }

        public async Task Handle(DeleteServiceRecipientCommand request, CancellationToken cancellationToken)
        {
            var serviceRecipient = await _context.ServiceRecipients
               .Where(s => s.Id == request.Id && s.IsActive == true).FirstOrDefaultAsync(cancellationToken);

            if (serviceRecipient != null)
            {

                serviceRecipient.FullName = new PersonName(serviceRecipient.FullName.FirstName, serviceRecipient.FullName.LastName);
                serviceRecipient.Email = new Email(serviceRecipient.Email.UserName, serviceRecipient.Email.DomainName);

                _context.ServiceRecipients.Remove(serviceRecipient);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}

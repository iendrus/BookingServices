using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace BookingServices.Application.Recipients.Commands.DeleteRecipient
{
    public class DeleteRecipientCommandHandler : IRequestHandler<DeleteRecipientCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeleteRecipientCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }

        public async Task Handle(DeleteRecipientCommand request, CancellationToken cancellationToken)
        {
            var recipient = await _context.Recipients
               .Where(s => s.Id == request.Id && s.IsActive == 1).FirstOrDefaultAsync(cancellationToken);

            if (recipient == null)
            {
                throw new IsNullException();
            }

            recipient.FullName = new PersonName(recipient.FullName.FirstName, recipient.FullName.LastName);
            recipient.Email = new Email(recipient.Email.UserName, recipient.Email.DomainName);

            _context.Recipients.Remove(recipient);
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}

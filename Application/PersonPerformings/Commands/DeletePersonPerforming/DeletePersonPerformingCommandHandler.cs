using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.PersonPerformings.Commands.DeletePersonPerforming
{
    public class DeletePersonPerformingCommandHandler : IRequestHandler<DeletePersonPerformingCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeletePersonPerformingCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }

        public async Task Handle(DeletePersonPerformingCommand request, CancellationToken cancellationToken)
        {
            var personPerforming = await _context.PersonPerformings
               .Where(s => s.Id == request.Id && s.IsActive == true).FirstOrDefaultAsync(cancellationToken);

            if (personPerforming != null)
            {

                personPerforming.FullName = new PersonName(personPerforming.FullName.FirstName, personPerforming.FullName.LastName);
                personPerforming.Email = new Email(personPerforming.Email.UserName, personPerforming.Email.DomainName);

                _context.PersonPerformings.Remove(personPerforming);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}

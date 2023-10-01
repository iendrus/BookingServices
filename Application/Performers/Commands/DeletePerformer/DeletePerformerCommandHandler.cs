using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.Performers.Commands.DeletePerformer
{
    public class DeletePerformerCommandHandler : IRequestHandler<DeletePerformerCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeletePerformerCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }

        public async Task Handle(DeletePerformerCommand request, CancellationToken cancellationToken)
        {
            var performer = await _context.Performers
               .Where(s => s.Id == request.Id && s.IsActive == 1).FirstOrDefaultAsync(cancellationToken);

            if (performer == null)
            {
                throw new IsNullException();
            }
            performer.FullName = new PersonName(performer.FullName.FirstName, performer.FullName.LastName);
            performer.Email = new Email(performer.Email.UserName, performer.Email.DomainName);

             _context.Performers.Remove(performer);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
